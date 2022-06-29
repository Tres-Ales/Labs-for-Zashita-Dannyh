using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace KMSI_lr1
{
    class CngKeys
    {
        public static CngKey CngKeyECDSA { get; set; }

        private static CspParameters rsaparams;
        public static RSACryptoServiceProvider rsaProvider;

        public static bool ExistsRSA(string name)
        {
            var cspParams = new CspParameters
            {
                Flags = CspProviderFlags.UseExistingKey,
                KeyContainerName = name
            };

            try
            {
                var provider = new RSACryptoServiceProvider(cspParams);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        public static bool ExistsECDSA(string name)
        {
            try
            {
                CngKey.Open(name);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static void CreateRSAContainerByName(string name)
        {
            if (ExistsRSA(name)) throw new InvalidOperationException("RSA container already exists");
            rsaparams = new CspParameters()
            {
                KeyContainerName = name,
            };
            rsaparams.ProviderType = 1;
            rsaProvider = new RSACryptoServiceProvider(rsaparams);
            rsaProvider.PersistKeyInCsp = true;
        }

        public static void CreateECDSAContainerByName(string name)
        {
            if (ExistsECDSA(name)) throw new InvalidOperationException("ECDSA container already exists");
            CngKeyECDSA = CngKey.Create(CngAlgorithm.ECDsaP521, name);
        }
        public static bool Exists(string name)
        {
            return ExistsRSA(name) && ExistsECDSA(name);
        }

        public static void CreateContainersByName(string name)
        {
            try
            {
                CreateRSAContainerByName(name);
            }
            catch (Exception e)
            {
                Console.WriteLine("RSA container already exists");
            }
            CreateECDSAContainerByName(name);

        }

        public static void SetRSAProvider(string name)
        {
            rsaparams = new CspParameters()
            {
                KeyContainerName = name,
            };
            rsaparams.ProviderType = 1;
            rsaProvider = new RSACryptoServiceProvider(rsaparams);
            rsaProvider.PersistKeyInCsp = true;
        }

        public static void SetECDSAProvider(string name)
        {
            CngKeyECDSA = CngKey.Open(name);
        }
        public static void SetCurrentProviders(string name)
        {
            SetRSAProvider(name);
            SetECDSAProvider(name);
        }

        public static void Delete(string name)
        {
            
            if (!ExistsRSA(name)) return;
            CspParameters p = new CspParameters()
            {
                KeyContainerName = name,
                Flags = CspProviderFlags.UseExistingKey,
            };
            var q = new RSACryptoServiceProvider(p);
            q.PersistKeyInCsp = false;
            q.Clear();

            CngKeyECDSA.Delete();
        }


        public static CngKey FindCngKey(string name)
        {
            return CngKey.Open(name);
        }
    }
}
