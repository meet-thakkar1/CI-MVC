using System.ComponentModel.DataAnnotations;

namespace CI_Plateform_Web.Models
{
    public class category
    {
        [Key]
        public int id { get; set; }
        [Required]
        public int MyProperty { get; set; }
    }
}
