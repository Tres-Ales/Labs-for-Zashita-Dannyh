using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KMSI_lr1
{
    class KeysContainer
    {
        public static void DeleteKeys(string name)
        {
            CngKeys.Delete(name);
        }
        public static bool IsKeyExists(string username)
        {
            return CngKeys.Exists(username);
        }

        public static void CreateContainersByName(string username)
        {
            CngKeys.CreateContainersByName(username);
        }

        public static void SetCurrentProviders(string username)
        {
            CngKeys.SetCurrentProviders(username);
        }
        


        public static byte[] SignatureECDSA(byte[] data)
        {
            ECDsaCng dsa = new ECDsaCng(CngKeys.CngKeyECDSA);
            byte[] result = dsa.SignData(data, HashAlgorithmName.SHA512);
            dsa.Dispose();
            return result;
        }

        public static byte[] SignatureRSA(byte[] data)
        {
            byte[] result = CngKeys.rsaProvider.SignData(data, MD5.Create());
            return result;
        }

        public static bool VerifyDataECDSA(string documentOwner, byte[] data, byte[] signature)
        {
            ECDsaCng dsa = new ECDsaCng(CngKeys.FindCngKey(documentOwner));
            return dsa.VerifyData(data, signature, HashAlgorithmName.SHA512);
        }

        public static bool VerifyDataRSA(byte[] data, byte[] signature)
        {
            return CngKeys.rsaProvider.VerifyData(data, SHA1.Create(), signature);
        }

        public static byte[] ExportPublicKey()
        {
            RSACryptoServiceProvider RSAcsp = CngKeys.rsaProvider;
            return RSAcsp.ExportCspBlob(false);
        }
    }
}
