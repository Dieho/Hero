using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.MonsterType
{
   public interface ILive
    {
        String Name { get; set; }
        int HP { get; set; }
        int MP { get; set; }
        int Damage { get; set; }
        int Def { get; set; }
        String Agression { get; set; }
    }
}