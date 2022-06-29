using System;
using System.Collections.Generic;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_1_DS
{

    public class FileEncryption
    {

        public static string encFile = @"Users.txt";
        public static string decFile = @"DecUsers.txt";
        static byte[] data = new byte[8];
        static byte[] key;
        static byte[] IV;
        static byte[] salt2;
        static byte[] salt1;

        //static byte[] salt1;
        public static string passFromForm = "";
        

        public static void DeleteDecrypFile()
        {
            if (File.Exists(decFile))
            {
                File.Delete(decFile);
            }
        }

        public static void CreateDecFile()
        {
            DeleteDecrypFile();
            //Расшифрование данных с использованием ключа, генерируемого на основе парольной фразы 
            using (var aesAlg = new AesCryptoServiceProvider())
            {
                //Режим шифрования
                aesAlg.Mode = CipherMode.CFB;
                aesAlg.BlockSize = 128;
                aesAlg.Padding = PaddingMode.Zeros;
               
                FileStream finStream = new FileStream(encFile, FileMode.Open);
                
                // создание буфера для случайной примеси
                
                salt2 = new byte[8];
                // чтение случайной примеси из начала зашифрованного файла
                finStream.Read(salt2, 0, 8);
                
                //Формирование ключа

                //byte[] pwddec = Encoding.Unicode.GetBytes("password");

                
                // сброс состояния объекта для алгоритма шифрования

                
                Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(passFromForm, salt2);
                aesAlg.Key = k1.GetBytes(aesAlg.KeySize / 8);
                aesAlg.IV = k1.GetBytes(aesAlg.BlockSize / 8);
                
                //Расшифровка данных          
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
               

                FileStream foutStream = new FileStream(decFile, FileMode.Create);
                CryptoStream CrStream = new CryptoStream(finStream, decryptor, CryptoStreamMode.Read);
                // выделение памяти для буфера ввода-вывода
                byte[] bytes = new byte[finStream.Length - 8];
                // задание количества непрочитанных байт
                int numBytesToRead = (int)(finStream.Length) - 8;
                // ввод данных из исходного файла
                int n = CrStream.Read(bytes, 0, numBytesToRead);
                // сохранение фактического количества прочитанных байт
                numBytesToRead = n;
                // запись в расшифрованный файл
                foutStream.Write(bytes, 0, numBytesToRead);
                // очистка памяти с конфиденциальными данными
                aesAlg.Clear();
                // закрытие потока
                CrStream.Close();
                // закрытие исходного файла
                finStream.Close();
                // закрытие результирующего файла
                foutStream.Close();

            }
        }

        public static void CreateEncrypFile()
        {
            if (!File.Exists(encFile) || LoginForm.Users.Count != 0)
            {
                string str = string.Empty;
                
                if (LoginForm.Users.Count == 0)
                {
                    USER newUser = new USER("ADMIN", "", true, false, false);
                    LoginForm.Users.Add(newUser);
                }

                foreach (var item in LoginForm.Users.ToArray())
                {
                    char pb = item.par_blocked ? '1' : '0';
                    char pr = item.par_restricted ? '1' : '0';
                    char ft = item.first_time ? 't' : 'f';
                    str += $"{item.username}' '{item.password}' '{ft}' '{pb}' '{pr}" + "\n";
                }


                EncryptedFile(Encoding.UTF8.GetBytes(str));
            }
           

        }

        private static void EncryptedFile(byte[] byteStr)
        {
            if (File.Exists(encFile)) File.Delete(encFile);
            //Шифрование данных с использованием ключа, генерируемого на основе парольной фразы 
            using (var myAes = new AesCryptoServiceProvider())
            {
                //Режим шифрования
                myAes.Mode = CipherMode.CFB;
                myAes.BlockSize = 128;
                myAes.Padding = PaddingMode.Zeros;
                //IV = myAes.IV;
                //Криптостойкое случайное число
                var csp = new RNGCryptoServiceProvider();
                salt1 = new byte[8];
                csp.GetBytes(salt1);

                //Console.WriteLine(Encoding.Unicode.GetString(salt1));
                //byte[] pwd = Encoding.Unicode.GetBytes("password");
                // создание объекта для генерации ключа из парольной фразы
                
                //Формирование ключа               
                Rfc2898DeriveBytes k1 = new Rfc2898DeriveBytes(passFromForm, salt1);
                myAes.Key = k1.GetBytes(myAes.KeySize/8);
                myAes.IV = k1.GetBytes(myAes.BlockSize / 8);

                IV = myAes.IV;
                
                //Шифрование данных          
                ICryptoTransform encryptor = myAes.CreateEncryptor(myAes.Key, myAes.IV);

                using (FileStream EncrypFile = File.Create(encFile))
                {
                    EncrypFile.Write(salt1, 0, 8);
                   
                    using (CryptoStream csEncryp = new CryptoStream(EncrypFile, encryptor, CryptoStreamMode.Write))
                    {
                        csEncryp.Write(byteStr, 0, byteStr.Length);

                    }
                }

            }
        }


    }
    

}
