namespace FinanceManager
{
    partial class ExpensesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExpensesDeleteButton = new System.Windows.Forms.Button();
            this.ExpensesClearButton = new System.Windows.Forms.Button();
            this.ExpensesUpdateButton = new System.Windows.Forms.Button();
            this.ExpensesAddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpensesDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ExpensesDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ExpensesAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ExpensesItem = new System.Windows.Forms.TextBox();
            this.ExpensesCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExpensesDeleteButton
            // 
            this.ExpensesDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ExpensesDeleteButton.FlatAppearance.BorderSize = 0;
            this.ExpensesDeleteButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.ExpensesDeleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpensesDeleteButton.Location = new System.Drawing.Point(570, 203);
            this.ExpensesDeleteButton.Name = "ExpensesDeleteButton";
            this.ExpensesDeleteButton.Size = new System.Drawing.Size(91, 42);
            this.ExpensesDeleteButton.TabIndex = 14;
            this.ExpensesDeleteButton.Text = "Delete";
            this.ExpensesDeleteButton.UseVisualStyleBackColor = false;
            this.ExpensesDeleteButton.Click += new System.EventHandler(this.ExpensesDeleteButton_Click);
            // 
            // ExpensesClearButton
            // 
            this.ExpensesClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ExpensesClearButton.FlatAppearance.BorderSize = 0;
            this.ExpensesClearButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.ExpensesClearButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpensesClearButton.Location = new System.Drawing.Point(436, 203);
            this.ExpensesClearButton.Name = "ExpensesClearButton";
            this.ExpensesClearButton.Size = new System.Drawing.Size(91, 42);
            this.ExpensesClearButton.TabIndex = 13;
            this.ExpensesClearButton.Text = "Clear";
            this.ExpensesClearButton.UseVisualStyleBackColor = false;
            this.ExpensesClearButton.Click += new System.EventHandler(this.ExpensesClearButton_Click);
            // 
            // ExpensesUpdateButton
            // 
            this.ExpensesUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ExpensesUpdateButton.FlatAppearance.BorderSize = 0;
            this.ExpensesUpdateButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.ExpensesUpdateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpensesUpdateButton.Location = new System.Drawing.Point(279, 203);
            this.ExpensesUpdateButton.Name = "ExpensesUpdateButton";
            this.ExpensesUpdateButton.Size = new System.Drawing.Size(91, 42);
            this.ExpensesUpdateButton.TabIndex = 12;
            this.ExpensesUpdateButton.Text = "Update";
            this.ExpensesUpdateButton.UseVisualStyleBackColor = false;
            this.ExpensesUpdateButton.Click += new System.EventHandler(this.ExpensesUpdateButton_Click);
            // 
            // ExpensesAddButton
            // 
            this.ExpensesAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.ExpensesAddButton.FlatAppearance.BorderSize = 0;
            this.ExpensesAddButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.ExpensesAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpensesAddButton.Location = new System.Drawing.Point(145, 203);
            this.ExpensesAddButton.Name = "ExpensesAddButton";
            this.ExpensesAddButton.Size = new System.Drawing.Size(91, 42);
            this.ExpensesAddButton.TabIndex = 11;
            this.ExpensesAddButton.Text = "Add";
            this.ExpensesAddButton.UseVisualStyleBackColor = false;
            this.ExpensesAddButton.Click += new System.EventHandler(this.ExpensesAddButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(397, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExpensesDate
            // 
            this.ExpensesDate.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ExpensesDate.Location = new System.Drawing.Point(455, 131);
            this.ExpensesDate.Name = "ExpensesDate";
            this.ExpensesDate.Size = new System.Drawing.Size(376, 30);
            this.ExpensesDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(340, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Description";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExpensesDescription
            // 
            this.ExpensesDescription.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ExpensesDescription.Location = new System.Drawing.Point(455, 34);
            this.ExpensesDescription.Multiline = true;
            this.ExpensesDescription.Name = "ExpensesDescription";
            this.ExpensesDescription.Size = new System.Drawing.Size(376, 76);
            this.ExpensesDescription.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(34, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Amount";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExpensesAmount
            // 
            this.ExpensesAmount.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ExpensesAmount.Location = new System.Drawing.Point(119, 131);
            this.ExpensesAmount.Name = "ExpensesAmount";
            this.ExpensesAmount.Size = new System.Drawing.Size(162, 30);
            this.ExpensesAmount.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(64, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExpensesItem
            // 
            this.ExpensesItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ExpensesItem.Location = new System.Drawing.Point(119, 80);
            this.ExpensesItem.Name = "ExpensesItem";
            this.ExpensesItem.Size = new System.Drawing.Size(162, 30);
            this.ExpensesItem.TabIndex = 3;
            // 
            // ExpensesCategory
            // 
            this.ExpensesCategory.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.ExpensesCategory.FormattingEnabled = true;
            this.ExpensesCategory.Location = new System.Drawing.Point(119, 34);
            this.ExpensesCategory.Name = "ExpensesCategory";
            this.ExpensesCategory.Size = new System.Drawing.Size(162, 29);
            this.ExpensesCategory.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(20, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(833, 285);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 359);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expenses List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExpensesDeleteButton);
            this.panel2.Controls.Add(this.ExpensesClearButton);
            this.panel2.Controls.Add(this.ExpensesUpdateButton);
            this.panel2.Controls.Add(this.ExpensesAddButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ExpensesDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.ExpensesDescription);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ExpensesAmount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ExpensesItem);
            this.panel2.Controls.Add(this.ExpensesCategory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 251);
            this.panel2.TabIndex = 4;
            // 
            // ExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "ExpensesForm";
            this.Size = new System.Drawing.Size(924, 648);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExpensesDeleteButton;
        private System.Windows.Forms.Button ExpensesClearButton;
        private System.Windows.Forms.Button ExpensesUpdateButton;
        private System.Windows.Forms.Button ExpensesAddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker ExpensesDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ExpensesDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ExpensesAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ExpensesItem;
        private System.Windows.Forms.ComboBox ExpensesCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}
