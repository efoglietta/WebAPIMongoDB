﻿using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Mongo.Entities
{
    public class Prodotto2
    {
        //Bson annotations
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public String? ProductId { get; set; }
       
        public string? ProductName { get; set; }         
        public decimal? UnitPrice { get; set; }
        public int Giacenza { get; set; }

    }


}
