using ClasesIdioma.Modelos;

namespace ClasesIdioma.Repositorios
{
    public interface IRepositorioIdiomas
    {
        Task<List<Idioma>> GetAll();
        Task<Idioma?> GetById(int id);
        Task<List<Idioma>> GetIdiomas();
        Task<Idioma> Add(Idioma idioma);
        Task Update(Idioma idioma);
        Task Delete(int id);
    }
}
