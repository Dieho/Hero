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
        protected float _HPCurent;
        protected float _MPCurent;
        protected float _DamageCurent;
        protected float _DefCurent;
        protected int _experience;
        protected int _experienceToLvl;
        protected int _Lvl;

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

        public float HPCurent
        {
            get { return _HPCurent; }
            set { _HPCurent = value; }
        }

        public float MPCurent
        {
            get { return _MPCurent; }
            set { _MPCurent = value; }
        }

        public float DamageCurent
        {
            get { return _DamageCurent; }
            set { _DamageCurent = value; }
        }

        public float DefCurent
        {
            get { return _DefCurent; }
            set { _DefCurent = value; }
        }

        public string Type
        {
            get { return _agression; }
            set { _agression = value; }
        }

        public int experience
        {
            get { return _experience; }
            set { _experience = value; }
        }

        public int experienceToLvl
        {
            get { return _experienceToLvl; }
            set { _experienceToLvl = value; }
        }

        public int Lvl
        {
            get { return _Lvl; }
            set { _Lvl = value; }
        }

        #region DDBuild
        public Hero SetDD(string name, int hp, int mp, int damage, int def, string agression, int Experience, int ExperienceToLvl, int Lvl)
        {
            _name = name;
            _HP = hp;
            _HPCurent = _HP;
            _MP = mp;
            _MPCurent = _MP;
            _Damage = damage;
            _DamageCurent = _Damage;
            _Def = def;
            _DefCurent = _Def;
            _Lvl = Lvl;
            _agression = agression;
            _experience = Experience;
            _experienceToLvl = NextLvl(_Lvl);
            return this;
        }

        public Hero SetDD()
        {
            _name = "DD";
            _HP = 7;
            _HPCurent = _HP;
            _MP = 6;
            _MPCurent = _MP;
            _Damage = 10;
            _DamageCurent = _Damage;
            _Def = 5;
            _DefCurent = _Def;
            _agression = "DD";
            _Lvl = Lvl;
            _experience = 0;
            _experienceToLvl = NextLvl(Lvl);

            return this;
        }
        #endregion

        #region DefenderBuilder
        public Hero SetDefender(string name, int hp, int mp, int damage, int def, string agression, int Experience, int ExperienceToLvl, int Lvl)
        {
            _name = name;
            _HP = hp;
            _HPCurent = _HP;
            _MP = mp;
            _MPCurent = _MP;
            _Damage = damage;
            _DamageCurent = _Damage;
            _Def = def;
            _DefCurent = _Def;
            _Lvl = Lvl;
            _agression = agression;
            _experience = Experience;
            _experienceToLvl = NextLvl(_Lvl);
            return this;
        }

        public Hero SetDefender()
        {
            _name = "Warrior";
            _HP = 10;
            _HPCurent = _HP;
            _MP = 4;
            _MPCurent = _MP;
            _Damage = 5;
            _DamageCurent = _Damage;
            _Def = 7;
            _DefCurent = _Def;
            _agression = "Defender";
            _Lvl = Lvl;
            _experience = 0;
            _experienceToLvl = NextLvl(Lvl);
            return this;
        }
        #endregion

        #region WizardBuilder
        public Hero SetWizard(string name, int hp, int mp, int damage, int def, string agression, int Experience, int ExperienceToLvl, int Lvl)
        {
            _name = name;
            _HP = hp;
            _HPCurent = _HP;
            _MP = mp;
            _MPCurent = _MP;
            _Damage = damage;
            _DamageCurent = _Damage;
            _Def = def;
            _DefCurent = _Def;
            _Lvl = Lvl;
            _agression = agression;
            _experience = Experience;
            _experienceToLvl = NextLvl(_Lvl);
            return this;
        }

        public Hero SetWizard()
        {//"Wizard", 5, 10, 24, 3, "Wizard"
            _name = "Wizard";
            _HP = 5;
            _HPCurent = _HP;
            _MP = 12;
            _MPCurent = _MP;
            _Damage = 24;
            _DamageCurent = _Damage;
            _Def = 3;
            _DefCurent = _Def;
            _agression = "Wizard";
            _Lvl = Lvl;
            _experience = 0;
            _experienceToLvl = NextLvl(Lvl);
            return this;
        }
        #endregion

        public int NextLvl(int lvl)
        {
            int Exp;
            Exp = 100;
            if (lvl == 1)
                return Exp+50;
           if (lvl>1)
            {
                Func<double, double> asd = null;
                asd = (x) => x > 1 ? asd(x - 1) + 0.5 * asd(x - 1) : x;
                Exp = (int)(asd(lvl) * 100);

            }
           return Exp;
        }

    }
}
