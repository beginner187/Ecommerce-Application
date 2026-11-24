using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    // Represents the status master
    public class Status
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required]
        [StringLength(50)]
        [BsonElement("name")]
        public string Name { get; set; }
    }
}