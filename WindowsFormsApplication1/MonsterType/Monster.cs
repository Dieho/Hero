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

        public int HP
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int MP
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int Damage
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int Def
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }


        public string Agression
        {
            get { return agression; }
            set { agression=value; }
        }

        //public Monster SetMonster(string a,HeroBuilder.Stat b,string c)
        //{
        //    Name = a;
        //    Stat = b;
        //    Agression = c;
        //    return this;
        //}
    }
}
