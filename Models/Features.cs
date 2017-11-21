using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspnetCore_angular04_EntityFramework_Vega_2.Models
{
    [Table("Features")]
    public class Feature
    {
        public int Id { get; set; } 

        [Required]
        [StringLength(255)]
        public string Name { get; set; }  
    }
}