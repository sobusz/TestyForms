using MathModules;
using System;
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

                var calc = new CalculatePithagoras();

                double sideC = calc.calcSideC(sideA, sideB);
                labelSideC.Text = sideC.ToString();

                double calcCirc = calc.calcCirc(sideA, sideB);
                labelCirc.Text = calcCirc.ToString();

                double calcArea = calc.calcArea(sideA, sideB);
                labelArea.Text = calcArea.ToString();

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

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
