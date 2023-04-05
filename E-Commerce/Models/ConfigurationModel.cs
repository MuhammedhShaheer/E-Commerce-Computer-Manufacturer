using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class ConfigurationModel
    {
        [Key]
        public int Id { get; set; } 

        public string Name { get; set; }  
        
        public string Description { get; set; }

        public double Price { get; set; }

        public int ComputerModelId { get; set; }

        //Relationships

        public List<ComputerModelsModel> ComputerModelsModel { get; set; }


    }
}
