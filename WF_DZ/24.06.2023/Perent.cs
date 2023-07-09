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
    public partial class Perent : Form
    {
        public Perent()
        {
            InitializeComponent();
        }

        private void ADD()
        {
            Child form = new Child();
            if (form.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Add(form.Product);
            }
        }

        private void Edit()
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Виберіть елемент для редагування.");
                return;
            }


            Product selectedProduct = (Product)listBox1.SelectedItem;


            Child form = new Child(selectedProduct);


            if (form.ShowDialog() == DialogResult.OK)
            {

                int selectedIndex = listBox1.SelectedIndex;
                listBox1.Items[selectedIndex] = form.Product;
            }
        }
        private void Delete()
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Виберіть елемент для видалення.");
                return;
            }


            Product selectedProduct = (Product)listBox1.SelectedItem;

            listBox1.Items.Remove(selectedProduct);

            MessageBox.Show("Елемент успішно видалений.");
        }

        private void addToolStripMenuItem2_Click(object sender, EventArgs e)
        {

            ADD();
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Виберіть елемент для редагування.");
                return;
            }
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.AddExtension = true;
            SFD.DefaultExt = "txt";
            SFD.Filter = "Text File | *.txt";
            SFD.Title = "Виберіть місце для збереження файлу";


            if (SFD.ShowDialog() == DialogResult.OK)
            {

                (listBox1.SelectedItem as Product).SaveAsFile(SFD.FileName);
                MessageBox.Show("Файл збережено.");
            }
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Edit();

        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void clearAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0)
            {
                MessageBox.Show("Список вже порожній.");
                return;
            }

            listBox1.Items.Clear();
            MessageBox.Show("Список успішно очищений.");
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADD();
        }

        private void editeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete();
        }
    }
}
