using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Batle
{
    public interface IBatle
    {
        ILive First { get; set; }
        ILive Second { get; set; }

    } 
}
