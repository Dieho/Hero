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

        public float HP
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public float MP
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public float Damage
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public float Def
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }


        public string Type
        {
            get { return agression; }
            set { agression=value; }
        }

        public int experience
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int experienceToLvl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int Lvl
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
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
