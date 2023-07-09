namespace WF_DZ._17._06._2023
{
    partial class Anketa
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
            btn_Enter = new Button();
            textBoxCity = new TextBox();
            radioButton_female = new RadioButton();
            radioButton_male = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            textBoxSName = new TextBox();
            textBoxFName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_Enter
            // 
            btn_Enter.Location = new Point(113, 307);
            btn_Enter.Name = "btn_Enter";
            btn_Enter.Size = new Size(94, 29);
            btn_Enter.TabIndex = 7;
            btn_Enter.Text = "Enter";
            btn_Enter.UseVisualStyleBackColor = true;
            btn_Enter.Click += btn_Enter_Click;
            // 
            // textBoxCity
            // 
            textBoxCity.Location = new Point(95, 134);
            textBoxCity.Name = "textBoxCity";
            textBoxCity.Size = new Size(125, 27);
            textBoxCity.TabIndex = 3;
            textBoxCity.TextChanged += textBoxCity_TextChanged;
            // 
            // radioButton_female
            // 
            radioButton_female.AutoSize = true;
            radioButton_female.Location = new Point(208, 187);
            radioButton_female.Name = "radioButton_female";
            radioButton_female.Size = new Size(76, 24);
            radioButton_female.TabIndex = 5;
            radioButton_female.TabStop = true;
            radioButton_female.Text = "female";
            radioButton_female.UseVisualStyleBackColor = true;
            radioButton_female.CheckedChanged += radioButton_female_CheckedChanged;
            // 
            // radioButton_male
            // 
            radioButton_male.AutoSize = true;
            radioButton_male.Location = new Point(34, 187);
            radioButton_male.Name = "radioButton_male";
            radioButton_male.Size = new Size(63, 24);
            radioButton_male.TabIndex = 4;
            radioButton_male.TabStop = true;
            radioButton_male.Text = "male";
            radioButton_male.UseVisualStyleBackColor = true;
            radioButton_male.CheckedChanged += radioButton_male_CheckedChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(34, 243);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 6;
            // 
            // textBoxSName
            // 
            textBoxSName.Location = new Point(95, 80);
            textBoxSName.Name = "textBoxSName";
            textBoxSName.Size = new Size(125, 27);
            textBoxSName.TabIndex = 2;
            textBoxSName.TextChanged += textBoxSName_TextChanged;
            // 
            // textBoxFName
            // 
            textBoxFName.Location = new Point(95, 33);
            textBoxFName.Name = "textBoxFName";
            textBoxFName.Size = new Size(125, 27);
            textBoxFName.TabIndex = 1;
            textBoxFName.TextChanged += textBoxFName_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 9;
            label2.Text = "S Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 10;
            label3.Text = "City";
            // 
            // Anketa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 355);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Enter);
            Controls.Add(textBoxCity);
            Controls.Add(radioButton_female);
            Controls.Add(radioButton_male);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxSName);
            Controls.Add(textBoxFName);
            Name = "Anketa";
            Text = "Anketa";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Enter;
        private TextBox textBoxCity;
        private RadioButton radioButton_female;
        private RadioButton radioButton_male;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxSName;
        private TextBox textBoxFName;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}