// ModManager.cs

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ModLoader
{
    public class Mod
    {
        public string Name { get; set; }
        public string Version { get; set; }
        public string Path { get; set; }

        public Mod(string name, string version, string path)
        {
            Name = name;
            Version = version;
            Path = path;
        }
    }

    public class ModManager
    {
        private List<Mod> mods;

        public ModManager()
        {
            mods = new List<Mod>();
        }

        public void LoadMods(string directory)
        {
            if (!Directory.Exists(directory))
            {
                throw new DirectoryNotFoundException($"Directory '{directory}' not found.");
            }

            var modFiles = Directory.GetFiles(directory, "*.mod");
            foreach (var modFile in modFiles)
            {
                var modData = File.ReadAllLines(modFile);
                var mod = new Mod(modData[0], modData[1], modFile);
                mods.Add(mod);
                Console.WriteLine($"Loaded mod: {mod.Name} v{mod.Version}");
            }
        }

        public void UnloadMod(string modName)
        {
            var mod = mods.FirstOrDefault(m => m.Name == modName);
            if (mod != null)
            {
                mods.Remove(mod);
                Console.WriteLine($"Unloaded mod: {mod.Name}");
            }
            else
            {
                Console.WriteLine($"Mod '{modName}' not found.");
            }
        }

        public void ListMods()
        {
            Console.WriteLine("Available Mods:");
            foreach (var mod in mods)
            {
                Console.WriteLine($"- {mod.Name} v{mod.Version}");
            }
        }
    }
}