using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace TPLibreria.Modelos
{
    public class LibroRepositorySQL : ILibroRepository
    {
        private const string CONNECTION_STRING = @"Data Source=localhost\sqlexpress;Initial Catalog=TPLibreria;User ID=UserCreator;Password=UserCreator;TrustServerCertificate=True";

        private Libro MapToLibro(SqlDataReader reader)
        {
            return new Libro(
                    reader.GetInt32("idlibro"),
                    reader.GetString("isbn"),
                    reader.GetString("titulo"),
                    reader.GetString("autor"),
                    reader.GetString("editorial"),
                    reader.GetString("categoria"),
                    reader.GetDateTime("fechapublicacion"),
                    reader.GetDecimal("precioventa"),
                    reader.GetBoolean("disponible"));
        }

        public async Task<List<Libro>> GetAllAsync()
        {
            List<Libro> libros = new List<Libro>();
            string sql = @"
                SELECT *
                FROM   Libros";
            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();
            await using SqlCommand cmd = new SqlCommand(sql, conn);
            await using SqlDataReader reader = await cmd.ExecuteReaderAsync();
            while (await reader.ReadAsync() == true)
            {
                Libro libro = MapToLibro(reader);
                libros.Add(libro);
            }
            return libros;
        }

        public async Task<Libro?> GetByISBNAsync(int isbn)
        {
            Libro? libro = null;
            string sql = @"
                SELECT *
                FROM   Libros
                WHERE  isbn = @Isbn";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Isbn", isbn);

            await using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync() == true)
            {
                libro = MapToLibro(reader);
            }

            return libro;
        }

        public async Task<Libro?> GetByIdAsync(int idLibro)
        {
            Libro? libro = null;
            string sql = @"
                SELECT *
                FROM   Libros
                WHERE  idlibro = @IdLibro";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@IdLibro", idLibro);

            await using SqlDataReader reader = await cmd.ExecuteReaderAsync();

            if (await reader.ReadAsync() == true)
            {
                libro = MapToLibro(reader);
            }

            return libro;
        }

        public async Task<bool> CreateAsync(Libro libro)
        {
            string sql = @"
                INSERT INTO Libros (isbn, titulo, autor, editorial, categoria, fechapublicacion, precioventa, disponible)
                VALUES (@Isbn, @Titulo, @Autor, @Editorial, @Categoria, @FechaPublicacion, @PrecioVenta, @Disponible)";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("isbn", libro.ISBN);
            cmd.Parameters.AddWithValue("titulo", libro.Titulo);
            cmd.Parameters.AddWithValue("autor", libro.Autor);
            cmd.Parameters.AddWithValue("editorial", libro.Editorial);
            cmd.Parameters.AddWithValue("categoria", libro.Categoria);
            cmd.Parameters.AddWithValue("fechaPublicacion", libro.FechaPublicacion);
            cmd.Parameters.AddWithValue("precioVenta", libro.PrecioVenta);
            cmd.Parameters.AddWithValue("disponible", libro.Disponible);

            int result = await cmd.ExecuteNonQueryAsync();
            return result > 0;
        }

        public async Task<bool> UpdateAsync(Libro libro)
        {
            string sql = @"
                UPDATE Libros 
                SET isbn = @isbn, titulo = @titulo, autor = @autor, editorial = @editorial, categoria = @categoria, 
                fechapublicacion = @fechapublicacion, precioventa = @precioventa, disponible = @disponible 
                WHERE idpersona = @idpersona";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("isbn", libro.ISBN);
            cmd.Parameters.AddWithValue("titulo", libro.Titulo);
            cmd.Parameters.AddWithValue("autor", libro.Autor);
            cmd.Parameters.AddWithValue("editorial", libro.Editorial);
            cmd.Parameters.AddWithValue("categoria", libro.Categoria);
            cmd.Parameters.AddWithValue("fechaPublicacion", libro.FechaPublicacion);
            cmd.Parameters.AddWithValue("precioVenta", libro.PrecioVenta);
            cmd.Parameters.AddWithValue("disponible", libro.Disponible);

            int result = await cmd.ExecuteNonQueryAsync();
            return result > 0;
        }

        public async Task<bool> DeleteAsync(int idLibro)
        {
            string sql = @"
                DELETE FROM Libros 
                WHERE idlibro = @idlibro";

            await using SqlConnection conn = new SqlConnection(CONNECTION_STRING);
            await conn.OpenAsync();

            await using SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("idlibro", idLibro);

            int result = await cmd.ExecuteNonQueryAsync();
            return result > 0;
        }
    }
}