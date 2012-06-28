using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.MonsterType
{
     interface ILive
    {
        String Name { get; set; }
        HeroBuilder.Stat Stat { get; set; }
        String Agression { get; set; }
    } 
}
