using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;

namespace WindowsFormsApplication1.MonsterType
{
    class Wizard:Hero
    {
        public override string ToString()
        {
            return "Wizard";
        }

        public ILive Build(string name = "Wizard", int hp = 5, int mp = 12, int damage = 24, int def = 3,
          string agression = "Wizard", int Experience = 0, int Lvl = 0, int ExperienceToLvl = 0, int X = 0, int Y = 0, int x = 0, int y = 0, Eff eff = null)
        {
            var hero = new Wizard();
            hero.SetHero(name, hp, mp, damage, def, agression, Experience, Lvl, ExperienceToLvl, X, Y, x, y,eff);
            return hero;
        }
    }
}
