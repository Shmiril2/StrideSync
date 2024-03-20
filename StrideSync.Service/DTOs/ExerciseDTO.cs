using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Service.DTOs
{
    public class ExerciseDTO : BaseDTO
    {
        public string Name { get; set; }
        public string MuscleGroup { get; set; }
        public double Weight { get; set; }
        public int Sets { get; set; }
        public int Repetitions { get; set; }
    }
}
