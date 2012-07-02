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
        protected float _HP;
        protected float _MP;
        protected float _Damage;
        protected float _Def; 

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public float HP
        {
            get { return _HP; }
            set { _HP = value; }
        }

        public float MP
        {
            get { return _MP; }
            set { _MP = value; }
        }

        public float Damage
        {
            get { return _Damage; }
            set { _Damage = value; }
        }

        public float Def
        {
            get { return _Def; }
            set { _Def = value; }
        }

        public string Type
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
