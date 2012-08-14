using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.Skills;

namespace WindowsFormsApplication1.MonsterType
{
    class DD:Hero
    {
        public override string ToString()
        {
            return "DD";
        }

        public ILive Build(string name = "DD", int hp = 7, int mp = 6, int damage = 10, int def = 5, string agression = "DD", int Experience = 0, int Lvl = 0, int ExperienceToLvl = 0, int X = 0, int Y = 0, int x = 0, int y = 0, Eff eff = null, IBattleSkill bskill = null)
        {
            var hero=new DD();
            hero.SetHero(name, hp, mp, damage, def, agression, Experience, Lvl, ExperienceToLvl, X, Y, x, y, eff, bskill);
            return hero;
        }
    }
}
