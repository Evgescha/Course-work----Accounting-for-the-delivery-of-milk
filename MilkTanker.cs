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
    public partial class MilkTanker : Form
    {
        public MilkTanker()
        {
            InitializeComponent();
        }

        private void MilkTanker_Load(object sender, EventArgs e)
        {
            this.молоковозTableAdapter.Fill(this.milkdatabaseDataSet.молоковоз);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                молоковозTableAdapter.Update(milkdatabaseDataSet.молоковоз);
                MessageBox.Show("Изменения сохранены");
                this.молоковозTableAdapter.Fill(this.milkdatabaseDataSet.молоковоз);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при сохранении данных.\n" + ex.Message); }
        }

        private void MilkTanker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.main.Show();
        }
    }
}
