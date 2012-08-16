using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.LandType
{
    public class MapRegion
    {
        //private String _regionName;
        public int Water { get; set; }
        public int Mountain { get; set; }
        public int Ground { get; set; }
        public String RegionName { get; set; }
        
        public int Width { get { return 10; } }
        public int Height { get { return 10; } }

        public MapRegion()
        {
            Water = 100;            
        }

        private ILand[,] _innerMap;
        
        private void GetDefaultMapFill()
        {
            if (_innerMap == null)
            {
                _innerMap = new ILand[Height, Width];

                for (int i = 0; i < Height; i++)
                    for (int j = 0; j < Width; j++)
                    {
                        _innerMap[i, j] = new Water();
                    }
            }
        }

        private ILand[,] CreateNewLayout(String landType)
        {
            int groundSquare = Generator.Generator.GenerateRandomValue(40, 99);
            const int groundC = 10;
            var map = new String [groundC];
            if (_innerMap != null)
            {
                for (int i = 0; i < groundC; i++)
                {
                    int positionX = Generator.Generator.GenerateRandomValue(0, Width);
                    int positionY = Generator.Generator.GenerateRandomValue(0, Height);
                    switch (landType)
                    {
                        case "Ground":
                            _innerMap[positionX, positionY] = new Ground();
                            break;
                        case "Mountain":
                            _innerMap[positionX, positionY] = new Mountain();
                            break;
                        case "Water":
                            _innerMap[positionX, positionY] = new Water();
                            break;
                    }
                    map[i] = positionX.ToString(CultureInfo.InvariantCulture) + ';' + positionY.ToString(CultureInfo.InvariantCulture);
                }
            }
            _innerMap = SmartLayout(_innerMap, map, groundSquare);

            return _innerMap;
        }

        private ILand[,] SmartLayout(ILand[,] innerMap, String [] map, int groundSquare)
        {
            for (int i = 0; i < groundSquare; i++)
            {
                int position = Generator.Generator.GenerateRandomValue(0, map.Length);
                string [] sep = map[position].Split(new Char[] { ';' }); 
                int positionX = int.Parse(sep[0]);
                int positionY = int.Parse(sep[1]);
                //if (innerMap[positionX, positionY].ToString() == "Ground")
                //    continue;
                switch (position % 4)
                {
                    case 0:
                        if (positionX != 0)
                            positionX -= 1;
                        break;
                    case 1:
                        if (positionX != 9)
                            positionX += 1;
                        break;
                    case 2:
                        if (positionY != 0)
                            positionY -= 1;
                        break;
                    case 3:
                        if (positionY != 9)
                            positionY += 1;
                        break;
                }
                _innerMap[positionX, positionY] = new Ground();
                var buffer = map;
                map = new string[map.Length + 1];
                buffer.CopyTo(map, 0);
                map[map.Length - 1] = positionX.ToString(CultureInfo.InvariantCulture) + ';' + positionY.ToString(CultureInfo.InvariantCulture); 

            }
            return innerMap;
        }

        public ILand [,] GenerateMapRegion()
        {
            
            GetDefaultMapFill();
            const string ground = "Ground";
            var innerMap = CreateNewLayout(ground);
            //const string moundtain = "Mountain";
            //CreateNewLayout(moundtain);

            return innerMap;
        }

        //public ILand[,] GetInnerMap()
        //{
        //    if (_innerMap == null)
        //        throw new Exception("InnerMap is empty! First call GenerateMapRegion method");
        //    return _innerMap;
        //}
    }
}
