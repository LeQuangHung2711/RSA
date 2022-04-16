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

using RSACrypto;

namespace RSACryptoGUI
{
    public partial class frmContainer : Form
    {
        public bool isSave = true;
        public frmRSACrypto rsaCryptoGui = null;
        frmRSACrypto frmCon;

        public frmContainer()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isSave)
            {
                RSAManager.KeysToContainer(txtContainerName.Text);
            }
            else
            {
                RSAManager.ContainerToKeys(txtContainerName.Text);
            }

            rsaCryptoGui.UpdateKeyText();
            rsaCryptoGui.Show();
            Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCon = new frmRSACrypto();
            frmCon.Show();
        }
    }
}