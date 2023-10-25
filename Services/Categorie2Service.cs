using Mongo.DL;
using Mongo.Entities;
using MongoDB.Driver;

namespace Mongo.Services
{
    public class Categorie2Service : ICategorie2Service
    {
        private readonly IMagazzinoContext _context;
        public Categorie2Service(IMagazzinoContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }
        public async Task CreateCategoria(Categoria2 categoria)
        {
            await _context.Categorie.InsertOneAsync(categoria);
        }

        public async Task<Categoria2> GetCategoria(string id)
        {
            var categorie = await _context
                          .Categorie
                          .Find(c => c.CategoryId == id).ToListAsync();
                         
            return categorie.FirstOrDefault();
        }

        public async Task<List<Categoria2>> GetCategorie()
        {
            return await _context
                            .Categorie
                            .Find(c => true)
                            .ToListAsync();
        }
    }
}
