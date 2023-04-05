using E_Commerce.Data.Enums;

namespace E_Commerce.Models
{
    public class ComputerModelsModel
    {
        public int ComputerCategoryId { get; set; }

        public ComputerSeriesModel ComputerSeries { get; set; }


        public int ComputerSeriesId { get; set; }

        public ComputerModel Computer { get; set; }


        public int ComputerModelId { get; set; }   

        public ConfigurationModel Configuration { get; set;}


        public int OrderStatusId { get; set; }

        public int CustomerId { get; set; }

        public OrderModel Order { get; set; }

    }
}
