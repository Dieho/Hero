using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Skills.MageSkill
{
    class FireBall:Skill,IMageSkill
    {
        private const short _lvl = 1;
        private const int _coolDown = 7;
        private float _damage = (float)1.3;
        private float _skillDamage;
        private Eff _skillEffect = new Bleeding();
        public FireBall()
        {
            base.CoolDown = _coolDown;
        }

        public override int RollBack
        {
            get
            {
                return _coolDown;
            }
            set
            {
                base.RollBack = _coolDown;
            }
        }

        public override string Name
        {
            get
            {
                return "BleedingSting";
            }
        }

        public override short Lvl
        {
            get { return _lvl; }
        }

        public override bool SkillCondition(ILive you)
        {
            if (you.Lvl>0&&you.Type!="Wizard")
            {return true;}
            return false;
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

        public Eff SkillEffect
        {
            get { return _skillEffect; } 
            set { _skillEffect = value; }
        }

        public float Smash(ILive you, ILive victim)
        {
            SkillDamage(you);
            var a = SkillEffect;
            victim.effects.Add(a);
            return _skillDamage;
        }
    }
}
