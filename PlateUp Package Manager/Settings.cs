using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        private void Settings_Load(object sender, EventArgs e)
        {
			listBox1.Items.Clear();

			Dictionary<string, object> Settings = SettingsManager.GetAllSettings();

			foreach (string key in Settings.Keys)
			{
				listBox1.Items.Add(key + " : " + Settings[key]);
			}
        }
    }
}
