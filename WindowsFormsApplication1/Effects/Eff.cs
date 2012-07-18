using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Effects
{
    public interface Eff
    {
        int Time { get; set; }
        void Go(ILive victim);
    }
}
