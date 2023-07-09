using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_DZ._22._06._2023
{
    public partial class AddItemForm : Form
    {
        public string New_text;
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            New_text = textBox1.Text.ToString();
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cnl_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
