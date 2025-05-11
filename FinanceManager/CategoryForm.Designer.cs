namespace FinanceManager
{
    partial class CategoryForm
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CategoryDeleteButton = new System.Windows.Forms.Button();
            this.CategoryClearButton = new System.Windows.Forms.Button();
            this.CategoryUpdateButton = new System.Windows.Forms.Button();
            this.CategoryAddButton = new System.Windows.Forms.Button();
            this.CategoryStatus = new System.Windows.Forms.ComboBox();
            this.CategoryType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CategoryName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.panel1.Controls.Add(this.CategoryDeleteButton);
            this.panel1.Controls.Add(this.CategoryClearButton);
            this.panel1.Controls.Add(this.CategoryUpdateButton);
            this.panel1.Controls.Add(this.CategoryAddButton);
            this.panel1.Controls.Add(this.CategoryStatus);
            this.panel1.Controls.Add(this.CategoryType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CategoryName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 605);
            this.panel1.TabIndex = 0;
            // 
            // CategoryDeleteButton
            // 
            this.CategoryDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.CategoryDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CategoryDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryDeleteButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CategoryDeleteButton.Location = new System.Drawing.Point(165, 476);
            this.CategoryDeleteButton.Name = "CategoryDeleteButton";
            this.CategoryDeleteButton.Size = new System.Drawing.Size(91, 42);
            this.CategoryDeleteButton.TabIndex = 8;
            this.CategoryDeleteButton.Text = "Delete";
            this.CategoryDeleteButton.UseVisualStyleBackColor = false;
            this.CategoryDeleteButton.Click += new System.EventHandler(this.CategoryDeleteButton_Click);
            // 
            // CategoryClearButton
            // 
            this.CategoryClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.CategoryClearButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CategoryClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryClearButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CategoryClearButton.Location = new System.Drawing.Point(31, 476);
            this.CategoryClearButton.Name = "CategoryClearButton";
            this.CategoryClearButton.Size = new System.Drawing.Size(91, 42);
            this.CategoryClearButton.TabIndex = 7;
            this.CategoryClearButton.Text = "Clear";
            this.CategoryClearButton.UseVisualStyleBackColor = false;
            this.CategoryClearButton.Click += new System.EventHandler(this.CategoryClearButton_Click);
            // 
            // CategoryUpdateButton
            // 
            this.CategoryUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.CategoryUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CategoryUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryUpdateButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CategoryUpdateButton.Location = new System.Drawing.Point(164, 404);
            this.CategoryUpdateButton.Name = "CategoryUpdateButton";
            this.CategoryUpdateButton.Size = new System.Drawing.Size(91, 42);
            this.CategoryUpdateButton.TabIndex = 6;
            this.CategoryUpdateButton.Text = "Update";
            this.CategoryUpdateButton.UseVisualStyleBackColor = false;
            this.CategoryUpdateButton.Click += new System.EventHandler(this.CategoryUpdateButton_Click);
            // 
            // CategoryAddButton
            // 
            this.CategoryAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.CategoryAddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.CategoryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CategoryAddButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CategoryAddButton.Location = new System.Drawing.Point(30, 404);
            this.CategoryAddButton.Name = "CategoryAddButton";
            this.CategoryAddButton.Size = new System.Drawing.Size(91, 42);
            this.CategoryAddButton.TabIndex = 0;
            this.CategoryAddButton.Text = "Add";
            this.CategoryAddButton.UseVisualStyleBackColor = false;
            this.CategoryAddButton.Click += new System.EventHandler(this.CategoryAddButton_Click);
            // 
            // CategoryStatus
            // 
            this.CategoryStatus.BackColor = System.Drawing.Color.White;
            this.CategoryStatus.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CategoryStatus.FormattingEnabled = true;
            this.CategoryStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.CategoryStatus.Location = new System.Drawing.Point(31, 316);
            this.CategoryStatus.Name = "CategoryStatus";
            this.CategoryStatus.Size = new System.Drawing.Size(224, 27);
            this.CategoryStatus.TabIndex = 5;
            // 
            // CategoryType
            // 
            this.CategoryType.BackColor = System.Drawing.Color.White;
            this.CategoryType.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CategoryType.FormattingEnabled = true;
            this.CategoryType.Items.AddRange(new object[] {
            "Income",
            "Expenses"});
            this.CategoryType.Location = new System.Drawing.Point(31, 194);
            this.CategoryType.Name = "CategoryType";
            this.CategoryType.Size = new System.Drawing.Size(224, 27);
            this.CategoryType.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // CategoryName
            // 
            this.CategoryName.BackColor = System.Drawing.Color.White;
            this.CategoryName.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.CategoryName.Location = new System.Drawing.Point(31, 73);
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.Size = new System.Drawing.Size(224, 27);
            this.CategoryName.TabIndex = 0;
            this.CategoryName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(320, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(587, 605);
            this.panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(225)))), ((int)(((byte)(233)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(125)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(125)))), ((int)(((byte)(146)))));
            this.dataGridView1.Location = new System.Drawing.Point(18, 25);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(220)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(548, 555);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "CategoryForm";
            this.Size = new System.Drawing.Size(924, 648);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CategoryName;
        private System.Windows.Forms.ComboBox CategoryType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CategoryStatus;
        private System.Windows.Forms.Button CategoryDeleteButton;
        private System.Windows.Forms.Button CategoryClearButton;
        private System.Windows.Forms.Button CategoryUpdateButton;
        private System.Windows.Forms.Button CategoryAddButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
