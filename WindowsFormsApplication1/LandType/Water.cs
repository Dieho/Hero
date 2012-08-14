using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

        public override string ToString()
        {
            return "Water";
        }
    }
}
