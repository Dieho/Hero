using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Effects
{
    class burning : Eff
    {
        private int _time;

        public burning()
        {
            _time = 5;
        }

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public override string ToString()
        {
            return "Burning";
        }

        public void Go(ILive victim, int i)
        {
            if (victim.effects[i].Time > 0)
            {
                victim.HPCurent -= (float)0.4;
                victim.effects[i].Time -= 1;

            }
            else
            {

                victim.effects.RemoveAt(i);

            }
        }

    }
}
