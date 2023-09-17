using System.ComponentModel.DataAnnotations;

namespace Api_App.Entities
{
    public class Team
    {
        [Key]
        public int Id { get; set; } 
        public string Image { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Titles { get; set; }
    }
}
