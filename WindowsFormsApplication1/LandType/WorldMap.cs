using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.LandType
{
    /// <summary>
    /// Strategic map of the world
    /// </summary>
    public class WorldMap
    {
        private readonly MapPart[,] _map;
        public int WidthCount { get; private set; }
        public int HeightCount { get; private set; }

        public MapPart[,] Map { get { return _map; } }

        public ILand[,] GetWorldMapPart(int line, int column)
        {
            return _map[line, column].GetMap();
        }


        public WorldMap(int mapWidth, int mapHeight)
        {
            _map = new MapPart[mapWidth, mapHeight];
            WidthCount = mapWidth;
            HeightCount = mapHeight;
            GenerateWorld();
        }

        private void GenerateWorld()
        {
            for (int i = 0; i < WidthCount; i++)
                for (int j = 0; j < HeightCount; j++)
                    _map[i, j] = new MapPart();
        }
    }
}
