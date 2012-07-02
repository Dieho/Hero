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
        private ILive hero,hero2,hero3;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Live.Add(HeroBuilder.Builder(1));
            Live.Add("UserName", HeroBuilder.Builder(1));
            hero = new HeroDefender().SetHero("Warrior", 10, 4, 5, 7, "Defender");
            hero2 = new HeroDefender().SetHero("DD", 7, 6, 10, 4, "DD");
            hero3 = new HeroDefender().SetHero("Wizard", 5, 10, 24, 3, "Wizard");
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
            f.Kick(hero, hero2);
            richTextBox1.Text =richTextBox1.Text+" \n"+hero.Name+" - "+ hero.HP.ToString()+" - "+hero2.Name+" "+hero2.HP.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fight f = new Fight();
            f.Kick(hero, hero3);
            richTextBox1.Text = richTextBox1.Text + " \n" + hero.Name + " - " + hero.HP.ToString() + " - " + hero3.Name + " " + hero3.HP.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fight f = new Fight();
            f.Kick(hero2, hero3);
            richTextBox1.Text = richTextBox1.Text + " \n" + hero2.Name + " - " + hero2.HP.ToString() + " - " + hero3.Name + " " + hero3.HP.ToString();
        }

        public void GenerateWorld()
        {
            //var asd = new Generator.Generator().MonsterGenerator(1);
           // var asd = new Monster().SetMonster("asd", HeroBuilder.MonsterBuilder(1), "zxc");
           // Live.Add("Monster", asd.Stat);
        }
    }
}
