
using BlemOS.Engine;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BlemOS.Registry
{
    public static class AppRegistry
    {
        static List<KeyValuePair<string, Type>> registry = new List<KeyValuePair<string, Type>>();
        static List<KeyValuePair<string, UserControl>> customRegistry = new List<KeyValuePair<string, UserControl>>();
        static WindowManger wm = new WindowManger();

        public static void registerApp(Type type, string name)
        {
            registry.Add(new KeyValuePair<string, Type>(name, type));
        }

        public static void registerCustomApp(UserControl uc, string name)
        {
            customRegistry.Add(new KeyValuePair<string, UserControl>(name, uc));
        }

        public static void loadApp(string name)
        {
            foreach(KeyValuePair<string, Type> key in registry)
            {
                if (key.Key == name) wm.initWindow((UserControl)Activator.CreateInstance(key.Value), name);
            }
        }

        public static void loadCustomApp(string name)
        {
            foreach (KeyValuePair<string, UserControl> key in customRegistry)
            {
                if (key.Key == name) wm.initWindow(key.Value, name);
            }
        }
        public static List<string> listApps()
        {
            List<string> apps = new List<string>();
            foreach(KeyValuePair<string, Type> key in registry)
            {
                apps.Add(key.Key);
            }
            return apps;
        }

        public static void loadMessageDialog(string title, string text)
        {
            wm.ShowMessage(text, title);
        }
    }
}
