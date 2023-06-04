using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Memory_matching_game
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Easy = new Form2();
            Easy.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameWindow Hard = new GameWindow();
            Hard.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Medium = new Form3();
            Medium.Show();
        }
    }
}
