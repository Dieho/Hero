using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.LandType
{
    public interface ILand
    {
        string Name { get;  }
        bool Passability { get; set; }
        ILandObject LandObject {get;set;}   
        ILive LivingBeings { get; set; }

    }

    public interface ILandObject
    {
        string Name { get; }
        bool Passability { get; set; }
        Eff Effect { get; set; }
    }
}
