using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Mongo.Entities
{
    public class Categoria2
    {
        //Bson annotations
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String? CategoryId { get; set; }

        public string? CategoryName { get; set; }
        //public string? Descrizione { get; set; }
        public List<Prodotto2> Products { get; set; }
    }

}
