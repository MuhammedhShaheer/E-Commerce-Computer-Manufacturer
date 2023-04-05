using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class ComputerModel
    {
        [Key]

        public int Id { get; set; }

        public string SeriesPictureURL { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageURL { get; set; }

        // Relationships

        public List<ComputerModelsModel> ComputerModelsModel { get; set; }
    }
}
