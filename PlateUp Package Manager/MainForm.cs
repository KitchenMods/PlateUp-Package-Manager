using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace PlateUp_Package_Manager
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

        private void MainForm_Load(object sender, EventArgs e)
		{
			this.Size = new Size(816, 489);
			RefVars.UniversalOnFormLoad(this);

			PlateUpPackage pack = new PlateUpPackage("modid", "modname", "modversion", "moddesc", "modauthors", "modurl", new Dictionary<string, string> { { "somefile", "somefilelocation"} });
			File.WriteAllText(RefVars.packageManagerPath + "/somepackage.json", JsonConvert.SerializeObject(pack));

			SettingsManager.Load();

			SetUpPanels();
			SetActivePanel(panel_home);
		}

		private void SetUpPanels()
		{
			panel_home.Location = new Point(12, 12);
			panel_repositories.Location = new Point(12, 12);
			panel_installed.Location = new Point(12, 12);
			panel_search.Location = new Point(12, 12);
		}

		private void SetActivePanel(Panel panel)
		{
			panel_home.Visible = false;
			panel_repositories.Visible = false;
			panel_installed.Visible = false;
			panel_search.Visible = false;

			panel.Visible = true;
		}

		private void button_home_Click(object sender, EventArgs e)
		{
			SetActivePanel(panel_home);
		}

		private void button_repositories_Click(object sender, EventArgs e)
		{
			SetActivePanel(panel_repositories);
		}

		private void button_installed_Click(object sender, EventArgs e)
		{
			SetActivePanel(panel_installed);
		}

		private void button_search_Click(object sender, EventArgs e)
		{
			SetActivePanel(panel_search);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Settings settingsMenu = new Settings();

			settingsMenu.Show();
		}
	}

	public class PlateUpPackage
	{
		public string PackageID { get; set; }
		public string Name { get; set; }
		public string Version { get; set; }
		public string Description { get; set; }
		public string Author { get; set; }
		public string URL { get; set; }
		public Dictionary<string, string> FileLocations { get; set; }

		public PlateUpPackage(string packageID, string name, string version, string description, string author, string url, Dictionary<string, string> fileLocations)
		{
			PackageID = packageID;
			Name = name;
			Version = version;
			Description = description;
			Author = author;
			URL = url;
			FileLocations = fileLocations;
		}
	}
}
