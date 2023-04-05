using E_Commerce.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models
{
    public class ProductCategoryModel
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        public string ImageURL { get; set; }

        public string Description { get; set; }

        public ProductCategory ProductCategory { get; set; }

        //Relationships

        public List<ComputerModelsModel> ComputerModels { get; set; }

        //ComputerSeries Relatioships

        public int ComputerCategoryId { get; set; }

        [ForeignKey("ComputerCategoryId")]

        public ComputerSeriesModel ComputerSeries { get; set; }

        //ComputerModel Relationships

        public int ComputerSeriesId { get; set; }

        [ForeignKey("ComputerSeriesId")]

        public ComputerModel Computer { get; set; }

        // Configuration Relationships

        public int ComputerModelId { get; set; }

        [ForeignKey("ComputerModelId")]

        public ConfigurationModel ConfigurationModel { get; set; }

        // Order Relationships

        public int OrderStatusId { get; set; }

        [ForeignKey("OrderStatusId")]

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]

        public OrderModel Order { get; set; }



    }
}
