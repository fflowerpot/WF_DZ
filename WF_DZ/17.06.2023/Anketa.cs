using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace WF_DZ._17._06._2023
{
    public partial class Anketa : Form
    {
        public Anketa()
        {
            InitializeComponent();
            btn_Enter.Enabled = false;
        }

        private void btn_Enter_Click(object sender, EventArgs e)
        {

            DateTime dateOfBirth = dateTimePicker1.Value;
            DateTime currentDate = DateTime.Now;
            int age = currentDate.Year - dateOfBirth.Year;
            if (currentDate.Month < dateOfBirth.Month || (currentDate.Month == dateOfBirth.Month && currentDate.Day < dateOfBirth.Day))
            {
                age--;
            }

            string gender = radioButton_male.Checked ? "Male" : "Female";

            string message = $"Name: {textBoxFName.Text} {textBoxSName.Text}\nCity: {textBoxCity.Text}\nAge: {age}\nGender: {gender}";

            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void CheckFormFields()
        {
            bool areFormsFilled = !(string.IsNullOrWhiteSpace(textBoxFName.Text) && string.IsNullOrWhiteSpace(textBoxSName.Text) && string.IsNullOrWhiteSpace(textBoxCity.Text)) && (radioButton_male.Checked || radioButton_female.Checked);

            btn_Enter.Enabled = areFormsFilled;
        }
        private void textBoxFName_TextChanged(object sender, EventArgs e)
        {
            CheckFormFields();
        }

        private void textBoxSName_TextChanged(object sender, EventArgs e)
        {
            CheckFormFields();
        }

        private void textBoxCity_TextChanged(object sender, EventArgs e)
        {
            CheckFormFields();
        }

        private void radioButton_male_CheckedChanged(object sender, EventArgs e)
        {
            CheckFormFields();
        }

        private void radioButton_female_CheckedChanged(object sender, EventArgs e)
        {
            CheckFormFields();
        }
    }
}
