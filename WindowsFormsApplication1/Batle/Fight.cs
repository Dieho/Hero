using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Calculator;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.MonsterType;
using WindowsFormsApplication1.Skills;
using WindowsFormsApplication1.Skills.BattleSkill;

namespace WindowsFormsApplication1.Batle
{
    class Fight
    {
        public string Kick(ILive first, ILive second, IBattleSkill skill = null)
        {

            var batleRandom = new BatleCalculates();
            string result = "";
            if (first.HPCurent > 0 && second.HPCurent > 0)
            {
                bool chance = batleRandom.ChanceToHit(first);
                if (!chance)
                {
                    result = "You MISS!";
                }
                else
                {
                    if (skill == null)
                        second.HPCurent = second.HPCurent - batleRandom.Damage(first) / second.DefCurent;
                    else
                    {
                        first.skillInUse.Add(skill as Skill);
                        second.HPCurent = second.HPCurent - skill.Smash(first, second) / second.DefCurent;
                    }

                }
                if (first.HPCurent > 0 && second.HPCurent > 0)
                {
                    chance = batleRandom.ChanceToHit(second);

                    if (!chance)
                        result += "He MISS!Ha-Ha";
                    else
                    {
                        first.HPCurent = first.HPCurent - batleRandom.Damage(second) / first.DefCurent;
                    }
                }
                GoEffect(first, second);
            }

            if (first.HPCurent <= 0)
            {
                first.HPCurent = 0;
                result += "You are dead!:(";
                batleRandom.Experience(second, first);
            }
            if (second.HPCurent <= 0)
            {
                second.HPCurent = 0;
                result += "He is dead!:)";
                batleRandom.Experience(first, second);
            }

            return result;
        }

        public void GoEffect(ILive first, ILive second)
        {
            for (int i = 0; i < first.effects.Count; i++)
            {
                first.effects[i].Go(first,i);
            }

            for (int i = 0; i < second.effects.Count; i++)
            {
                second.effects[i].Go(second,i);
            }

            for (int i = 0; i < first.skillInUse.Count; i++)
            {
                first.skillInUse[i].ToCollDown(first);

            }

            for (int i = 0; i < second.skillInUse.Count; i++)
            {
                second.skillInUse[i].ToCollDown(second);

            }

        }

    }

}
