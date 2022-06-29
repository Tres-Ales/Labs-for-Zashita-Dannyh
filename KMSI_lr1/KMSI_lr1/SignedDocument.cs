using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KMSI_lr1
{
    class SignedDocument
    {
        private byte[] textDocument;
        private string userName;

        private byte[] sign = null;

        public SignedDocument() { }

        public string GetUserName()
        {
            return userName;
        }

        public void SetUserName(string userName)
        {
            this.userName = userName;
        }

        public byte[] GetTextDocument()
        {
            return textDocument;
        }

        public void SetTextDocument(byte[] textDocument)
        {
            this.textDocument = textDocument;
        }

        public bool CheckSign(byte[] pkBlob)
        {
            CspParameters cspParameters = new CspParameters();
            // Алгоритм подписи документа - RSA
            cspParameters.ProviderType = 1;

            RSACryptoServiceProvider p = new RSACryptoServiceProvider(cspParameters);
            p.PersistKeyInCsp = false;
            //p.ImportCspBlob(pkBlob);

            // Алгоритм хеширования документа - MD5
            return p.VerifyData(textDocument, MD5.Create(), sign);
       
        }


        public void SetSign(byte[] sign)
        {
            this.sign = sign;
        }

        public void SaveToFile(string path)
        {
            using (BinaryWriter binaryWriter = new BinaryWriter(new FileStream(path, FileMode.Create, FileAccess.Write)))
            {
                binaryWriter.Write(userName.Length);
                binaryWriter.Write(sign.Length);
                binaryWriter.Write(Encoding.GetEncoding(1251).GetBytes(userName));
                binaryWriter.Write(sign);
                binaryWriter.Write(textDocument);
            }
        }

        public void LoadFromFile(string path)
        {
            using (BinaryReader binaryReader = new BinaryReader(new FileStream(path, FileMode.Open, FileAccess.Read)))
            {
                int userNameLength = binaryReader.ReadInt32();
                int edsLength = binaryReader.ReadInt32();
                userName = Encoding.GetEncoding(1251).GetString(binaryReader.ReadBytes(userNameLength));
                sign = binaryReader.ReadBytes(edsLength);
                textDocument = binaryReader.ReadBytes((int)(binaryReader.BaseStream.Length - binaryReader.BaseStream.Position));
                
            }
        }
    }
}
