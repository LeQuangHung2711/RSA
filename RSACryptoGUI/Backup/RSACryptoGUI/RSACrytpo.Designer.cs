namespace RSACryptoGUI
{
    partial class frmRSACrypto
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
            this.txtCleartext = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtPublicKey = new System.Windows.Forms.TextBox();
            this.txtPrivateKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEncPublic = new System.Windows.Forms.Button();
            this.btnEncPrivate = new System.Windows.Forms.Button();
            this.txtCipherText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFinalText = new System.Windows.Forms.TextBox();
            this.btnDecPrivate = new System.Windows.Forms.Button();
            this.btnDecPublic = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKeysContainer = new System.Windows.Forms.Button();
            this.btnKeysXml = new System.Windows.Forms.Button();
            this.btnXmlKeys = new System.Windows.Forms.Button();
            this.btnContainerKeys = new System.Windows.Forms.Button();
            this.cmbBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCleartext
            // 
            this.txtCleartext.Location = new System.Drawing.Point(434, 6);
            this.txtCleartext.MaxLength = 1024;
            this.txtCleartext.Multiline = true;
            this.txtCleartext.Name = "txtCleartext";
            this.txtCleartext.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCleartext.Size = new System.Drawing.Size(232, 152);
            this.txtCleartext.TabIndex = 0;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(293, 6);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "1. Generate Keys";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtPublicKey
            // 
            this.txtPublicKey.Location = new System.Drawing.Point(12, 6);
            this.txtPublicKey.Multiline = true;
            this.txtPublicKey.Name = "txtPublicKey";
            this.txtPublicKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPublicKey.Size = new System.Drawing.Size(275, 106);
            this.txtPublicKey.TabIndex = 2;
            // 
            // txtPrivateKey
            // 
            this.txtPrivateKey.Location = new System.Drawing.Point(12, 118);
            this.txtPrivateKey.Multiline = true;
            this.txtPrivateKey.Name = "txtPrivateKey";
            this.txtPrivateKey.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPrivateKey.Size = new System.Drawing.Size(275, 342);
            this.txtPrivateKey.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Public Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 447);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Private Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(672, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cleartext";
            // 
            // btnEncPublic
            // 
            this.btnEncPublic.Location = new System.Drawing.Point(555, 169);
            this.btnEncPublic.Name = "btnEncPublic";
            this.btnEncPublic.Size = new System.Drawing.Size(101, 23);
            this.btnEncPublic.TabIndex = 7;
            this.btnEncPublic.Text = "2b. Enc Public";
            this.btnEncPublic.UseVisualStyleBackColor = true;
            this.btnEncPublic.Click += new System.EventHandler(this.btnEncPublic_Click);
            // 
            // btnEncPrivate
            // 
            this.btnEncPrivate.Location = new System.Drawing.Point(448, 169);
            this.btnEncPrivate.Name = "btnEncPrivate";
            this.btnEncPrivate.Size = new System.Drawing.Size(101, 23);
            this.btnEncPrivate.TabIndex = 8;
            this.btnEncPrivate.Text = "2a. Enc Private";
            this.btnEncPrivate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEncPrivate.UseVisualStyleBackColor = true;
            this.btnEncPrivate.Click += new System.EventHandler(this.btnEncPrivate_Click);
            // 
            // txtCipherText
            // 
            this.txtCipherText.Location = new System.Drawing.Point(434, 198);
            this.txtCipherText.Multiline = true;
            this.txtCipherText.Name = "txtCipherText";
            this.txtCipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCipherText.Size = new System.Drawing.Size(232, 152);
            this.txtCipherText.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(672, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ciphertext";
            // 
            // txtFinalText
            // 
            this.txtFinalText.Location = new System.Drawing.Point(434, 385);
            this.txtFinalText.Multiline = true;
            this.txtFinalText.Name = "txtFinalText";
            this.txtFinalText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFinalText.Size = new System.Drawing.Size(232, 152);
            this.txtFinalText.TabIndex = 11;
            // 
            // btnDecPrivate
            // 
            this.btnDecPrivate.Location = new System.Drawing.Point(448, 356);
            this.btnDecPrivate.Name = "btnDecPrivate";
            this.btnDecPrivate.Size = new System.Drawing.Size(101, 23);
            this.btnDecPrivate.TabIndex = 13;
            this.btnDecPrivate.Text = "3. Dec Private";
            this.btnDecPrivate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDecPrivate.UseVisualStyleBackColor = true;
            this.btnDecPrivate.Click += new System.EventHandler(this.btnDecPrivate_Click);
            // 
            // btnDecPublic
            // 
            this.btnDecPublic.AccessibleName = "Decrypt with Public Key";
            this.btnDecPublic.BackColor = System.Drawing.Color.IndianRed;
            this.btnDecPublic.Cursor = System.Windows.Forms.Cursors.No;
            this.btnDecPublic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecPublic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecPublic.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnDecPublic.Location = new System.Drawing.Point(555, 356);
            this.btnDecPublic.Name = "btnDecPublic";
            this.btnDecPublic.Size = new System.Drawing.Size(101, 23);
            this.btnDecPublic.TabIndex = 12;
            this.btnDecPublic.Text = "Dec Public";
            this.btnDecPublic.UseVisualStyleBackColor = false;
            this.btnDecPublic.Click += new System.EventHandler(this.btnDecPublic_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(672, 524);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Decrypted Text";
            // 
            // btnKeysContainer
            // 
            this.btnKeysContainer.Location = new System.Drawing.Point(45, 483);
            this.btnKeysContainer.Name = "btnKeysContainer";
            this.btnKeysContainer.Size = new System.Drawing.Size(101, 23);
            this.btnKeysContainer.TabIndex = 15;
            this.btnKeysContainer.Text = "Keys->Container";
            this.btnKeysContainer.UseVisualStyleBackColor = true;
            this.btnKeysContainer.Click += new System.EventHandler(this.btnKeysContainer_Click);
            // 
            // btnKeysXml
            // 
            this.btnKeysXml.Location = new System.Drawing.Point(152, 483);
            this.btnKeysXml.Name = "btnKeysXml";
            this.btnKeysXml.Size = new System.Drawing.Size(101, 23);
            this.btnKeysXml.TabIndex = 16;
            this.btnKeysXml.Text = "Keys->XML";
            this.btnKeysXml.UseVisualStyleBackColor = true;
            this.btnKeysXml.Click += new System.EventHandler(this.btnKeysXml_Click);
            // 
            // btnXmlKeys
            // 
            this.btnXmlKeys.Location = new System.Drawing.Point(152, 512);
            this.btnXmlKeys.Name = "btnXmlKeys";
            this.btnXmlKeys.Size = new System.Drawing.Size(101, 23);
            this.btnXmlKeys.TabIndex = 18;
            this.btnXmlKeys.Text = "XML->Keys";
            this.btnXmlKeys.UseVisualStyleBackColor = true;
            this.btnXmlKeys.Click += new System.EventHandler(this.btnXmlKeys_Click);
            // 
            // btnContainerKeys
            // 
            this.btnContainerKeys.Location = new System.Drawing.Point(45, 512);
            this.btnContainerKeys.Name = "btnContainerKeys";
            this.btnContainerKeys.Size = new System.Drawing.Size(101, 23);
            this.btnContainerKeys.TabIndex = 17;
            this.btnContainerKeys.Text = "Container->Keys";
            this.btnContainerKeys.UseVisualStyleBackColor = true;
            this.btnContainerKeys.Click += new System.EventHandler(this.btnContainerKeys_Click);
            // 
            // cmbBits
            // 
            this.cmbBits.FormattingEnabled = true;
            this.cmbBits.Items.AddRange(new object[] {
            "1024",
            "4096",
            "8192",
            "16384"});
            this.cmbBits.Location = new System.Drawing.Point(293, 36);
            this.cmbBits.Name = "cmbBits";
            this.cmbBits.Size = new System.Drawing.Size(61, 21);
            this.cmbBits.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Bits";
            // 
            // frmRSACrypto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 560);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbBits);
            this.Controls.Add(this.btnXmlKeys);
            this.Controls.Add(this.btnContainerKeys);
            this.Controls.Add(this.btnKeysXml);
            this.Controls.Add(this.btnKeysContainer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDecPrivate);
            this.Controls.Add(this.btnDecPublic);
            this.Controls.Add(this.txtFinalText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCipherText);
            this.Controls.Add(this.btnEncPrivate);
            this.Controls.Add(this.btnEncPublic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrivateKey);
            this.Controls.Add(this.txtPublicKey);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtCleartext);
            this.Name = "frmRSACrypto";
            this.Text = "RSACrypto";
            this.Load += new System.EventHandler(this.frmRSACrypto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCleartext;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtPublicKey;
        private System.Windows.Forms.TextBox txtPrivateKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEncPublic;
        private System.Windows.Forms.Button btnEncPrivate;
        private System.Windows.Forms.TextBox txtCipherText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFinalText;
        private System.Windows.Forms.Button btnDecPrivate;
        private System.Windows.Forms.Button btnDecPublic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKeysContainer;
        private System.Windows.Forms.Button btnKeysXml;
        private System.Windows.Forms.Button btnXmlKeys;
        private System.Windows.Forms.Button btnContainerKeys;
        private System.Windows.Forms.ComboBox cmbBits;
        private System.Windows.Forms.Label label6;
    }
}

