using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KMSI_lr1
{
    class PublicKey
    {
        
            private string userName;
            //private byte[] blob;
            private byte[] eds = null;
            CngKey key;

            public PublicKey() { }

            public string GetUserName()
            {
                return userName;
            }

            public void SetUserName(string userName)
            {
                this.userName = userName;
            }

            public CngKey GetKey()
            {
                return key;
            }

       

        public void DeleteKey()
            {
                key.Delete();
            }

            public void SetCngKey()
            {
                if (!CngKey.Exists(userName))
                {
                    this.key = CngKey.Create(CngAlgorithm.ECDsaP256, userName);
                }
                else
                {
                    this.key = CngKey.Open(userName);
                }
            }

            public CngKey GetCngKey()
            {
                if (CngKey.Exists(userName))
                {
                    return CngKey.Open(userName);
                }

                throw new Exception("Ключ с данным именем не существует: " + userName);
            }

            public byte[] ExportBlob()
            {
                return key.Export(CngKeyBlobFormat.EccPublicBlob);
            }

            public bool CheckEDS(byte[] blob, byte[] sign)
            {
                return Key_class.VerifyEDS(GetCngKey(), blob, sign);
            }

            public byte[] ComputeEDS(byte[] blob)
            {
               return Key_class.GetEDS(GetCngKey(), blob);
            }

           

            
        }
}
