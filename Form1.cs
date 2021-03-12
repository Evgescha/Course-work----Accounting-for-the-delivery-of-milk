using System;
using System.Windows.Forms;

namespace myMilkProject
{
    public partial class Form1 : Form
    {
        public static Form1 main;
        public Form1()
        {
            InitializeComponent();
            main = this;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.приездTableAdapter.Fill(this.milkdatabaseDataSet.приезд);
        }

        private void молоковозыToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Employee().Show();
            this.Hide();
        }

        private void постыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Post().Show();
            this.Hide();
        }
        // добавить
        private void button1_Click(object sender, EventArgs e)
        {

        }
        // изменить
        private void button2_Click(object sender, EventArgs e)
        {

        }
        // удалить
        private void button3_Click(object sender, EventArgs e)
        {

        }
        // показать принимавших сотрудников
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
