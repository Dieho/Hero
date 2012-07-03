using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.LandType
{
    public class Water : ILand
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return "Вода";
        }
    }
}
