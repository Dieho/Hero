using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.MonsterType
{
   public interface ILive
    {
        String Name { get; set; }
        float HP { get; set; }
        float MP { get; set; }
        float Damage { get; set; }
        float Def { get; set; }
        string Type { get; set; }
        int experience { get; set; }
        int experienceToLvl { get; set; }
        int Lvl { get; set; }
    }
}