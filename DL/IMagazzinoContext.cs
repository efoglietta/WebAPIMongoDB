using Mongo.Entities;
using MongoDB.Driver;

namespace Mongo.DL
{
    public interface IMagazzinoContext
    {
        IMongoCollection<Prodotto> Prodotti { get; }
        public IMongoCollection<Categoria2> Categorie { get; }
    }

}
