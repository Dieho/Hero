using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Batle;
using WindowsFormsApplication1.MonsterType;

namespace WindowsFormsApplication1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        Dictionary<string ,HeroBuilder.Stat> Live=new Dictionary<string, HeroBuilder.Stat>();
        //private List<HeroBuilder.Stat> Live=new List<HeroBuilder.Stat>();
        //private HeroBuilder.Stat _hero;
        private ILive hero,hero2;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Live.Add(HeroBuilder.Builder(1));
            Live.Add("UserName", HeroBuilder.Builder(1));
            hero = new HeroDefender().SetHero("Вася", 10,4,5,7, "Герой");
            hero2 = new HeroDefender().SetHero("asdasd", 7,6,9,4, "Герой");
            panel1.Visible = false;
            panel2.Visible = true;
            //GenerateWorld();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Live.Add("UserName", HeroBuilder.Builder(2));
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Live.Add("UserName", HeroBuilder.Builder(3));
            panel1.Visible = false;
            panel2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Fight f=new Fight();
            f.Kick(hero, hero2, 5);
            richTextBox1.Text = hero.HP.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        public void GenerateWorld()
        {
            //var asd = new Generator.Generator().MonsterGenerator(1);
           // var asd = new Monster().SetMonster("asd", HeroBuilder.MonsterBuilder(1), "zxc");
           // Live.Add("Monster", asd.Stat);
        }
    }
}
