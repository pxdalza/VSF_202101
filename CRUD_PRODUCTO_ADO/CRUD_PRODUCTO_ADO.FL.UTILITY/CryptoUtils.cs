using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_PRODUCTO_ADO.FL.UTILITY
{
    public class CryptoUtils
    {

        public static byte[] encryptWithOptions(byte[] keyBytes, byte[] ivBytes, PaddingMode padding, byte[] messageBytes)
        {
            RijndaelManaged cipher = getAESCBCCipher(keyBytes, ivBytes, padding);
            return encrypt(cipher, messageBytes);
        }

        public static byte[] decryptWithOptions(byte[] keyBytes, byte[] ivBytes, PaddingMode padding, byte[] encryptedMessageBytes)
        {
            RijndaelManaged decipher = getAESCBCCipher(keyBytes, ivBytes, padding);
            return decrypt(decipher, encryptedMessageBytes);
        }

        public static RijndaelManaged getAESCBCCipher(byte[] keyBytes, byte[] IVBytes, PaddingMode padding)
        {
            RijndaelManaged cipher = new RijndaelManaged();
            cipher.KeySize = 128;
            cipher.BlockSize = 128;
            cipher.Mode = CipherMode.CBC;
            cipher.Padding = padding;
            cipher.IV = IVBytes;
            cipher.Key = keyBytes;
            return cipher;
        }

        public static RijndaelManaged getAESECBCipher(byte[] keyBytes, PaddingMode padding)
        {
            RijndaelManaged cipher = new RijndaelManaged();
            cipher.KeySize = 128;
            cipher.BlockSize = 128;
            cipher.Mode = CipherMode.ECB;
            cipher.Padding = padding;
            cipher.Key = keyBytes;
            return cipher;
        }

        public static byte[] encrypt(RijndaelManaged cipher, byte[] toEncrypt)
        {
            ICryptoTransform encryptor = cipher.CreateEncryptor();
            MemoryStream msEncrypt = new MemoryStream();
            CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write);
            csEncrypt.Write(toEncrypt, 0, toEncrypt.Length);
            csEncrypt.FlushFinalBlock();
            return msEncrypt.ToArray();
        }

        public static byte[] decrypt(RijndaelManaged cipher, byte[] encrypted)
        {
            ICryptoTransform decryptor = cipher.CreateDecryptor();
            MemoryStream msDecrypt = new MemoryStream(encrypted);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read);
            byte[] fromEncrypt = new byte[encrypted.Length];
            csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
            return fromEncrypt;
        }

    }
}
