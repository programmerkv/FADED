using System;
using System.Windows.Forms;

namespace FractionLearningProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void calculateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var calculateLearning = new CalculateLearning();
            calculateLearning.Show();
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var compareLearning = new CompareLearning();
            compareLearning.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void calculateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var calculateExercise = new CalculateExercise();
            calculateExercise.Show();
        }

        private void compareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var compareExercises = new CompareExercises();
            compareExercises.Show();
        }
    }
}