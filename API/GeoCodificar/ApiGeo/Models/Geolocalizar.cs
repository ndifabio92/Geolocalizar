using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiGeo.Models
{
    public class Geolocalizar
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Ciudad { get; set; }
        public string Codigo_Postal { get; set; }
        public string Provincia { get; set; }
        public string Pais { get; set; }

    }
}
