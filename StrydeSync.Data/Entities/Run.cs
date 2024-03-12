using StrideSync.Data.Entities.Abstractions;
using System.ComponentModel.DataAnnotations;

namespace StrideSync.Data.Entities
{
    public class Run : BaseEntity
    {
        [Required]
        public double Distance { get; set; }
        [Required]
        public TimeSpan Time { get; set; }
    }
}
