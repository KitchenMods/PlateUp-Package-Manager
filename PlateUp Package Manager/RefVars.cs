using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.ComponentModel.Design;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace PlateUp_Package_Manager
{
	public class RefVars
	{
		public static string softwareVersion = "0.2.0";

		
		public static string applicationDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/";
		public static string packageManagerPath = applicationDataPath + "PlateUp Package Manager/";
		public static string packageManagerTempPath = packageManagerPath + "Temp/";

		public static string settingsFilePath = packageManagerPath + "settings.json";
		public static string installedPackagesFilePath = packageManagerPath + "installedPackages.json";
		public static string installedReposFilePath = packageManagerPath + "installedRepos.json";

		public static void MakeSureDirectoryExists(string path)
		{
			if (!Directory.Exists(path))
				Directory.CreateDirectory(path);
		}

		public static void MakeSureFileExists(string path)
		{
			if (!File.Exists(path))
				File.Create(path);
		}

		public static void UniversalOnFormLoad(Form form)
		{
			form.Text = form.Text + " v" + softwareVersion;
		}
	}

	public class SettingsManager
	{
		private static Dictionary<string, object> Settings = new Dictionary<string, object>();

		public static void SetupSettings()
		{
			Load();
		}

		public static void Save()
		{
			File.WriteAllText(RefVars.settingsFilePath, JsonConvert.SerializeObject(Settings));
		}

		public static void Load()
		{
			if (!File.Exists(RefVars.settingsFilePath))
				return;
			Dictionary<string, object> settings = JsonConvert.DeserializeObject<Dictionary<string, object>>(File.ReadAllText(RefVars.settingsFilePath));
			Settings = settings;
		}

		public static void Set(string key, object value)
		{
			if (Settings.ContainsKey(key))
				Settings[key] = value;
			else
				Settings.Add(key, value);
		}

		public static void Remove(string key)
		{
			if (Settings.ContainsKey(key))
				Settings.Remove(key);
		}

		public static T Get<T>(string key)
		{
			if (Settings.ContainsKey(key))
				return (T)Settings[key];
			else
				return default(T);
		}

		public static Dictionary<string, object> GetAllSettings()
		{
			return Settings;
		}
	}
}
