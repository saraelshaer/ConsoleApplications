using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager
{
    internal class Encryption
    {
        private static string key = "JacobAl-Kindi";
        private static int sizeKey = key.Length;
        private static string originalText = "0123456789~!@#$&_=-?></*|abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private static int sizeOfOriginalText = originalText.Length;

        public static string EncryptPlainText(string plainText)
        {
            int length = plainText.Length;
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int k = originalText.IndexOf(key[i % sizeKey]);
                int p = originalText.IndexOf(plainText[i]);
                int c = (k + p) % sizeOfOriginalText;
                sb.Append(originalText[c]);
            }
            return sb.ToString();
        }

        public static string decryptCipherText(string cipherText)
        {
            int length = cipherText.Length;
            var sb = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int k = originalText.IndexOf(key[i % sizeKey]);
                int c = originalText.IndexOf(cipherText[i]);
                int p = c - k ;
                if (p < 0) p = (p % sizeOfOriginalText + sizeOfOriginalText) % sizeOfOriginalText;
                else p= p%sizeOfOriginalText;
                sb.Append(originalText[p]);
            }
            return sb.ToString();
        }
    }
}
