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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.IncomeDeleteButton = new System.Windows.Forms.Button();
            this.IncomeClearButton = new System.Windows.Forms.Button();
            this.IncomeUpdateButton = new System.Windows.Forms.Button();
            this.IncomeAddButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Name = "panel1";
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
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
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
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
            resources.ApplyResources(this.panel2, "panel2");
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
            this.panel2.Name = "panel2";
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
            this.IncomeDescription.BackColor = System.Drawing.Color.White;
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
            this.IncomeIncome.BackColor = System.Drawing.Color.White;
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
            this.IncomeItem.BackColor = System.Drawing.Color.White;
            this.IncomeItem.Name = "IncomeItem";
            // 
            // IncomeCategory
            // 
            resources.ApplyResources(this.IncomeCategory, "IncomeCategory");
            this.IncomeCategory.BackColor = System.Drawing.Color.White;
            this.IncomeCategory.FormattingEnabled = true;
            this.IncomeCategory.Name = "IncomeCategory";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // IncomeDeleteButton
            // 
            resources.ApplyResources(this.IncomeDeleteButton, "IncomeDeleteButton");
            this.IncomeDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.IncomeDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.IncomeDeleteButton.Name = "IncomeDeleteButton";
            this.IncomeDeleteButton.UseVisualStyleBackColor = false;
            this.IncomeDeleteButton.Click += new System.EventHandler(this.IncomeDeleteButton_Click);
            // 
            // IncomeClearButton
            // 
            resources.ApplyResources(this.IncomeClearButton, "IncomeClearButton");
            this.IncomeClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.IncomeClearButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.IncomeClearButton.Name = "IncomeClearButton";
            this.IncomeClearButton.UseVisualStyleBackColor = false;
            this.IncomeClearButton.Click += new System.EventHandler(this.IncomeClearButton_Click);
            // 
            // IncomeUpdateButton
            // 
            resources.ApplyResources(this.IncomeUpdateButton, "IncomeUpdateButton");
            this.IncomeUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.IncomeUpdateButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.IncomeUpdateButton.Name = "IncomeUpdateButton";
            this.IncomeUpdateButton.UseVisualStyleBackColor = false;
            this.IncomeUpdateButton.Click += new System.EventHandler(this.IncomeUpdateButton_Click);
            // 
            // IncomeAddButton
            // 
            resources.ApplyResources(this.IncomeAddButton, "IncomeAddButton");
            this.IncomeAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(252)))));
            this.IncomeAddButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.IncomeAddButton.Name = "IncomeAddButton";
            this.IncomeAddButton.UseVisualStyleBackColor = false;
            this.IncomeAddButton.Click += new System.EventHandler(this.IncomeAddButton_Click);
            // 
            // IncomeForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "IncomeForm";
            this.Load += new System.EventHandler(this.IncomeForm_Load);
            this.VisibleChanged += new System.EventHandler(this.IncomeForm_VisibleChanged);
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button IncomeDeleteButton;
        private System.Windows.Forms.Button IncomeClearButton;
        private System.Windows.Forms.Button IncomeUpdateButton;
        private System.Windows.Forms.Button IncomeAddButton;
    }
}
