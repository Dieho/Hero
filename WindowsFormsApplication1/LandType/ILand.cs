using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.LandType
{
    interface ILand
    {
      
            String name    { get; }
            int    mountain { get; set; }
            int    forest   { get; set; }
            int    water    { get; set; }
        
        
    }
}
