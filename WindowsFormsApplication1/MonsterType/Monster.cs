using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.MonsterType
{
    class Monster:ILive
    {
        private string name; 
        private string agression;
        private HeroBuilder.Stat stat;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public HeroBuilder.Stat Stat
        {
            get { return stat; }
            set { stat = value; }
        }

        public string Agression
        {
            get { return agression; }
            set { agression=value; }
        }

        public Monster SetMonster(string a,HeroBuilder.Stat b,string c)
        {
            Name = a;
            Stat = b;
            Agression = c;
            return this;
        }
    }
}
