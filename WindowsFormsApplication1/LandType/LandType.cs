using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.LandType
{
    class LandType
    {
        public struct Land
        {
            public static string name;
            public static int mountain;
            public static int forest;
            public static int water;
        }

        public static Land CreateLand(int land)
        {
            switch (land)
            {
                case 8&9&10:
                    Land.name = new Mountain().name;
                    Land.mountain = new Mountain().mountain;
                    Land.forest = new Mountain().forest;
                    Land.water = new Mountain().water;
                    break;
            }
            return new Land();
        }

    }
}
