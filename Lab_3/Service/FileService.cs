using System.IO;
using System.Text;

namespace Storehouse.Service
{
    public class FileService : IFileService
    {
        public string ReadFromFile(string path)
        {
            string str;
            using (var sr = new StreamReader(path, Encoding.Default))
            {
                str = sr.ReadToEnd();
            }
            return str;
        }

        public void SaveToFile(string path, string str)
        {
            using (var sw = new StreamWriter(path, true, Encoding.Default))
            {
                sw.Write(str);
                sw.Flush();
            }
        }
    }
}
