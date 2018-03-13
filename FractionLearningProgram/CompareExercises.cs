using System;
using System.Windows.Forms;

namespace FractionLearningProgram
{
    public partial class CompareExercises : Form
    {
        public CompareExercises()
        {
            InitializeComponent();
            GenerateFraction();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GenerateFraction();
        }

        private void GenerateFraction()
        {
            var random = new Random();
            txtNum1.Text = random.Next(0, 9).ToString();
            txtDen1.Text = random.Next(1, 9).ToString();
            txtNum2.Text = random.Next(0, 9).ToString();
            txtDen2.Text = random.Next(1, 9).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var result1 = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtDen1.Text);
            var result2 = Convert.ToDouble(txtNum2.Text) / Convert.ToDouble(txtDen2.Text);

            if (txtSign.Text == ">")
            {
                if (result1 > result2) MessageBox.Show("You are right!");
                else MessageBox.Show("You are wrong!");
            }
            else if (txtSign.Text == "<")
            {
                if (result1 < result2) MessageBox.Show("You are right!");
                else MessageBox.Show("You are wrong!");
            }
            else
            {
                if (result1 == result2) MessageBox.Show("You are right!");
                else MessageBox.Show("You are wrong!");
            }
        }

        private void txtSign_TextChanged(object sender, EventArgs e)
        {
            if (txtSign.Text != "" && txtSign.Text != ">" && txtSign.Text != "<" && txtSign.Text != "=")
                MessageBox.Show("ERROR: Not a legal sign");
        }
    }
}