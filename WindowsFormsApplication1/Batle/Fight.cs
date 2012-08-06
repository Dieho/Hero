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
    class Fight : IBatle
    {
        private ILive _first;
        private ILive _second;

        public ILive First
        {
            get { return _first; }
            set { _first = value; }
        }

        public ILive Second
        {
            get { return _second; }
            set { _second = value; }
        }

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
            if (first.effects.Count != 0)
            {
                foreach (var i in first.effects)
                {

                    i.Go(first);
                }
            }

            if (second.effects.Count != 0)
            {
                foreach (var i in second.effects)
                {
                    i.Go(second);
                }
            }

            if (first.skillInUse.Count != 0)
            {
                foreach (var i in first.skillInUse)
                {
                    i.ToCollDown();// i.Go(first);

                }
            }

            if (second.skillInUse.Count != 0)
            {
                foreach (var i in second.skillInUse)
                {
                    i.ToCollDown();//  i.Go(second);
                }
            }
        }

    }

}
