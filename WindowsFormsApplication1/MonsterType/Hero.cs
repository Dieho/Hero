using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.MonsterType
{
    class Hero : ILive
    {
        protected string _name;
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

        #region DDBuild
        public Hero SetDD(string name, int hp, int mp, int damage, int def, string agression)
        {
            _name = name;
            _HP = hp;
            _MP = mp;
            _Damage = damage;
            _Def = def;
            _agression = agression;
            return this;
        }

        public Hero SetDD()
        {
            _name = "DD";
            _HP = 7;
            _MP = 6;
            _Damage = 10;
            _Def = 5;
            _agression = "DD";
            return this;
        }
        #endregion

        #region DefenderBuilder
        public Hero SetDefender(string name, int hp, int mp, int damage, int def, string agression)
        {
            _name = name;
            _HP = hp;
            _MP = mp;
            _Damage = damage;
            _Def = def;
            _agression = agression;
            return this;
        }

        public Hero SetDefender()
        {
            _name = "Warrior";
            _HP = 10;
            _MP = 4;
            _Damage = 5;
            _Def = 7;
            _agression = "Defender";
            return this;
        }
        #endregion
        
        #region WizardBuilder
        public Hero SetWizard(string name, int hp, int mp, int damage, int def, string agression)
        {
            _name = name;
            _HP = hp;
            _MP = mp;
            _Damage = damage;
            _Def = def;
            _agression = agression;
            return this;
        }

        public Hero SetWizard()
        {//"Wizard", 5, 10, 24, 3, "Wizard"
            _name = "Wizard";
            _HP = 5;
            _MP = 12;
            _Damage = 24;
            _Def = 3;
            _agression = "Wizard";
            return this;
        }
        #endregion

    }
}
