using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public void Kick(ILive _first,ILive _second,int power)
        {
            _first.HP = _first.HP - power; //Test
            //ToDO: Calculate Kick (or punch :) power with checking defence
        }
    }
}
