﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 Forun = new Form4();

            this.Hide();

            Forun.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 Forum = new Form3();

            this.Hide();

            Forum.Show();
        }
    }
}