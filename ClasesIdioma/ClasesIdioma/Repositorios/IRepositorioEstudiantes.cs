using ClasesIdioma.Modelos;

namespace ClasesIdioma.Repositorios
{
    public interface IRepositorioEstudiantes
    {
        Task<List<Estudiante>> GetAll();
        Task<Estudiante?> GetById(int id);
        Task<Estudiante> Add(Estudiante estudiante);
        Task Update(Estudiante estudiante);
        Task Delete(int id);
    }
}
