using System;
using System.Windows.Forms;

namespace FractionLearningProgram
{
    public partial class CalculateExercise : Form
    {
        public CalculateExercise()
        {
            InitializeComponent();
            GenerateFraction();
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "+";
        }

        private void radSub_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "-";
        }

        private void radMult_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "×";
        }

        private void radDiv_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "÷";
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

        private double FractionDivision()
        {
            var resultNum =
                Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtDen2.Text);
            var resultDen = Convert.ToInt32(txtDen1.Text) * Convert.ToInt32(txtNum2.Text);

            return Convert.ToDouble(resultNum) / resultDen;
        }

        private double FractionMultiplication()
        {
            var resultNum =
                Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtNum2.Text);
            var resultDen = Convert.ToInt32(txtDen1.Text) * Convert.ToInt32(txtDen2.Text);

            return Convert.ToDouble(resultNum) / resultDen;
        }

        private double FractionSubtraction()
        {
            var resultNum =
                Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtDen2.Text)
                - Convert.ToInt32(txtNum2.Text) * Convert.ToInt32(txtDen1.Text);
            var resultDen = Convert.ToInt32(txtDen1.Text) * Convert.ToInt32(txtDen2.Text);

            return Convert.ToDouble(resultNum) / resultDen;
        }

        private double FractionAddition()
        {
            var resultNum =
                Convert.ToInt32(txtNum1.Text) * Convert.ToInt32(txtDen2.Text)
                + Convert.ToInt32(txtNum2.Text) * Convert.ToInt32(txtDen1.Text);
            var resultDen = Convert.ToInt32(txtDen1.Text) * Convert.ToInt32(txtDen2.Text);

            return Convert.ToDouble(resultNum) / resultDen;
        }

        private void txtNum3_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtDen3_TextChanged(object sender, EventArgs e)
        {
            if (txtDen3.Text == "0")
                MessageBox.Show("ERROR: Can not divide by zero");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            var result = Convert.ToDouble(txtNum3.Text) / Convert.ToDouble(txtDen3.Text);
            bool message;

            if (radAdd.Checked)
                message = result == FractionAddition();
            else if (radSub.Checked)
                message = result == FractionSubtraction();
            else if (radMult.Checked)
                message = result == FractionMultiplication();
            else
                message = result == FractionDivision();

            if (message) MessageBox.Show("You are right!");
            else MessageBox.Show("You are wrong");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}