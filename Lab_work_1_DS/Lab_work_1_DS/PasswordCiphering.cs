using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_work_1_DS
{
    public class PasswordCiphering
    {
        public string password = "";

        public string Alphabet = "abcdefghijklmnopqrstuvwxyz" +
            "ABCDEFGHIJKLMNOPQRSTUVWXYZ" +
                "абвгдеёжзийклмнопрстуфхцчшщъыьэюя" + // 157 символов - простое число
            "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ" +  // можно обойтись без проверки
                ";:,.<>?/|#№{}[]()%$!@^'~" + "§" +
                                           "+=-_" +  // на взаимную простоту
            "0123456789";


        public int A;
        public int B;

        public PasswordCiphering()
        {
            A = 0;
            B = 0;
            password = "";
        }
        public PasswordCiphering(string pas, string userName)
        {

            A = Alphabet.IndexOf(userName[0]);
            B = Alphabet.IndexOf(userName[1]);
            password = pas;
        }

        public int INV(int A, int n)
        {
            int n1 = n + 1;
            //int Anew = (n + 1) / A;
            int ost = (n1 + 1) % A;
            while (ost != 0)
            {
                n1 += n;
                ost = n1 % A;
            }

            return (n1 / A);

        }

        public string GetPasswordCipher()
        { // y = (ax + b) (mod n)
            string resStr = "";
            
            foreach (char ch in password)
            {
                if (Alphabet.Contains(ch))
                {
                    int charCode = Alphabet.IndexOf(ch);

                    charCode = A * charCode + B;
                    charCode = charCode % Alphabet.Length; 
                    resStr += Alphabet[charCode];

                }
                else resStr += ch;
            }

            return resStr;
        }

        public string Decipher(string passwordInDoc)
        {
            // x = Anew*(y + n - b) (mod n)
            string resultStr = "";
            int Anew = INV(A, Alphabet.Length); // обратное по модулю
            foreach (char ch in passwordInDoc)
            {
                if (Alphabet.Contains(ch))
                {
                    int charCode = Alphabet.IndexOf(ch);

                    charCode = (charCode + Alphabet.Length - B) * Anew;
                   
                    charCode = charCode % Alphabet.Length; 

                    resultStr += Alphabet[charCode];
                }
                else { resultStr += ch; }
            }


            return resultStr;
        }
    }
}
