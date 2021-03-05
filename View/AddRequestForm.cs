using Model;
using Model.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Unity;
using Controller;

namespace View
{
    public partial class AddRequestForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RequestController service;
        private readonly CategoryController serviceCategory;
        private readonly PriorityController servicePriority;
        private readonly ComplexityController serviceComplexity;
        private readonly ExecutorController serviceExecutor;
        public AddRequestForm(RequestController service, CategoryController serviceCg, PriorityController serviceP, ComplexityController serviceC, ExecutorController serviceE)
        {
            InitializeComponent();
            this.service = service;
            this.serviceCategory = serviceCg;
            this.serviceComplexity = serviceC;
            this.servicePriority = serviceP;
            this.serviceExecutor = serviceE;

            List<CategoryView> list = serviceCategory.GetList();
            comboBoxCategory.DataSource = list;
            comboBoxCategory.DisplayMember = "Name";

            List<ComplexityView> listC = serviceComplexity.GetList();
            comboBoxComplexity.DataSource = listC;
            comboBoxComplexity.DisplayMember = "Name";

            List<PriorityView> listP = servicePriority.GetList();
            comboBoxPriority.DataSource = listP;
            comboBoxPriority.DisplayMember = "Name";

            List<ExecutorView> listE = serviceExecutor.GetList();
            comboBoxExecutor.DataSource = listE;
            comboBoxExecutor.DisplayMember = "FIO";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cName = comboBoxCategory.Text.ToString();
            string complexityName = comboBoxComplexity.Text.ToString();
            string pName = comboBoxPriority.Text.ToString();
            string eName = comboBoxExecutor.Text.ToString();
            bool isBusy = true;
            serviceExecutor.UpdElement(eName, isBusy);
            int categoryId = serviceCategory.searchId(cName);
            int complexityId = serviceComplexity.searchId(complexityName);
            int priorityId = servicePriority.searchId(pName);
            int executorId = serviceExecutor.searchId(eName);
            try
            {

                service.AddElement(new Request
                {
                    Theme = textBoxTheme.Text,
                    CategoryId = categoryId,
                    ComplexityId = complexityId,
                    PriorityId = priorityId,
                    Description = textBoxDescription.Text,
                    ExecutorId = executorId,
                });
               

                labelError.ForeColor = Color.Green;
                labelError.Text = "Исполнитель добавлен";
                button1.Enabled = false;
            }
            catch (Exception ex)
            {
                labelError.ForeColor = Color.Red;
                labelError.Text = ex.Message.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cName = comboBoxCategory.Text.ToString();
            string complexityName = comboBoxComplexity.Text.ToString();
            string pName = comboBoxPriority.Text.ToString();

            try
            {
                List<ExecutorView> list = serviceExecutor.getExecutorsDss(cName, pName, complexityName);
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
    }

}
