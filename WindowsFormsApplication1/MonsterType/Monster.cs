using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.Skills;

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

        public float HPCurent
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public float MPCurent
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public float DamageCurent
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public float DefCurent
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

        public Point location
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public Point mapPosition
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public List<Eff> effects
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public List<IBattleSkill> battleSkills
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public List<Skill> skillInUse
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
