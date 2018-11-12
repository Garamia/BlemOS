using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlemOS.Registry
{

    public static class PersistentSettings
    {
        public static PersistentSettingsObject internalSettings { get; set; }
        public static string appdataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BlemOS");

        public static void load()
        {
            UpdatePersistentStoragePath();

            internalSettings = JsonConvert.DeserializeObject<PersistentSettingsObject>(File.ReadAllText(Path.Combine(appdataPath, "_persistentStorage.json")));
        }


        public static void update()
        {
            File.WriteAllText(Path.Combine(appdataPath, "_persistentStorage.json"), JsonConvert.SerializeObject(internalSettings));
        }

        public static void UpdatePersistentStoragePath()
        {
            if (!Directory.Exists(appdataPath))
            {
                CreateFolders();
            }
            else
            {
                if (!File.Exists(Path.Combine(appdataPath, "_persistentStorage.json")))
                {
                    FileStream persistentSettings = File.Create(Path.Combine(appdataPath, "_persistentStorage.json"));

                    Properties.Settings.Default.PersistentSettingsPath = persistentSettings.Name;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();

                    persistentSettings.Close();
                }
                else
                {
                    Properties.Settings.Default.PersistentSettingsPath = Path.Combine(appdataPath, "_persistentStorage.json");
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                }
            }
        }
        public static void CreateFolders()
        {
            Directory.CreateDirectory(appdataPath);

            FileStream persistentSettings = File.Create(Path.Combine(appdataPath, "_persistentStorage.json"));
            Properties.Settings.Default.PersistentSettingsPath = persistentSettings.Name;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

            persistentSettings.Close();
        }
    }
}
