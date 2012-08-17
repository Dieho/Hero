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
        private readonly int _width;
        private readonly int _height;

        public int Water { get; set; }
        public int Mountain { get; set; }
        public int Ground { get; set; }
        public String RegionName { get; set; }

        public int Width { get { return _width; } }
        public int Height { get { return _height; } }

        public MapRegion(int width, int height)
        {
            _width = width;
            _height = height;
        }

        private ILand[,] _innerMap;
        
        private void GetDefaultMapFill()
        {
            if (_innerMap == null)
            {
                _innerMap = new ILand[_height, _width];

                for (int i = 0; i < _height; i++)
                    for (int j = 0; j < _width; j++)
                    {
                        _innerMap[i, j] = new Water();
                    }
            }
        }

        private ILand[,] CreateNewLayout(String landType, String baseLandType, int landSquare)
        {
            //int groundSquare = Generator.Generator.GenerateRandomValue(40, _width * _height - 1);
            const int groundC = 10;
            var map = new String [groundC];
            if (_innerMap != null)
            {
                for (int i = 0; i < groundC; i++)
                {
                    int positionX = Generator.Generator.GenerateRandomValue(0, _width);
                    int positionY = Generator.Generator.GenerateRandomValue(0, _height);

                    if(_innerMap[positionX, positionY].ToString() == baseLandType)
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
            _innerMap = SmartLayout(_innerMap, map, landType, landSquare);

            return _innerMap;
        }

        private ILand[,] SmartLayout(ILand[,] innerMap, String[] map, String landType, int landSquare)
        {
            for (int i = 0; i < landSquare; i++)
            {
                int position = Generator.Generator.GenerateRandomValue(0, map.Length);
                string [] sep = map[position].Split(new Char[] { ';' }); 
                int positionX = int.Parse(sep[0]);
                int positionY = int.Parse(sep[1]);
             
                switch (position % 4)
                {
                    case 0:
                        if (positionX != 0)
                            positionX -= 1;
                        break;
                    case 1:
                        if (positionX != (_width - 1))
                            positionX += 1;
                        break;
                    case 2:
                        if (positionY != 0)
                            positionY -= 1;
                        break;
                    case 3:
                        if (positionY != (_height - 1))
                            positionY += 1;
                        break;
                }

                if (innerMap[positionX, positionY].ToString() == landType)
                    continue;
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
            string baseLandType = "Water";
            var innerMap = CreateNewLayout(ground, baseLandType, Ground);
            baseLandType = "Ground";
            const string moundtain = "Mountain";
            CreateNewLayout(moundtain, baseLandType, Mountain);

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
