using E_Commerce.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class OrderModel
    {
        [Key]

        public int Id { get; set; }

        public string OrderDate { get; set; }

        public string ShippingAddress { get; set; }

        public string BillingAddress { get; set; }

        public string ShippingMethod { get; set; }

        public double Price { get; set; }

        public int CustomerId { get; set; } 
        
        public int OrderStatusId { get; set; }

        public int ComputerModelId { get; set; }

        public string CustomerName { get; set; }

        //Relationships

        public List<ComputerModelsModel> ComputerModelsModel { get; set; }


    }
}
