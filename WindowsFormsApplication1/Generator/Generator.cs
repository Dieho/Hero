using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1.Generator
{
    internal class Generator : WorldGenerator
    {
        public int[,] MonsterPosition
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public int[,] Land
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public WorldGenerator MonsterGenerator(int type)
        {
            throw new NotImplementedException();
        }

        public WorldGenerator GroundGenerator(int size)
        {
            throw new NotImplementedException();
        }

        public static int GenerateRandomValue(int min, int max)
        {
            var random = new Random(BitConverter.ToInt32(Guid.NewGuid().ToByteArray(), 0));
            return random.Next(min, max);
        }
}

}
