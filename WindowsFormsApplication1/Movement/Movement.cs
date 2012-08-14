using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1.Movement
{
    public class Movement
    {
        public void MoveToRight(ILive hero, bool[,] arrea)
        {
            if (hero.mapPosition.X < Math.Sqrt(arrea.Length))
                hero.mapPosition = new Point(hero.mapPosition.X + 1, hero.mapPosition.Y);
        }
        public void MoveToLeft(ILive hero, bool[,] arrea)
        {
            if (hero.mapPosition.X > Math.Sqrt(arrea.Length))
                hero.mapPosition = new Point(hero.mapPosition.X - 1, hero.mapPosition.Y);
        }
        public void MoveUp(ILive hero, bool[,] arrea)
        {
            if (hero.mapPosition.Y < Math.Sqrt(arrea.Length))
                hero.mapPosition = new Point(hero.mapPosition.X, hero.mapPosition.Y+1);
        }
        public void MoveDown(ILive hero, bool[,] arrea)
        {
            if (hero.mapPosition.Y > Math.Sqrt(arrea.Length))
                hero.mapPosition = new Point(hero.mapPosition.X, hero.mapPosition.Y-1);
        }
    }
}
