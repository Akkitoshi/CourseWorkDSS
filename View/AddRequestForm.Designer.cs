namespace View
{
    partial class AddRequestForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxTheme = new System.Windows.Forms.TextBox();
            this.labelTheme = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPriority = new System.Windows.Forms.Label();
            this.labelComplexity = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelExecutor = new System.Windows.Forms.Label();
            this.labelDSSExecutor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxExecutor = new System.Windows.Forms.ComboBox();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxComplexity = new System.Windows.Forms.ComboBox();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelError = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTheme
            // 
            this.textBoxTheme.Location = new System.Drawing.Point(94, 12);
            this.textBoxTheme.Name = "textBoxTheme";
            this.textBoxTheme.Size = new System.Drawing.Size(298, 20);
            this.textBoxTheme.TabIndex = 4;
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.Location = new System.Drawing.Point(5, 12);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(34, 13);
            this.labelTheme.TabIndex = 3;
            this.labelTheme.Text = "Тема";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDescription.Location = new System.Drawing.Point(482, 10);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(341, 143);
            this.textBoxDescription.TabIndex = 21;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(409, 19);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(57, 13);
            this.labelDescription.TabIndex = 20;
            this.labelDescription.Text = "Описание";
            // 
            // labelPriority
            // 
            this.labelPriority.AutoSize = true;
            this.labelPriority.Location = new System.Drawing.Point(5, 132);
            this.labelPriority.Name = "labelPriority";
            this.labelPriority.Size = new System.Drawing.Size(61, 13);
            this.labelPriority.TabIndex = 26;
            this.labelPriority.Text = "Приоритет";
            // 
            // labelComplexity
            // 
            this.labelComplexity.AutoSize = true;
            this.labelComplexity.Location = new System.Drawing.Point(5, 94);
            this.labelComplexity.Name = "labelComplexity";
            this.labelComplexity.Size = new System.Drawing.Size(63, 13);
            this.labelComplexity.TabIndex = 24;
            this.labelComplexity.Text = "Сложность";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(5, 57);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 22;
            this.labelCategory.Text = "Категория";
            // 
            // labelExecutor
            // 
            this.labelExecutor.AutoSize = true;
            this.labelExecutor.Location = new System.Drawing.Point(12, 367);
            this.labelExecutor.Name = "labelExecutor";
            this.labelExecutor.Size = new System.Drawing.Size(74, 13);
            this.labelExecutor.TabIndex = 28;
            this.labelExecutor.Text = "Исполнитель";
            // 
            // labelDSSExecutor
            // 
            this.labelDSSExecutor.AutoSize = true;
            this.labelDSSExecutor.Location = new System.Drawing.Point(5, 161);
            this.labelDSSExecutor.Name = "labelDSSExecutor";
            this.labelDSSExecutor.Size = new System.Drawing.Size(159, 13);
            this.labelDSSExecutor.TabIndex = 31;
            this.labelDSSExecutor.Text = "Рекомендуемые исполнители";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(748, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxExecutor
            // 
            this.comboBoxExecutor.FormattingEnabled = true;
            this.comboBoxExecutor.Location = new System.Drawing.Point(94, 369);
            this.comboBoxExecutor.Name = "comboBoxExecutor";
            this.comboBoxExecutor.Size = new System.Drawing.Size(298, 21);
            this.comboBoxExecutor.TabIndex = 33;
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.FormattingEnabled = true;
            this.comboBoxPriority.Location = new System.Drawing.Point(94, 132);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(298, 21);
            this.comboBoxPriority.TabIndex = 34;
            // 
            // comboBoxComplexity
            // 
            this.comboBoxComplexity.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxComplexity.FormattingEnabled = true;
            this.comboBoxComplexity.Location = new System.Drawing.Point(94, 93);
            this.comboBoxComplexity.Name = "comboBoxComplexity";
            this.comboBoxComplexity.Size = new System.Drawing.Size(298, 21);
            this.comboBoxComplexity.TabIndex = 35;
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(94, 54);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(298, 21);
            this.comboBoxCategory.TabIndex = 36;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(811, 150);
            this.dataGridView1.TabIndex = 37;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(398, 372);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Поиск";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AddRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 435);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.comboBoxComplexity);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.comboBoxExecutor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelDSSExecutor);
            this.Controls.Add(this.labelExecutor);
            this.Controls.Add(this.labelPriority);
            this.Controls.Add(this.labelComplexity);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textBoxTheme);
            this.Controls.Add(this.labelTheme);
            this.Name = "AddRequestForm";
            this.Text = "Добавить заявку";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTheme;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPriority;
        private System.Windows.Forms.Label labelComplexity;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelExecutor;
        private System.Windows.Forms.Label labelDSSExecutor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxExecutor;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.ComboBox comboBoxComplexity;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button button2;
    }
}