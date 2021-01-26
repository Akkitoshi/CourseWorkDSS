using Contoller;
using Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class AddPriorityForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly PriorityController service;
        public AddPriorityForm(PriorityController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                labelError.ForeColor = Color.Red;
                labelError.Text = "Заполните поле наименование";

            }

            try
            {
                service.AddElement(new Priority
                {
                    Name = textBoxName.Text
                });

                labelError.ForeColor = Color.Green;
                labelError.Text = "Приоритет добавлен";
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
