using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WF_DZ._22._06._2023
{
    public partial class OrderManagerForm : Form
    {
        private List<string> customers;
        private List<string> products;
        private Dictionary<string, List<string>> postalOffices;

        public OrderManagerForm()
        {
            InitializeComponent();
            InitializeData();
            PopulateListBoxes();
            PopulateComboBoxeCity();
            btn_submit.Enabled = false;
        }

        private void InitializeData()
        {
         
            customers = new List<string>()
            {
                "Іван",
                "Петро",
                "Оля"
            };

            products = new List<string>()
            {
                "Товар А",
                "Товар Б",
                "Товар В",
                "Товар Г"
            };

          
            postalOffices = new Dictionary<string, List<string>>()
            {
                { "Київ", new List<string> { "Відділення 1", "Відділення 2", "Відділення 3" } },
                { "Львів", new List<string> { "Відділення 4", "Відділення 5", "Відділення 6" } },
                { "Одеса", new List<string> { "Відділення 7", "Відділення 8", "Відділення 9" } }
            };
        }

        private void PopulateListBoxes()
        {
           
            foreach (string customer in customers)
            {
                listBoxCustomers.Items.Add(customer);
            }

           
            foreach (string product in products)
            {
                checkedListBoxProducts.Items.Add(product);
            }
        }
        private void PopulateComboBoxeCity()
        {

            foreach (string city in postalOffices.Keys)
            {
                comboBoxCity.Items.Add(city);
            }


        }


        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxPostalOffice.Items.Clear();
            //беремo ключ
            string selectedCity = comboBoxCity.SelectedItem.ToString();
            //заповнюємо другий комбо бокс згідно з ключем
            if (postalOffices.ContainsKey(selectedCity))
            {
                List<string> offices = postalOffices[selectedCity];
                foreach (string office in offices)
                {
                    comboBoxPostalOffice.Items.Add(office);
                }
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            // дані з форми
            string customerName = listBoxCustomers.SelectedItem.ToString();
            List<string> selectedProducts = new List<string>();
            foreach (var item in checkedListBoxProducts.CheckedItems)
            {
                selectedProducts.Add(item.ToString());
            }
            string city = comboBoxCity.SelectedItem.ToString();
            string postalOffice = comboBoxPostalOffice.SelectedItem.ToString();

            // повідомлення замовлення
            string message = $"Замовник: {customerName}\n";
            message += $"Товари: {string.Join(", ", selectedProducts)}\n";
            message += $"Адреса одержувача: {city} - {postalOffice}";

          
            MessageBox.Show(message, "Інформація про замовлення", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void CheckSubmitButtonEnabledState()
        {
            bool hasSelectedProducts = checkedListBoxProducts.CheckedIndices.Count > 0;

            btn_submit.Enabled = listBoxCustomers.SelectedItem != null
                                && comboBoxCity.SelectedItem != null
                                && comboBoxPostalOffice.SelectedItem != null
                                && hasSelectedProducts;
        }


        private void listBoxCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSubmitButtonEnabledState();
        }


        private void comboBoxCity_MouseCaptureChanged(object sender, EventArgs e)
        {
            CheckSubmitButtonEnabledState();
        }

        private void comboBoxPostalOffice_MouseCaptureChanged(object sender, EventArgs e)
        {
            CheckSubmitButtonEnabledState();
        }

        private void checkedListBoxProducts_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            CheckSubmitButtonEnabledState();
        }

        private void checkedListBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckSubmitButtonEnabledState();
        }

        private void comboBoxCity_TextChanged(object sender, EventArgs e)
        {
            CheckSubmitButtonEnabledState();
        }

        private void comboBoxPostalOffice_TextChanged(object sender, EventArgs e)
        {
            CheckSubmitButtonEnabledState();
        }

        private void btn_addC_Click(object sender, EventArgs e)
        {
            // діалогове вікно для додавання нового клієнта
            AddItemForm addItemForm = new AddItemForm();
            if (addItemForm.ShowDialog() == DialogResult.OK)
            {
                listBoxCustomers.Items.Add(addItemForm.New_text);
            }
        }

        private void btn_dellC_Click(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItem != null)
            {
                string selectedCustomer = listBoxCustomers.SelectedItem.ToString();

             
                customers.Remove(selectedCustomer);
                listBoxCustomers.Items.Remove(selectedCustomer);
            }
        }

        private void btn_addP_Click(object sender, EventArgs e)
        {
            // діалогове вікно для додавання нового клієнта
            AddItemForm addItemForm = new AddItemForm();
            if (addItemForm.ShowDialog() == DialogResult.OK)
            {
                checkedListBoxProducts.Items.Add(addItemForm.New_text);
            }
        }

        private void btn_dellP_Click(object sender, EventArgs e)
        {
            if (checkedListBoxProducts.SelectedItem != null)
            {
                string selectedProduct = checkedListBoxProducts.SelectedItem.ToString();

                
                products.Remove(selectedProduct);
                checkedListBoxProducts.Items.Remove(selectedProduct);
            }
        }
    }
}
