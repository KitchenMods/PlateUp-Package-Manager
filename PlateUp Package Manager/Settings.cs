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
    }
}
