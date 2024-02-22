using System.ComponentModel.DataAnnotations;

namespace StrideSync.Data
{
    public class Run
    {
        public int Id { get; set; }
        [Required]
        public double Distance { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
    }
}
