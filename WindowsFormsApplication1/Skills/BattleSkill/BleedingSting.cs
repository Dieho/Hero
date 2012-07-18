using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Skills.BattleSkill
{
    class BleedingSting:IBattleSkill
    {
        private int _lvl;
        private float _damage;
        private float _skillDamage;
        private int _skillEffect;
        private int _coolDown;
        private int _toCollDown;

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

        public float SkillDamage
        {
            get { return _skillDamage; }
            set { _skillDamage = value; }
        }

        public int SkillEffect
        {
            get { return _skillEffect; }
            set { _skillEffect = value; }
        }

        public int CoolDown
        {
            get { return _coolDown; }
            set { _coolDown = value; }
        }

        public int ToCollDown
        {
            get { return _toCollDown; }
            set { _toCollDown = value; }
        }

        public double Smash(ILive you)
        {
           var sDamage = you.DamageCurent*1.5;
           Bleeding a = new Bleeding();
           you.effects.Add(a);
           return sDamage;
        }
    }
}
