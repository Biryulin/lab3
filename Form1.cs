﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._01._25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y, c;
            bool re1 = double.TryParse(textBox1.Text, out x);
            if (re1 == false)
            {
                MessageBox.Show("Ты что не правильный формат");
            }
            bool re2 = double.TryParse(textBox2.Text, out y);
            if (re2 == false)
            {
                MessageBox.Show("Ты что не правильный формат");
            }
            c = 2 * (Math.Sin(x) + Math.Cos(y));
            string otvet = c.ToString();
            label4.Text = otvet;
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
