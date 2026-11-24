using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    // Represents an individual item within a shopping cart
    public class CartItem
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required]
        [BsonElement("cartId")]
        public ObjectId CartId { get; set; }

        [Required]
        [BsonElement("productId")]
        public ObjectId ProductId { get; set; }

        [Required]
        [Range(1, 100,
            ErrorMessage = "Quantity must be between 1 and 100.")]
        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [Required]
        [Range(typeof(decimal), "0.01", "10000.00",
            ErrorMessage = "Unit Price must be between $0.01 and $10,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("unitPrice")]
        public decimal UnitPrice { get; set; }

        [Range(typeof(decimal), "0.00", "1000.00",
            ErrorMessage = "Discount must be between $0.00 and $1,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("discount")]
        public decimal Discount { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("totalPrice")]
        public decimal TotalPrice { get; set; }

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