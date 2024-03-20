using StrideSync.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Service.DTOs
{
    public class TrainingSessionDTO:BaseDTO
    {
        [Required]
        public string Name { get; set; }
        [AllowNull]
        public virtual ICollection<Exercise>? Exercises { get; set; }
        [AllowNull]
        public virtual ICollection<Run>? Runs { get; set; }
    }
}
