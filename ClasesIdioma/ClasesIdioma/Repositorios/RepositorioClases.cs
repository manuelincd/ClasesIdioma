using ClasesIdioma.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ClasesIdioma.Repositorios
{
    public class RepositorioClases : IRepositorioClases
    {
        private readonly ClasesIdiomaDBContext _context;

        public RepositorioClases(ClasesIdiomaDBContext context)
        {
            _context = context;
        }

        public async Task<List<Clase>> GetAll()
        {
            return await _context.Clases
                .Include(c => c.Idioma)
                .Include(c => c.Maestro)
                .Include(c => c.Estudiantes)
                .ToListAsync();
        }

        public async Task<Clase?> GetById(int id)
        {
            return await _context.Clases
                .Include(c => c.Idioma)
                .Include(c => c.Maestro)
                .Include(c => c.Estudiantes)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Clase> Add(Clase clase)
        {
            _context.Clases.Add(clase);
            await _context.SaveChangesAsync();
            return clase;
        }

        public async Task Update(Clase clase)
        {
            _context.Clases.Update(clase);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var clase = await _context.Clases.FindAsync(id);
            if (clase != null)
            {
                _context.Clases.Remove(clase);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<Idioma>> GetIdiomas()
        {
            return await _context.Idiomas.ToListAsync();
        }

        public async Task<List<Maestro>> GetMaestros()
        {
            return await _context.Maestros.ToListAsync();
        }

        public async Task<List<Estudiante>> GetEstudiantes()
        {
            return await _context.Estudiantes.ToListAsync();
        }
    }
}
