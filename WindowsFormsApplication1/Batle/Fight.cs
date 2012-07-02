using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Calculator;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Batle
{
    class Fight:IBatle
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

        public void Kick(ILive first,ILive second)
        {
            BatleCalculates batleRandom=new BatleCalculates();
            bool chance = batleRandom.ChanceToHit(first);
            if(chance)
            second.HP = second.HP -first.Damage/second.Def ;
            chance = batleRandom.ChanceToHit(second);
            if (chance)
            first.HP = first.HP - second.Damage / first.Def;
            
        }
    }
}
