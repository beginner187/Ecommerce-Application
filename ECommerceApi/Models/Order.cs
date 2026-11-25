using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ECommerceApp.MongoModels
{
    public class Order
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [Required]
        [StringLength(30,
            ErrorMessage = "Order Number cannot exceed 30 characters.")]
        [BsonElement("orderNumber")]
        public string OrderNumber { get; set; }

        [Required]
        [BsonElement("orderDate")]
        [BsonDateTimeOptions(Kind = DateTimeKind.Utc)]
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "Customer ID is required.")]
        [BsonElement("customerId")]
        public ObjectId CustomerId { get; set; }

        [Required(ErrorMessage = "Billing Address ID is required.")]
        [BsonElement("billingAddressId")]
        public ObjectId BillingAddressId { get; set; }

        [Required(ErrorMessage = "Shipping Address ID is required.")]
        [BsonElement("shippingAddressId")]
        public ObjectId ShippingAddressId { get; set; }

        [Required]
        [Range(typeof(decimal), "0.00", "100000.00",
            ErrorMessage = "Total Base Amount must be between $0.00 and $100,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("totalBaseAmount")]
        public decimal TotalBaseAmount { get; set; }

        [Required]
        [Range(typeof(decimal), "0.00", "100000.00",
            ErrorMessage = "Total Discount Amount must be between $0.00 and $100,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("totalDiscountAmount")]
        public decimal TotalDiscountAmount { get; set; }

        [Range(typeof(decimal), "0.00", "10000.00",
            ErrorMessage = "Shipping Cost must be between $0.00 and $10,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("shippingCost")]
        public decimal ShippingCost { get; set; }

        [Required]
        [Range(typeof(decimal), "0.00", "110000.00",
            ErrorMessage = "Total Amount must be between $0.00 and $110,000.00.")]
        [BsonRepresentation(BsonType.Decimal128)]
        [BsonElement("totalAmount")]
        public decimal TotalAmount { get; set; }

        [Required]
        [EnumDataType(typeof(OrderStatus),
            ErrorMessage = "Invalid Order Status.")]
        [BsonRepresentation(BsonType.String)]
        [BsonElement("orderStatus")]
        public OrderStatus OrderStatus { get; set; }
    }
}