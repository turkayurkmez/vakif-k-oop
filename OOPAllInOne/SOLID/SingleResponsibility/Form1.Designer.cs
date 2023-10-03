namespace SingleResponsibility
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonCreate = new Button();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            buttonColor = new Button();
            SuspendLayout();
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(125, 178);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(75, 23);
            buttonCreate.TabIndex = 0;
            buttonCreate.Text = "Ekle";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(100, 120);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 1;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(100, 149);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(100, 23);
            textBoxPrice.TabIndex = 2;
            // 
            // buttonColor
            // 
            buttonColor.Location = new Point(146, 297);
            buttonColor.Name = "buttonColor";
            buttonColor.Size = new Size(126, 23);
            buttonColor.TabIndex = 3;
            buttonColor.Text = "Arka planı değiştir";
            buttonColor.UseVisualStyleBackColor = true;
            buttonColor.Click += buttonColor_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 332);
            Controls.Add(buttonColor);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(buttonCreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCreate;
        private TextBox textBoxName;
        private TextBox textBoxPrice;
        private Button buttonColor;
    }
}