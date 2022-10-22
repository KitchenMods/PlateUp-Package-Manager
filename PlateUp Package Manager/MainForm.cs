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
using PlateUp_Package_Manager;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.IO.Compression;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PlateUp_Package_Manager
{
	public partial class MainForm : Form
	{
		private Dictionary<string, Package> installedPackagesListBoxKey = new Dictionary<string, Package>();
		private Dictionary<string, Repository> installedReposListBoxKey = new Dictionary<string, Repository>();
		private Dictionary<string, Package> searchedPackagesListBoxKey = new Dictionary<string, Package>();

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			//Package c = new Package("someid","somename","somedesc","someuath","somever","someurl", new Dictionary<string, string> { { "somepath" , "somefile"} });
			//File.WriteAllText("c.json",JsonConvert.SerializeObject(c));

			Package p = JsonToPackage(File.ReadAllText("c.json"));

			Console.WriteLine(p.Name);

			this.Size = new Size(816, 505);
			this.MaximumSize = new Size(816, 505);
			this.MinimumSize = new Size(816, 505);
			RefVars.UniversalOnFormLoad(this);
			SettingsManager.Load();
			Setup();
			SetUpPanels();
			SetActivePanel(panel_home);

			if (Directory.Exists(SettingsManager.Get<string>("plateupfolder") + "/BepInEx"))
			{
				DialogResult dialogResult = MessageBox.Show("We've detected BepInEx is already installed in PlateUp, this WILL cause issues with MelonLoader mods.\nDo you want to uninstall BepInEx?\n\nIf you don't uninstall BepInEx, this application will close.", "WARNING!", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/BepInEx", true);
					ForceDeleteFile(SettingsManager.Get<string>("plateupfolder") + "/winhttp.dll");
					ForceDeleteFile(SettingsManager.Get<string>("plateupfolder") + "/doorstop_config.ini");
					ForceDeleteFile(SettingsManager.Get<string>("plateupfolder") + "/changelog.txt");
				}
				else
				{
					Application.Exit();
				}
			}

			if (Directory.Exists(RefVars.applicationDataPath + "/PlateUpModManager"))
			{
				DialogResult dialogResult = MessageBox.Show("We've detected another PlateUp manager, did you want to remove this?", "Another Manager?", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/MelonLoader", true);
					ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/Mods", true);
					ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/Plugins", true);
					ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/UserData", true);
					ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/UserLibs", true);
					ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/PlateUp_Data/StreamingAssets", true);
					ForceDeleteDir(RefVars.applicationDataPath + "/PlateUpModManager", true);

					ForceDeleteFile(SettingsManager.Get<string>("plateupfolder") + "/NOTICE.txt");
					ForceDeleteFile(SettingsManager.Get<string>("plateupfolder") + "/version.dll");
				}
			}
			
			if (!Directory.Exists(SettingsManager.Get<string>("plateupfolder") + "/MelonLoader"))
			{
				//ML not installed
				DialogResult dialogResult = MessageBox.Show("Melonloader doesn't seem to be installed, it's required to run mods! Do you want to install it now?", "MelonLoader Missing", MessageBoxButtons.YesNo);
				if (dialogResult == DialogResult.Yes)
				{
					MelonLoaderInstaller.installMelonLoader(this);
				}
			}
		}

		public Package JsonToPackage(string json)
		{
			Package package = JsonConvert.DeserializeObject<Package>(json);
			return package;
		}

		public string PackageToJson(Package package)
		{
			return JsonConvert.SerializeObject(package);
		}

		public void RefreshMLInstallState()
		{
			if (Directory.Exists(SettingsManager.Get<string>("plateupfolder") + "/MelonLoader"))
			{
				button_installML.Enabled = false;
				button_uninstallML.Enabled = true;
			}
			else
			{
				button_installML.Enabled = true;
				button_uninstallML.Enabled = false;
			}
		}

		public void SetProgessBar(int percent)
		{
			progressBar1.Value = percent;
		}

		public void SetMLProgress(int percent)
		{
			progressBar2.Value = percent;
		}

		public void Log(string msg)
		{
			label_logger.Text = msg;
		}


		private void Setup()
		{
			PackageManager.Setup(RefVars.installedPackagesFilePath, this);
			RepositoryManager.Setup(RefVars.installedReposFilePath, this);
			if (Directory.Exists(RefVars.packageManagerTempPath))
				Directory.Delete(RefVars.packageManagerTempPath, true);
			RefreshMLInstallState();

			label_selectedInstalledPackageInformation.Text = "";
			label_selectedInstalledRepoInformation.Text = "";
			label_selectedSearchPackageInformation.Text = "";
			label_logger.Text = "";

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
			RefreshInstalledRepositories();
		}


		private void button_installed_Click(object sender, EventArgs e)
		{
			SetActivePanel(panel_installed);
			RefreshInstalledPackagesPage();
		}

		private void button_search_Click(object sender, EventArgs e)
		{
			SetActivePanel(panel_search);
			RefreshSearchPage();
		}

		private void button_settings_Click(object sender, EventArgs e)
		{
			Settings settingsMenu = new Settings();

			settingsMenu.Show();
		}

		private void button_installed_remove_Click(object sender, EventArgs e)
		{
			if (listView_installed.SelectedItems.Count > 0)
			{
				PackageManager.UninstallPackage(installedPackagesListBoxKey[listView_installed.SelectedItems[0].Text]);
				RefreshInstalledPackagesPage();
			}
		}

		private void RefreshInstalledPackagesPage()
		{
			listView_installed.Clear();
			listView_installed.Columns.Add("", -2);
			installedPackagesListBoxKey.Clear();
			foreach (Package package in PackageManager.GetInstalledPackages())
			{
				if (!installedPackagesListBoxKey.ContainsKey(package.Name + " v" + package.Version))
				{
					installedPackagesListBoxKey.Add(package.Name + " v" + package.Version, package);
					ListViewItem item = listView_installed.Items.Add(package.Name + " v" + package.Version);
				}
			}
		}

		private void RefreshInstalledRepositories()
		{
			listView_repos_installedrepos.Clear();
			listView_repos_installedrepos.Columns.Add("", -2);
			installedReposListBoxKey.Clear();
			foreach (Repository repo in RepositoryManager.GetInstalledRepositories())
			{
				if (!installedReposListBoxKey.ContainsKey(repo.Name))
				{
					installedReposListBoxKey.Add(repo.Name, repo);
					ListViewItem item = listView_repos_installedrepos.Items.Add(repo.Name);
				}
			}
		}

		public void RefreshSearchPage()
		{
			listView_search.Clear();
			listView_search.Columns.Add("", -2);
			searchedPackagesListBoxKey.Clear();
			foreach (Repository repo in RepositoryManager.GetInstalledRepositories())
			{
				foreach (Package package in repo.Packages)
				{
					if (!PackageManager.IsPackageInstalled(package))
					{
						searchedPackagesListBoxKey.Add(package.Name + " v" + package.Version, package);
						ListViewItem item = listView_search.Items.Add(package.Name + " v" + package.Version);
					}
				}
			}
		}

		private void button_manuallInstall_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Select PlateUp.exe";
			dialog.ShowDialog();
			if (dialog.FileName != "")
			{
				PackageManager.InstallPackage(dialog.FileName);
				RefreshInstalledPackagesPage();
			}
		}

		private void listView_installed_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView_installed.SelectedItems.Count > 0)
			{
				Package package = installedPackagesListBoxKey[listView_installed.SelectedItems[0].Text];
				label_selectedInstalledPackageInformation.Text = "Name: " + package.Name + "\nVersion: " + package.Version + "\nAuthor: " + package.Author + "\nDescription: " + package.Description;
				button_installed_remove.Enabled = true;
			}
			else
			{
				button_installed_remove.Enabled = false;
				label_selectedInstalledPackageInformation.Text = "";
			}
		}

		private void button_addrepo_Click(object sender, EventArgs e)
		{
			string url = textBox_addrepo.Text;
			if (RepositoryManager.IsRepositoryValid(url))
			{
				if (RepositoryManager.AddInstalledRepository(RepositoryManager.GetRepositoryInfo(url)))
				{
					RefreshInstalledRepositories();
				}
			}
			else
				Log("Repository: " + url + " is not valid");
		}

		private void button_repos_remove_Click(object sender, EventArgs e)
		{
			if (listView_repos_installedrepos.SelectedItems.Count > 0)
			{
				RepositoryManager.RemoveInstalledRepository(installedReposListBoxKey[listView_repos_installedrepos.SelectedItems[0].Text]);
				RefreshInstalledRepositories();
			}
		}

		private void listView_repos_installedrepos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView_repos_installedrepos.SelectedItems.Count > 0)
			{
				Repository repo= installedReposListBoxKey[listView_repos_installedrepos.SelectedItems[0].Text];
				label_selectedInstalledRepoInformation.Text = "Name: " + repo.Name + "\nDescription: " + repo.Description + "\nURL: " + repo.URL;
				button_repos_remove.Enabled = true;
			}
			else
			{
				button_repos_remove.Enabled = false;
				label_selectedInstalledRepoInformation.Text = "";
			}
		}

		private void button_search_refresh_Click(object sender, EventArgs e)
		{
			List<string> repos = new List<string>();
			foreach (Repository repo in RepositoryManager.GetInstalledRepositories())
			{
				repos.Add(repo.URL);
			}

			RepositoryManager.SetInstalledRepositories(new List<Repository>());

			foreach (string repo in repos)
			{
				RepositoryManager.AddInstalledRepository(RepositoryManager.GetRepositoryInfo(repo));
			}

			RefreshInstalledRepositories();
			RefreshSearchPage();
		}

		private void listView_search_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView_search.SelectedItems.Count > 0)
			{
				Package package = searchedPackagesListBoxKey[listView_search.SelectedItems[0].Text];
				label_selectedSearchPackageInformation.Text = "Name: " + package.Name + "\nVersion: " + package.Version + "\nAuthor: " + package.Author + "\nDescription: " + package.Description;
				button_searchInstall.Enabled = true;
			}
			else
			{
				button_searchInstall.Enabled = false;
				label_selectedSearchPackageInformation.Text = "";
			}
		}

		private void button_searchInstall_Click(object sender, EventArgs e)
		{
			if (listView_search.SelectedItems.Count > 0)
			{
				Package package = searchedPackagesListBoxKey[listView_search.SelectedItems[0].Text];
				string downloadPath = package.URL + "/packages/" + package.ID + "/" + package.ID + "-" + package.Version + ".plateupmod";
				PackageManager.InstallRemotePackage(downloadPath, package);
			}
		}

		private void textBox_searchField_TextChanged(object sender, EventArgs e)
		{
			string search = textBox_searchField.Text;
			listView_search.Clear();
			listView_search.Columns.Add("", -2);
			foreach (string packagename in searchedPackagesListBoxKey.Keys)
			{
				if (packagename.Contains(search))
				{
					ListViewItem item = listView_search.Items.Add(packagename);
				}
			}
		}

		private void button_installML_Click(object sender, EventArgs e)
		{
			MelonLoaderInstaller.installMelonLoader(this);
		}

		private void ForceDeleteDir(string path, bool recursive)
		{
			if (Directory.Exists(path))
				Directory.Delete(path, recursive);
		}

		private void ForceDeleteFile(string path)
		{
			if (File.Exists(path))
				File.Delete(path);
		}
		private void button_uninstallML_Click(object sender, EventArgs e)
		{
			List<Package> packs = new List<Package>();
			foreach (Package package in PackageManager.GetInstalledPackages())
			{
				packs.Add(package);
			}
			foreach (Package package in packs)
			{
				PackageManager.UninstallPackage(package);
			}
			RefreshInstalledPackagesPage();
			RefreshSearchPage();

			ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/MelonLoader", true);
			ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/Mods", true);
			ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/Plugins", true);
			ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/UserData", true);
			ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/UserLibs", true);
			ForceDeleteDir(SettingsManager.Get<string>("plateupfolder") + "/PlateUp_Data/StreamingAssets", true);

			ForceDeleteFile(SettingsManager.Get<string>("plateupfolder") + "/NOTICE.txt");
			ForceDeleteFile(SettingsManager.Get<string>("plateupfolder") + "/version.dll");
			Log("MelonLoader Uninstalled.");
			RefreshMLInstallState();
		}
	}

	public class PackageManager
	{
		private static List<Package> InstalledPackages = new List<Package>();
		private static MainForm MainForm;

		/*
		 * Package Managment
		 */

		public static void InstallPackage(string path)
		{
			RefVars.MakeSureDirectoryExists(RefVars.packageManagerTempPath);
			ZipFile.ExtractToDirectory(path, RefVars.packageManagerTempPath);
			Package package = JsonConvert.DeserializeObject<Package>(File.ReadAllText(RefVars.packageManagerTempPath + "PACKAGE.json"));
			MainForm.Log("Installing package " + package.Name + " v" + package.Version + "...");

			foreach (string paths in package.FilePaths.Values)
			{
				RefVars.MakeSureDirectoryExists(SettingsManager.Get<string>("plateupfolder") + "/" + paths);
			}

			foreach (string file in package.FilePaths.Keys)
			{
				File.Copy(RefVars.packageManagerTempPath + file, SettingsManager.Get<string>("plateupfolder") + package.FilePaths[file] + "/" + file, true);
			}

			Directory.Delete(RefVars.packageManagerTempPath, true);

			AddInstalledPackage(package);
			SaveInstalledPackages();
			MainForm.Log("Installed package " + package.Name + " v" + package.Version);
		}

		public static void UninstallPackage(Package package)
		{
			//Uninstall package files

			MainForm.Log("Uninstalling package " + package.Name + " v" + package.Version + "...");
			foreach (string file in package.FilePaths.Keys)
			{
				if (File.Exists(SettingsManager.Get<string>("plateupfolder") + package.FilePaths[file] + "/" + file))
					File.Delete(SettingsManager.Get<string>("plateupfolder") + package.FilePaths[file] + "/" + file);
			}

			RemoveInstalledPackage(package);
			SaveInstalledPackages();
			MainForm.Log("Uninstalled package " + package.Name + " v" + package.Version);
		}

		/*
		 * Installed Package Managment
		 */

		public static void Setup(string path, MainForm mainForm)
		{
			if (File.Exists(path))
				LoadInstalledPackages();
			else
				SetInstalledPackages(new List<Package>());

			MainForm = mainForm;
		}

		public static void LoadInstalledPackages()
		{
			List<Package> installedPackages = JsonConvert.DeserializeObject<List<Package>>(File.ReadAllText(RefVars.installedPackagesFilePath));
			InstalledPackages = installedPackages;
		}

		public static void SaveInstalledPackages()
		{
			File.WriteAllText(RefVars.installedPackagesFilePath, JsonConvert.SerializeObject(InstalledPackages));
		}

		public static List<Package> GetInstalledPackages()
		{
			return InstalledPackages;
		}

		public static void SetInstalledPackages(List<Package> installedPackages)
		{
			InstalledPackages = installedPackages;
		}

		public static bool IsPackageInstalled(Package package)
		{
			foreach (Package pack in InstalledPackages)
			{
				if (pack.ID == package.ID && pack.Name == package.Name && pack.Version == package.Version)
					return true;
			}
			return false;
		}

		private static bool AddInstalledPackage(Package package)
		{
			int doesContain = 0;
			Package identicalPack = null;
			foreach (Package pack in InstalledPackages)
			{
				if (pack.Name == package.Name && pack.ID == package.ID)
				{
					if (pack.Version != package.Version)
					{
						doesContain = 2;
						identicalPack = pack;
					}
					else
					{
						doesContain = 1;
					}
					break;
				}
			}

			if (doesContain == 0)
			{
				InstalledPackages.Add(package);
				return true;
			}
			else if (doesContain == 2)
			{
				if (identicalPack != null)
				{
					RemoveInstalledPackage(identicalPack);
					InstalledPackages.Add(package);
					return true;
				}
				return false;
			}
			else
				return false;
		}

		private static bool RemoveInstalledPackage(Package package)
		{
			foreach (Package pack in InstalledPackages)
			{
				if (pack.Name == package.Name && pack.ID == package.ID)
				{
					InstalledPackages.Remove(pack);
					return true;
				}
			}
			return false;
		}
		private static Package currentlyInstalling;
		public static void InstallRemotePackage(string downloadURL, Package package)
		{
			RefVars.MakeSureDirectoryExists(RefVars.packageManagerTempPath);
			WebClient webClient = new WebClient();
			currentlyInstalling = package;
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
			webClient.DownloadFileAsync(new Uri(downloadURL), RefVars.packageManagerTempPath + "/" + package.ID + "-" + package.Version + ".plateupmod");
			MainForm.Log("Downloading " + package.Name + "...");
		}

		private static void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			MainForm.SetProgessBar(e.ProgressPercentage);
		}
		private static void Completed(object sender, AsyncCompletedEventArgs e)
		{
			if (currentlyInstalling != null)
			{
				InstallPackage(RefVars.packageManagerTempPath + "/" + currentlyInstalling.ID + "-" + currentlyInstalling.Version + ".plateupmod");
				currentlyInstalling = null;
				MainForm.RefreshSearchPage();
			}
		}

		/*
		 * Remote Package Managment
		 */
	}

	public class RepositoryManager
	{

		private static List<Repository> InstalledRepositories = new List<Repository>();
		private static MainForm MainForm;

		public static void Setup(string path, MainForm mainForm)
		{
			if (File.Exists(path))
				LoadInstalledRepositories();
			else
				SetInstalledRepositories(new List<Repository>());

			MainForm = mainForm;
		}

		public static void LoadInstalledRepositories()
		{
			InstalledRepositories = JsonConvert.DeserializeObject<List<Repository>>(File.ReadAllText(RefVars.installedReposFilePath));
		}

		public static void SaveInstalledRepositories()
		{
			File.WriteAllText(RefVars.installedReposFilePath, JsonConvert.SerializeObject(InstalledRepositories));
		}

		public static bool AddInstalledRepository(Repository repository)
		{
			if (InstalledRepositories.Contains(repository))
				return false;

			InstalledRepositories.Add(repository);
			SaveInstalledRepositories();
			MainForm.Log("Repository Added: " + repository.Name);
			return true;
		}

		public static bool RemoveInstalledRepository(Repository repository)
		{
			foreach (Repository repo in InstalledRepositories)
			{
				if (repo.Name == repository.Name && repo.Description == repository.Description)
				{
					InstalledRepositories.Remove(repo);
					SaveInstalledRepositories();
					MainForm.Log("Repository Removed: " + repository.Name);
					return true;
				}
			}
			return false;
		}

		public static void SetInstalledRepositories(List<Repository> repositories)
		{
			InstalledRepositories = repositories;
		}

		public static List<Repository> GetInstalledRepositories()
		{
			return InstalledRepositories;
		}

		public static bool IsRepositoryValid(string URL)
		{
			if (GetHTMLFromURL(URL + "/REPO") == "")
				return false;
			return true;
		}

		public static Repository GetRepositoryInfo(string URL)
		{
			Repository repository = JsonConvert.DeserializeObject<Repository>(GetHTMLFromURL(URL + "/REPO"));
			return repository;
		}

		public static List<Package> GetRepositoryPackages(Repository repository)
		{
			return repository.Packages;
		}

		private static string GetHTMLFromURL(string url)
		{
			using (WebClient web1 = new WebClient())
			{
				try
				{
					string data = web1.DownloadString(url);
					return data;
				}
				catch
				{
					return "";
				}
			}
		}
	}

	public class PackageDependency
	{
		public string ID { get; set; }
		public string Author { get; set; }
		public string Version { get; set; }
	}

	public class Package
	{
		public string ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Author { get; set; }
		public string Version { get; set; }
		public string URL { get; set; }
		public List<string> Depends = new List<string>();
		public Dictionary<string, string> FilePaths { get; set; }

		public Package(string id, string name, string description, string author, string version, string url, Dictionary<string, string> filePaths)
		{
			ID = id;
			Name = name;
			Description = description;
			Author = author;
			Version = version;
			URL = url;
			FilePaths = filePaths;
		}
	}

	public class Repository
	{
		public string Name { get; set; }
		public string URL { get; set; }
		public string Description { get; set; }
		public List<Package> Packages { get; set; }

		public Repository(string name, string url, string description, List<Package> packages)
		{
			Name = name;
			URL = url;
			Description = description;
			Packages = packages;
		}
	}
	public class MelonLoaderInstaller
	{
		private static WebClient webClient = null;
		private static MainForm MainForm;
		public static bool VerifyMelonLoaderInstall(List<string> filesToCheck, out List<string> checkLogs)
		{
			bool result = true;
			string pup = "";
			checkLogs = new List<string>();
			if (SettingsManager.Get<string>("plateupfolder") == "") // Does PlateUpFolder Exist
				result = false;
			else
				pup = SettingsManager.Get<string>("plateupfolder");

			foreach (string file in filesToCheck)
			{
				if (File.Exists(pup + "/" + file))
					checkLogs.Add("Valid: " + pup + "/" + file);
				else
				{
					checkLogs.Add("Invalid: " + pup + "/" + file);
					result = false;
				}
			}

			return result;
		}
		public static void installMelonLoader(MainForm mainForm = null)
		{
			MainForm = mainForm;
			if (MainForm!=null)
				MainForm.Log("Melonloader Downloading...");
			RefVars.MakeSureDirectoryExists(RefVars.packageManagerTempPath);
			if (webClient != null)
				return;
			webClient = new WebClient();
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(OnProgessChange);
			webClient.DownloadFileAsync(new Uri("https://github.com/LavaGang/MelonLoader/releases/download/v0.5.5/MelonLoader.x64.zip"), RefVars.packageManagerTempPath + "/MelonLoader.x64.zip");
		}
		private static void Completed(object sender, AsyncCompletedEventArgs e)
		{
			webClient = null;
			ZipFile.ExtractToDirectory(RefVars.packageManagerTempPath + "/MelonLoader.x64.zip", SettingsManager.Get<string>("plateupfolder")); ;
			Directory.Delete(RefVars.packageManagerTempPath, true);
			if (MainForm != null)
			{
				MainForm.Log("Melonloader Installed.");
				MainForm.RefreshMLInstallState();
			}
		}

		private static void OnProgessChange(object sender, ProgressChangedEventArgs e)
		{
			if (MainForm != null)
				MainForm.SetMLProgress(e.ProgressPercentage);
		}
	}

	public class UpdateManager
	{
		private static WebClient webClient = null;
		public static void Update()
		{
			if (webClient != null)
				return;
			webClient = new WebClient();
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(OnProgessChange);
			webClient.DownloadFileAsync(new Uri("http://plateup.starfluxgames.com/Manager/update.zip"), Application.StartupPath + "/update.zip");
		}
		private static void Completed(object sender, AsyncCompletedEventArgs e)
		{
			Application.Exit();
		}

		private static void OnProgessChange(object sender, ProgressChangedEventArgs e)
		{
		}
	}
}
