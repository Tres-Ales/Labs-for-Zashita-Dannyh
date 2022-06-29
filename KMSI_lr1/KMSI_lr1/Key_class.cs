using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KMSI_lr1
{
    class Key_class
    {
        
        private RSACryptoServiceProvider RSAcsp;

        // Создание контейнера ключей
        public void CreateKeyContainer(string name)
        {
            CspParameters cspParameters = new CspParameters();
            cspParameters.KeyContainerName = name;
            

            // Алгоритм подписи документа - RSA
            cspParameters.ProviderType = 1;

            RSAcsp = new RSACryptoServiceProvider(cspParameters);
            RSAcsp.PersistKeyInCsp = true;
        }

        // Проверка наличия контейнера ключей с именем name
        // static, тк не привязано к полям класса
        public static bool IsKeyContainerExist(string name)
        {
            CspParameters cspParameters = new CspParameters();
            cspParameters.KeyContainerName = name;
            cspParameters.Flags = CspProviderFlags.UseExistingKey;
            try
            {
                _ = new RSACryptoServiceProvider(cspParameters);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        // Удаление пары ключей из криптопровайдера
        public void RemovePairKey(string name)
        {
            PublicKey publicKey = new PublicKey();
            publicKey.SetUserName(name);
            publicKey.SetCngKey();
            publicKey.DeleteKey();

            FileInfo file = new FileInfo(Application.StartupPath + "\\PublicKeys\\" + name + ".pub");
            if (file.Exists)
            {
                file.Delete();
            }

        }

        // Подпись документа
        public byte[] SignDocument(string name, string doc)
        {
            CspParameters cspParameters = new CspParameters();
            cspParameters.KeyContainerName = name;
            // Алгоритм подписи документа - RSA
            cspParameters.ProviderType = 1;

            RSAcsp = new RSACryptoServiceProvider(cspParameters);
            RSAcsp.PersistKeyInCsp = true;
            return RSAcsp.SignData(Encoding.GetEncoding(1251).GetBytes(doc), MD5.Create());
        }

        // Получение блоба открытого ключа
        public byte[] GetCspBlob()
        {
            return RSAcsp.ExportCspBlob(false);
        }

        // Подпись открытого ключа
        static public byte[] GetEDS(CngKey key, byte[] pk)
        {
            ECDsaCng ecdsa = new ECDsaCng(key);
            ecdsa.HashAlgorithm = CngAlgorithm.Sha512;
            return ecdsa.SignData(pk);
            // Алгоритм хеширования открытого ключа - SHA512
            //return RSAcsp.SignData(pk, SHA512.Create());
        }

        // Подпись документа
        public byte[] SignDocument(string doc)
        {
            // Алгоритм хеширования документа - MD5
            return RSAcsp.SignData(Encoding.GetEncoding(1251).GetBytes(doc), MD5.Create());
        }

        // Проверка подписи документа
        public bool VerifySignDocument(byte[] DataToVerify, byte[] SignedData, byte[] pkBlob)
        {
            CspParameters cspParameters = new CspParameters();
            // Алгоритм подписи документа - RSA
            cspParameters.ProviderType = 1;

            RSACryptoServiceProvider p = new RSACryptoServiceProvider(cspParameters);
            p.PersistKeyInCsp = false;
            p.ImportCspBlob(pkBlob);

            // Алгоритм хеширования документа - MD5
            return p.VerifyData(DataToVerify, MD5.Create(), SignedData);
        }

        // Проверка подписи ключа
        static public bool VerifyEDS(CngKey key, byte[] DataToVerify, byte[] SignedData)
        {
            ECDsaCng ecdsa = new ECDsaCng(key);
            ecdsa.HashAlgorithm = CngAlgorithm.Sha512;
            return ecdsa.VerifyData(DataToVerify, SignedData);
            // Алгоритм хеширования открытого ключа - SHA512
            //return ECDsa.VerifyData(DataToVerify, SignedData, HashAlgorithmName.SHA512);
        }

        public CngKey GetCngKey(string username)
        {
            if (CngKey.Exists(username))
            {
                return CngKey.Open(username);
            }

            throw new Exception("Ключ с данным именем не существует: " + username);
        }
    }
}
