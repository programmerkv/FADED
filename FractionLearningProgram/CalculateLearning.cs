using System;
using System.Windows.Forms;

namespace FractionLearningProgram
{
    public partial class CalculateLearning : Form
    {
        public CalculateLearning()
        {
            InitializeComponent();
            GenerateFraction();
        }

        private void radAdd_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "+";
            CalculateFractions();
        }

        private void radSub_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "-";
            CalculateFractions();
        }

        private void radMult_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "×";
            CalculateFractions();
        }

        private void radDiv_CheckedChanged(object sender, EventArgs e)
        {
            lblOperator.Text = "÷";
            CalculateFractions();
        }

        private void GenerateFraction()
        {
            var random = new Random();
            txtNum1.Text = random.Next(0, 9).ToString();
            txtDen1.Text = random.Next(1, 9).ToString();
            txtNum2.Text = random.Next(0, 9).ToString();
            txtDen2.Text = random.Next(1, 9).ToString();

            CalculateFractions();
        }

        private void CalculateFractions()
        {
            if (radAdd.Checked)
                FractionAddition();
            else if (radSub.Checked)
                FractionSubtraction();
            else if (radMult.Checked)
                FractionMultiplication();
            else
                FractionDivision();
        }

        private void FractionDivision()
        {
            int num1, den1, num2, den2;
            ConvertFraction(out num1, out den1, out num2, out den2);

            var resultNum = num1 * den2;
            var resultDen = den1 * num2;

            Simplify(den1, den2, resultNum, resultDen);
        }

        private void FractionMultiplication()
        {
            int num1, den1, num2, den2;
            ConvertFraction(out num1, out den1, out num2, out den2);

            var resultNum = num1 * num2;
            var resultDen = den1 * den2;

            Simplify(den1, den2, resultNum, resultDen);
        }

        private void FractionSubtraction()
        {
            int num1, den1, num2, den2;
            ConvertFraction(out num1, out den1, out num2, out den2);

            var resultNum = num1 * den2 - num2 * den1;
            var resultDen = den1 * den2;

            Simplify(den1, den2, resultNum, resultDen);
        }

        private void FractionAddition()
        {
            int num1, den1, num2, den2;
            ConvertFraction(out num1, out den1, out num2, out den2);

            var resultNum = num1 * den2 + num2 * den1;
            var resultDen = den1 * den2;

            Simplify(den1, den2, resultNum, resultDen);
        }

        private void ConvertFraction(out int num1, out int den1, out int num2, out int den2)
        {
            num1 = Convert.ToInt32(txtNum1.Text);
            den1 = Convert.ToInt32(txtDen1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            den2 = Convert.ToInt32(txtDen2.Text);
        }

        private void Simplify(int den1, int den2, int resultNum, int resultDen)
        {
            if (resultNum % GCD(den1, den2) == 0)
            {
                txtNum3.Text = (resultNum / GCD(resultNum, resultDen)).ToString();
                txtDen3.Text = (resultDen / GCD(resultNum, resultDen)).ToString();
            }
            else
            {
                txtNum3.Text = resultNum.ToString();
                txtDen3.Text = resultDen.ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GenerateFraction();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public int GCD(int p, int q)
        {
            if (q == 0) return p;
            var r = p % q;

            return GCD(q, r);
        }
    }
}