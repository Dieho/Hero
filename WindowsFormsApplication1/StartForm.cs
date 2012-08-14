using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.Batle;
using WindowsFormsApplication1.Calculator;
using WindowsFormsApplication1.Effects;
using WindowsFormsApplication1.MonsterType;
using WindowsFormsApplication1.Skills;
using WindowsFormsApplication1.Skills.BattleSkill;

namespace WindowsFormsApplication1
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
        private LandType.WorldMap _world;

        private ILive _hero1, _hero2;


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void Button4Click(object sender, EventArgs e)
        {
            var w = new Warrior().Build(Experience: 99, bskill: new BleedingSting());
            NewFight(w);
        }

        private void Button5Click(object sender, EventArgs e)
        {
            var dd = new DD().Build();
            NewFight(dd);
        }

        private void Button6Click(object sender, EventArgs e)
        {
            var wi = new Wizard().Build();
            NewFight(wi);
        }

        public void NewFight(ILive hero)
        {
            if (_hero1 == null || _hero1.HPCurent == 0)
            {
                richTextBox1.Clear();
                _hero1 = hero;
                richTextBox1.Text = "Welcome " + _hero1.Name + "!";
                button8.Enabled = true;
            }
            else
            {
                _hero2 = hero;
                richTextBox1.Text += "\nWelcome " + _hero2.Name + "!\n";
                button1.Enabled = true;
            }
        }

        private void Button1Click(object sender, EventArgs e)
        {

            var f = new Fight();
            string result = f.Kick(_hero1, _hero2);
            richTextBox1.Text = richTextBox1.Text + _hero1.Name + " - " + _hero1.HPCurent.ToString() + " - " + _hero2.Name + " " + _hero2.HPCurent.ToString() + "\n" + result + " \n";
            if (_hero1.HPCurent == 0)
            {
                _hero1 = null;

                button1.Enabled = false;
                button8.Enabled = false;
            }
            if (_hero2.HPCurent == 0)
            {
                _hero2 = null;
                var asd = new BatleCalculates();
                asd.LvlUp(_hero1);
                button1.Enabled = false;
            }
            if (_hero1 != null)
            {
                if (_hero1.skillInUse.Count == 0)
                {
                    button9.Enabled = true;
                }
                else
                {
                    foreach (var i in _hero1.skillInUse)
                    {
                        if (i.Name == "BleedingSting")
                        {
                            if (i.IsCooled)
                                button9.Enabled = true;
                        }
                    }
                }
            }

        }


        private void Button2Click(object sender, EventArgs e)
        {
            GenerateWorld();
        }

        public void GenerateWorld()
        {
            _world = new LandType.WorldMap(Convert.ToInt32(tbColumns.Text), Convert.ToInt32(tbLines.Text));
            var map = _world.Map;

            var sb = new StringBuilder("Карта (Суша-Вода-Горы)\n");

            for (int i = 0; i < _world.HeightCount; i++)
            {
                for (int j = 0; j < _world.WidthCount; j++)
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
        }


        private void Button3Click(object sender, EventArgs e)
        {
            LandType.ILand[,] part = _world.GetWorldMapPart(Convert.ToInt32(comboBox1.SelectedValue),
                                                           Convert.ToInt32(comboBox2.SelectedValue));

            var sb = new StringBuilder(string.Format("Участок[{0}][{1}]:\n", Convert.ToInt32(comboBox1.Text),
                                                                             Convert.ToInt32(comboBox2.Text)));
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (_hero1.mapPosition.X == i && _hero1.mapPosition.Y == j)
                    {
                        sb.Append(string.Format("{0}\t", 1));
                    }
                    else
                    {
                        sb.Append(string.Format("{0}\t", part[i, j]));
                    }
                }
                sb.Append("\n");
            }

            richTextBox1.Text += sb.ToString();
        }

        private void Button7Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "Exp - " + _hero1.experience.ToString() + "Lvl - " + _hero1.Lvl.ToString() + "\n";
        }

        private void Button8Click(object sender, EventArgs e)
        {
            _hero1.HPCurent = _hero1.HP;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Skill i in _hero1.battleSkills)
            {
                if (i.Name == "BleedingSting")
                {
                    var f = new Fight();
                    string result = f.Kick(_hero1, _hero2, i as IBattleSkill);
                    richTextBox1.Text = richTextBox1.Text + _hero1.Name + " - " + _hero1.HPCurent.ToString() + " - " +
                                        _hero2.Name + " " + _hero2.HPCurent.ToString() + "\n" + result + " \n";
                    if (_hero1.HPCurent == 0)
                    {
                        _hero1 = null;

                        button1.Enabled = false;
                        button8.Enabled = false;
                    }
                    if (_hero2.HPCurent == 0)
                    {
                        _hero2 = null;
                        var asd = new BatleCalculates();
                        asd.LvlUp(_hero1);
                        button1.Enabled = false;
                    }

                    button9.Enabled = false;
                }
                else
                {
                    MessageBox.Show("You have not this skill!");
                }
            }

        }
    }
}
