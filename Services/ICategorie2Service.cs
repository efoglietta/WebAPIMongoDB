using Mongo.Entities;

namespace Mongo.Services
{
    public interface ICategorie2Service
    {
       
        Task<Categoria2> GetCategoria(string id);
        Task<List<Categoria2>> GetCategorie();
        Task CreateCategoria(Categoria2 categoria);
     
    }
}
