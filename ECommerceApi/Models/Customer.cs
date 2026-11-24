using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    // Represents a customer in the e-commerce system
    public class Customer
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "First Name must be between 2 and 50 characters.")]
        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(50, MinimumLength = 2,
            ErrorMessage = "Last Name must be between 2 and 50 characters.")]
        [BsonElement("lastName")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        [BsonElement("email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "PhoneNumber is required.")]
        [BsonElement("phoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "DateOfBirth is required.")]
        [BsonElement("dateOfBirth")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [BsonElement("password")]
        public string Password { get; set; }

        [BsonElement("isActive")]
        public bool IsActive { get; set; } = true;
    }
}