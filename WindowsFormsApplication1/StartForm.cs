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
        private LandType.WorldMap world;

        private ILive hero1, hero2;


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button4_Click(object sender, EventArgs e)
        {

            if (hero1 == null || hero1.HP == 0)
            {
                richTextBox1.Clear();
                hero1 = new Hero().SetDefender();
                richTextBox1.Text = "Welcome Warrior!";
            }
            else
            {
                hero2 = new Hero().SetDefender();
                richTextBox1.Text += "\nWelcome Warrior!\n";
                button1.Enabled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (hero1 == null || hero1.HP == 0)
            {
                richTextBox1.Clear();
                hero1 = new Hero().SetWizard();
                richTextBox1.Text = "Welcome Wizard!";
            }
            else
            {
                hero2 = new Hero().SetWizard();
                richTextBox1.Text += "\nWelcome Wizard!\n";
                button1.Enabled = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            if (hero1 == null || hero1.HP == 0)
            {
                richTextBox1.Clear();
                hero1 = new Hero().SetDD();
                richTextBox1.Text = "Welcome DD!";
            }
            else
            {
                hero2 = new Hero().SetDD();
                richTextBox1.Text += "\nWelcome DD!\n";
                button1.Enabled = true;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

            Fight f = new Fight();
            string result;
            result = f.Kick(hero1, hero2);
            richTextBox1.Text = richTextBox1.Text + hero1.Name + " - " + hero1.HP.ToString() + " - " + hero2.Name + " " + hero2.HP.ToString() + "\n" + result + " \n";
            if (hero1.HP == 0 || hero2.HP == 0)
            {
                hero1 = null;
                hero2 = null;
                button1.Enabled = false;
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            GenerateWorld();
        }

        public void GenerateWorld()
        {
            world = new LandType.WorldMap(Convert.ToInt32(tbColumns.Text), Convert.ToInt32(tbLines.Text));
            var map = world.Map;

            var sb = new StringBuilder("Карта (Суша-Вода-Горы)\n");

            for (int i = 0; i < world.HeightCount; i++)
            {
                for (int j = 0; j < world.WidthCount; j++)
                {
                    sb.Append(string.Format("{0}-{1}-{2}\t", map[i, j].Ground, map[i, j].Water, map[i, j].Mountain));
                }
                sb.Append("\n");
            }

            richTextBox1.Text += sb.ToString();

            comboBox1.DataSource = Enumerable.Range(0, Convert.ToInt32(tbColumns.Text)).ToList();
            comboBox2.DataSource = Enumerable.Range(0, Convert.ToInt32(tbLines.Text)).ToList();

            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            button3.Enabled = true;



            //var asd = new Generator.Generator().MonsterGenerator(1);
            // var asd = new Monster().SetMonster("asd", HeroBuilder.MonsterBuilder(1), "zxc");
            // Live.Add("Monster", asd.Stat);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            LandType.ILand[,] part = world.GetWorldMapPart(Convert.ToInt32(comboBox1.SelectedValue),
                                                           Convert.ToInt32(comboBox2.SelectedValue));

            var sb = new StringBuilder(string.Format("Участок[{0}][{1}]:\n", Convert.ToInt32(comboBox1.Text),
                                                                             Convert.ToInt32(comboBox2.Text)));
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sb.Append(string.Format("{0}\t",part[i, j]));
                }
                sb.Append("\n");
            }

            richTextBox1.Text += sb.ToString();
        }
    }
}
