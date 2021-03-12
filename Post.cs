using System;
using System.Windows.Forms;

namespace myMilkProject
{
    public partial class Post : Form
    {
        public Post()
        {
            InitializeComponent();
        }

        private void Post_Load(object sender, EventArgs e)
        {
            this.постTableAdapter.Fill(this.milkdatabaseDataSet.пост);
        }

        private void Post_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.main.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                постTableAdapter.Update(milkdatabaseDataSet.пост);
                MessageBox.Show("Изменения сохранены");
                this.постTableAdapter.Fill(this.milkdatabaseDataSet.пост);
            }
            catch (Exception ex) { MessageBox.Show("Ошибка при сохранении данных.\n"+ex.Message); }
        }
    }
}
