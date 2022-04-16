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
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace RSACrypto
{
    public class RSAManager
    {
        public static RSACryptoServiceProvider rsaCrypto = null;

        private static RSACryptoServiceProvider _rsaPrivate = null;
        private static RSACryptoServiceProvider _rsaPublic = null;

        public static void KeysToContainer(string containername)
        {
            CspParameters cp = new CspParameters(1);
            cp.Flags = CspProviderFlags.UseMachineKeyStore;

            cp.KeyContainerName = containername;
            RSACryptoServiceProvider privatestore = new RSACryptoServiceProvider(cp);
            privatestore.FromXmlString(rsaCrypto.ToXmlString(true));
            privatestore.PersistKeyInCsp = true;
            privatestore.Clear();
        }

        public static void ContainerToKeys(string containername)
        {
            CspParameters cspParams = new CspParameters(1);
            cspParams.Flags = CspProviderFlags.UseMachineKeyStore;
            cspParams.ProviderName = "Microsoft Strong Cryptographic Provider";

            cspParams.KeyContainerName = containername;
            rsaCrypto = new RSACryptoServiceProvider(cspParams);

            _rsaPrivate = new RSACryptoServiceProvider();
            _rsaPrivate.FromXmlString(rsaCrypto.ToXmlString(true));

            _rsaPublic = new RSACryptoServiceProvider();
            _rsaPublic.FromXmlString(rsaCrypto.ToXmlString(false));
        }

        public static void XmlToKeys(string xmlfilename)
        {
            CspParameters cspParams = new CspParameters(1);
            rsaCrypto = new RSACryptoServiceProvider(cspParams);

            StreamReader keyReader = new StreamReader(xmlfilename);
            string keyXml = keyReader.ReadToEnd();
            keyReader.Dispose();

            rsaCrypto = new RSACryptoServiceProvider();
            rsaCrypto.FromXmlString(keyXml);

            _rsaPrivate = new RSACryptoServiceProvider();
            _rsaPrivate.FromXmlString(keyXml);

            _rsaPublic = new RSACryptoServiceProvider();
            _rsaPublic.FromXmlString(rsaCrypto.ToXmlString(false));
        }

        public static void GenerateNewKeys(int bits)
        {
            CspParameters cspParams = new CspParameters(1);
            rsaCrypto = new RSACryptoServiceProvider(bits, cspParams);

            _rsaPrivate = new RSACryptoServiceProvider();
            _rsaPrivate.FromXmlString(rsaCrypto.ToXmlString(true));

            _rsaPublic = new RSACryptoServiceProvider();
            _rsaPublic.FromXmlString(rsaCrypto.ToXmlString(false));
        }

        public static string EncryptWithPublic(string cleartext)
        {
            byte[] plainbytes = Encoding.Unicode.GetBytes(cleartext);
            byte[] cipherbytes = _rsaPublic.Encrypt(plainbytes, false);
            return Convert.ToBase64String(cipherbytes);
        }

        public static string EncryptWithPrivate(string cleartext)
        {
            byte[] plainbytes = Encoding.Unicode.GetBytes(cleartext);
            byte[] cipherbytes = _rsaPrivate.Encrypt(plainbytes, false);
            return Convert.ToBase64String(cipherbytes);
        }

        /// <summary>
        /// Attempts to decrypt ciphertext with public key.
        /// As this is RSA (asymmetric algo) this method should always fail.
        /// </summary>
        /// <param name="ciphertext">The ciphertext.</param>
        /// <returns></returns>
        public static string DecryptWithPublic(string ciphertext)
        {
            string cleartext = "";

            try
            {
                byte[] cipherbytes = Convert.FromBase64String(ciphertext);
                byte[] plain = _rsaPublic.Decrypt(cipherbytes, false);
                cleartext = System.Text.Encoding.Unicode.GetString(plain);
            }
            catch
            {
                throw;
            }

            return cleartext;
        }

        public static string DecryptWithPrivate(string ciphertext)
        {
            string cleartext = "";

            try
            {
                byte[] cipherbytes = Convert.FromBase64String(ciphertext);
                byte[] plain = _rsaPrivate.Decrypt(cipherbytes, false);
                cleartext = System.Text.Encoding.Unicode.GetString(plain);
            }
            catch
            {
                throw;
            }

            return cleartext;
        }
        
    }
}
