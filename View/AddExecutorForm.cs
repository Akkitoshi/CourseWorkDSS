using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Model.ViewModels;
using Unity;

namespace View
{
    public partial class AddExecutorForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ExecutorController service;
        private readonly CategoryController serviceCategory;
        public AddExecutorForm(ExecutorController service, CategoryController serviceC )
        {
            InitializeComponent();
            this.service = service;
            this.serviceCategory = serviceC;
            List<CategoryView> list = serviceCategory.GetList();
            comboBoxCategory.DataSource = list;
            comboBoxCategory.DisplayMember = "Name";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            try
            {
                string cName = comboBoxCategory.Text.ToString();
                int categoryId = serviceCategory.searchId(cName);
                service.AddElement(new Executor
                {
                   
                    FIO = textBoxFIO.Text,
                    CategoryName = cName,
                    Experience = Convert.ToInt32(textBoxExperience.Text),
                    CodingLevel = comboBoxLevel.SelectedItem.ToString(),
                    isBusy = false
                });

                labelError.ForeColor = Color.Green;
                labelError.Text = "Исполнитель добавлен";
                buttonAdd.Enabled = false;
            }
            catch
            {
                labelError.ForeColor = Color.Red;
                labelError.Text = "Ошибка";
            }
        }
        
    }

}
