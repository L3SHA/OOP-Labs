namespace EncryptionPlugin
{
    public interface IEncoder
    {
        byte[] Encrypt(byte[] data);

        byte[] Decrypt(byte[] data);
    }
}
