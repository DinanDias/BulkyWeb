using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30)] //server-side
        [DisplayName("Category Name")] //client side validation adjusting row names
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display order should be between 1 and 100")]
        public int DisplayOrder { get; set; }
    }
}
