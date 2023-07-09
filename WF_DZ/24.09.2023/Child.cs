using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_DZ._24._09._2023
{
    public partial class Child : Form
    {

        public Product Product;
        public Child()
        {
            InitializeComponent();

        }
        public Child(Product product)
        {
            InitializeComponent();
            this.Product = product;
            textBox1.Text = product.Name;
            numericUpDown1.Value = (decimal)product.Price;
            numericUpDown2.Value = product.Quantity;
        }

        private void Child_Load(object sender, EventArgs e)
        {
            numericUpDown1.Controls[0].Visible = false;
            numericUpDown2.Controls[0].Visible = false;
            //numericUpDown1.Text = "";
            //numericUpDown2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Product = new Product(textBox1.Text, (double)numericUpDown1.Value, (int)numericUpDown2.Value);
            this.DialogResult = DialogResult.OK;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
