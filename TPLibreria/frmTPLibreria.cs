using TPLibreria.Modelos;

namespace TPLibreria
{
    public partial class frmTPLibreria : Form
    {
        private readonly ILibroRepository _repo;
        private int _idLibroModificar = 0;
        public frmTPLibreria(ILibroRepository repo)
        {
            InitializeComponent();
            this._repo = repo;
        }

        private void InicializarControles()
        {
            this._idLibroModificar = 0;

            txtIsbn.Clear();
            txtTitulo.Clear();
            txtAutor.Clear();
            dtpFechaPublicacion.Value = DateTime.Today;
            cmbEditorial.SelectedIndex = 0;
            chkDisponible.Checked = false;
        }

        private async void frmTPLibreria_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();

            txtIsbn.MaxLength = 13; // En la ejercitación se pide que debe tener un exacto de 13 dígitos, por lo que se establece el mismo límite en el TextBox.

            txtTitulo.MaxLength = 150; // En la tabla Libros aparece como un máximo de 150 caracteres, por lo que se establece el mismo límite en el TextBox.

            txtAutor.MaxLength = 80; // En la tabla Libros aparece como un máximo de 80 caracteres, por lo que se establece el mismo límite en el TextBox.
            
            cmbEditorial.Items.Add("Prentice Hall");
            cmbEditorial.Items.Add("Manning");
            cmbEditorial.Items.Add("OReilly Media");
            cmbEditorial.Items.Add("Andrew Hunt");
            cmbEditorial.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEditorial.SelectedIndex = 0;
            
            dtpFechaPublicacion.MinDate = new DateTime(1900, 1, 1);
            dtpFechaPublicacion.MaxDate = DateTime.Today;
            
            rbProgramacion.Checked = true;
            
            txtPrecioVenta.MaxLength = 9; // 9 dígitos para el precio de venta porque son 8 digitos donde 2 son decimales y se incluye la coma decimal.
            
            chkDisponible.Checked = false;

            await CargarGrilla();
        }


        private async Task CargarGrilla()
        {
            try
            {
                List<Libro> lista = (List<Libro>)await _repo.GetAllAsync();
                dgvLibros.DataSource = lista;
                dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvLibros.Columns["idlibro"].Visible = false;
                dgvLibros.Columns["fechapublicacion"].HeaderText = "Fecha Pub.";
                dgvLibros.Columns["fechapublicacion"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)//Le agregué el ASYNC al método para poder usar el AWAIT
        {
            try
            {
                ValidarFormulario();

                Libro nuevoLibro = new Libro();
                nuevoLibro.IdLibro = this._idLibroModificar;
                nuevoLibro.ISBN = txtIsbn.Text;
                nuevoLibro.Titulo = txtTitulo.Text;
                nuevoLibro.Autor = txtAutor.Text;
                nuevoLibro.FechaPublicacion = dtpFechaPublicacion.Value;
                nuevoLibro.Editorial = cmbEditorial.Text;
                if (rbAnalisisNumerico.Checked)
                {
                    nuevoLibro.Categoria = rbAnalisisNumerico.Text;
                }
                    else if (rbSistemas.Checked)
                    {
                        nuevoLibro.Categoria = rbSistemas.Text;
                    }
                        else { 
                            nuevoLibro.Categoria = rbProgramacion.Text;
                        }
                nuevoLibro.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
                nuevoLibro.Disponible = chkDisponible.Checked;

                await ValidarReglas(nuevoLibro);

                if (nuevoLibro.IdLibro == 0)
                {
          
                    await _repo.CreateAsync(nuevoLibro);
                }
                else
                {
                    
                    await _repo.UpdateAsync(nuevoLibro);
                }

                await CargarGrilla();

                InicializarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarFormulario()
        {
            decimal precioVenta;
            string isbn = txtIsbn.Text.Trim();
            string titulo = txtTitulo.Text.Trim();
            string autor = txtAutor.Text.Trim();
            
            var errores = new List<string>();

            if (isbn == string.Empty) { 
                errores.Add("El ISBN es obligatorio.");
            }
                else if (!isbn.All(char.IsAsciiDigit)) { 
                    errores.Add("El ISBN debe ser numérico.");
                }
                    else if (isbn.Length != 13) { 
                        errores.Add("El ISBN debe estar formado por 13 dígitos.");
                    }
                        else if (isbn.All(c => c == '0')) { 
                            errores.Add("El ISBN no puede ser cero.");
                        }
            
            if (titulo == string.Empty) { 
                errores.Add("El título es obligatorio.");
            }
                //else if (titulo.Length > 32767) { 
                //        errores.Add("El título debe tener menos de 32767 caracteres.");
                //}
            
            if (autor == string.Empty) { 
                errores.Add("El autor es obligatorio.");
            }
                //else if (autor.Length > 32767) { 
                //    errores.Add("El autor debe tener menos de 32767 caracteres.");
                //}

            if (txtPrecioVenta.Text.Trim() == string.Empty) { 
                errores.Add("El precio de venta es obligatorio.");
            }
                else if (decimal.TryParse(txtPrecioVenta.Text, out precioVenta) == false) { 
                        errores.Add("El precio de venta debe ser numerico.");
                }
                    else if (precioVenta == 0) { 
                                errores.Add("El precio de venta no puede ser cero.");
                    }

            if (errores.Count > 0) {
                throw new Exception(string.Join("\n", errores));
            }
        }

        private async Task ValidarReglas(Libro libro)
        {

            Libro? libroMismoISBN = await this._repo.GetByISBNAsync(libro.ISBN);//SOLUCION: En el metodo GetByISBNAsync cambie el parametro int isbn por string isbn. PROBLEMA: Hay que revisar el problema este, capaz nos conviene tratar ISBN como integer desde su definición

            if (libro.IdLibro == 0)
            {
                //es una alta
                if (libroMismoISBN != null)
                    throw new Exception("El número de ISBN ya existe.");
            }
            else
            {
                //es una modificación
                if (libroMismoISBN != null && libro.IdLibro != libroMismoISBN.IdLibro)
                    throw new Exception("El número de ISBN ya existe.");
            }
            //Preguntar a los profes porque las categorías a seleccionar y las que usan para los precios de venta NO COINCIDEN
            //Puntos .9 y 2.10 del TP

            if ((libro.Categoria == "Programación") && (libro.PrecioVenta < 40000))
            {
                throw new Exception("Para la categoría programación el libro debe tener un valor mínimo de 40000.");
            }
            else
            {
                if ((libro.Categoria == "Análisis Numérico") && (libro.PrecioVenta < 45000))
                {
                    throw new Exception("Para la categoría Análisis Numérico el libro debe tener un valor mínimo de 45000.");
                }
                else
                {
                    if (libro.PrecioVenta < 50000)
                    {
                        throw new Exception("Para la categoría Sistemas el libro debe tener un valor mínimo de 50000.");
                    }
                }
            }
        }


    }
}
