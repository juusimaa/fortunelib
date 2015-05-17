using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneLib
{
    [Serializable]
    public class FortuneItem
    {
        public string FortuneText { get; set; }
        public FortuneLib.Enums.FortuneType Type { get; set; }
        
        public int Lenght 
        {
            get { return FortuneText.Length; }
        }
        
        public bool IsOffensive { get; set; }
    }
}
