using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoApplication
{
    class Settings
    {
        private string SaveFilePath;
        private string SettingsFilePath;

        private string GetSaveFilePathContent()
        {
            return SaveFilePath;
        }

        private string GetSettingsFilePath()
        {
            return SettingsFilePath;
        }

        public string[] GetUsers()
        {
            return new string[0];
        }

        public void ChangeSaveFilePath()
        {

        }

        public void ChangeSettingsFilePath()
        {

        }
    }
}
