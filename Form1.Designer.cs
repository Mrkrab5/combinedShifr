namespace combinedShifr
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
            encrypt = new Button();
            label1 = new Label();
            entryMassenge = new TextBox();
            label2 = new Label();
            dopYsl = new TextBox();
            itogEncrypt = new Label();
            SuspendLayout();
            // 
            // encrypt
            // 
            encrypt.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            encrypt.Location = new Point(340, 208);
            encrypt.Name = "encrypt";
            encrypt.Size = new Size(137, 47);
            encrypt.TabIndex = 0;
            encrypt.Text = "Зашифровать";
            encrypt.UseVisualStyleBackColor = true;
            encrypt.Click += encrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(96, 23);
            label1.Name = "label1";
            label1.Size = new Size(223, 27);
            label1.TabIndex = 1;
            label1.Text = "Что надо шифровать";
            // 
            // entryMassenge
            // 
            entryMassenge.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            entryMassenge.Location = new Point(22, 62);
            entryMassenge.Name = "entryMassenge";
            entryMassenge.Size = new Size(363, 35);
            entryMassenge.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(590, 23);
            label2.Name = "label2";
            label2.Size = new Size(69, 27);
            label2.TabIndex = 3;
            label2.Text = "Ключ";
            // 
            // dopYsl
            // 
            dopYsl.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            dopYsl.Location = new Point(502, 62);
            dopYsl.Name = "dopYsl";
            dopYsl.Size = new Size(253, 35);
            dopYsl.TabIndex = 4;
            // 
            // itogEncrypt
            // 
            itogEncrypt.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            itogEncrypt.Location = new Point(22, 120);
            itogEncrypt.Name = "itogEncrypt";
            itogEncrypt.Size = new Size(766, 61);
            itogEncrypt.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 274);
            Controls.Add(itogEncrypt);
            Controls.Add(dopYsl);
            Controls.Add(label2);
            Controls.Add(entryMassenge);
            Controls.Add(label1);
            Controls.Add(encrypt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button encrypt;
        private Label label1;
        private TextBox entryMassenge;
        private Label label2;
        private TextBox dopYsl;
        private Label itogEncrypt;
    }
}