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

        private ILive Warrior,DD,Wizard;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Персонажи создаютсья на прямую. Следует создать клас дляя каждого вида героя
            Generate();
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            Fight f=new Fight();
            f.Kick(Warrior, DD);
            richTextBox1.Text = richTextBox1.Text + " \n" + Warrior.Name + " - " + Warrior.HP.ToString() + " - " + DD.Name + " " + DD.HP.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fight f = new Fight();
            f.Kick(Warrior, Wizard);
            richTextBox1.Text = richTextBox1.Text + " \n" + Warrior.Name + " - " + Warrior.HP.ToString() + " - " + Wizard.Name + " " + Wizard.HP.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fight f = new Fight();
            f.Kick(DD, Wizard);
            richTextBox1.Text = richTextBox1.Text + " \n" + DD.Name + " - " + DD.HP.ToString() + " - " + Wizard.Name + " " + Wizard.HP.ToString();
        }

        public void GenerateWorld()
        {
            //var asd = new Generator.Generator().MonsterGenerator(1);
           // var asd = new Monster().SetMonster("asd", HeroBuilder.MonsterBuilder(1), "zxc");
           // Live.Add("Monster", asd.Stat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generate();
            richTextBox1.Clear();
        }

        public void Generate()
        {
            Warrior = new Hero().SetDefender();
            DD = new Hero().SetDD();
            Wizard = new Hero().SetWizard();
        }
    }
}
