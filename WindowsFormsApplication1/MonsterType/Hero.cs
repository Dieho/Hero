using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;

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
        protected Point _mapPosition;
        protected Point _location;
        protected List<Eff> _effects=new List<Eff>();

        #region
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

        public Point location
        {
            get { return _location; }
            set { _location = value; }
        }

        public Point mapPosition
        {
            get { return _mapPosition; }
            set { _mapPosition = value; }
        }

        public List<Eff> effects
        {
            get { return _effects; }
            set { _effects = value; }
        }

        #endregion
        //#region DDBuild


        protected Hero SetHero(string name, int hp, int mp, int damage, int def, string agression, int Experience, int Lvl, int ExperienceToLvl, int X, int Y, int x, int y, Eff effect=null)
        {
            _location.X = x;
            _location.Y = y;
            _mapPosition.X = X;
            _mapPosition.Y = Y;
            _name = name;_HP = hp;
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
            if (effect!=null)
            _effects.Add(effect);
            return this;

        }


        public int NextLvl(int lvl)
        {
            int Exp = 100;
            if (lvl == 1)
                return Exp + 50;
            if (lvl > 1)
            {
                Func<double, double> asd = null;
                asd = (x) => x > 1 ? asd(x - 1) + 0.5 * asd(x - 1) : x;
                Exp = (int)(asd(lvl) * 100);

            }
            return Exp;
        }

    }
}
