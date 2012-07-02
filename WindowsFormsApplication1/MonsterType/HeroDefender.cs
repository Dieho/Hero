using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.MonsterType
{
    class HeroDefender:ILive
    {
        protected string _name;
        protected HeroBuilder.Stat _stat;
        protected string _agression;
        protected int _HP;
        protected int _MP;
        protected int _Damage;
        protected int _Def; 

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HP
        {
            get { return _HP; }
            set { _HP = value; }
        }

        public int MP
        {
            get { return _MP; }
            set { _MP = value; }
        }

        public int Damage
        {
            get { return _Damage; }
            set { _Damage = value; }
        }

        public int Def
        {
            get { return _Def; }
            set { _Def = value; }
        }

        public string Agression
        {
            get { return _agression; }
            set { _agression = value; }
        }

        public HeroDefender SetHero(string name,int hp,int mp,int damage,int def, string agression)
        {
            _name = name;
            _HP = hp;
            _MP = mp;
            _Damage = damage;
            _Def = def;
            _agression = agression;
            return this;
        }
    }
}
