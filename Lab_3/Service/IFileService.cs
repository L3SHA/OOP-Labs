namespace Storehouse.Service
{
    public interface IFileService
    {
        void SaveToFile(string path, string str);

        string ReadFromFile(string path);
    }
}
