namespace EncryptionPlugin
{
    public interface IFunctionalPlugin
    {
        byte[] ProcessOutput(byte[] data, string fileName);

        byte[] ProcessInput(byte[] data, string fileName);
    }
}
