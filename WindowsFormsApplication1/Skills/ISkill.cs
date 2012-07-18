using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Skills
{
    interface IBattleSkill
    {
        int Lvl { get; set; }
        float Damage { get; set;}
        float SkillDamage { get; set; }
        int SkillEffect { get; set; }
        int CoolDown { get; set; }
        int ToCollDown { get; set; }
    }

    interface IPassiveSkill
    {
    }

    interface IPeaceSkill
    {
    }

    interface IMageSkill
    {
    }
}
