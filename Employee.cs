using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myMilkProject
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "milkdatabaseDataSet.сотрудник". При необходимости она может быть перемещена или удалена.
            this.сотрудникTableAdapter.Fill(this.milkdatabaseDataSet.сотрудник);

        }

        private void Employee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.main.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                сотрудникTableAdapter.Update(milkdatabaseDataSet.сотрудник);
                MessageBox.Show("Изменения сохранены");
                this.сотрудникTableAdapter.Fill(this.milkdatabaseDataSet.сотрудник);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при сохранении данных.\n" + ex.Message); }
        }
    }
}
