using Microsoft.EntityFrameworkCore;
using ClasesIdioma.Modelos;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasesIdioma.Repositorios
{
    public class RepositorioMaestros : IRepositorioMaestros
    {
        private readonly ClasesIdiomaDBContext _context;

        public RepositorioMaestros(ClasesIdiomaDBContext context)
        {
            _context = context;
        }

        public async Task<List<Maestro>> GetByIdiomaId(int idiomaId)
        {
            return await _context.Maestros
                .Where(m => m.IdiomaId == idiomaId)            
                .ToListAsync();                                 
        }
        public async Task<List<Idioma>> GetIdiomas()
        {
            return await _context.Idiomas.ToListAsync();
        }
        public async Task<List<Maestro>> GetAll()
        {
            return await _context.Maestros
                .Include(m => m.Idioma) 
                .ToListAsync();
        }
        public async Task<Maestro?> GetById(int id)
        {
            return await _context.Maestros.FindAsync(id);
        }

        public async Task<Maestro> Add(Maestro maestro)
        {
            _context.Maestros.Add(maestro);
            await _context.SaveChangesAsync();
            return maestro;
        }

        public async Task Update(Maestro maestro)
        {
            _context.Entry(maestro).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var maestro = await _context.Maestros.FindAsync(id);
            if (maestro != null)
            {
                _context.Maestros.Remove(maestro);
                await _context.SaveChangesAsync();
            }
        }
    }
}