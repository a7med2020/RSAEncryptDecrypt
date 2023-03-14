using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSAEncryptDecrypt
{
    public partial class Form1 : Form
    {
        RSAService RSAService;
        OpenFileDialog openFileDialog;
        public Form1()
        {
            InitializeComponent();
            RSAService = new RSAService();
            openFileDialog = new OpenFileDialog();
        }


        private void btn_BrowsePublicKey_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "PEM (*.pem)|*.pem| txt files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_PublicKeyPath.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Exception !! info : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_BrowsePrivateKey_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.Filter = "PEM (*.pem)|*.pem| txt files (*.txt)|*.txt";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txt_PrivateKeyPath.Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unknown Exception !! info : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Encrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_PublicKeyPath.Text))
            {
                MessageBox.Show("You must choose a public key file first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txt_PlainText.Text))
            {
                MessageBox.Show("You must enter text to encrypt it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt_EncrptResult.Text = RSAService.EncryptText(txt_PlainText.Text, GetFileText(txt_PublicKeyPath.Text));
            }
            
        }

        private void btn_Decrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_PrivateKeyPath.Text))
            {
                MessageBox.Show("You must choose a private key file first", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrEmpty(txt_CipherText.Text))
            {
                MessageBox.Show("You must enter text to decrypt it", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt_DecrptResult.Text = RSAService.DecryptText(txt_CipherText.Text, GetFileText(txt_PrivateKeyPath.Text));
            }
        }

        string GetFileText(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
