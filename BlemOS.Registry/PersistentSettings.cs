using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlemOS.Registry
{
    /// <summary>
    /// Persistent Settings class for storing items on the user's hard drive
    /// </summary>
    public static class PersistentSettings
    {
        public static PersistentSettingsObject internalSettings { get; set; }
        public static string appdataPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BlemOS");


        public static void load()
        {
            //See if the Storage Path or file is corrupted
            UpdatePersistentStoragePath();

            //Deserialize the persistent settings file and load it into the program
            internalSettings = JsonConvert.DeserializeObject<PersistentSettingsObject>(File.ReadAllText(Path.Combine(appdataPath, "_persistentStorage.json")));
        }


        public static void update()
        {
            //Write to the persistent storage file the internal copy of the structure
            File.WriteAllText(Path.Combine(appdataPath, "_persistentStorage.json"), JsonConvert.SerializeObject(internalSettings));
        }

        public static void UpdatePersistentStoragePath()
        {
            //Check if the persistent storage directories doesn't exist
            if (!Directory.Exists(appdataPath))
            {
                //Create the folders
                CreateFolders();
            }
            else
            {
                //Check if the persistent storage file doesn't exist
                if (!File.Exists(Path.Combine(appdataPath, "_persistentStorage.json")))
                {
                    //Create a new persistent storage file
                    FileStream persistentSettings = File.Create(Path.Combine(appdataPath, "_persistentStorage.json"));

                    //Set the setting in the program's setting file to equal the path of the persistent storage file
                    Properties.Settings.Default.PersistentSettingsPath = persistentSettings.Name;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();

                    //Close the connection to the write stream
                    persistentSettings.Close();
                }
                else
                {
                    //Set the settings in the program's setting file to the path of the persistent storage file
                    Properties.Settings.Default.PersistentSettingsPath = Path.Combine(appdataPath, "_persistentStorage.json");
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.Reload();
                }
            }
        }
        public static void CreateFolders()
        {
            //Create the folders in the user's appdatz
            Directory.CreateDirectory(appdataPath);

            //Create the persistent storage file
            FileStream persistentSettings = File.Create(Path.Combine(appdataPath, "_persistentStorage.json"));

            //Set the program's setting equal to the path of the persistent storage file
            Properties.Settings.Default.PersistentSettingsPath = persistentSettings.Name;
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();

            //Close the Write Stream
            persistentSettings.Close();
        }
    }
}
