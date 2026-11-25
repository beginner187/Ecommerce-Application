using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    public class Cancellation
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required(ErrorMessage = "Order ID is required.")]
        [BsonElement("orderId")]
        public ObjectId OrderId { get; set; }

        [Required(ErrorMessage = "Cancellation reason is required.")]
        [StringLength(500,
            ErrorMessage = "Cancellation reason cannot exceed 500 characters.")]
        [BsonElement("reason")]
        public string Reason { get; set; }

        [Required]
        [EnumDataType(typeof(CancellationStatus),
            ErrorMessage = "Invalid Cancellation Status.")]
        [BsonRepresentation(BsonType.String)]
        [BsonElement("status")]
        public CancellationStatus Status { get; set; }

        [Required]
        [BsonElement("requestedAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime RequestedAt { get; set; }

        [BsonElement("processedAt")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime? ProcessedAt { get; set; }

        [BsonElement("processedBy")]
        public int? ProcessedBy { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("orderAmount")]
        public decimal OrderAmount { get; set; }

        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("cancellationCharges")]
        public decimal? CancellationCharges { get; set; } = 0.00m;

        [StringLength(500,
            ErrorMessage = "Remarks cannot exceed 500 characters.")]
        [BsonElement("remarks")]
        public string? Remarks { get; set; }
    }
}