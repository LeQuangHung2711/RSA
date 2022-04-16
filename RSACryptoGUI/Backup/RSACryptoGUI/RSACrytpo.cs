//This RSACrypto demo is distributed under the terms of an MIT-style license:

//The MIT License

//Copyright (c) 2008 Andrew Badera andrew@badera.us

//Permission is hereby granted, free of charge, to any person
//obtaining a copy of this software and associated documentation
//files (the "Software"), to deal in the Software without
//restriction, including without limitation the rights to use,
//copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the
//Software is furnished to do so, subject to the following
//conditions:

//The above copyright notice and this permission notice shall be
//included in all copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
//EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
//OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
//NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
//HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
//WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
//FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
//OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

using RSACrypto;

namespace RSACryptoGUI
{
    public partial class frmRSACrypto : Form
    {
        private frmContainer formContainer = new frmContainer();
        protected SaveFileDialog saveFileDialog = new SaveFileDialog();
        protected OpenFileDialog openFileDialog = new OpenFileDialog();

        public void UpdateKeyText()
        {
            txtPublicKey.Text = "";
            txtPrivateKey.Text = "";

            txtPublicKey.Text = RSAManager.rsaCrypto.ToXmlString(false);
            txtPrivateKey.Text = RSAManager.rsaCrypto.ToXmlString(true);
        }

        public frmRSACrypto()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            txtPublicKey.Text = "";
            txtPrivateKey.Text = "";

            int ibits = int.Parse(cmbBits.SelectedItem.ToString());

            DialogResult result = DialogResult.Cancel;
            
            if (ibits > 4096)
            {
                result = MessageBox.Show("Warning, key generation could take a while! Continue?", "Long key warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }

            if (ibits <= 4096 || result == DialogResult.OK)
            {
                RSAManager.GenerateNewKeys(ibits);
                txtPublicKey.Text = RSAManager.rsaCrypto.ToXmlString(false);
                txtPrivateKey.Text = RSAManager.rsaCrypto.ToXmlString(true);
            }
        }

        private void btnEncPublic_Click(object sender, EventArgs e)
        {
            if (txtPublicKey.Text.Trim() == "")
            {
                MessageBox.Show("Please generate or load keys first.", "Key generation required", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                btnGenerate.Focus();
            }
            else
            {
                txtCipherText.Text = "";
                txtCipherText.Text = RSAManager.EncryptWithPublic(txtCleartext.Text);
            }
        }

        private void btnEncPrivate_Click(object sender, EventArgs e)
        {
            if (txtPrivateKey.Text.Trim() == "")
            {
                MessageBox.Show("Please generate or load keys first.", "Key generation required", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                btnGenerate.Focus();
            }
            else
            {
                txtCipherText.Text = "";
                txtCipherText.Text = RSAManager.EncryptWithPrivate(txtCleartext.Text);
            }
        }

        private void btnDecPrivate_Click(object sender, EventArgs e)
        {
            txtFinalText.Text = "";

            if (txtCipherText.Text.Trim() == "")
            {
                MessageBox.Show("Please encrypt data first.", "Encrypted data required", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                btnEncPublic.Focus();
            }
            else
            {
                try
                {
                    txtFinalText.Text = RSAManager.DecryptWithPrivate(txtCipherText.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected failure - could not decrypt with Private key: " + ex.Message, "Private key decryption error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnDecPublic_Click(object sender, EventArgs e)
        {
            txtFinalText.Text = "";

            if (txtCipherText.Text.Trim() == "")
            {
                MessageBox.Show("Please encrypt data first.", "Encrypted data required", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);

                btnEncPublic.Focus();
            }
            else
            {
                try
                {
                    txtFinalText.Text = RSAManager.DecryptWithPublic(txtCipherText.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Expected failure - could not decrypt with Public key: " + ex.Message, "Public key decryption error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void btnKeysContainer_Click(object sender, EventArgs e)
        {
            formContainer.isSave = true;
            formContainer.Show();
            Hide();
        }

        private void btnContainerKeys_Click(object sender, EventArgs e)
        {
            formContainer.isSave = false;
            formContainer.Show();
            Hide();
        }

        private void btnKeysXml_Click(object sender, EventArgs e)
        {
            XmlDocument privateKeyXml = new XmlDocument();
            privateKeyXml.LoadXml(RSAManager.rsaCrypto.ToXmlString(true));

            

            saveFileDialog.Title = "Save Private Key:";
            saveFileDialog.FileName = "PrivateKey.xml";
            
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                privateKeyXml.Save(saveFileDialog.FileName);
            }
        }

        private void frmRSACrypto_Load(object sender, EventArgs e)
        {
            formContainer.rsaCryptoGui = this;

            cmbBits.SelectedIndex = 0;

            saveFileDialog.DefaultExt = "xml";
            saveFileDialog.CheckFileExists = false;
            saveFileDialog.AddExtension = true;
            saveFileDialog.Filter = "xml keys (*.xml)|";
            saveFileDialog.OverwritePrompt = true;

            openFileDialog.DefaultExt = "xml";
            openFileDialog.AddExtension = true;
            openFileDialog.Filter = "xml keys (*.xml)|";
        }

        private void btnXmlKeys_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Load Private Key XML:";
            if (DialogResult.OK == openFileDialog.ShowDialog())
            {
                RSAManager.XmlToKeys(openFileDialog.FileName);
            }

            UpdateKeyText();
        }


    }
}