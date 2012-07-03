using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.LandType
{
    public class MapPart
    {
        public int Name { get; set; }
        public int Water { get; set; }
        public int Mountain { get; set; }
        public int Ground { get; set; }

        public int Width { get { return 10; } }
        public int Height { get { return 10; } }

        public MapPart()
        {
            PercentGenerate();
        }

        public void PercentGenerate()
        {
            Ground = Generator.Generator.GenerateRandomValue(0, 100);
            Water = Generator.Generator.GenerateRandomValue(0, 100 - Ground);
            Mountain = 100 - Water - Ground;
        }

        private ILand[,] _innerMap;

        public ILand[,] GetMap()
        {
            if (_innerMap == null)
            {
                _innerMap = new ILand[Height,Width];

                for (int i = 0; i < Height; i++)
                    for (int j = 0; j < Width; j++)
                    {
                        int res = Generator.Generator.GenerateRandomValue(1, 99);

                        switch (res % 3)
                        {
                            case 0:
                                _innerMap[i, j] = new Ground();
                                break;
                            case 1:
                                _innerMap[i, j] = new Water();
                                break;
                            case 2:
                                _innerMap[i, j] = new Mountain();
                                break;
                        }
                    }
            }
            return _innerMap;
        }
    }
}
