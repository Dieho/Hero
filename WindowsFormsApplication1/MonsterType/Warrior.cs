using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.Skills;
using WindowsFormsApplication1.Skills.BattleSkill;

namespace WindowsFormsApplication1.MonsterType
{
    class Warrior:Hero
    {
        public override string ToString()
        {
            return "Warrior";
        }

        public ILive Build(string name = "Warrior", int hp = 10, int mp = 4, int damage = 5, int def = 7,
            string agression = "Warrior", int Experience = 0, int Lvl = 0, int ExperienceToLvl = 0, int X = 0, int Y = 0, int x = 0, int y = 0, Eff eff=null, IBattleSkill bskill=null)
        {
            var hero = new Warrior();
            hero.SetHero(name, hp, mp, damage, def, agression, Experience, Lvl, ExperienceToLvl, X, Y, x, y,eff,bskill);
            return hero;
        }

       public void LvlUp(ILive hero)
       {//var b=new BleedingSting();
        //   hero.battleSkills.Add(b);
           foreach (var i in BattleSkillEnum.BattleSkills)
           {
               if (i.SkillCondition(hero))
                   hero.battleSkills.Add(i as IBattleSkill);
           }
       }
    }
}
