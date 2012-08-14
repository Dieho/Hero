using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Skills
{
    public abstract class  Skill
    {
        private bool isCooled;
        private int _cooldown;
        private int _rollBack;

        #region virtual methods
        public virtual string Name { get; set; }


        public virtual int CoolDown
        {
            get { return _cooldown; }
            set { _cooldown = value; }
        }

        public virtual short Lvl
        {
            get; set;
        }

        public virtual int RollBack
        {
            get { return _rollBack; }
            set { _rollBack = value; }
        }

        public virtual bool SkillCondition(ILive you) { return true; }
        #endregion

        public bool IsCooled
        {
            get { return isCooled; }
            set { isCooled = value; }
        }

        public void ToCollDown(ILive you)
        {
            if (_cooldown > 0)
            {
                CoolDown--;
                isCooled = false;
            }
            else
            {
                isCooled = true;
                you.skillInUse.Remove(this);
                _cooldown = RollBack;
            }
        }

    }

    public interface IBattleSkill
    {
        float Damage { get;}
        float SkillDamage(ILive you);
        float Smash(ILive you, ILive victim);
      //  Eff SkillEffect { get; set; }
    }

    interface IPassiveSkill
    {
    }

    interface IPeaceSkill
    {
    }

    interface IMageSkill
    {
        float Damage { get; set; }
        float SkillDamage(ILive you);
        float Smash(ILive you, ILive victim);
    }
}
