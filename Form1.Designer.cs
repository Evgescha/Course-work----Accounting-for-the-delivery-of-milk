
namespace myMilkProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.молоковозыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.milkdatabaseDataSet = new myMilkProject.milkdatabaseDataSet();
            this.приездBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.приездTableAdapter = new myMilkProject.milkdatabaseDataSetTableAdapters.приездTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.молоковозDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.постDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаПриездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПриездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началиМытьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закончилиМытьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяВыездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.milkdatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приездBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.молоковозыToolStripMenuItem,
            this.сотрудникиToolStripMenuItem,
            this.постыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // молоковозыToolStripMenuItem
            // 
            this.молоковозыToolStripMenuItem.Name = "молоковозыToolStripMenuItem";
            this.молоковозыToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.молоковозыToolStripMenuItem.Text = "Молоковозы";
            this.молоковозыToolStripMenuItem.Click += new System.EventHandler(this.молоковозыToolStripMenuItem_Click);
            // 
            // сотрудникиToolStripMenuItem
            // 
            this.сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            this.сотрудникиToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.сотрудникиToolStripMenuItem.Text = "Сотрудники";
            this.сотрудникиToolStripMenuItem.Click += new System.EventHandler(this.сотрудникиToolStripMenuItem_Click);
            // 
            // постыToolStripMenuItem
            // 
            this.постыToolStripMenuItem.Name = "постыToolStripMenuItem";
            this.постыToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.постыToolStripMenuItem.Text = "Посты";
            this.постыToolStripMenuItem.Click += new System.EventHandler(this.постыToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.молоковозDataGridViewTextBoxColumn,
            this.постDataGridViewTextBoxColumn,
            this.датаПриездаDataGridViewTextBoxColumn,
            this.времяПриездаDataGridViewTextBoxColumn,
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn,
            this.началиМытьDataGridViewTextBoxColumn,
            this.закончилиМытьDataGridViewTextBoxColumn,
            this.времяВыездаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.приездBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1031, 217);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(12, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(173, 279);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(334, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1043, 242);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приезды молоковозов";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button4.Location = new System.Drawing.Point(495, 279);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(302, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Показать кто обслуживал";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // milkdatabaseDataSet
            // 
            this.milkdatabaseDataSet.DataSetName = "milkdatabaseDataSet";
            this.milkdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // приездBindingSource
            // 
            this.приездBindingSource.DataMember = "приезд";
            this.приездBindingSource.DataSource = this.milkdatabaseDataSet;
            // 
            // приездTableAdapter
            // 
            this.приездTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.ReadOnly = true;
            this.кодDataGridViewTextBoxColumn.Visible = false;
            // 
            // молоковозDataGridViewTextBoxColumn
            // 
            this.молоковозDataGridViewTextBoxColumn.DataPropertyName = "Молоковоз";
            this.молоковозDataGridViewTextBoxColumn.HeaderText = "Молоковоз";
            this.молоковозDataGridViewTextBoxColumn.Name = "молоковозDataGridViewTextBoxColumn";
            this.молоковозDataGridViewTextBoxColumn.ReadOnly = true;
            this.молоковозDataGridViewTextBoxColumn.Width = 89;
            // 
            // постDataGridViewTextBoxColumn
            // 
            this.постDataGridViewTextBoxColumn.DataPropertyName = "Пост";
            this.постDataGridViewTextBoxColumn.HeaderText = "Пост";
            this.постDataGridViewTextBoxColumn.Name = "постDataGridViewTextBoxColumn";
            this.постDataGridViewTextBoxColumn.ReadOnly = true;
            this.постDataGridViewTextBoxColumn.Width = 57;
            // 
            // датаПриездаDataGridViewTextBoxColumn
            // 
            this.датаПриездаDataGridViewTextBoxColumn.DataPropertyName = "Дата приезда";
            this.датаПриездаDataGridViewTextBoxColumn.HeaderText = "Дата приезда";
            this.датаПриездаDataGridViewTextBoxColumn.Name = "датаПриездаDataGridViewTextBoxColumn";
            this.датаПриездаDataGridViewTextBoxColumn.ReadOnly = true;
            this.датаПриездаDataGridViewTextBoxColumn.Width = 95;
            // 
            // времяПриездаDataGridViewTextBoxColumn
            // 
            this.времяПриездаDataGridViewTextBoxColumn.DataPropertyName = "Время приезда";
            this.времяПриездаDataGridViewTextBoxColumn.HeaderText = "Время приезда";
            this.времяПриездаDataGridViewTextBoxColumn.Name = "времяПриездаDataGridViewTextBoxColumn";
            this.времяПриездаDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяПриездаDataGridViewTextBoxColumn.Width = 101;
            // 
            // количествоПривезенногоМолокаЛDataGridViewTextBoxColumn
            // 
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn.DataPropertyName = "Количество привезенного молока, л";
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn.HeaderText = "Количество привезенного молока, л";
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn.Name = "количествоПривезенногоМолокаЛDataGridViewTextBoxColumn";
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn.ReadOnly = true;
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn.Width = 137;
            // 
            // началиМытьDataGridViewTextBoxColumn
            // 
            this.началиМытьDataGridViewTextBoxColumn.DataPropertyName = "Начали мыть";
            this.началиМытьDataGridViewTextBoxColumn.HeaderText = "Начали мыть";
            this.началиМытьDataGridViewTextBoxColumn.Name = "началиМытьDataGridViewTextBoxColumn";
            this.началиМытьDataGridViewTextBoxColumn.ReadOnly = true;
            this.началиМытьDataGridViewTextBoxColumn.Width = 91;
            // 
            // закончилиМытьDataGridViewTextBoxColumn
            // 
            this.закончилиМытьDataGridViewTextBoxColumn.DataPropertyName = "Закончили мыть";
            this.закончилиМытьDataGridViewTextBoxColumn.HeaderText = "Закончили мыть";
            this.закончилиМытьDataGridViewTextBoxColumn.Name = "закончилиМытьDataGridViewTextBoxColumn";
            this.закончилиМытьDataGridViewTextBoxColumn.ReadOnly = true;
            this.закончилиМытьDataGridViewTextBoxColumn.Width = 106;
            // 
            // времяВыездаDataGridViewTextBoxColumn
            // 
            this.времяВыездаDataGridViewTextBoxColumn.DataPropertyName = "Время выезда";
            this.времяВыездаDataGridViewTextBoxColumn.HeaderText = "Время выезда";
            this.времяВыездаDataGridViewTextBoxColumn.Name = "времяВыездаDataGridViewTextBoxColumn";
            this.времяВыездаDataGridViewTextBoxColumn.ReadOnly = true;
            this.времяВыездаDataGridViewTextBoxColumn.Width = 97;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 314);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Приезды";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.milkdatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приездBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem молоковозыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private milkdatabaseDataSet milkdatabaseDataSet;
        private System.Windows.Forms.BindingSource приездBindingSource;
        private milkdatabaseDataSetTableAdapters.приездTableAdapter приездTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn молоковозDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn постDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПриездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПривезенногоМолокаЛDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началиМытьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn закончилиМытьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяВыездаDataGridViewTextBoxColumn;
    }
}

