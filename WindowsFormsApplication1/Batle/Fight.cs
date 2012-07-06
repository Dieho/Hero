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
            if (first.HPCurent > 0 && second.HPCurent > 0)
            {
                bool chance = batleRandom.ChanceToHit(first);
                if (!chance)
                {
                    result = "You MISS!";
                }
                else
                {
                    second.HPCurent = second.HPCurent - batleRandom.Damage(first) / second.DefCurent;
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
                batleRandom.Experience( first,second);
            }

            return result;
        }

    }

}
