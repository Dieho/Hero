using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.Skills;

namespace WindowsFormsApplication1.MonsterType
{
   public interface ILive
    {
        String Name { get; set; }
        float HP { get; set; }
        float MP { get; set; }
        float Damage { get; set; }
        float Def { get; set; }
        float HPCurent { get; set; }
        float MPCurent { get; set; }
        float DamageCurent { get; set; }
        float DefCurent { get; set; }
        string Type { get; set; }
        int experience { get; set; }
        int experienceToLvl { get; set; }
        int Lvl { get; set; }
        Point location { get; set; }
        Point mapPosition { get; set; }
        List<Eff> effects { get; set; }
        List<IBattleSkill> battleSkills { get; set; }
        List<Skill> skillInUse { get; set; }

    }
}