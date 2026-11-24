using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    // Represents a product category
    public class Category
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required(ErrorMessage = "Category Name is required.")]
        [StringLength(100, MinimumLength = 3,
            ErrorMessage = "Category Name must be between 3 and 100 characters.")]
        [BsonElement("name")]
        public string Name { get; set; }

        [StringLength(500,
            ErrorMessage = "Description cannot exceed 500 characters.")]
        [BsonElement("description")]
        public string? Description { get; set; }

        [BsonElement("isActive")]
        public bool IsActive { get; set; } = true;
    }
}