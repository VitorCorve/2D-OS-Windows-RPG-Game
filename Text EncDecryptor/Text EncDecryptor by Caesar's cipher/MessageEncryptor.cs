namespace Text_EncDecryptor_by_Caesar_s_cipher
{
    public  class MessageEncryptor
    {
        public int Turn { get; set; }
        public string EncryptedData { get; private set; }
        public char[] EncryptedDataArray { get; private set; }
        public void Encrypt(string message)
        {
            EncryptedDataArray = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                EncryptedDataArray[i] = ((char)((int)message[i] + Turn));
                EncryptedData += EncryptedDataArray[i];
            }
        }
        public MessageEncryptor(int turn)
        {
            Turn = turn;
        }
    }
}
