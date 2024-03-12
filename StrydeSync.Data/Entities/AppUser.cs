using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrideSync.Data.Entities.Abstractions;

namespace StrideSync.Data.Entities
{
    internal class AppUser : BaseEntity
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public double Weight { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
