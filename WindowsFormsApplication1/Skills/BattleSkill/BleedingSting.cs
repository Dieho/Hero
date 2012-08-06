using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Skills.BattleSkill
{
    class BleedingSting :  Skill,IBattleSkill
    {
        private int _lvl = 1;
        private float _damage = (float)1.5;
        private float _skillDamage;
        private Eff _skillEffect = new Bleeding();
        //private int _coolDown = 5;
        //public bool isCooled;
        public override string Name
        {
            get
            {
                return "BleedingSting";
            }
            set
            {
                base.Name = value;
            }
        }

        public int Lvl
        {
            get { return _lvl; }
            set { _lvl = value; }
        }

        public float Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public float SkillDamage(ILive you)
        {
            _skillDamage = you.DamageCurent * _damage;
            return _skillDamage;
        }

        public Eff SkillEffect { get { return _skillEffect; } set { _skillEffect = value; } }

        //public int CoolDown
        //{
        //    get { return _coolDown; }
        //    set { _coolDown = value; }
        //}

        //public void ToCollDown()
        //{
        //    if (CoolDown > 0)
        //    {
        //        CoolDown--;
        //        isCooled = false;
        //    }
        //    else
        //    {
        //        isCooled = true;
        //    }
        //}

        public float Smash(ILive you, ILive victim)
        {
            SkillDamage(you);
            var a = SkillEffect;
            victim.effects.Add(a);
            return _skillDamage;
        }


    }
}
