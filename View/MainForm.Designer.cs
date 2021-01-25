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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.опцииToolStripMenuItemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.спискиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЗаявкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьИсполнителяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьПриоритетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьСложностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исполнителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.категорииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.приоритетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сложностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(798, 397);
            this.dataGridView1.TabIndex = 0;
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
            // добавитьЗаявкуToolStripMenuItem
            // 
            this.добавитьЗаявкуToolStripMenuItem.Name = "добавитьЗаявкуToolStripMenuItem";
            this.добавитьЗаявкуToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьЗаявкуToolStripMenuItem.Text = "Добавить заявку";
            // 
            // добавитьИсполнителяToolStripMenuItem
            // 
            this.добавитьИсполнителяToolStripMenuItem.Name = "добавитьИсполнителяToolStripMenuItem";
            this.добавитьИсполнителяToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьИсполнителяToolStripMenuItem.Text = "Добавить исполнителя";
            // 
            // добавитьПриоритетToolStripMenuItem
            // 
            this.добавитьПриоритетToolStripMenuItem.Name = "добавитьПриоритетToolStripMenuItem";
            this.добавитьПриоритетToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьПриоритетToolStripMenuItem.Text = "Добавить приоритет";
            // 
            // добавитьКатегориюToolStripMenuItem
            // 
            this.добавитьКатегориюToolStripMenuItem.Name = "добавитьКатегориюToolStripMenuItem";
            this.добавитьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьКатегориюToolStripMenuItem.Text = "Добавить категорию";
            // 
            // добавитьСложностьToolStripMenuItem
            // 
            this.добавитьСложностьToolStripMenuItem.Name = "добавитьСложностьToolStripMenuItem";
            this.добавитьСложностьToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.добавитьСложностьToolStripMenuItem.Text = "Добавить сложность";
            // 
            // исполнителиToolStripMenuItem
            // 
            this.исполнителиToolStripMenuItem.Name = "исполнителиToolStripMenuItem";
            this.исполнителиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.исполнителиToolStripMenuItem.Text = "Исполнители";
            // 
            // категорииToolStripMenuItem
            // 
            this.категорииToolStripMenuItem.Name = "категорииToolStripMenuItem";
            this.категорииToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.категорииToolStripMenuItem.Text = "Категории";
            // 
            // приоритетыToolStripMenuItem
            // 
            this.приоритетыToolStripMenuItem.Name = "приоритетыToolStripMenuItem";
            this.приоритетыToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.приоритетыToolStripMenuItem.Text = "Приоритеты";
            // 
            // сложностиToolStripMenuItem
            // 
            this.сложностиToolStripMenuItem.Name = "сложностиToolStripMenuItem";
            this.сложностиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сложностиToolStripMenuItem.Text = "Сложности";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список заявок";
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
            this.buttonDelete.Location = new System.Drawing.Point(655, 453);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(139, 23);
            this.buttonDelete.TabIndex = 12;
            this.buttonDelete.Text = "Удалить заявку";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(362, 453);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Главная: Список заявок";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBox1;
    }
}