using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneLib
{
    public class Fortune
    {
        public string FortuneText { get; set; }
        public FortuneLib.Enums.FortuneType Type { get; set; }
        public int Lenght { get; set; }
        public bool IsOffensive { get; set; }
    }
}
