using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KMZI_lr3
{
    class CryptoService
    {
        public static X509Certificate2 currentCertificate;
        public static DSACryptoServiceProvider currentDSA;
        
        public static void SaveDocument(Stream file, byte[] data)
        {
            byte[] signature = currentDSA.SignData(data, HashAlgorithmName.SHA1);
            byte[] certInfo = currentCertificate.RawData;

            FileService.WriteToDocument(file, certInfo.Length, signature.Length, certInfo, signature, data);
        }

        public static void LoadDocument(Stream file, Form1 mainform)
        {
            List<byte[]> infoFromFile = null;
            try
            {
                infoFromFile = FileService.ReadFromDocument(file);
            }
            catch (Exception ex)
            {
                throw new Exception("docwrong");
            }

            byte[] certRawData = infoFromFile[0];
            byte[] signature = infoFromFile[1];
            byte[] data = infoFromFile[2];

            X509Certificate2 cert = null;

            try
            {
                cert = new X509Certificate2(certRawData);
                X509Chain chain = new X509Chain();
                chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
                if (!chain.Build(cert))
                {
                    throw new Exception("certnotvalid");
                }
            }
            catch (Exception ex1)
            {
                throw new Exception("certwrong");
            }

            DSACryptoServiceProvider dsa = (DSACryptoServiceProvider)cert.PublicKey.Key;
            if (!dsa.VerifyData(data, signature, HashAlgorithmName.SHA1))
            {
                throw new Exception("signaturewrong");
            }
            else
            {
                mainform.Text = "Подписанный документ " + cert.GetNameInfo(X509NameType.SimpleName, false);
                mainform.docContent.Text = Encoding.Default.GetString(data);
            }
        }
    }
}
