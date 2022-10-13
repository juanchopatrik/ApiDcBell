using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ApiDcBell.Models
{
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Title { get; set; }
        public int Cost { get; set; }


        public string Description { get; set; }
    }
}
