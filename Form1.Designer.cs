
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.молоковозыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сотрудникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.постыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.приездBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.milkdatabaseDataSet = new myMilkProject.milkdatabaseDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.приездTableAdapter = new myMilkProject.milkdatabaseDataSetTableAdapters.приездTableAdapter();
            this.молоковозBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.молоковозTableAdapter = new myMilkProject.milkdatabaseDataSetTableAdapters.молоковозTableAdapter();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.постBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.постTableAdapter = new myMilkProject.milkdatabaseDataSetTableAdapters.постTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.молоковозDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.постDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.датаПриездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяПриездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началиМытьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.закончилиМытьDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.времяВыездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.приездBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkdatabaseDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.молоковозBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1205, 24);
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1169, 205);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // приездBindingSource
            // 
            this.приездBindingSource.DataMember = "приезд";
            this.приездBindingSource.DataSource = this.milkdatabaseDataSet;
            // 
            // milkdatabaseDataSet
            // 
            this.milkdatabaseDataSet.DataSetName = "milkdatabaseDataSet";
            this.milkdatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1181, 252);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Приезды молоковозов";
            // 
            // приездTableAdapter
            // 
            this.приездTableAdapter.ClearBeforeFill = true;
            // 
            // молоковозBindingSource
            // 
            this.молоковозBindingSource.DataMember = "молоковоз";
            this.молоковозBindingSource.DataSource = this.milkdatabaseDataSet;
            // 
            // молоковозTableAdapter
            // 
            this.молоковозTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.приездBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1175, 25);
            this.bindingNavigator1.TabIndex = 2;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(133, 22);
            this.toolStripButton1.Text = "Сохранить изменения";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // постBindingSource
            // 
            this.постBindingSource.DataMember = "пост";
            this.постBindingSource.DataSource = this.milkdatabaseDataSet;
            // 
            // постTableAdapter
            // 
            this.постTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            this.кодDataGridViewTextBoxColumn.Visible = false;
            this.кодDataGridViewTextBoxColumn.Width = 51;
            // 
            // молоковозDataGridViewTextBoxColumn
            // 
            this.молоковозDataGridViewTextBoxColumn.DataPropertyName = "Молоковоз";
            this.молоковозDataGridViewTextBoxColumn.DataSource = this.молоковозBindingSource;
            this.молоковозDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.молоковозDataGridViewTextBoxColumn.HeaderText = "Молоковоз";
            this.молоковозDataGridViewTextBoxColumn.Name = "молоковозDataGridViewTextBoxColumn";
            this.молоковозDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.молоковозDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.молоковозDataGridViewTextBoxColumn.ValueMember = "Код";
            this.молоковозDataGridViewTextBoxColumn.Width = 89;
            // 
            // постDataGridViewTextBoxColumn
            // 
            this.постDataGridViewTextBoxColumn.DataPropertyName = "Пост";
            this.постDataGridViewTextBoxColumn.DataSource = this.постBindingSource;
            this.постDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.постDataGridViewTextBoxColumn.HeaderText = "Пост";
            this.постDataGridViewTextBoxColumn.Name = "постDataGridViewTextBoxColumn";
            this.постDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.постDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.постDataGridViewTextBoxColumn.ValueMember = "Код";
            this.постDataGridViewTextBoxColumn.Width = 57;
            // 
            // датаПриездаDataGridViewTextBoxColumn
            // 
            this.датаПриездаDataGridViewTextBoxColumn.DataPropertyName = "Дата приезда";
            this.датаПриездаDataGridViewTextBoxColumn.HeaderText = "Дата приезда";
            this.датаПриездаDataGridViewTextBoxColumn.Name = "датаПриездаDataGridViewTextBoxColumn";
            this.датаПриездаDataGridViewTextBoxColumn.Width = 95;
            // 
            // времяПриездаDataGridViewTextBoxColumn
            // 
            this.времяПриездаDataGridViewTextBoxColumn.DataPropertyName = "Время приезда";
            this.времяПриездаDataGridViewTextBoxColumn.HeaderText = "Время приезда";
            this.времяПриездаDataGridViewTextBoxColumn.Name = "времяПриездаDataGridViewTextBoxColumn";
            this.времяПриездаDataGridViewTextBoxColumn.Width = 101;
            // 
            // количествоПривезенногоМолокаЛDataGridViewTextBoxColumn
            // 
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn.DataPropertyName = "Количество привезенного молока, л";
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn.HeaderText = "Количество привезенного молока, л";
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn.Name = "количествоПривезенногоМолокаЛDataGridViewTextBoxColumn";
            this.количествоПривезенногоМолокаЛDataGridViewTextBoxColumn.Width = 198;
            // 
            // началиМытьDataGridViewTextBoxColumn
            // 
            this.началиМытьDataGridViewTextBoxColumn.DataPropertyName = "Начали мыть";
            this.началиМытьDataGridViewTextBoxColumn.HeaderText = "Начали мыть";
            this.началиМытьDataGridViewTextBoxColumn.Name = "началиМытьDataGridViewTextBoxColumn";
            this.началиМытьDataGridViewTextBoxColumn.Width = 91;
            // 
            // закончилиМытьDataGridViewTextBoxColumn
            // 
            this.закончилиМытьDataGridViewTextBoxColumn.DataPropertyName = "Закончили мыть";
            this.закончилиМытьDataGridViewTextBoxColumn.HeaderText = "Закончили мыть";
            this.закончилиМытьDataGridViewTextBoxColumn.Name = "закончилиМытьDataGridViewTextBoxColumn";
            this.закончилиМытьDataGridViewTextBoxColumn.Width = 106;
            // 
            // времяВыездаDataGridViewTextBoxColumn
            // 
            this.времяВыездаDataGridViewTextBoxColumn.DataPropertyName = "Время выезда";
            this.времяВыездаDataGridViewTextBoxColumn.HeaderText = "Время выезда";
            this.времяВыездаDataGridViewTextBoxColumn.Name = "времяВыездаDataGridViewTextBoxColumn";
            this.времяВыездаDataGridViewTextBoxColumn.Width = 97;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Приезды";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.приездBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.milkdatabaseDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.молоковозBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.постBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem молоковозыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сотрудникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem постыToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private milkdatabaseDataSet milkdatabaseDataSet;
        private System.Windows.Forms.BindingSource приездBindingSource;
        private milkdatabaseDataSetTableAdapters.приездTableAdapter приездTableAdapter;
        private System.Windows.Forms.BindingSource молоковозBindingSource;
        private milkdatabaseDataSetTableAdapters.молоковозTableAdapter молоковозTableAdapter;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.BindingSource постBindingSource;
        private milkdatabaseDataSetTableAdapters.постTableAdapter постTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn молоковозDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn постDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаПриездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяПриездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоПривезенногоМолокаЛDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началиМытьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn закончилиМытьDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn времяВыездаDataGridViewTextBoxColumn;
    }
}

