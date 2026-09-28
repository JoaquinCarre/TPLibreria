using System;
using System.Collections.Generic;
using System.Text;

namespace TPLibreria.Modelos
{
    public interface ILibroRepository
    {
        Task<List<Libro>> GetAllAsync();
        Task<Libro> GetByISBNAsync(string isbn);
        Task<Libro?> GetByIdAsync(int idLibro);

        Task<bool> CreateAsync(Libro libro);

        Task<bool> UpdateAsync(Libro libro);

        Task<bool> DeleteAsync(int idLibro);
    }


}
