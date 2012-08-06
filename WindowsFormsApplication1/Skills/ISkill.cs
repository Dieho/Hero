using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Skills
{
    public abstract class  Skill{
        private string _name;
        private int CoolDown = 5;
        private bool isCooled;

        public virtual string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public bool IsCooled
        {
            get { return isCooled; }
            set { isCooled = value; }
        }

        public void ToCollDown()
        {
            if (CoolDown > 0)
            {
                CoolDown--;
                isCooled = false;
            }
            else
            {
                isCooled = true;
            }
        }
    }

    public interface IBattleSkill
    {
        int Lvl { get; set; }
        float Damage { get; set;}
        float SkillDamage(ILive you);
        Eff SkillEffect { get; set; }
        //int CoolDown { get; set; }
        //void ToCollDown();
        float Smash(ILive you, ILive victim);
    }

    interface IPassiveSkill
    {
    }

    interface IPeaceSkill
    {
    }

    interface IMageSkill
    {
    }
}
