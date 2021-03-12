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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "milkdatabaseDataSet.пост". При необходимости она может быть перемещена или удалена.
            this.постTableAdapter.Fill(this.milkdatabaseDataSet.пост);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "milkdatabaseDataSet.молоковоз". При необходимости она может быть перемещена или удалена.
            this.молоковозTableAdapter.Fill(this.milkdatabaseDataSet.молоковоз);
            this.приездTableAdapter.Fill(this.milkdatabaseDataSet.приезд);
        }

        private void молоковозыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MilkTanker().Show();
            this.Hide();
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

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                приездTableAdapter.Update(milkdatabaseDataSet.приезд);
                MessageBox.Show("Изменения сохранены");
                this.приездTableAdapter.Fill(this.milkdatabaseDataSet.приезд);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при сохранении данных.\n" + ex.Message); }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
