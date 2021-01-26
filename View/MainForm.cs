using Contoller;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class MainForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RequestController service;

        public MainForm(RequestController service)
        {
            InitializeComponent();
            this.service = service;
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
    }
}