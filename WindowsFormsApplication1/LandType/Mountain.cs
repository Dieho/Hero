using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.LandType
{
    class Mountain:ILand
    {
        private string _name="Mountain"; 

        public string name
        {
            get { return _name; }
           
        }

        public int mountain
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int forest
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int water
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
    }
}
