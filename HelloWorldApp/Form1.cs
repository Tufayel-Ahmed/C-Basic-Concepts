using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HelloWorldApp
{
    public partial class HelloAppUI : Form
    {
        public HelloAppUI()
        {
            InitializeComponent();
        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            
            if(firstNameTextBox.Text.Trim() == "")
            {
                MessageBox.Show("Enter your first name.");
                firstNameTextBox.Focus();
                return;
            }
            string firstName = firstNameTextBox.Text;
            string middleName = middleNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string fullNmae = $"{firstName} {middleName} {lastName}";
            fullNameTextBox.Text = fullNmae;

            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
            
        }
    }
}
