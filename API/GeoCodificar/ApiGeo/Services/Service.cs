using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using ApiGeo.Models;

namespace ApiGeo.Services
{
    public class Service
    {
        private readonly IMongoCollection<Geolocalizar> _geolocalizar;

        public Service(IStoreDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _geolocalizar = database.GetCollection<Geolocalizar>(settings.CollectionName);
        }

        public Geolocalizar Create(Geolocalizar geolocalizar)
        {
            _geolocalizar.InsertOne(geolocalizar);
            return geolocalizar;
        }

        //public Geocodificar Get(string id) =>
        //    _geolocalizar.Find<Geocodificar>(book => book.Id == id).FirstOrDefault();
    }
}
