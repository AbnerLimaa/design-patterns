using Common.Singleton;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Sample.Problems.LoadFile
{
    public class AppSettings : ISingleton
    {
        private static AppSettings instance;

        public static AppSettings INSTANCE
        {
            get
            {
                if (instance == null)
                    instance = new AppSettings();
                return instance;
            }
        }

        public Settings Settings { get; private set; }

        private AppSettings()
        {
            this.LoadSettings();
        }

        private void LoadSettings()
        {
            using (StreamReader reader = new StreamReader(@"Problems/LoadFile/settings.json"))
            {
                string json = reader.ReadToEnd();
                this.Settings = JsonConvert.DeserializeObject<Settings>(json);
            }
        }
    }
}
