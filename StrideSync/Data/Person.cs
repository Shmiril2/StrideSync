using System.ComponentModel.DataAnnotations;

namespace StrideSync.Data
{
    public class Person
    {
        public int Id { get; set; }
        
        [Required]
        public int Age { get; set; }
        
        [Required]
        public int Height { get; set; }
        
        [Required]
        public double Weight { get; set; }
        
        [Required]
        public string Gender { get; set; }
    }
}
