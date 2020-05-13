using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using SerializerInterface;
using ZipPluginInterface;

namespace Storehouse.PluginAPI
{
    class PluginManager
    {
        private readonly string PathToAppPlugins = Path.Combine(Directory.GetCurrentDirectory(), "Plugins"); 

        public PluginManager()
        {
            SerializerPlugins = GetPluginsList<ISerializerPlugin>(PathToAppPlugins + "/SerializationPlugins/");
            ZipPlugins = GetPluginsList<IZipPlugin>(PathToAppPlugins + "/CompressPlugins/");
        }

        public List<ISerializerPlugin> SerializerPlugins { private set; get; }
        public List<IZipPlugin> ZipPlugins { private set; get; }

        private List<T> GetPluginsList<T>(string pluginPath)
        {
            var pluginList = new List<T>();
            DirectoryInfo pluginDirectory = new DirectoryInfo(pluginPath);
            if (!pluginDirectory.Exists)
                pluginDirectory.Create();
            var pluginFiles = Directory.GetFiles(pluginPath, "*.dll");
            foreach (var file in pluginFiles)
            {
                if(IsValidPlugin(file))
                {
                    Assembly asm = Assembly.LoadFrom(file);
                    var types = asm.GetTypes().Where(t => t.GetInterfaces().Where(i => i.FullName == typeof(T).FullName).Any());
                    foreach (var type in types)
                    {
                        var plugin = asm.CreateInstance(type.FullName);
                        if (plugin is T)
                        {
                            pluginList.Add((T)plugin);
                        }
                        
                    }
                }
                
            }
            return pluginList;
        }

        private static bool IsEqual(byte[] first, byte[] second)
        {
            bool result = true;
            if (first.Length != second.Length)
                return false;
            for (int i = 0; i < first.Length; i++)
            {
                if (first[i] != second[i])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }

        private static bool IsValidPlugin(string fileName)
        {
            try
            {
                AssemblyName asmName = AssemblyName.GetAssemblyName(fileName);
                AssemblyName selfAsmName = Assembly.GetExecutingAssembly().GetName();
                if (IsEqual(asmName.GetPublicKeyToken(), selfAsmName.GetPublicKeyToken()))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }
    }
}
