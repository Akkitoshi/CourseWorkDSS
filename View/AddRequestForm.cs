using Contoller;
using System;
using System.Windows.Forms;
using Unity;

namespace View
{
    public partial class AddRequestForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RequestController service;
        public AddRequestForm(RequestController service)
        {
            InitializeComponent();
            this.service = service;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxComplexity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPtiority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /* private void buttonAdd_Click(object sender, EventArgs e)
         {
             if (string.IsNullOrEmpty(textBoxName.Text))
             {
                 labelError.ForeColor = Color.Red;
                 labelError.Text = "Заполните поле наименование";

             }

             try
             {
                 service.AddElement(new Request
                 {
                     Name = textBoxName.Text
                 });

                 labelError.ForeColor = Color.Green;
                 labelError.Text = "Категория добавлена";
                 buttonAdd.Enabled = false;
             }
             catch
             {
                 labelError.ForeColor = Color.Red;
                 labelError.Text = "Ошибка";
             }
         }*/
    }

}
