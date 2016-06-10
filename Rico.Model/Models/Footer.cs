using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Rico.Model.Models
{
    [Table("Footer")]
    public class Footer
    {
        [Key]
        public string ID { set; get; }
        [Required]
        public string Content { set; get; }

    }
}
