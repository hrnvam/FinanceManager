namespace FinanceManager
{
    partial class IncomeForm1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.IncomeDeleteButton = new System.Windows.Forms.Button();
            this.IncomeClearButton = new System.Windows.Forms.Button();
            this.IncomeUpdateButton = new System.Windows.Forms.Button();
            this.IncomeAddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.IncomeDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.IncomeDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IncomeIncome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.IncomeItem = new System.Windows.Forms.TextBox();
            this.IncomeCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(20, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 359);
            this.panel1.TabIndex = 5;
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
            this.dataGridView1.Location = new System.Drawing.Point(24, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(833, 285);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(19, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Income List";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.IncomeDeleteButton);
            this.panel2.Controls.Add(this.IncomeClearButton);
            this.panel2.Controls.Add(this.IncomeUpdateButton);
            this.panel2.Controls.Add(this.IncomeAddButton);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.IncomeDate);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.IncomeDescription);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.IncomeIncome);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.IncomeItem);
            this.panel2.Controls.Add(this.IncomeCategory);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 381);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 251);
            this.panel2.TabIndex = 6;
            // 
            // IncomeDeleteButton
            // 
            this.IncomeDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.IncomeDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.IncomeDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeDeleteButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.IncomeDeleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IncomeDeleteButton.Location = new System.Drawing.Point(570, 203);
            this.IncomeDeleteButton.Name = "IncomeDeleteButton";
            this.IncomeDeleteButton.Size = new System.Drawing.Size(91, 42);
            this.IncomeDeleteButton.TabIndex = 14;
            this.IncomeDeleteButton.Text = "Delete";
            this.IncomeDeleteButton.UseVisualStyleBackColor = false;
            this.IncomeDeleteButton.Click += new System.EventHandler(this.IncomeDeleteButton_Click);
            // 
            // IncomeClearButton
            // 
            this.IncomeClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.IncomeClearButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.IncomeClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeClearButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.IncomeClearButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IncomeClearButton.Location = new System.Drawing.Point(436, 203);
            this.IncomeClearButton.Name = "IncomeClearButton";
            this.IncomeClearButton.Size = new System.Drawing.Size(91, 42);
            this.IncomeClearButton.TabIndex = 13;
            this.IncomeClearButton.Text = "Clear";
            this.IncomeClearButton.UseVisualStyleBackColor = false;
            this.IncomeClearButton.Click += new System.EventHandler(this.IncomeClearButton_Click);
            // 
            // IncomeUpdateButton
            // 
            this.IncomeUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.IncomeUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.IncomeUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeUpdateButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.IncomeUpdateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IncomeUpdateButton.Location = new System.Drawing.Point(279, 203);
            this.IncomeUpdateButton.Name = "IncomeUpdateButton";
            this.IncomeUpdateButton.Size = new System.Drawing.Size(91, 42);
            this.IncomeUpdateButton.TabIndex = 12;
            this.IncomeUpdateButton.Text = "Update";
            this.IncomeUpdateButton.UseVisualStyleBackColor = false;
            this.IncomeUpdateButton.Click += new System.EventHandler(this.IncomeUpdateButton_Click);
            // 
            // IncomeAddButton
            // 
            this.IncomeAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.IncomeAddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.IncomeAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IncomeAddButton.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold);
            this.IncomeAddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IncomeAddButton.Location = new System.Drawing.Point(145, 203);
            this.IncomeAddButton.Name = "IncomeAddButton";
            this.IncomeAddButton.Size = new System.Drawing.Size(91, 42);
            this.IncomeAddButton.TabIndex = 11;
            this.IncomeAddButton.Text = "Add";
            this.IncomeAddButton.UseVisualStyleBackColor = false;
            this.IncomeAddButton.Click += new System.EventHandler(this.IncomeAddButton_Click);
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
            // IncomeDate
            // 
            this.IncomeDate.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.IncomeDate.Location = new System.Drawing.Point(455, 131);
            this.IncomeDate.Name = "IncomeDate";
            this.IncomeDate.Size = new System.Drawing.Size(376, 30);
            this.IncomeDate.TabIndex = 9;
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
            // IncomeDescription
            // 
            this.IncomeDescription.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.IncomeDescription.Location = new System.Drawing.Point(455, 34);
            this.IncomeDescription.Multiline = true;
            this.IncomeDescription.Name = "IncomeDescription";
            this.IncomeDescription.Size = new System.Drawing.Size(376, 76);
            this.IncomeDescription.TabIndex = 7;
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
            // IncomeIncome
            // 
            this.IncomeIncome.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.IncomeIncome.Location = new System.Drawing.Point(119, 131);
            this.IncomeIncome.Name = "IncomeIncome";
            this.IncomeIncome.Size = new System.Drawing.Size(162, 30);
            this.IncomeIncome.TabIndex = 5;
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
            // IncomeItem
            // 
            this.IncomeItem.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.IncomeItem.Location = new System.Drawing.Point(119, 80);
            this.IncomeItem.Name = "IncomeItem";
            this.IncomeItem.Size = new System.Drawing.Size(162, 30);
            this.IncomeItem.TabIndex = 3;
            // 
            // IncomeCategory
            // 
            this.IncomeCategory.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.IncomeCategory.FormattingEnabled = true;
            this.IncomeCategory.Location = new System.Drawing.Point(119, 34);
            this.IncomeCategory.Name = "IncomeCategory";
            this.IncomeCategory.Size = new System.Drawing.Size(162, 29);
            this.IncomeCategory.TabIndex = 2;
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
            // IncomeForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "IncomeForm1";
            this.Size = new System.Drawing.Size(924, 648);
            this.VisibleChanged += new System.EventHandler(this.IncomeForm1_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button IncomeDeleteButton;
        private System.Windows.Forms.Button IncomeClearButton;
        private System.Windows.Forms.Button IncomeUpdateButton;
        private System.Windows.Forms.Button IncomeAddButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker IncomeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IncomeDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IncomeIncome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IncomeItem;
        private System.Windows.Forms.ComboBox IncomeCategory;
        private System.Windows.Forms.Label label2;
    }
}
