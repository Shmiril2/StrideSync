using StrideSync.Data.Entities.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Data.Entities
{
    public class Exercise : BaseEntity
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
    }
}
