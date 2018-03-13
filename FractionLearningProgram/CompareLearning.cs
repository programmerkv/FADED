using System;
using System.Windows.Forms;

namespace FractionLearningProgram
{
    public partial class CompareLearning : Form
    {
        public CompareLearning()
        {
            InitializeComponent();
            GenerateFraction();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GenerateFraction()
        {
            var random = new Random();
            txtNum1.Text = random.Next(0, 9).ToString();
            txtDen1.Text = random.Next(1, 9).ToString();
            txtNum2.Text = random.Next(0, 9).ToString();
            txtDen2.Text = random.Next(1, 9).ToString();

            var value1 = Convert.ToDouble(txtNum1.Text) / Convert.ToDouble(txtDen1.Text);
            var value2 = Convert.ToDouble(txtNum2.Text) / Convert.ToDouble(txtDen2.Text);

            if (value1 > value2) lblSign.Text = ">";
            else if (value1 < value2) lblSign.Text = "<";
            else lblSign.Text = "=";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            GenerateFraction();
        }
    }
}