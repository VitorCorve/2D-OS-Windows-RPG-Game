namespace Text_EncDecryptor_by_Caesar_s_cipher
{
    public class MessageDecryptor
    {
        public int Turn { get; set; }
        public string DecryptedData { get; private set; }
        public void Decrypt(string message)
        {
            for (int i = 0; i < message.Length; i++)
                DecryptedData += ((char)((int)message[i] - Turn));
        }
        public MessageDecryptor(int turn)
        {
            Turn = turn;
        }
    }
}
