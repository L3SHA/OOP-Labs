using ZipPluginInterface;
using System.IO.Compression;
using System.IO;

namespace ZipArchivePlugin
{
    public class ZipArchivePlugin : IZipPlugin
    {
        public void UnZip(string srcPath, string destPath)
        {
            using (FileStream srcStream = new FileStream(srcPath, FileMode.OpenOrCreate))
            {
                using (FileStream targetStream = File.Create(destPath))
                {
                    using (GZipStream decompressionStream = new GZipStream(srcStream, CompressionMode.Decompress))
                    {
                        decompressionStream.CopyTo(targetStream);
                    }
                }
            }
        }

        public void Zip(string srcPath, string destPath)
        {
            using (FileStream srcStream = new FileStream(srcPath, FileMode.OpenOrCreate))
            {
                using (var destStream = new FileStream(destPath, FileMode.Create))
                {
                    using (GZipStream compressionStream = new GZipStream(destStream, CompressionMode.Compress))
                    {
                        srcStream.CopyTo(compressionStream);
                    }
                }
            }
        }
    }
}
