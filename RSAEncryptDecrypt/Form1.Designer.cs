
namespace RSAEncryptDecrypt
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BrowsePublicKey = new System.Windows.Forms.Button();
            this.txt_PublicKeyPath = new System.Windows.Forms.TextBox();
            this.btn_Encrypt = new System.Windows.Forms.Button();
            this.txt_EncrptResult = new System.Windows.Forms.TextBox();
            this.txt_PlainText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_BrowsePrivateKey = new System.Windows.Forms.Button();
            this.txt_PrivateKeyPath = new System.Windows.Forms.TextBox();
            this.btn_Decrypt = new System.Windows.Forms.Button();
            this.txt_DecrptResult = new System.Windows.Forms.TextBox();
            this.txt_CipherText = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_BrowsePublicKey);
            this.groupBox1.Controls.Add(this.txt_PublicKeyPath);
            this.groupBox1.Controls.Add(this.btn_Encrypt);
            this.groupBox1.Controls.Add(this.txt_EncrptResult);
            this.groupBox1.Controls.Add(this.txt_PlainText);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 750);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encrypt text";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Public Key File:";
            // 
            // btn_BrowsePublicKey
            // 
            this.btn_BrowsePublicKey.Location = new System.Drawing.Point(708, 46);
            this.btn_BrowsePublicKey.Name = "btn_BrowsePublicKey";
            this.btn_BrowsePublicKey.Size = new System.Drawing.Size(88, 30);
            this.btn_BrowsePublicKey.TabIndex = 4;
            this.btn_BrowsePublicKey.Text = "Browse";
            this.btn_BrowsePublicKey.UseVisualStyleBackColor = true;
            this.btn_BrowsePublicKey.Click += new System.EventHandler(this.btn_BrowsePublicKey_Click);
            // 
            // txt_PublicKeyPath
            // 
            this.txt_PublicKeyPath.Enabled = false;
            this.txt_PublicKeyPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_PublicKeyPath.Location = new System.Drawing.Point(159, 46);
            this.txt_PublicKeyPath.Name = "txt_PublicKeyPath";
            this.txt_PublicKeyPath.Size = new System.Drawing.Size(543, 30);
            this.txt_PublicKeyPath.TabIndex = 3;
            // 
            // btn_Encrypt
            // 
            this.btn_Encrypt.Location = new System.Drawing.Point(276, 340);
            this.btn_Encrypt.Name = "btn_Encrypt";
            this.btn_Encrypt.Size = new System.Drawing.Size(194, 49);
            this.btn_Encrypt.TabIndex = 2;
            this.btn_Encrypt.Text = "Encrypt ↓";
            this.btn_Encrypt.UseVisualStyleBackColor = true;
            this.btn_Encrypt.Click += new System.EventHandler(this.btn_Encrypt_Click);
            // 
            // txt_EncrptResult
            // 
            this.txt_EncrptResult.Location = new System.Drawing.Point(12, 395);
            this.txt_EncrptResult.Multiline = true;
            this.txt_EncrptResult.Name = "txt_EncrptResult";
            this.txt_EncrptResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_EncrptResult.Size = new System.Drawing.Size(784, 344);
            this.txt_EncrptResult.TabIndex = 1;
            // 
            // txt_PlainText
            // 
            this.txt_PlainText.Location = new System.Drawing.Point(12, 98);
            this.txt_PlainText.Multiline = true;
            this.txt_PlainText.Name = "txt_PlainText";
            this.txt_PlainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_PlainText.Size = new System.Drawing.Size(784, 236);
            this.txt_PlainText.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_BrowsePrivateKey);
            this.groupBox2.Controls.Add(this.txt_PrivateKeyPath);
            this.groupBox2.Controls.Add(this.btn_Decrypt);
            this.groupBox2.Controls.Add(this.txt_DecrptResult);
            this.groupBox2.Controls.Add(this.txt_CipherText);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(872, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 750);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Decrypt text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Private Key File:";
            // 
            // btn_BrowsePrivateKey
            // 
            this.btn_BrowsePrivateKey.Location = new System.Drawing.Point(708, 46);
            this.btn_BrowsePrivateKey.Name = "btn_BrowsePrivateKey";
            this.btn_BrowsePrivateKey.Size = new System.Drawing.Size(88, 32);
            this.btn_BrowsePrivateKey.TabIndex = 7;
            this.btn_BrowsePrivateKey.Text = "Browse";
            this.btn_BrowsePrivateKey.UseVisualStyleBackColor = true;
            this.btn_BrowsePrivateKey.Click += new System.EventHandler(this.btn_BrowsePrivateKey_Click);
            // 
            // txt_PrivateKeyPath
            // 
            this.txt_PrivateKeyPath.Enabled = false;
            this.txt_PrivateKeyPath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_PrivateKeyPath.Location = new System.Drawing.Point(169, 46);
            this.txt_PrivateKeyPath.Name = "txt_PrivateKeyPath";
            this.txt_PrivateKeyPath.Size = new System.Drawing.Size(533, 30);
            this.txt_PrivateKeyPath.TabIndex = 6;
            // 
            // btn_Decrypt
            // 
            this.btn_Decrypt.Location = new System.Drawing.Point(288, 340);
            this.btn_Decrypt.Name = "btn_Decrypt";
            this.btn_Decrypt.Size = new System.Drawing.Size(194, 49);
            this.btn_Decrypt.TabIndex = 2;
            this.btn_Decrypt.Text = "Decrypt ↓";
            this.btn_Decrypt.UseVisualStyleBackColor = true;
            this.btn_Decrypt.Click += new System.EventHandler(this.btn_Decrypt_Click);
            // 
            // txt_DecrptResult
            // 
            this.txt_DecrptResult.Location = new System.Drawing.Point(12, 395);
            this.txt_DecrptResult.Multiline = true;
            this.txt_DecrptResult.Name = "txt_DecrptResult";
            this.txt_DecrptResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_DecrptResult.Size = new System.Drawing.Size(784, 344);
            this.txt_DecrptResult.TabIndex = 1;
            // 
            // txt_CipherText
            // 
            this.txt_CipherText.Location = new System.Drawing.Point(12, 98);
            this.txt_CipherText.Multiline = true;
            this.txt_CipherText.Name = "txt_CipherText";
            this.txt_CipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_CipherText.Size = new System.Drawing.Size(784, 236);
            this.txt_CipherText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1702, 767);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Encrypt;
        private System.Windows.Forms.TextBox txt_EncrptResult;
        private System.Windows.Forms.TextBox txt_PlainText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Decrypt;
        private System.Windows.Forms.TextBox txt_DecrptResult;
        private System.Windows.Forms.TextBox txt_CipherText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BrowsePublicKey;
        private System.Windows.Forms.TextBox txt_PublicKeyPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_BrowsePrivateKey;
        private System.Windows.Forms.TextBox txt_PrivateKeyPath;
    }
}

