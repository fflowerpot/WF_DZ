namespace WF_DZ._22._06._2023
{
    partial class AddItemForm
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
            textBox1 = new TextBox();
            btn_ok = new Button();
            btn_cnl = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(60, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 27);
            textBox1.TabIndex = 0;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(60, 45);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(94, 29);
            btn_ok.TabIndex = 1;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // btn_cnl
            // 
            btn_cnl.Location = new Point(190, 45);
            btn_cnl.Name = "btn_cnl";
            btn_cnl.Size = new Size(94, 29);
            btn_cnl.TabIndex = 2;
            btn_cnl.Text = "Cancel";
            btn_cnl.UseVisualStyleBackColor = true;
            btn_cnl.Click += btn_cnl_Click;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 87);
            Controls.Add(btn_cnl);
            Controls.Add(btn_ok);
            Controls.Add(textBox1);
            Name = "AddItemForm";
            Text = "AddItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btn_ok;
        private Button btn_cnl;
    }
}