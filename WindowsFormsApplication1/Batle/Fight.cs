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
            if (first.HP > 0 && second.HP > 0)
            {
                bool chance = batleRandom.ChanceToHit(first);
                if (!chance)
                    return "You MISS!";
                second.HP = second.HP - first.Damage / second.Def;
                if (first.HP > 0 && second.HP > 0)
                {
                    chance = batleRandom.ChanceToHit(second);

                    if (!chance)
                        return "He MISS!Ha-Ha";
                    first.HP = first.HP - second.Damage / first.Def;
                }
            }

            if (first.HP <= 0)
            {
                first.HP = 0;
                return "You are dead!:(";
            }
            if (second.HP <= 0)
            {
                second.HP = 0;
                return "He is dead!:)";
            }

            return "--------";
        }

    }

}
