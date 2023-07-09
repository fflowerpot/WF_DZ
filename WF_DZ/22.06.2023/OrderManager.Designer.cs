namespace WF_DZ._22._06._2023
{
    partial class OrderManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxCustomers = new ListBox();
            checkedListBoxProducts = new CheckedListBox();
            comboBoxCity = new ComboBox();
            comboBoxPostalOffice = new ComboBox();
            btn_addC = new Button();
            btn_dellC = new Button();
            btn_addP = new Button();
            btn_dellP = new Button();
            btn_submit = new Button();
            SuspendLayout();
            // 
            // listBoxCustomers
            // 
            listBoxCustomers.FormattingEnabled = true;
            listBoxCustomers.ItemHeight = 20;
            listBoxCustomers.Location = new Point(12, 12);
            listBoxCustomers.Name = "listBoxCustomers";
            listBoxCustomers.Size = new Size(146, 144);
            listBoxCustomers.TabIndex = 0;
            listBoxCustomers.SelectedIndexChanged += listBoxCustomers_SelectedIndexChanged;
            // 
            // checkedListBoxProducts
            // 
            checkedListBoxProducts.CheckOnClick = true;
            checkedListBoxProducts.FormattingEnabled = true;
            checkedListBoxProducts.Location = new Point(183, 12);
            checkedListBoxProducts.Name = "checkedListBoxProducts";
            checkedListBoxProducts.Size = new Size(155, 136);
            checkedListBoxProducts.TabIndex = 1;
            checkedListBoxProducts.ItemCheck += checkedListBoxProducts_ItemCheck;
            checkedListBoxProducts.SelectedIndexChanged += checkedListBoxProducts_SelectedIndexChanged;
            // 
            // comboBoxCity
            // 
            comboBoxCity.FormattingEnabled = true;
            comboBoxCity.Location = new Point(428, 12);
            comboBoxCity.Name = "comboBoxCity";
            comboBoxCity.Size = new Size(151, 28);
            comboBoxCity.TabIndex = 2;
            comboBoxCity.SelectedIndexChanged += comboBoxCity_SelectedIndexChanged;
            comboBoxCity.TextChanged += comboBoxCity_TextChanged;
            comboBoxCity.MouseCaptureChanged += comboBoxCity_MouseCaptureChanged;
            // 
            // comboBoxPostalOffice
            // 
            comboBoxPostalOffice.FormattingEnabled = true;
            comboBoxPostalOffice.Location = new Point(428, 120);
            comboBoxPostalOffice.Name = "comboBoxPostalOffice";
            comboBoxPostalOffice.Size = new Size(151, 28);
            comboBoxPostalOffice.TabIndex = 3;
            comboBoxPostalOffice.TextChanged += comboBoxPostalOffice_TextChanged;
            comboBoxPostalOffice.MouseCaptureChanged += comboBoxPostalOffice_MouseCaptureChanged;
            // 
            // btn_addC
            // 
            btn_addC.Location = new Point(64, 202);
            btn_addC.Name = "btn_addC";
            btn_addC.Size = new Size(94, 29);
            btn_addC.TabIndex = 4;
            btn_addC.Text = "Додати";
            btn_addC.UseVisualStyleBackColor = true;
            btn_addC.Click += btn_addC_Click;
            // 
            // btn_dellC
            // 
            btn_dellC.Location = new Point(64, 271);
            btn_dellC.Name = "btn_dellC";
            btn_dellC.Size = new Size(94, 29);
            btn_dellC.TabIndex = 5;
            btn_dellC.Text = "Видалити";
            btn_dellC.UseVisualStyleBackColor = true;
            btn_dellC.Click += btn_dellC_Click;
            // 
            // btn_addP
            // 
            btn_addP.Location = new Point(244, 202);
            btn_addP.Name = "btn_addP";
            btn_addP.Size = new Size(94, 29);
            btn_addP.TabIndex = 6;
            btn_addP.Text = "Додати";
            btn_addP.UseVisualStyleBackColor = true;
            btn_addP.Click += btn_addP_Click;
            // 
            // btn_dellP
            // 
            btn_dellP.Location = new Point(244, 271);
            btn_dellP.Name = "btn_dellP";
            btn_dellP.Size = new Size(94, 29);
            btn_dellP.TabIndex = 7;
            btn_dellP.Text = "Видалити";
            btn_dellP.UseVisualStyleBackColor = true;
            btn_dellP.Click += btn_dellP_Click;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(485, 291);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(94, 29);
            btn_submit.TabIndex = 8;
            btn_submit.Text = "Підтвердити";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // OrderManagerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 343);
            Controls.Add(btn_submit);
            Controls.Add(btn_dellP);
            Controls.Add(btn_addP);
            Controls.Add(btn_dellC);
            Controls.Add(btn_addC);
            Controls.Add(comboBoxPostalOffice);
            Controls.Add(comboBoxCity);
            Controls.Add(checkedListBoxProducts);
            Controls.Add(listBoxCustomers);
            Name = "OrderManagerForm";
            Text = "OrderManager";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxCustomers;
        private CheckedListBox checkedListBoxProducts;
        private ComboBox comboBoxCity;
        private ComboBox comboBoxPostalOffice;
        private Button btn_addC;
        private Button btn_dellC;
        private Button btn_addP;
        private Button btn_dellP;
        private Button btn_submit;
    }
}