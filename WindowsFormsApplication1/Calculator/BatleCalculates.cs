using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Calculator
{
    class BatleCalculates
    {
        /// <summary>
        /// OK
        /// </summary>
        /// <param name="first"></param>
        /// <returns></returns>
        public bool ChanceToHit(ILive first)
        {
            var rand = new Random();
            double chanceToHit = rand.NextDouble();
            switch (first.Type)
            {
                case "Defender": if (chanceToHit > 0.8)
                        return false; break;
                case "Wizard": break;
                case "DD": if (chanceToHit > 0.9)
                        return false; break;
                case "Monster1": if (chanceToHit > 0.5)
                        return false; break;
                case "Monster2": if (chanceToHit > 0.6)
                        return false; break;
                case "Monster3": if (chanceToHit > 0.7)
                        return false; break;
            }
            return true;
        }
    }
}
