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

        private ILive Warrior, DD, Wizard;
        private LandType.WorldMap world;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Персонажи создаютсья на прямую. Следует создать клас дляя каждого вида героя
            Generate();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Fight f = new Fight();
            string result;
            result = f.Kick(Warrior, DD);
            richTextBox1.Text = richTextBox1.Text + " \n" + Warrior.Name + " - " + Warrior.HP.ToString() + " - " + DD.Name + " " + DD.HP.ToString() + "\n" + result;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Fight f = new Fight();
            string result;
            result = f.Kick(Warrior, Wizard);
            richTextBox1.Text = richTextBox1.Text + " \n" + Warrior.Name + " - " + Warrior.HP.ToString() + " - " + Wizard.Name + " " + Wizard.HP.ToString() + "\n" + result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Fight f = new Fight();
            string result;
            result = f.Kick(DD, Wizard);
            richTextBox1.Text = richTextBox1.Text + " \n" + DD.Name + " - " + DD.HP.ToString() + " - " + Wizard.Name + " " + Wizard.HP.ToString() + "\n" + result;
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
