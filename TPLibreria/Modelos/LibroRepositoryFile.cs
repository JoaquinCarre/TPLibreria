using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;

namespace TPLibreria.Modelos
{
    public class LibroRepositoryFile : ILibroRepository
    {
        public async Task<List<Libro>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Libro?> GetByISBNAsync(string isbn)
        {
            throw new NotImplementedException();
        }

        public async Task<Libro?> GetByIdAsync(int idLibro)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> CreateAsync(Libro libro)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateAsync(Libro libro)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(int idlibro)
        {
            throw new NotImplementedException();
        }
    }
}