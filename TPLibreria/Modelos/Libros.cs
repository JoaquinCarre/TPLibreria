using System;
using System.Collections.Generic;
using System.Text;

namespace TPLibreria.Modelos
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public string Categoria { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public decimal PrecioVenta { get; set; }
        public bool Disponible { get; set; }

        public Libro() 
        {
            this.IdLibro = 0;
            this.ISBN = string.Empty;
            this.Titulo = string.Empty;
            this.Autor = string.Empty;
            this.Editorial = string.Empty;
            this.Categoria = string.Empty;
            this.FechaPublicacion = DateTime.MinValue;
            this.PrecioVenta = 0;
            this.Disponible = false;
        }

        public Libro (int idLibro, string isbn, string titulo, string autor, string editorial, string categoria, DateTime fechaPublicacion, decimal precioVenta, bool disponible)
        {
            this.IdLibro = idLibro;
            this.ISBN = isbn;
            this.Titulo = titulo;
            this.Autor = autor;
            this.Editorial = editorial;
            this.Categoria = categoria;
            this.FechaPublicacion = fechaPublicacion;
            this.PrecioVenta = precioVenta;
            this.Disponible = disponible;
        }
    }
}
