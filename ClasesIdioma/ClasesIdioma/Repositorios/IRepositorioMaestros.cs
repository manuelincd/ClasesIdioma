using ClasesIdioma.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ClasesIdioma.Repositorios
{
    public interface IRepositorioMaestros
    {
        Task<List<Maestro>> GetAll();
        Task<List<Idioma>> GetIdiomas(); 

        Task<Maestro?> GetById(int id);

        Task<List<Maestro>> GetByIdiomaId(int idiomaId);

        Task<Maestro> Add(Maestro maestro);

        Task Update(Maestro maestro);

        Task Delete(int id);
    }
}