namespace TPLibreria
{
    partial class frmTPLibreria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCancelar = new Button();
            dgvLibros = new DataGridView();
            btnRegistrar = new Button();
            txtIsbn = new TextBox();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            cmbEditorial = new ComboBox();
            dtpFechaPublicacion = new DateTimePicker();
            rbProgramacion = new RadioButton();
            txtPrecioVenta = new TextBox();
            chkDisponible = new CheckBox();
            lblIsbn = new Label();
            lblTitulo = new Label();
            lblAutor = new Label();
            lblCategoria = new Label();
            lblFechaPublicacion = new Label();
            lblEditorial = new Label();
            lblPrecioVenta = new Label();
            lblDisponible = new Label();
            rbAnalisisNumerico = new RadioButton();
            rbSistemas = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(673, 406);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(130, 32);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Location = new Point(357, 12);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.Size = new Size(813, 283);
            dgvLibros.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(439, 406);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(130, 32);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(50, 9);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(100, 23);
            txtIsbn.TabIndex = 4;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(50, 37);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 5;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(50, 66);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(100, 23);
            txtAutor.TabIndex = 6;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(62, 98);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(121, 23);
            cmbEditorial.TabIndex = 7;
            // 
            // dtpFechaPublicacion
            // 
            dtpFechaPublicacion.Format = DateTimePickerFormat.Short;
            dtpFechaPublicacion.Location = new Point(131, 127);
            dtpFechaPublicacion.Name = "dtpFechaPublicacion";
            dtpFechaPublicacion.Size = new Size(101, 23);
            dtpFechaPublicacion.TabIndex = 8;
            // 
            // rbProgramacion
            // 
            rbProgramacion.AutoSize = true;
            rbProgramacion.Location = new Point(70, 163);
            rbProgramacion.Name = "rbProgramacion";
            rbProgramacion.Size = new Size(100, 19);
            rbProgramacion.TabIndex = 9;
            rbProgramacion.TabStop = true;
            rbProgramacion.Text = "Programación";
            rbProgramacion.UseVisualStyleBackColor = true;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(103, 247);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(100, 23);
            txtPrecioVenta.TabIndex = 10;
            // 
            // chkDisponible
            // 
            chkDisponible.AutoSize = true;
            chkDisponible.Location = new Point(75, 291);
            chkDisponible.Name = "chkDisponible";
            chkDisponible.Size = new Size(82, 19);
            chkDisponible.TabIndex = 11;
            chkDisponible.Text = "checkBox1";
            chkDisponible.UseVisualStyleBackColor = true;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(6, 12);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(32, 15);
            lblIsbn.TabIndex = 12;
            lblIsbn.Text = "ISBN";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(6, 40);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(38, 15);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Titulo";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(7, 69);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 14;
            lblAutor.Text = "Autor";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(6, 165);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 15;
            lblCategoria.Text = "Categoria";
            // 
            // lblFechaPublicacion
            // 
            lblFechaPublicacion.AutoSize = true;
            lblFechaPublicacion.Location = new Point(6, 133);
            lblFechaPublicacion.Name = "lblFechaPublicacion";
            lblFechaPublicacion.Size = new Size(119, 15);
            lblFechaPublicacion.TabIndex = 16;
            lblFechaPublicacion.Text = "Fecha de Publicacion";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.Location = new Point(6, 101);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(50, 15);
            lblEditorial.TabIndex = 17;
            lblEditorial.Text = "Editorial";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(6, 250);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(100, 15);
            lblPrecioVenta.TabIndex = 18;
            lblPrecioVenta.Text = "Precio de Venta  $";
            // 
            // lblDisponible
            // 
            lblDisponible.AutoSize = true;
            lblDisponible.Location = new Point(6, 291);
            lblDisponible.Name = "lblDisponible";
            lblDisponible.Size = new Size(63, 15);
            lblDisponible.TabIndex = 19;
            lblDisponible.Text = "Disponible";
            // 
            // rbAnalisisNumerico
            // 
            rbAnalisisNumerico.AutoSize = true;
            rbAnalisisNumerico.Location = new Point(70, 188);
            rbAnalisisNumerico.Name = "rbAnalisisNumerico";
            rbAnalisisNumerico.Size = new Size(121, 19);
            rbAnalisisNumerico.TabIndex = 20;
            rbAnalisisNumerico.TabStop = true;
            rbAnalisisNumerico.Text = "Análisis Numérico";
            rbAnalisisNumerico.UseVisualStyleBackColor = true;
            // 
            // rbSistemas
            // 
            rbSistemas.AutoSize = true;
            rbSistemas.Location = new Point(70, 214);
            rbSistemas.Name = "rbSistemas";
            rbSistemas.Size = new Size(71, 19);
            rbSistemas.TabIndex = 21;
            rbSistemas.TabStop = true;
            rbSistemas.Text = "Sistemas";
            rbSistemas.UseVisualStyleBackColor = true;
            // 
            // frmTPLibreria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 450);
            Controls.Add(rbSistemas);
            Controls.Add(rbAnalisisNumerico);
            Controls.Add(lblDisponible);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblEditorial);
            Controls.Add(lblFechaPublicacion);
            Controls.Add(lblCategoria);
            Controls.Add(lblAutor);
            Controls.Add(lblTitulo);
            Controls.Add(lblIsbn);
            Controls.Add(chkDisponible);
            Controls.Add(txtPrecioVenta);
            Controls.Add(rbProgramacion);
            Controls.Add(dtpFechaPublicacion);
            Controls.Add(cmbEditorial);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(txtIsbn);
            Controls.Add(btnRegistrar);
            Controls.Add(dgvLibros);
            Controls.Add(btnCancelar);
            Name = "frmTPLibreria";
            Text = "Librería \"El Papiro\"";
            Load += frmTPLibreria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancelar;
        private DataGridView dgvLibros;
        private Button btnRegistrar;
        private TextBox txtIsbn;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private ComboBox cmbEditorial;
        private DateTimePicker dtpFechaPublicacion;
        private RadioButton rbProgramacion;
        private TextBox txtPrecioVenta;
        private CheckBox chkDisponible;
        private Label lblIsbn;
        private Label lblTitulo;
        private Label lblAutor;
        private Label lblCategoria;
        private Label lblFechaPublicacion;
        private Label lblEditorial;
        private Label lblPrecioVenta;
        private Label lblDisponible;
        private RadioButton rbAnalisisNumerico;
        private RadioButton rbSistemas;
    }
}
