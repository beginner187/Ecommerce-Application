using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    public class OrderItem
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required(ErrorMessage = "Order ID is required.")]
        [BsonElement("orderId")]
        public ObjectId OrderId { get; set; }

        [Required(ErrorMessage = "Product ID is required.")]
        [BsonElement("productId")]
        public ObjectId ProductId { get; set; }

        [Range(1, 100,
            ErrorMessage = "Quantity must be between 1 and 100.")]
        [BsonElement("quantity")]
        public int Quantity { get; set; }

        [Range(typeof(decimal), "0.00", "10000.00",
            ErrorMessage = "Unit Price must be between $0.00 and $10,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("unitPrice")]
        public decimal UnitPrice { get; set; }

        [Range(typeof(decimal), "0.00", "10000.00",
            ErrorMessage = "Discount must be between $0.00 and $10,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("discount")]
        public decimal Discount { get; set; }

        [Range(typeof(decimal), "0.00", "10000.00",
            ErrorMessage = "Total Price must be between $0.00 and $10,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("totalPrice")]
        public decimal TotalPrice { get; set; }
    }
}