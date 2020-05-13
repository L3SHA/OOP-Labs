using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZipPluginInterface
{
    public interface IZipPlugin
    {
        void Zip(string srcPath, string destPath);

        void UnZip(string srcPath, string destPath);
    }
}
