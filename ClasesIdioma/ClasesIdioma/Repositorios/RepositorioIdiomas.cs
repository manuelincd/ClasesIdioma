using ClasesIdioma.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ClasesIdioma.Repositorios
{
    public class RepositorioIdiomas : IRepositorioIdiomas
    {
        private readonly ClasesIdiomaDBContext _context;

        public RepositorioIdiomas(ClasesIdiomaDBContext context)
        {
            _context = context;
        }

        public async Task<List<Idioma>> GetAll()
        {
            return await _context.Idiomas.ToListAsync();
        }

        public async Task<Idioma?> GetById(int id)
        {
            return await _context.Idiomas.FindAsync(id);

        }

        public async Task<Idioma> Add(Idioma idioma)
        {
            _context.Idiomas.Add(idioma);
            await _context.SaveChangesAsync();
            return idioma;
        }

        public async Task Update(Idioma idioma)
        {
            _context.Idiomas.Update(idioma);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var idioma = await _context.Idiomas.FindAsync(id);
            if (idioma != null)
            {
                _context.Idiomas.Remove(idioma);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<Idioma>> GetIdiomas()
        {
            return await _context.Idiomas.ToListAsync();
        }
    }
}
