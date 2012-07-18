using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Effects
{
    class Bleeding : Eff
    {
        private int _time = 10;

        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }

        void Eff.Go(ILive victim)
        {
            if (Time > 0)
            {
                victim.HPCurent -= (float)0.3;
                Time -= 1;
            }
            else
            {
                foreach (var i in victim.effects)
                {
                    if (i.Time<=0)
                    {
                        victim.effects.Remove(i);
                        break;
                    }
                }
            }
        }

    }
}
