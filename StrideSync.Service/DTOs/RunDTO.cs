using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrideSync.Service.DTOs
{
    public class RunDTO : BaseDTO
    {
        public int Distance { get; set; }
        public TimeSpan Time { get; set; }
    }
}
