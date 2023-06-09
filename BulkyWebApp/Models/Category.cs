using System.ComponentModel.DataAnnotations;

namespace BulkyWebApp.Models
{
    public class Category
    {
        // data annotation []
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;


    }
}
