using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Effects
{
    class Bleeding : Eff
    {
        private int _time;

        public Bleeding()
        {
            _time = 10;
        }

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public override string ToString()
        {
            return "BleedingSting";
        }

        public void Go(ILive victim, int i)
        {
            if (victim.effects[i].Time > 0)
            {
                victim.HPCurent -= (float)0.3;
                victim.effects[i].Time -= 1;

            }
            else
            {

                victim.effects.RemoveAt(i);

            }
        }

    }
}
