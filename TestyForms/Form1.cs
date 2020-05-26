﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestyForms
{
    public partial class Form1 : Form
    {
        public double sideA;
        public double sideB;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (sideA != null && sideB != null)
            {
                double result;
                result = Math.Pow(sideA, 2) + Math.Pow(sideB, 2);
                
                textBoxResult.Text = Math.Round(Math.Sqrt(result), 4).ToString();
            }

        }

        private void textBoxSideA_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSideA.Text))
            {
                 sideA = Double.Parse(textBoxSideA.Text);
            }
        }

        private void textBoxSideB_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSideB.Text))
            {
                 sideB = Double.Parse(textBoxSideB.Text);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;
            string number = textBoxNumber.Text;
            string email = textBoxEmail.Text;
            string date = textBoxDate.Text;

            labelName.Text = "imię: " + name;
            labelNumber.Text = "numer : " + number;
            labelEmail.Text = "e-mail: " + email;
            labelDate.Text = "data urodzenia: " + date;
        }
    }
}
