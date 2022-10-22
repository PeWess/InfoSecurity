using System;
using System.Linq;
using System.Text;

namespace Lab_7
{
    class Program
    {
        private static Random _rnd = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

        private static string CreateKey(int length)
        {
            return new string(Enumerable.Repeat(chars, length).Select(s => s[_rnd.Next(s.Length)]).ToArray()); ;
        }

        private static string Encrypt(string message, string key)
        {
            string result = "";

            for(int i = 0; i < message.Length; i++)
            {
                result += Convert.ToChar(message[i] ^ key[i]);
            }

            return result;
        }

        private static string Decrypt(string encrypted, string key)
        {
            string result = "";

            for (int i = 0; i < encrypted.Length; i++)
            {
                result += Convert.ToChar(encrypted[i] ^ key[i]);
            }

            return result;
        }

        static void Main(string[] args)
        {
            string str = "С Новым годом, друзья!";
            int length = str.Length;
            string key = CreateKey(length);
            string encrypted = Encrypt(str, key);

            byte[] encrypted_code = Encoding.Unicode.GetBytes(encrypted);
            byte[] key_code = Encoding.Unicode.GetBytes(key);

            string trans_encrypted = BitConverter.ToString(encrypted_code).Replace("-", " ");
            string trans_key = BitConverter.ToString(key_code).Replace("-", " ");


            Console.WriteLine($"Сгенерированный ключ: {key}");
            Console.WriteLine($"Сгенерированный ключ в 16-ом виде: {trans_key}");
            Console.WriteLine($"Зашифрованные данные в 16-ом виде: {trans_encrypted}");
            Console.WriteLine("Результат дешифровки:" + Decrypt(encrypted, key));
        }
    }
}
