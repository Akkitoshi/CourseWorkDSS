using Contoller;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class PrioritiesForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly PriorityController service;

        public PrioritiesForm(PriorityController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void PrioritiesForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                List<PriorityView> list = service.GetList();
                if (list != null)
                {
                    dataGridView1.DataSource = list;
                    dataGridView1.Columns[0].Visible = true;
                    dataGridView1.Columns[0].HeaderText = "Идентификатор";
                    dataGridView1.Columns[1].Visible = true;
                    dataGridView1.Columns[1].HeaderText = "Наименование";
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

        private void добавитьПриоритетToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<AddPriorityForm>();
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