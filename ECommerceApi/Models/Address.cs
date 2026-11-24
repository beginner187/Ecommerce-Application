using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    // Represents a customer's address
    public class Address
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required]
        [BsonElement("customerId")]
        public ObjectId CustomerId { get; set; }

        [Required(ErrorMessage = "Address Line 1 is required.")]
        [StringLength(100,
            ErrorMessage = "Address Line 1 cannot exceed 100 characters.")]
        [BsonElement("addressLine1")]
        public string AddressLine1 { get; set; }

        [StringLength(100,
            ErrorMessage = "Address Line 2 cannot exceed 100 characters.")]
        [BsonElement("addressLine2")]
        public string? AddressLine2 { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [StringLength(50,
            ErrorMessage = "City cannot exceed 50 characters.")]
        [BsonElement("city")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required.")]
        [StringLength(50,
            ErrorMessage = "State cannot exceed 50 characters.")]
        [BsonElement("state")]
        public string State { get; set; }

        [Required(ErrorMessage = "Postal Code is required.")]
        [BsonElement("postalCode")]
        public string PostalCode { get; set; }

        [Required(ErrorMessage = "Country is required.")]
        [StringLength(50,
            ErrorMessage = "Country cannot exceed 50 characters.")]
        [BsonElement("country")]
        public string Country { get; set; }
    }
}