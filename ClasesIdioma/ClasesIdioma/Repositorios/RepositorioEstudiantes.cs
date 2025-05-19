using ClasesIdioma.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ClasesIdioma.Repositorios
{
    public class RepositorioEstudiantes : IRepositorioEstudiantes
    {
        private readonly ClasesIdiomaDBContext _context;

        public RepositorioEstudiantes(ClasesIdiomaDBContext context)
        {
            _context = context;
        }

        public async Task<List<Estudiante>> GetAll()
        {
            return await _context.Estudiantes
                .Include(e => e.Clases) 
                .ToListAsync();
        }

        public async Task<Estudiante?> GetById(int id)
        {
            return await _context.Estudiantes
                .Include(e => e.Clases)
                .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<Estudiante> Add(Estudiante estudiante)
        {
            _context.Estudiantes.Add(estudiante);
            await _context.SaveChangesAsync();
            return estudiante;
        }

        public async Task Update(Estudiante estudiante)
        {
            _context.Estudiantes.Update(estudiante);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var estudiante = await _context.Estudiantes.FindAsync(id);
            if (estudiante != null)
            {
                _context.Estudiantes.Remove(estudiante);
                await _context.SaveChangesAsync();
            }
        }
    }
}
