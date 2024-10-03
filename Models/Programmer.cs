using System.ComponentModel.DataAnnotations;

namespace ProPlusApi.Models
{
    public class Programmer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email is required")]
        public string Email {  get; set; }
        public int Age {  get; set; }
    }
}
