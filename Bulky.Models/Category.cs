using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Bulky.Models
{
    public class Category
    {
        [Key] //Explicitly declaring primary key for category table
        public int Id { get; set; }
        [Required] //Specifies that that field is required
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Order must be between 1-100")]
        public int DisplayOrder { get; set; }
    }
}
