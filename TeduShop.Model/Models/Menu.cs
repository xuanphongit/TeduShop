using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model.Models
{
    [Table("Menus")]
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        public int? DisplayOrder { get; set; }
        [Required]
        public int GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual MenuGroup MenuGroup { get; set; }
        [Required]
        public string Target { get; set; }
        [Required]
        public bool Status { get; set; }
    }
}
