namespace View
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИсполнителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПриоритетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСложностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исполнителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приоритетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDelId = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опцииToolStripMenuItemOptions,
            this.спискиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // опцииToolStripMenuItemOptions
            // 
            this.опцииToolStripMenuItemOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьЗаявкуToolStripMenuItem,
            this.добавитьИсполнителяToolStripMenuItem,
            this.добавитьПриоритетToolStripMenuItem,
            this.добавитьКатегориюToolStripMenuItem,
            this.добавитьСложностьToolStripMenuItem});
            this.опцииToolStripMenuItemOptions.Name = "опцииToolStripMenuItemOptions";
            this.опцииToolStripMenuItemOptions.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItemOptions.Text = "Опции";
            // 
            // добавитьЗаявкуToolStripMenuItem
            // 
            this.добавитьЗаявкуToolStripMenuItem.Name = "добавитьЗаявкуToolStripMenuItem";
            this.добавитьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьЗаявкуToolStripMenuItem.Text = "Добавить заявку";
            this.добавитьЗаявкуToolStripMenuItem.Click += new System.EventHandler(this.добавитьЗаявкуToolStripMenuItem_Click);
            // 
            // добавитьИсполнителяToolStripMenuItem
            // 
            this.добавитьИсполнителяToolStripMenuItem.Name = "добавитьИсполнителяToolStripMenuItem";
            this.добавитьИсполнителяToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьИсполнителяToolStripMenuItem.Text = "Добавить исполнителя";
            this.добавитьИсполнителяToolStripMenuItem.Click += new System.EventHandler(this.добавитьИсполнителяToolStripMenuItem_Click);
            // 
            // добавитьПриоритетToolStripMenuItem
            // 
            this.добавитьПриоритетToolStripMenuItem.Name = "добавитьПриоритетToolStripMenuItem";
            this.добавитьПриоритетToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьПриоритетToolStripMenuItem.Text = "Добавить приоритет";
            this.добавитьПриоритетToolStripMenuItem.Click += new System.EventHandler(this.добавитьПриоритетToolStripMenuItem_Click);
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьКатегориюToolStripMenuItem.Text = "Добавить категорию";
            this.добавитьКатегориюToolStripMenuItem.Click += new System.EventHandler(this.добавитьКатегориюToolStripMenuItem_Click);
            // 
            // добавитьСложностьToolStripMenuItem
            // 
            this.добавитьСложностьToolStripMenuItem.Name = "добавитьСложностьToolStripMenuItem";
            this.добавитьСложностьToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьСложностьToolStripMenuItem.Text = "Добавить сложность";
            this.добавитьСложностьToolStripMenuItem.Click += new System.EventHandler(this.добавитьСложностьToolStripMenuItem_Click);
            // 
            // спискиToolStripMenuItem
            // 
            this.спискиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.исполнителиToolStripMenuItem,
            this.категорииToolStripMenuItem,
            this.приоритетыToolStripMenuItem,
            this.сложностиToolStripMenuItem});
            this.спискиToolStripMenuItem.Name = "спискиToolStripMenuItem";
            this.спискиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.спискиToolStripMenuItem.Text = "Списки";
            // 
            // исполнителиToolStripMenuItem
            // 
            this.исполнителиToolStripMenuItem.Name = "исполнителиToolStripMenuItem";
            this.исполнителиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.исполнителиToolStripMenuItem.Text = "Исполнители";
            this.исполнителиToolStripMenuItem.Click += new System.EventHandler(this.исполнителиToolStripMenuItem_Click);
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.категорииToolStripMenuItem.Text = "Категории";
            this.категорииToolStripMenuItem.Click += new System.EventHandler(this.категорииToolStripMenuItem_Click);
            // 
            // приоритетыToolStripMenuItem
            // 
            this.приоритетыToolStripMenuItem.Name = "приоритетыToolStripMenuItem";
            this.приоритетыToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.приоритетыToolStripMenuItem.Text = "Приоритеты";
            this.приоритетыToolStripMenuItem.Click += new System.EventHandler(this.приоритетыToolStripMenuItem_Click);
            // 
            // сложностиToolStripMenuItem
            // 
            this.сложностиToolStripMenuItem.Name = "сложностиToolStripMenuItem";
            this.сложностиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.сложностиToolStripMenuItem.Text = "Сложности";
            this.сложностиToolStripMenuItem.Click += new System.EventHandler(this.сложностиToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(228, 458);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Введите id заявки";
            // 
            // buttonDelete
            // 
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Location = new System.Drawing.Point(655, 453);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Удалить заявку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDelId
            // 
            this.textBoxDelId.Location = new System.Drawing.Point(362, 453);
            this.textBoxDelId.Name = "textBoxDelId";
            this.textBoxDelId.Size = new System.Drawing.Size(287, 20);
            this.textBoxDelId.TabIndex = 11;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(1, 463);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(788, 411);
            this.dataGridView1.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxDelId);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная: Список заявок";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem опцииToolStripMenuItemOptions;
        private System.Windows.Forms.ToolStripMenuItem добавитьЗаявкуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьИсполнителяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьПриоритетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьКатегориюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьСложностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem спискиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исполнителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem категорииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem приоритетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сложностиToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDelId;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}