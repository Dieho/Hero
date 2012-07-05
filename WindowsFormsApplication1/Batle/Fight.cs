using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Calculator;
using WindowsFormsApplication1.MonsterType;

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

        public string Kick(ILive first, ILive second)
        {
            BatleCalculates batleRandom = new BatleCalculates();
            string result = "";
            if (first.HP > 0 && second.HP > 0)
            {
                bool chance = batleRandom.ChanceToHit(first);
                if (!chance)
                {
                    result = "You MISS!";
                }
                else
                {
                    second.HP = second.HP - batleRandom.Damage(first) / second.Def;
                }
                if (first.HP > 0 && second.HP > 0)
                {
                    chance = batleRandom.ChanceToHit(second);

                    if (!chance)
                        result += "He MISS!Ha-Ha";
                    else
                    {
                        first.HP = first.HP - batleRandom.Damage(second) / first.Def;
                    }
                }
            }

            if (first.HP <= 0)
            {
                first.HP = 0;
                result += "You are dead!:(";
            }
            if (second.HP <= 0)
            {
                second.HP = 0;
                result += "He is dead!:)";
            }

            return result;
        }

    }

}
