using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private int number1;
        private int number2;
        private int result;

        private int intValidation;

        public Form1()
        {
            InitializeComponent();

            number1 = 0;
            number2 = 0;

            textBox1.ReadOnly = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    number1 = int.Parse(textBox2.Text);
                    number2 = int.Parse(textBox3.Text);
                    result = number1 + number2;

                    textBox1.Text = result.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void Textbox_validating_1(object sender, CancelEventArgs e)
        {
            //clear the error provider
            errorProvider1.SetError(textBox2, "");
            if(! int.TryParse(textBox2.Text, out intValidation))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Please enter a valid integer.");
            }
        }

        private void textbox2_validade(object sender, CancelEventArgs e)
        {
            errorProvider2.SetError(textBox3, "");
            if(! int.TryParse(textBox3.Text, out intValidation))
            {
                e.Cancel = true;
                errorProvider2.SetError(textBox3, "Please enter a valid integer.");
            }
        }
    }
}
