using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    class HeroBuilder
    {
        public struct Stat
        {
            public static int HP;
            public static int MP;
            public static int Damage;
            public static int Def;
        }


        public static Stat Builder(int type)
        {
            switch (type)
            {
                case 1:
                    Stat.HP = 10;
                    Stat.MP = 4;
                    Stat.Damage = 5;
                    Stat.Def = 7;
                    break;
                case 2:
                    Stat.HP = 7;
                    Stat.MP = 6;
                    Stat.Damage = 9;
                    Stat.Def = 4;
                    break;
                case 3:
                    Stat.HP = 5;
                    Stat.MP = 10;
                    Stat.Damage = 12;
                    Stat.Def = 3;
                    break;
            }
            return new Stat();
        }

        public Stat Builder(int HP,int MP,int Damage,int Def)
        {

                    Stat.HP = HP;
                    Stat.MP = MP;
                    Stat.Damage = Damage;
                    Stat.Def = Def;

            return new Stat();
        }

        public static Stat MonsterBuilder(int type)
        {
            switch (type)
            {
                case 1:
                    Stat.HP = 3;
                    Stat.MP = 0;
                    Stat.Damage = 1;
                    Stat.Def = 2;
                    break;
                case 2:
                    Stat.HP = 4;
                    Stat.MP = 2;
                    Stat.Damage = 3;
                    Stat.Def = 3;
                    break;
                case 3:
                    Stat.HP = 6;
                    Stat.MP = 3;
                    Stat.Damage = 4;
                    Stat.Def = 4;
                    break;
            }
            return new Stat();
        }
    }
}
