using Contoller;
using Model;
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
    public partial class AddComplexityForm : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ComplexityController service;
        public AddComplexityForm(ComplexityController service)
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
                service.AddElement(new Complexity
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
        }
    }

}
