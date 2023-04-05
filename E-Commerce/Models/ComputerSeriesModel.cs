using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class ComputerSeriesModel
    {
        [Key]

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ComputerCategoryID { get; set; }

        // Relationship

        public List<ComputerModelsModel> ComputerModelsModel { get; set; }
    }
}
