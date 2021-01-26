namespace View
{
    partial class AddExecutorForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelCategory = new System.Windows.Forms.Label();
            this.textBoxExperience = new System.Windows.Forms.TextBox();
            this.labelExperience = new System.Windows.Forms.Label();
            this.textBoxCodingLevel = new System.Windows.Forms.TextBox();
            this.labelCodingLevel = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.labelError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdd.Location = new System.Drawing.Point(321, 159);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(98, 12);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(298, 20);
            this.textBoxFIO.TabIndex = 4;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(9, 12);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(34, 13);
            this.labelFIO.TabIndex = 3;
            this.labelFIO.Text = "ФИО";
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(9, 49);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(60, 13);
            this.labelCategory.TabIndex = 6;
            this.labelCategory.Text = "Категория";
            // 
            // textBoxExperience
            // 
            this.textBoxExperience.Location = new System.Drawing.Point(98, 87);
            this.textBoxExperience.Name = "textBoxExperience";
            this.textBoxExperience.Size = new System.Drawing.Size(298, 20);
            this.textBoxExperience.TabIndex = 9;
            // 
            // labelExperience
            // 
            this.labelExperience.AutoSize = true;
            this.labelExperience.Location = new System.Drawing.Point(9, 87);
            this.labelExperience.Name = "labelExperience";
            this.labelExperience.Size = new System.Drawing.Size(74, 13);
            this.labelExperience.TabIndex = 8;
            this.labelExperience.Text = "Опыт работы";
            // 
            // textBoxCodingLevel
            // 
            this.textBoxCodingLevel.Location = new System.Drawing.Point(98, 133);
            this.textBoxCodingLevel.Name = "textBoxCodingLevel";
            this.textBoxCodingLevel.Size = new System.Drawing.Size(298, 20);
            this.textBoxCodingLevel.TabIndex = 11;
            // 
            // labelCodingLevel
            // 
            this.labelCodingLevel.AutoSize = true;
            this.labelCodingLevel.Location = new System.Drawing.Point(9, 117);
            this.labelCodingLevel.Name = "labelCodingLevel";
            this.labelCodingLevel.Size = new System.Drawing.Size(153, 13);
            this.labelCodingLevel.TabIndex = 10;
            this.labelCodingLevel.Text = "Уровень программирования";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(97, 49);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(298, 21);
            this.comboBoxCategory.TabIndex = 34;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(22, 164);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 35;
            // 
            // AddExecutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 191);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.textBoxCodingLevel);
            this.Controls.Add(this.labelCodingLevel);
            this.Controls.Add(this.textBoxExperience);
            this.Controls.Add(this.labelExperience);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Name = "AddExecutorForm";
            this.Text = "Добавить исполнителя";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.TextBox textBoxExperience;
        private System.Windows.Forms.Label labelExperience;
        private System.Windows.Forms.TextBox textBoxCodingLevel;
        private System.Windows.Forms.Label labelCodingLevel;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label labelError;
    }
}