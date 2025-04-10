<<<<<<< HEAD
namespace ArtFestival
=======
﻿using System.Drawing;
using System.Windows.Forms;

namespace TestForChanges
>>>>>>> cebaecd (Обновленный макет)
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
<<<<<<< HEAD
        }

        private void labelMainFilterCategory_Click(object sender, EventArgs e)
=======
            SetupPlaceholders();
        }

        private void SetupPlaceholders()
        {
            SetupTextBoxPlaceholder(txtAddTitle, "Название события");
            SetupTextBoxPlaceholder(txtEditTitle, "Название события");
        }

        private void SetupTextBoxPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void groupBoxReport_Enter(object sender, System.EventArgs e)
>>>>>>> cebaecd (Обновленный макет)
        {

        }

<<<<<<< HEAD
        private void lbMainEvents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
=======
        private void label1_Click(object sender, System.EventArgs e)
>>>>>>> cebaecd (Обновленный макет)
        {

        }
    }
<<<<<<< HEAD
}
=======
}
>>>>>>> cebaecd (Обновленный макет)
