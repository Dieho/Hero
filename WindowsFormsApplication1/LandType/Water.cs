using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.LandType
{
    public class Water : ILand
    {
        private bool _passability;
        private const string _name="Water";
        public string Name
        {
            get { return _name; }
        }

        public bool Passability
        {
            get { return _passability; }
            set { _passability = value; }
        }

        public ILandObject LandObject
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ILive LivingBeings
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public override string ToString()
        {
            return "Water";
        }
    }
}
