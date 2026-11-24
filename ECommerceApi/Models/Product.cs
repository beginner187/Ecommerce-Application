using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    // Represents a product available for purchase
    public class Product
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required(ErrorMessage = "Product Name is required.")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "Product Name must be between 3 and 100 characters.")]
        [BsonElement("name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required.")]
        [MinLength(10,
            ErrorMessage = "Description must be at least 10 characters.")]
        [BsonElement("description")]
        public string Description { get; set; }

        [Range(typeof(decimal), "0.01", "10000.00",
            ErrorMessage = "Price must be between $0.01 and $10,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("price")]
        public decimal Price { get; set; }

        [Range(0, 1000,
            ErrorMessage = "Stock Quantity must be between 0 and 1000.")]
        [BsonElement("stockQuantity")]
        public int StockQuantity { get; set; }

        [BsonElement("imageUrl")]
        public string? ImageUrl { get; set; }

        [Range(0, 100,
            ErrorMessage = "Discount Percentage must be between 0% and 100%.")]
        [BsonElement("discountPercentage")]
        public int DiscountPercentage { get; set; }

        [BsonElement("isAvailable")]
        public bool IsAvailable { get; set; } = true;

        [Required(ErrorMessage = "Category ID is required.")]
        [BsonElement("categoryId")]
        public ObjectId CategoryId { get; set; }
    }
}