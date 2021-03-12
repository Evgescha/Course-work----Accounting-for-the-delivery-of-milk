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
            updateTables();
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

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                обслуживаниеTableAdapter.Update(milkdatabaseDataSet.обслуживание);
                MessageBox.Show("Изменения сохранены");
                this.обслуживаниеTableAdapter.Fill(this.milkdatabaseDataSet.обслуживание);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при сохранении данных.\n" + ex.Message); }
        }

        private void обновитьДанныеТаблицToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateTables();
        }
        private void updateTables() {
            this.сотрудникTableAdapter.Fill(this.milkdatabaseDataSet.сотрудник);
            this.обслуживаниеTableAdapter.Fill(this.milkdatabaseDataSet.обслуживание);
            this.постTableAdapter.Fill(this.milkdatabaseDataSet.пост);
            this.молоковозTableAdapter.Fill(this.milkdatabaseDataSet.молоковоз);
            this.приездTableAdapter.Fill(this.milkdatabaseDataSet.приезд);
        }
    }
}
