using ClasesIdioma.Modelos;

namespace ClasesIdioma.Repositorios
{
    public interface IRepositorioClases
    {
        Task<List<Clase>> GetAll();                        
        Task<Clase?> GetById(int id);                      
        Task<Clase> Add(Clase clase);                     
        Task Update(Clase clase);                          
        Task Delete(int id);                               

        Task<List<Idioma>> GetIdiomas();
        Task<List<Maestro>> GetMaestros();
        Task<List<Estudiante>> GetEstudiantes();
    }
}
