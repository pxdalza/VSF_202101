using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.FL.UTILITY
{
    public static class PasswordSC
    {

        public static String PasswordEncriptar(String Password)
        {
            UTF8Encoding textConverter = new UTF8Encoding();

            //Key 16
            byte[] keyBytes = textConverter.GetBytes("0000020509463124");
            String keyString = System.Convert.ToBase64String(keyBytes);

            //IV 16
            byte[] IVBytes = textConverter.GetBytes("0000020509463124");
            String IVString = System.Convert.ToBase64String(IVBytes);

            //Message
            String message = Password;
            byte[] mesageBytes = textConverter.GetBytes(message);

            //Padding
            PaddingMode padding = PaddingMode.PKCS7;

            //Encrypt
            byte[] encryptedBytes = CryptoUtils.encryptWithOptions(keyBytes, IVBytes, padding, mesageBytes);
            String encryptedMessage = System.Convert.ToBase64String(encryptedBytes);

            return encryptedMessage;
        }

        public static String PasswordDesencriptar(String PasswordEncriptado)
        {
            UTF8Encoding textConverter = new UTF8Encoding();

            //Key 16
            byte[] keyBytes = textConverter.GetBytes("0000020509463124");
            String keyString = System.Convert.ToBase64String(keyBytes);

            //IV 16
            byte[] IVBytes = textConverter.GetBytes("0000020509463124");
            String IVString = System.Convert.ToBase64String(IVBytes);

            //Padding
            PaddingMode padding = PaddingMode.PKCS7;

            //Encrypt
            byte[] encryptedBytes = System.Convert.FromBase64String(PasswordEncriptado);

            //Decrypted
            byte[] decryptedBytes = CryptoUtils.decryptWithOptions(keyBytes, IVBytes, padding, encryptedBytes);
            String decryptedMessage = textConverter.GetString(decryptedBytes);

            decryptedMessage = decryptedMessage.Replace("\0", String.Empty);

            return decryptedMessage;
        }

        //---------------------------Hash SHA512----------------------------

        public static String PasswordEncriptarSHA512(String Password)
        {

            SHA512Managed HashTool = new SHA512Managed();

            Byte[] PhraseAsByte = Encoding.UTF8.GetBytes(string.Concat(Password));
            Byte[] EncryptedBytes = HashTool.ComputeHash(PhraseAsByte);
            HashTool.Clear();

            var result = Convert.ToBase64String(EncryptedBytes);

            return result;

        }


    }
}
