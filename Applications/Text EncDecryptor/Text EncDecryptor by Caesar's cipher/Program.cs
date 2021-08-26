using System;

namespace Text_EncDecryptor_by_Caesar_s_cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Set encryption turn: (1 - 1000)");
            int turn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nType message:\n");

            var encryptor = new MessageEncryptor(turn);
            var decryptor = new MessageDecryptor(turn);

            encryptor.Encrypt(Console.ReadLine());
            var encryptedMessage = encryptor.EncryptedData;

            Console.WriteLine("\n Encrypted message: " + encryptedMessage);

            decryptor.Decrypt(encryptor.EncryptedData);
            var decryptedMessage = decryptor.DecryptedData;

            Console.WriteLine("\n Decrypted message: " + decryptedMessage);
        }
    }
}
