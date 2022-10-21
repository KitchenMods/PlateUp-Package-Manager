using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PlateUp_Package_Manager
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();
		}

		private Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();

		private void Settings_Load(object sender, EventArgs e)
		{
			SetupList();
		}

		private void SetupList()
		{
			listBox1.Items.Clear();
			keyValuePairs.Clear();

			Dictionary<string, object> Settings = SettingsManager.GetAllSettings();

			if (Settings == null)
				return;
			
			foreach (string key in Settings.Keys)
			{
				keyValuePairs.Add(key + " : " + Settings[key], key);
				listBox1.Items.Add(key + " : " + Settings[key]);
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			SettingsManager.Set(textBox_key.Text, textBox_value.Text);
			SettingsManager.Save();
			SettingsManager.Load();
			SetupList();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex >= 0)
			{
				string key = keyValuePairs[listBox1.Items[listBox1.SelectedIndex].ToString()];
				SettingsManager.Remove(key);
				SettingsManager.Save();
				SettingsManager.Load();
				SetupList();
			}
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex >= 0)
			{
				string key = keyValuePairs[listBox1.Items[listBox1.SelectedIndex].ToString()];
				textBox_key.Text = key;
				textBox_value.Text = SettingsManager.Get<string>(key);
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void button4_Click(object sender, EventArgs e)
		{	
			if (VersionManager.IsCurrentVersionOutdated())
			{
				DialogResult dialogResult = MessageBox.Show("We've found an update! Do you want to install it?\n\n Once the update is downloaded, Manager will close.", "Manager Update!", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					UpdateManager.Update();
				}
			}
			
        }

        private void button5_Click(object sender, EventArgs e)
        {
			string[] allfiles = Directory.GetFiles("C:\\Users\\Pilch\\Downloads\\MelonLoader.x64\\", "*.*", SearchOption.AllDirectories);
			List<string> strings = new List<string>();
			foreach (string x in allfiles)
				strings.Add("\""+x.Replace("C:\\Users\\Pilch\\Downloads\\MelonLoader.x64\\", "")+"\",");
			File.WriteAllLines(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/tt.log", strings.ToArray());
			List<string> check = new List<string> { "",
			};
			List<string> log = new List<string>();
			log.Add("-----Verifying MelonLoader Install-----");
			List<string> checkLogs;
			bool isMLValid = MelonLoaderInstaller.VerifyMelonLoaderInstall(check, out checkLogs);
			foreach (string x in checkLogs)
				log.Add(x);

			if (isMLValid)
				log.Add("-----MelonLoader Valid-----");
			else
				log.Add("-----MelonLoader Invalid-----");
			log.Add("");
			log.Add("");
			log.Add("");

			if (SettingsManager.Get<string>("plateupfolder") != "")
			{
				string pup = SettingsManager.Get<string>("plateupfolder");
				log.Add("-----Mods Installed-----");
				log.Add("");
				if (Directory.Exists(pup + "/Mods"))
				{
					string[] files = Directory.GetFiles(pup + "/Mods");
					foreach (string x in files)
					{
						log.Add(x);
					}
				}
				log.Add("");
				log.Add("");
				log.Add("");
				log.Add("-----StreamingAssets Installed-----");
				log.Add("");
				if (Directory.Exists(pup + "/PlateUp_Data/StreamingAssets"))
				{
					string[] files = Directory.GetFiles(pup + "/PlateUp_Data/StreamingAssets");
					foreach (string x in files)
					{
						log.Add(x);
					}
				}
			}

			File.WriteAllLines(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/Debug.log", log.ToArray());
			MessageBox.Show("Debug Log Generated");
		}
    }
}
