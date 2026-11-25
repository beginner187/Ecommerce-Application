using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    public class Payment
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required]
        [BsonElement("orderId")]
        public ObjectId OrderId { get; set; }

        [Required]
        [StringLength(50)]
        [BsonElement("paymentMethod")]
        public string PaymentMethod { get; set; }

        [StringLength(50)]
        [BsonElement("transactionId")]
        public string? TransactionId { get; set; }

        [Required]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("amount")]
        public decimal Amount { get; set; }

        [Required]
        [BsonElement("paymentDate")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime PaymentDate { get; set; }

        [Required]
        [EnumDataType(typeof(PaymentStatus),
            ErrorMessage = "Invalid Payment Status.")]
        [BsonRepresentation(BsonType.String)]
        [BsonElement("status")]
        public PaymentStatus Status { get; set; }
    }
}