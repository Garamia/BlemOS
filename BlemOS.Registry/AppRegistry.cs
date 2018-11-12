
using BlemOS.Engine;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlemOS.Registry
{
    /// <summary>
    /// Registry for storing the apps
    /// </summary>
    public static class AppRegistry
    {
        //Create a local registry and a custom registry 
        static List<KeyValuePair<string, Type>> registry = new List<KeyValuePair<string, Type>>();
        static List<KeyValuePair<string, UserControl>> customRegistry = new List<KeyValuePair<string, UserControl>>();
        static WindowManger wm = new WindowManger();

        public static void registerApp(Type type, string name)
        {
            //Add the app to the Registry
            registry.Add(new KeyValuePair<string, Type>(name, type));
        }

        public static void registerCustomApp(UserControl uc, string name)
        {
            //Add the custom app to the registry
            customRegistry.Add(new KeyValuePair<string, UserControl>(name, uc));
        }

        public static void loadApp(string name)
        {
            //Loop through the apps in the registry and look for the one that was asked for
            foreach(KeyValuePair<string, Type> key in registry)
            {
                //If the app was found, call the window manager to initialize a new window
                if (key.Key == name) wm.initWindow((UserControl)Activator.CreateInstance(key.Value), name);
            }
        }

        public static void loadCustomApp(string name)
        {
            //Loop through the custom apps in the registry and look for the one that was asked for
            foreach (KeyValuePair<string, UserControl> key in customRegistry)
            {
                //If the custom app was found, call the window manager to initialize a new window
                if (key.Key == name) wm.initWindow(key.Value, name);
            }
        }
        public static List<string> listApps()
        {
            List<string> apps = new List<string>();

            //Loop through all the apps, adding each one into the list
            foreach(KeyValuePair<string, Type> key in registry)
            {
                apps.Add(key.Key);
            }
            return apps;
        }

        public static void loadMessageDialog(string title, string text)
        {
            //Prompt a message box with the given text and tite;
            wm.ShowMessage(text, title);
        }
    }
}
