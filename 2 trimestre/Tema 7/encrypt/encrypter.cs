using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encrypt
{
    class encrypter
    {
        public static string encrypt(string text)
        {
            StringBuilder textoencriptado = new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
            {
                textoencriptado[i] = (char)(text[i] + 1);
            }
            return textoencriptado.ToString();
        }
        public static string decrypt(string text)
        {
            StringBuilder textoencriptado = new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
            {
                textoencriptado[i] = (char)(text[i] - 1);
            }
            return textoencriptado.ToString();
        }
        static void Main(string[] args)
        {

            Console.WriteLine(encrypt("hola"));
            Console.WriteLine(decrypt(encrypt("hola")));
        }
    }
}
