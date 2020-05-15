namespace EncryptionPlugin
{
    public class Kernel : IFunctionalPlugin
    {
        public byte[] ProcessInput(byte[] data, string fileName)
        {
            var cryptoService = new CryptoService(fileName);
            return cryptoService.Decrypt(data);
        }

        public byte[] ProcessOutput(byte[] data, string fileName)
        {
            var cryptoService = new CryptoService(fileName);
            return cryptoService.Encrypt(data);
        }
    }
}
