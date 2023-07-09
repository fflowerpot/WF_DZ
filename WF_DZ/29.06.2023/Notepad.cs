using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WF_DZ._29._06._2023
{
    public partial class Notepad : Form
    {
        public Notepad()
        {
            InitializeComponent();
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog.Title = "Open File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Завантажуємо текст з вибраного файлу і встановлюємо його у поле для введення тексту
                string filePath = openFileDialog.FileName;
                string fileContent = System.IO.File.ReadAllText(filePath);
                textBox1.Text = fileContent;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Відкриваємо вікно для збереження файлу
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog.Title = "Save File";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Зберігаємо вміст поля для введення тексту в обраний файл
                string filePath = saveFileDialog.FileName;
                System.IO.File.WriteAllText(filePath, textBox1.Text);
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void Notepad_SizeChanged(object sender, EventArgs e)
        {
            textBox1.Size = new System.Drawing.Size(ClientSize.Width, ClientSize.Height - textBox1.Location.Y);
        }
    }
}
