﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.MonsterType
{
    class Warrior:Hero
    {
        public ILive Build(string name = "Warrior", int hp = 10, int mp = 4, int damage = 5, int def = 7,
            string agression = "Warrior", int Experience = 0, int Lvl = 0, int ExperienceToLvl = 0, int X = 0, int Y = 0, int x = 0, int y = 0)
        {
            var hero = new Warrior();
            hero.SetHero(name, hp, mp, damage, def, agression, Experience, Lvl, ExperienceToLvl, X, Y, x, y);
            return hero;
        }
    }
}
