using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private HeroBuilder.Stat hero;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hero=HeroBuilder.Builder(1);
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hero=HeroBuilder.Builder(2);
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hero=HeroBuilder.Builder(3);
            panel1.Visible = false;
        }
    }
}
