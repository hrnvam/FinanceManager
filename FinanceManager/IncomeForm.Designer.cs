namespace FinanceManager
{
    partial class IncomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeForm));
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
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(233)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // IncomeDeleteButton
            // 
            this.IncomeDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.IncomeDeleteButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.IncomeDeleteButton, "IncomeDeleteButton");
            this.IncomeDeleteButton.Name = "IncomeDeleteButton";
            this.IncomeDeleteButton.UseVisualStyleBackColor = false;
            this.IncomeDeleteButton.Click += new System.EventHandler(this.IncomeDeleteButton_Click);
            // 
            // IncomeClearButton
            // 
            this.IncomeClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.IncomeClearButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.IncomeClearButton, "IncomeClearButton");
            this.IncomeClearButton.Name = "IncomeClearButton";
            this.IncomeClearButton.UseVisualStyleBackColor = false;
            this.IncomeClearButton.Click += new System.EventHandler(this.IncomeClearButton_Click);
            // 
            // IncomeUpdateButton
            // 
            this.IncomeUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.IncomeUpdateButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.IncomeUpdateButton, "IncomeUpdateButton");
            this.IncomeUpdateButton.Name = "IncomeUpdateButton";
            this.IncomeUpdateButton.UseVisualStyleBackColor = false;
            this.IncomeUpdateButton.Click += new System.EventHandler(this.IncomeUpdateButton_Click);
            // 
            // IncomeAddButton
            // 
            this.IncomeAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(242)))), ((int)(((byte)(249)))));
            this.IncomeAddButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.IncomeAddButton, "IncomeAddButton");
            this.IncomeAddButton.Name = "IncomeAddButton";
            this.IncomeAddButton.UseVisualStyleBackColor = false;
            this.IncomeAddButton.Click += new System.EventHandler(this.IncomeAddButton_Click);
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // IncomeDate
            // 
            resources.ApplyResources(this.IncomeDate, "IncomeDate");
            this.IncomeDate.Name = "IncomeDate";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // IncomeDescription
            // 
            resources.ApplyResources(this.IncomeDescription, "IncomeDescription");
            this.IncomeDescription.Name = "IncomeDescription";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // IncomeIncome
            // 
            resources.ApplyResources(this.IncomeIncome, "IncomeIncome");
            this.IncomeIncome.Name = "IncomeIncome";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // IncomeItem
            // 
            resources.ApplyResources(this.IncomeItem, "IncomeItem");
            this.IncomeItem.Name = "IncomeItem";
            // 
            // IncomeCategory
            // 
            resources.ApplyResources(this.IncomeCategory, "IncomeCategory");
            this.IncomeCategory.FormattingEnabled = true;
            this.IncomeCategory.Name = "IncomeCategory";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // IncomeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox IncomeItem;
        private System.Windows.Forms.ComboBox IncomeCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker IncomeDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox IncomeDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IncomeIncome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button IncomeUpdateButton;
        private System.Windows.Forms.Button IncomeAddButton;
        private System.Windows.Forms.Button IncomeDeleteButton;
        private System.Windows.Forms.Button IncomeClearButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
