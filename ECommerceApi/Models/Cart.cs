using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    // Represents a shopping cart
    public class Cart
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required]
        [BsonElement("customerId")]
        public ObjectId CustomerId { get; set; }

        [BsonElement("isCheckedOut")]
        public bool IsCheckedOut { get; set; } = false;

        [Required]
        [BsonElement("createdAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime CreatedAt { get; set; }

        [Required]
        [BsonElement("updatedAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime UpdatedAt { get; set; }
    }
}