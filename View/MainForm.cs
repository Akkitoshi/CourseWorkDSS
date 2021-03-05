using Controller;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RequestController service;
        private readonly ExecutorController serviceExecutor;

        public MainForm(RequestController service, ExecutorController serviceE)
        {
            InitializeComponent();
            this.service = service;
            this.serviceExecutor = serviceE;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<RequestView> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[1].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch
            {
                labelError.ForeColor = Color.Red;
                labelError.Text = "Ошибка";
            }
        }

        private void категорииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<CategoriesForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void приоритетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<PrioritiesForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void сложностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ComplexitiesForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void исполнителиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<ExecutorsForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void добавитьКатегориюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddCategoryForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void добавитьЗаявкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddRequestForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
            LoadData();
        }

        private void добавитьИсполнителяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddExecutorForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void добавитьПриоритетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddPriorityForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void добавитьСложностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddComplexityForm>();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            labelError.ForeColor = Color.White;
            if (textBoxDelId.Text.Length > 5)
            {
                labelError.ForeColor = Color.Red;
                labelError.Text = "Максимум символов 5";
            }
            if (!(new Regex(@"[\d!#h]")).Match(textBoxDelId.Text).Success)
            {
                labelError.ForeColor = Color.Red;
                labelError.Text = "Не цифровое значение";
            }
            else
            {
                try
                {
                    service.delElement(Convert.ToInt32(textBoxDelId.Text));
                    LoadData();
                    labelError.ForeColor = Color.Green;
                    labelError.Text = "Успешно";
                    textBoxDelId.Text = "";
                }
                catch
                {
                    labelError.ForeColor = Color.Red;
                    labelError.Text = "Ошибка";
                }
            }
        }
    }
}