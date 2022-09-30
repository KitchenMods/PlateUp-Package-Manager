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
	/*
	 * TODO: Create InstallPackage function
	 * TODO: Create RepositoryManager class
	 * TODO: Create Search function
	 */
	public partial class MainForm : Form
	{
		private Dictionary<string, string> installedPackagesListBoxKey = new Dictionary<string, string>();
		public MainForm()
		{
			InitializeComponent();
		}

        private void MainForm_Load(object sender, EventArgs e)
		{
			this.Size = new Size(816, 489);
			RefVars.UniversalOnFormLoad(this);
			Setup();
			SettingsManager.Load();
			SetUpPanels();
			SetActivePanel(panel_home);
		}

		private void Setup()
		{
			if (!File.Exists(RefVars.installedPackagesFilePath))
				return;
			PackageManager.LoadInstalledPackages();

			//PackageManager.AddInstalledPackage("modid", new PlateUpPackage("modid", "Mod Name", "1.0.0", "Some cool words", "ME", "http something?", new Dictionary<string, string> { { "sometext.txt", "somepath" } }));
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
			listBox_installed.Items.Clear();
			if (PackageManager.GetInstalledPackages() != null)
			{
				foreach (string key in PackageManager.GetInstalledPackages().Keys)
				{
					listBox_installed.Items.Add(PackageManager.GetInstalledPackages()[key].Name);
					installedPackagesListBoxKey.Add(PackageManager.GetInstalledPackages()[key].Name, key);
				}
			}
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

		private void button_installed_remove_Click(object sender, EventArgs e)
		{
			if (listBox_installed.SelectedIndex >= 0)
			{
				string key = installedPackagesListBoxKey[listBox_installed.SelectedItem.ToString()];
				PackageManager.UninstallPackage(PackageManager.GetInstalledPackage(key));
			}
		}
	}

	public class PackageManager
	{
		private static Dictionary<string, PlateUpPackage> installedPackages = new Dictionary<string, PlateUpPackage>();
		
		public static void LoadInstalledPackages()
		{
			SetInstalledPackages(JsonConvert.DeserializeObject<Dictionary<string, PlateUpPackage>>(File.ReadAllText(RefVars.installedPackagesFilePath)));
		}

		public static void SaveInstalledPackages()
		{
			File.WriteAllText(RefVars.installedPackagesFilePath, JsonConvert.SerializeObject(GetInstalledPackages()));
		}
		
		public static Dictionary<string, PlateUpPackage> GetInstalledPackages()
		{
			return installedPackages;
		}

		public static void SetInstalledPackages(Dictionary<string, PlateUpPackage> installedPackagesDic)
		{
			installedPackages = installedPackagesDic;
		}

		public static void AddInstalledPackage(string packageID, PlateUpPackage package)
		{
			installedPackages.Add(packageID, package);
		}

		public static void RemoveInstalledPackage(string packageID)
		{
			if (installedPackages.ContainsKey(packageID))
				installedPackages.Remove(packageID);
		}

		public static PlateUpPackage GetInstalledPackage(string packageID)
		{
			if (installedPackages.ContainsKey(packageID))
				return installedPackages[packageID];
			else
				return null;
		}

		public static void UninstallPackage(PlateUpPackage package)
		{
			Dictionary<string, string> fileLocations = package.FileLocations;
			string plateupfolder = SettingsManager.Get<string>("plateupfolder");
			foreach (string file in fileLocations.Keys)
			{
				Console.WriteLine(plateupfolder + "/" + fileLocations[file] + "/" + file);
				if (File.Exists(plateupfolder + "/" + fileLocations[file] + "/" + file))
					File.Delete(plateupfolder + "/" + fileLocations[file] + "/" + file);
				else
					Console.WriteLine("Failed to delete: " + plateupfolder + "/" + fileLocations[file] + "/" + file);
			}
			RemoveInstalledPackage(package.PackageID);
			SaveInstalledPackages();
		}
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

public class PlateUpRepo
{
	public string RepoName { get; set; }
	public string RepoURL { get; set; }
	public string RepoDescription { get; set; }

	public PlateUpRepo(string name, string url, string description)
	{
		RepoName = name;
		RepoURL = url;
		RepoDescription = description;
	}
}