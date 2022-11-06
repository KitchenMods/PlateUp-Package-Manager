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
using System.Text.RegularExpressions;
using Semver;
using System.Runtime.CompilerServices;
using System.Drawing.Drawing2D;
using System.Windows.Forms.VisualStyles;

namespace PlateUp_Package_Manager
{
	public partial class MainForm : Form
	{
		private Dictionary<string, Package> installedPackagesListBoxKey = new Dictionary<string, Package>();
		private Dictionary<string, Repository> installedReposListBoxKey = new Dictionary<string, Repository>();
		private Dictionary<Package, string> searchedPackagesListBoxKey = new Dictionary<Package, string>();
		private List<Package> searchedPackagesListBoxIndexes = new List<Package>();
		//private Dictionary<string, Package> searchedPackagesListBoxKey = new Dictionary<string, Package>();
		private Dictionary<string, Package> installedPackages = new Dictionary<string, Package>();

		public MainForm()
		{
			//1232,718
			InitializeComponent();
		}


		public void UpdateInstallButtons(bool enabled)
		{
			button_mods_modify.Enabled = enabled;
			button_toggleMod.Enabled = enabled;
			button_manuallInstall.Enabled = enabled;
			button_installed_remove.Enabled = enabled;
		}
		private void MainForm_Load(object sender, EventArgs e)
		{

			this.Size = new Size(1252, 760);
			this.MaximumSize = new Size(1252, 760);
			this.MinimumSize = new Size(1252, 760);
			RefVars.UniversalOnFormLoad(this);
			label_currentversion.Text = "Current Version: " + VersionManager.GetCurrentVersion();
			SettingsManager.Load();
			Setup();
			SetUpPanels();
			SetActivePanel(panel_installed);
			RefreshSearchPage();
			RefreshInstalledPackagesPage();

			RefVars.RoundButton(button_home);
			RefVars.RoundButton(button_repositories);
			RefVars.RoundButton(button_installed);
			RefVars.RoundButton(button_search);
			RefVars.RoundButton(button_settings);

			RefVars.RoundButton(button_launch_vanilla);
			RefVars.RoundButton(button_launch_bepinex);
			RefVars.RoundButton(button_launch_melonloader);

			RefVars.RoundButton(button_clean);
			RefVars.RoundButton(button_packageBuilder);

			RefVars.RoundButton(button_mods_localdownload);
			RefVars.RoundButton(button_mods_modify);
			RefVars.RoundButton(button_mods_refresh);
			RefVars.RoundButton(button_toggleMod);

			RefVars.RoundButton(button_addrepo);
			RefVars.RoundButton(button_repos_remove);

			RefVars.RoundButton(button_update);
			RefVars.RoundButton(button_debuglog);

			RefVars.RoundTextbox(textBox_searchField);
			RefVars.RoundTextbox(textBox_addrepo);



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

			label_repo_title.Text = "";
			label_repo_description.Text = "";
			label_repo_url.Text = "";

			label_mod_title.Text = "";
			label_mod_version.Text = "";
			label_mod_description.Text = "";
			label_mod_author.Text = "";
			label_mod_dependslist.Text = "";
			label_logger.Text = "";

		}

		private void SetUpPanels()
		{
			panel_home.Location = new Point(268, 76);
			panel_repositories.Location = new Point(268, 76);
			panel_installed.Location = new Point(268, 76);
			panel_search.Location = new Point(268, 76);
		}

		private void SetActivePanel(Panel panel)
		{
			panel_home.Visible = false;
			panel_repositories.Visible = false;
			panel_installed.Visible = false;
			panel_search.Visible = false;

			if (panel == panel_home) label_title.Text = "PlateUp! Mod Manager - Home";
			if (panel == panel_repositories) label_title.Text = "PlateUp! Mod Manager - Repositories";
			if (panel == panel_installed) label_title.Text = "PlateUp! Mod Manager - Installed";
			if (panel == panel_search) label_title.Text = "PlateUp! Mod Manager - Search";

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
			RefreshSearchPage();
		}

		private void button_search_Click(object sender, EventArgs e)
		{
			//SetActivePanel(panel_search);
			//RefreshSearchPage();
		}

		private void button_settings_Click(object sender, EventArgs e)
		{
			//Settings settingsMenu = new Settings();
			//settingsMenu.Show();
			
			SetActivePanel(panel_search);
			RefreshSearchPage();
		}

		private void button_installed_remove_Click(object sender, EventArgs e)
		{
			if (listView_installed.SelectedItems.Count > 0)
			{
				PackageManager.UninstallPackage(installedPackagesListBoxKey[listView_installed.SelectedItems[0].Text]);
				RefreshInstalledPackagesPage();
			}
		}

		public void RefreshInstalledPackagesPage()
		{
			listView_installed.Clear();
			listView_installed.Columns.Add("", -2);
			installedPackagesListBoxKey.Clear();
			installedPackages.Clear();
			label_mod_title.Text = "";
			label_mod_version.Text = "";
			label_mod_description.Text = "";
			label_mod_author.Text = "";
			label_mod_dependslist.Text = "";
			PackageManager.LoadInstalledPackages();
			foreach (Package package in PackageManager.GetInstalledPackages())
			{
				if (!installedPackagesListBoxKey.ContainsKey(package.Name + " v" + package.Version))
				{
					installedPackagesListBoxKey.Add(package.Name + " v" + package.Version, package);
					ListViewItem item = listView_installed.Items.Add(package.Name + " v" + package.Version);
					if (!package.IsEnabled)
						item.ForeColor = Color.Red;
					installedPackages.Add($"{package.Author},{package.ID},{package.Version}", package);
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
			searchedPackagesListBoxIndexes.Clear();
			foreach (Repository repo in RepositoryManager.GetInstalledRepositories())
			{
				foreach (Package package in repo.Packages)
				{
					if (!PackageManager.IsPackageInstalled(package))
					{
						searchedPackagesListBoxKey.Add(package, package.Name + " v" + package.Version);
						searchedPackagesListBoxIndexes.Add(package);
						ListViewItem item = listView_search.Items.Add(package.Name + " v" + package.Version);
					}
				}
			}
		}

		private void button_manuallInstall_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Select PlateUp Mod";
			dialog.ShowDialog();
			if (dialog.FileName != "")
			{
				PackageManager.InstallPackage(dialog.FileName);
				RefreshInstalledPackagesPage();
			}
		}

		private void listView_installed_SelectedIndexChanged(object sender, EventArgs e)
		{
			listView_search.SelectedItems.Clear();
			button_mods_modify.Text = "Uninstall";
			if (listView_installed.SelectedItems.Count > 0)
			{
				Package package = installedPackagesListBoxKey[listView_installed.SelectedItems[0].Text];
				//label_selectedInstalledPackageInformation.Text = "Name: " + package.Name + "\n\nVersion: " + package.Version + "\n\nAuthor: " + package.Author + "\n\nDescription: " + package.Description + "\n\nDepends: ";
				label_mod_title.Text = package.Name;
				label_mod_description.Text = package.Description;
				label_mod_version.Text = "Version: " + package.Version;
				label_mod_author.Text = package.Author;

				label_mod_dependslist.Text = "";
				foreach (string depends in package.HardDepends)
				{
					//label_selectedInstalledPackageInformation.Text = label_selectedInstalledPackageInformation.Text + "\n" + depends;
					label_mod_dependslist.Text += depends + "\n";
				}
				button_installed_remove.Enabled = true;
			}
			else
			{
				button_installed_remove.Enabled = false;
				label_mod_title.Text = "";
				label_mod_version.Text = "";
				label_mod_description.Text = "";
				label_mod_author.Text = "";
				label_mod_dependslist.Text = "";
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
				label_repo_title.Text = "";
				label_repo_description.Text = "";
				label_repo_url.Text = "";
				RepositoryManager.RemoveInstalledRepository(installedReposListBoxKey[listView_repos_installedrepos.SelectedItems[0].Text]);
				RefreshInstalledRepositories();
			}
		}

		private void listView_repos_installedrepos_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listView_repos_installedrepos.SelectedItems.Count > 0)
			{
				Repository repo= installedReposListBoxKey[listView_repos_installedrepos.SelectedItems[0].Text];
				//label_selectedInstalledRepoInformation.Text = "Name: " + repo.Name + "\n\nDescription: " + repo.Description + "\n\nURL: " + repo.URL;
				label_repo_title.Text = repo.Name;
				label_repo_description.Text = repo.Description;
				label_repo_url.Text = repo.URL;
				button_repos_remove.Enabled = true;
			}
			else
			{
				button_repos_remove.Enabled = false;
				label_repo_title.Text = "";
				label_repo_description.Text = "";
				label_repo_url.Text = "";
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
			listView_installed.SelectedItems.Clear();
			button_mods_modify.Text = "Install";
			if (listView_search.SelectedItems.Count > 0)
			{
				Package package = searchedPackagesListBoxIndexes[listView_search.SelectedItems[0].Index];
				//label_selectedSearchPackageInformation.Text = "Name: " + package.Name + "\n\nVersion: " + package.Version + "\n\nAuthor: " + package.Author + "\n\nDescription: " + package.Description + "\n\nDepends: ";
				label_mod_title.Text = package.Name;
				label_mod_description.Text = package.Description;
				label_mod_version.Text = "Version: "+package.Version;
				label_mod_author.Text = package.Author;

				label_mod_dependslist.Text = "";
				foreach (string depends in package.HardDepends)
				{
					//label_selectedSearchPackageInformation.Text = label_selectedSearchPackageInformation.Text + "\n" + depends;
					label_mod_dependslist.Text += depends + "\n";
				}
			}
			else
			{
			}
		}

		private void button_searchInstall_Click(object sender, EventArgs e)
		{
			if (listView_search.SelectedItems.Count > 0)
			{
				Package package = searchedPackagesListBoxIndexes[listView_search.SelectedItems[0].Index];
				PackageManager.LoadInstalledPackages();
				RefreshInstalledPackagesPage();
				string[] installedKeys = installedPackages.Keys.ToArray();
				List<Match> regexMatches = new List<Match>();

				foreach (string x in installedKeys)
				{
					Regex pattern = new Regex(@"([A-Za-z0-9]+),([A-Za-z0-9]+),([0-9]+)\.([0-9]+)\.([0-9]+)");
					Match match = Regex.Match(x, pattern.ToString());
					if (match.Success)
						regexMatches.Add(match);
				}
				foreach (string incompatable in package.Incompatable)
				{
					Regex pattern = new Regex(@"([A-Za-z0-9]+),([A-Za-z0-9]+)");
					Match match = Regex.Match(incompatable, pattern.ToString());
					bool found = false;
					foreach (Match regexMatch in regexMatches)
					{
						if (regexMatch.Groups[1].Value == match.Groups[1].Value && regexMatch.Groups[2].Value == match.Groups[2].Value)
						{
							found = true;
							break;
						}
					}
					if (found)
					{
						DialogResult dialogResult = MessageBox.Show($"Package: {package.Name} is incompatible with: {match.Groups[1]}.{match.Groups[2]}, Would you like to FORCE install?\n\nForcing the installation may cause unforseen problems.", "Incompatible Package!", MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.No)
						{
							return;
						}
					}
				}
				foreach (string hardDepend in package.HardDepends)
				{
					Regex pattern = new Regex(@"([A-Za-z0-9]+),([A-Za-z0-9]+),([0-9]+)\.([0-9]+)\.([0-9]+)");
					Match match = Regex.Match(hardDepend, pattern.ToString());

					if (match.Success)
					{
						bool found = false;
						foreach (Match regexMatch in regexMatches)
						{
							if (regexMatch.Groups[1].Value == match.Groups[1].Value && regexMatch.Groups[2].Value == match.Groups[2].Value)
							{
								Match foundVersion = regexMatch;
								Match requiredVersion = match;

								//Semver Checks
								SemVersion foundVer = new SemVersion(int.Parse(regexMatch.Groups[3].Value), int.Parse(regexMatch.Groups[4].Value), int.Parse(regexMatch.Groups[5].Value));
								SemVersion requiredVer = new SemVersion(int.Parse(match.Groups[3].Value), int.Parse(match.Groups[4].Value), int.Parse(match.Groups[5].Value));

								int result = SemVersion.CompareSortOrder(foundVer, requiredVer);
								if (result >= 0)
								{
									found = true;
									break;
								}
							}
						}
						if (!found)
						{
							Log("Package: " + package.Name + " requires package: " + match.Groups[2].Value + " v" + match.Groups[3].Value +"."+ match.Groups[4].Value + "." + match.Groups[5].Value + " to be installed");
							return;
						}
					}
					else
					{
						Log("Package: " + package.Name + " has an invalid hard depend: " + hardDepend);
						return;
					}
				}

				List<Package> packages = PackageManager.GetInstalledPackages();
				List<Package> packagesToUninstall = new List<Package>();
				foreach (Package installedPackage in packages)
				{
					if (installedPackage.Author == package.Author && installedPackage.ID == package.ID)
					{
						DialogResult dialogResult = MessageBox.Show($"Package: {package.Name} is already installed, would you like to reinstall?", "Package already installed!", MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.No)
						{
							return;
						}
						else
						{
							packagesToUninstall.Add(installedPackage);
						}
					}
				}

				if (packagesToUninstall.Count > 0)
				{
					foreach (Package installedPackage in packagesToUninstall)
					{
						PackageManager.UninstallPackage(installedPackage);
					}
				}
				string downloadPath = package.URL + "/packages/" + package.ID + "/" + package.ID + "-" + package.Version + ".plateupmod";
				UpdateInstallButtons(false);
				PackageManager.InstallRemotePackage(downloadPath, package);
			}
		}

		private void textBox_searchField_TextChanged(object sender, EventArgs e)
		{
			string search = textBox_searchField.Text;


			//Installed

			listView_installed.Clear();
			listView_installed.Columns.Add("", -2);
			installedPackagesListBoxKey.Clear();
			installedPackages.Clear();
			label_mod_title.Text = "";
			label_mod_version.Text = "";
			label_mod_description.Text = "";
			label_mod_author.Text = "";
			label_mod_dependslist.Text = "";
			PackageManager.LoadInstalledPackages();
			foreach (Package package in PackageManager.GetInstalledPackages())
			{
				if (!installedPackagesListBoxKey.ContainsKey(package.Name + " v" + package.Version) && package.Name.Contains(search))
				{
					installedPackagesListBoxKey.Add(package.Name + " v" + package.Version, package);
					ListViewItem item = listView_installed.Items.Add(package.Name + " v" + package.Version);
					if (!package.IsEnabled)
						item.ForeColor = Color.Red;
					installedPackages.Add($"{package.Author},{package.ID},{package.Version}", package);
				}
			}

			//Search
			listView_search.Clear();
			listView_search.Columns.Add("", -2);
			searchedPackagesListBoxKey.Clear();
			searchedPackagesListBoxIndexes.Clear();
			foreach (Repository repo in RepositoryManager.GetInstalledRepositories())
			{
				foreach (Package package in repo.Packages)
				{
					if (!PackageManager.IsPackageInstalled(package))
					{
						if (package.Name.Contains(search))
						{
							searchedPackagesListBoxKey.Add(package, package.Name + " v" + package.Version);
							searchedPackagesListBoxIndexes.Add(package);
							ListViewItem item = listView_search.Items.Add(package.Name + " v" + package.Version);
						}
					}
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

		private void button_toggleMod_Click(object sender, EventArgs e)
		{
			if (listView_installed.SelectedItems.Count > 0)
			{
				Package package = installedPackagesListBoxKey[listView_installed.SelectedItems[0].Text];
				if (package.IsEnabled)
					PackageManager.DisablePackage(package);
				else
					PackageManager.EnablePackage(package);
				//PackageManager.UninstallPackage();
				RefreshInstalledPackagesPage();
			}
		}

		private void button_packageBuilder_Click(object sender, EventArgs e)
		{
			PackageBuilder packageBuilder = new PackageBuilder();
			packageBuilder.Show();
		}

		private void button_clean_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Would you like to clean your PlateUp! folder?", "Clean PlateUp?", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
			string pup = SettingsManager.Get<string>("plateupfolder");
			if (pup != "")
			{
				if (Directory.Exists(pup))
				{
					string[] files = Directory.GetFiles(pup);
					foreach (string file in files)
					{
						string x = file.Replace(pup, "");
						if (x != "\\lib_burst_generated.pdb"
							&& x != "\\PlateUp.exe"
							&& x != "\\UnityCrashHandler64.exe"
							&& x != "\\UnityPlayer.dll")
						{
							File.Delete(file);
						}
					}

					string[] dirs = Directory.GetDirectories(pup);
					foreach (string dir in dirs)
					{
						string x = dir.Replace(pup, "");
						if (x != "\\MonoBleedingEdge"
							&& x != "\\PlateUp_Data")
						{
							Directory.Delete(dir, true);
						}
					}

					string[] datadirs = Directory.GetDirectories(pup + "\\PlateUp_Data");
					foreach (string dir in datadirs)
					{
						string x = dir.Replace(pup + "\\PlateUp_Data", "");
						if (x != "\\Managed"
							&& x != "\\Plugins"
							&& x != "\\Resources")
						{
							Directory.Delete(dir, true);
						}
					}
				}
			}
		}

		private void button_searchDownload_Click(object sender, EventArgs e)
		{
			if (listView_search.SelectedItems.Count > 0)
			{
				Package package = searchedPackagesListBoxIndexes[listView_search.SelectedItems[0].Index];

				string downloadPath = package.URL + "/packages/" + package.ID + "/" + package.ID + "-" + package.Version + ".plateupmod";
				UpdateInstallButtons(false);
				PackageManager.DownloadRemotePackage(downloadPath, package);
			}
		}

		private void button_mods_modify_Click(object sender, EventArgs e)
		{
			if (listView_installed.SelectedItems.Count > 0)
			{
				PackageManager.UninstallPackage(installedPackagesListBoxKey[listView_installed.SelectedItems[0].Text]);
				RefreshInstalledPackagesPage();
				RefreshSearchPage();
			}
			if (listView_search.SelectedItems.Count > 0)
			{
				Package package = searchedPackagesListBoxIndexes[listView_search.SelectedItems[0].Index];
				PackageManager.LoadInstalledPackages();
				RefreshInstalledPackagesPage();
				string[] installedKeys = installedPackages.Keys.ToArray();
				List<Match> regexMatches = new List<Match>();

				foreach (string x in installedKeys)
				{
					Regex pattern = new Regex(@"([A-Za-z0-9]+),([A-Za-z0-9]+),([0-9]+)\.([0-9]+)\.([0-9]+)");
					Match match = Regex.Match(x, pattern.ToString());
					if (match.Success)
						regexMatches.Add(match);
				}
				foreach (string incompatable in package.Incompatable)
				{
					Regex pattern = new Regex(@"([A-Za-z0-9]+),([A-Za-z0-9]+)");
					Match match = Regex.Match(incompatable, pattern.ToString());
					bool found = false;
					foreach (Match regexMatch in regexMatches)
					{
						if (regexMatch.Groups[1].Value == match.Groups[1].Value && regexMatch.Groups[2].Value == match.Groups[2].Value)
						{
							found = true;
							break;
						}
					}
					if (found)
					{
						DialogResult dialogResult = MessageBox.Show($"Package: {package.Name} is incompatible with: {match.Groups[1]}.{match.Groups[2]}, Would you like to FORCE install?\n\nForcing the installation may cause unforseen problems.", "Incompatible Package!", MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.No)
						{
							return;
						}
					}
				}
				foreach (string hardDepend in package.HardDepends)
				{
					Regex pattern = new Regex(@"([A-Za-z0-9]+),([A-Za-z0-9]+),([0-9]+)\.([0-9]+)\.([0-9]+)");
					Match match = Regex.Match(hardDepend, pattern.ToString());

					if (match.Success)
					{
						bool found = false;
						foreach (Match regexMatch in regexMatches)
						{
							if (regexMatch.Groups[1].Value == match.Groups[1].Value && regexMatch.Groups[2].Value == match.Groups[2].Value)
							{
								Match foundVersion = regexMatch;
								Match requiredVersion = match;

								//Semver Checks
								SemVersion foundVer = new SemVersion(int.Parse(regexMatch.Groups[3].Value), int.Parse(regexMatch.Groups[4].Value), int.Parse(regexMatch.Groups[5].Value));
								SemVersion requiredVer = new SemVersion(int.Parse(match.Groups[3].Value), int.Parse(match.Groups[4].Value), int.Parse(match.Groups[5].Value));

								int result = SemVersion.CompareSortOrder(foundVer, requiredVer);
								if (result >= 0)
								{
									found = true;
									break;
								}
							}
						}
						if (!found)
						{
							Log("Package: " + package.Name + " requires package: " + match.Groups[2].Value + " v" + match.Groups[3].Value + "." + match.Groups[4].Value + "." + match.Groups[5].Value + " to be installed");
							return;
						}
					}
					else
					{
						Log("Package: " + package.Name + " has an invalid hard depend: " + hardDepend);
						return;
					}
				}

				List<Package> packages = PackageManager.GetInstalledPackages();
				List<Package> packagesToUninstall = new List<Package>();
				foreach (Package installedPackage in packages)
				{
					if (installedPackage.Author == package.Author && installedPackage.ID == package.ID)
					{
						DialogResult dialogResult = MessageBox.Show($"Package: {package.Name} is already installed, would you like to reinstall?", "Package already installed!", MessageBoxButtons.YesNo);
						if (dialogResult == DialogResult.No)
						{
							return;
						}
						else
						{
							packagesToUninstall.Add(installedPackage);
						}
					}
				}

				if (packagesToUninstall.Count > 0)
				{
					foreach (Package installedPackage in packagesToUninstall)
					{
						PackageManager.UninstallPackage(installedPackage);
					}
				}
				string downloadPath = package.URL + "/packages/" + package.ID + "/" + package.ID + "-" + package.Version + ".plateupmod";
				UpdateInstallButtons(false);
				PackageManager.InstallRemotePackage(downloadPath, package);
			}
		}

		private void button_mods_localdownload_Click(object sender, EventArgs e)
		{
			if (listView_search.SelectedItems.Count > 0)
			{
				Package package = searchedPackagesListBoxIndexes[listView_search.SelectedItems[0].Index];

				string downloadPath = package.URL + "/packages/" + package.ID + "/" + package.ID + "-" + package.Version + ".plateupmod";
				UpdateInstallButtons(false);
				PackageManager.DownloadRemotePackage(downloadPath, package);
			}
		}

		private void button_debuglog_Click(object sender, EventArgs e)
		{
			List<string> check = new List<string> { @"NOTICE.txt", @"version.dll", @"MelonLoader\0Harmony.dll", @"MelonLoader\AssetRipper.VersionUtilities.dll", @"MelonLoader\AssetsTools.NET.dll", @"MelonLoader\bHapticsLib.dll", @"MelonLoader\IndexRange.dll", @"MelonLoader\MelonLoader.dll", @"MelonLoader\MelonLoader.xml", @"MelonLoader\Mono.Cecil.dll", @"MelonLoader\Mono.Cecil.Mdb.dll", @"MelonLoader\Mono.Cecil.Pdb.dll", @"MelonLoader\Mono.Cecil.Rocks.dll", @"MelonLoader\MonoMod.RuntimeDetour.dll", @"MelonLoader\MonoMod.Utils.dll", @"MelonLoader\Tomlet.dll", @"MelonLoader\ValueTupleBridge.dll", @"MelonLoader\WebSocketDotNet.dll", @"MelonLoader\Dependencies\Bootstrap.dll", @"MelonLoader\Dependencies\MelonStartScreen.dll", @"MelonLoader\Dependencies\CompatibilityLayers\Il2CppUnityTls.dll", @"MelonLoader\Dependencies\CompatibilityLayers\IPA.dll", @"MelonLoader\Dependencies\Il2CppAssemblyGenerator\Il2CppAssemblyGenerator.dll", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\mono-2.0-bdwgc.dll", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\MonoPosixHelper.dll", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\browscap.ini", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\DefaultWsdlHelpGenerator.aspx", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\machine.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\settings.map", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\web.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\Browsers\Compat.browser", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\DefaultWsdlHelpGenerator.aspx", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\machine.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\settings.map", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\web.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\Browsers\Compat.browser", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\DefaultWsdlHelpGenerator.aspx", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\machine.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\settings.map", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\web.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\Browsers\Compat.browser", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\mconfig\config.xml", @"MelonLoader\Dependencies\SupportModules\Mono.dll", @"MelonLoader\Dependencies\SupportModules\Preload.dll", @"MelonLoader\Documentation\CHANGELOG.md", @"MelonLoader\Documentation\LICENSE.md", @"MelonLoader\Documentation\NOTICE.txt", @"MelonLoader\Documentation\README.md", @"MelonLoader\Managed\Accessibility.dll", @"MelonLoader\Managed\Boo.Lang.Compiler.dll", @"MelonLoader\Managed\Boo.Lang.dll", @"MelonLoader\Managed\Boo.Lang.Extensions.dll", @"MelonLoader\Managed\Boo.Lang.Parser.dll", @"MelonLoader\Managed\Boo.Lang.PatternMatching.dll", @"MelonLoader\Managed\Boo.Lang.Useful.dll", @"MelonLoader\Managed\Commons.Xml.Relaxng.dll", @"MelonLoader\Managed\cscompmgd.dll", @"MelonLoader\Managed\CustomMarshalers.dll", @"MelonLoader\Managed\I18N.CJK.dll", @"MelonLoader\Managed\I18N.dll", @"MelonLoader\Managed\I18N.MidEast.dll", @"MelonLoader\Managed\I18N.Other.dll", @"MelonLoader\Managed\I18N.Rare.dll", @"MelonLoader\Managed\I18N.West.dll", @"MelonLoader\Managed\IBM.Data.DB2.dll", @"MelonLoader\Managed\Microsoft.CSharp.dll", @"MelonLoader\Managed\Microsoft.Web.Infrastructure.dll", @"MelonLoader\Managed\Mono.CompilerServices.SymbolWriter.dll", @"MelonLoader\Managed\Mono.CSharp.dll", @"MelonLoader\Managed\Mono.Data.Sqlite.dll", @"MelonLoader\Managed\Mono.Data.Tds.dll", @"MelonLoader\Managed\Mono.Messaging.dll", @"MelonLoader\Managed\Mono.Posix.dll", @"MelonLoader\Managed\Mono.Security.dll", @"MelonLoader\Managed\Mono.WebBrowser.dll", @"MelonLoader\Managed\mscorlib.dll", @"MelonLoader\Managed\netstandard.dll", @"MelonLoader\Managed\Newtonsoft.Json.dll", @"MelonLoader\Managed\Newtonsoft.Json.xml", @"MelonLoader\Managed\Novell.Directory.Ldap.dll", @"MelonLoader\Managed\SMDiagnostics.dll", @"MelonLoader\Managed\System.ComponentModel.Composition.dll", @"MelonLoader\Managed\System.ComponentModel.DataAnnotations.dll", @"MelonLoader\Managed\System.Configuration.dll", @"MelonLoader\Managed\System.Configuration.Install.dll", @"MelonLoader\Managed\System.Core.dll", @"MelonLoader\Managed\System.Data.DataSetExtensions.dll", @"MelonLoader\Managed\System.Data.dll", @"MelonLoader\Managed\System.Data.Entity.dll", @"MelonLoader\Managed\System.Data.Linq.dll", @"MelonLoader\Managed\System.Data.OracleClient.dll", @"MelonLoader\Managed\System.Data.Services.Client.dll", @"MelonLoader\Managed\System.Data.Services.dll", @"MelonLoader\Managed\System.Design.dll", @"MelonLoader\Managed\System.DirectoryServices.dll", @"MelonLoader\Managed\System.DirectoryServices.Protocols.dll", @"MelonLoader\Managed\System.dll", @"MelonLoader\Managed\System.Drawing.Design.dll", @"MelonLoader\Managed\System.Drawing.dll", @"MelonLoader\Managed\System.EnterpriseServices.dll", @"MelonLoader\Managed\System.IdentityModel.dll", @"MelonLoader\Managed\System.IdentityModel.Selectors.dll", @"MelonLoader\Managed\System.IO.Compression.dll", @"MelonLoader\Managed\System.IO.Compression.FileSystem.dll", @"MelonLoader\Managed\System.Json.dll", @"MelonLoader\Managed\System.Management.dll", @"MelonLoader\Managed\System.Messaging.dll", @"MelonLoader\Managed\System.Net.dll", @"MelonLoader\Managed\System.Net.Http.dll", @"MelonLoader\Managed\System.Net.Http.Formatting.dll", @"MelonLoader\Managed\System.Net.Http.WebRequest.dll", @"MelonLoader\Managed\System.Numerics.dll", @"MelonLoader\Managed\System.Numerics.Vectors.dll", @"MelonLoader\Managed\System.Reflection.Context.dll", @"MelonLoader\Managed\System.Runtime.Caching.dll", @"MelonLoader\Managed\System.Runtime.DurableInstancing.dll", @"MelonLoader\Managed\System.Runtime.Remoting.dll", @"MelonLoader\Managed\System.Runtime.Serialization.dll", @"MelonLoader\Managed\System.Runtime.Serialization.Formatters.Soap.dll", @"MelonLoader\Managed\System.Security.dll", @"MelonLoader\Managed\System.ServiceModel.Activation.dll", @"MelonLoader\Managed\System.ServiceModel.Discovery.dll", @"MelonLoader\Managed\System.ServiceModel.dll", @"MelonLoader\Managed\System.ServiceModel.Internals.dll", @"MelonLoader\Managed\System.ServiceModel.Routing.dll", @"MelonLoader\Managed\System.ServiceModel.Web.dll", @"MelonLoader\Managed\System.ServiceProcess.dll", @"MelonLoader\Managed\System.Transactions.dll", @"MelonLoader\Managed\System.Web.Abstractions.dll", @"MelonLoader\Managed\System.Web.ApplicationServices.dll", @"MelonLoader\Managed\System.Web.dll", @"MelonLoader\Managed\System.Web.DynamicData.dll", @"MelonLoader\Managed\System.Web.Extensions.Design.dll", @"MelonLoader\Managed\System.Web.Extensions.dll", @"MelonLoader\Managed\System.Web.Http.dll", @"MelonLoader\Managed\System.Web.Http.SelfHost.dll", @"MelonLoader\Managed\System.Web.Http.WebHost.dll", @"MelonLoader\Managed\System.Web.Mvc.dll", @"MelonLoader\Managed\System.Web.Razor.dll", @"MelonLoader\Managed\System.Web.RegularExpressions.dll", @"MelonLoader\Managed\System.Web.Routing.dll", @"MelonLoader\Managed\System.Web.Services.dll", @"MelonLoader\Managed\System.Web.WebPages.Deployment.dll", @"MelonLoader\Managed\System.Web.WebPages.dll", @"MelonLoader\Managed\System.Web.WebPages.Razor.dll", @"MelonLoader\Managed\System.Windows.Forms.DataVisualization.dll", @"MelonLoader\Managed\System.Windows.Forms.dll", @"MelonLoader\Managed\System.Xaml.dll", @"MelonLoader\Managed\System.Xml.dll", @"MelonLoader\Managed\System.Xml.Linq.dll", @"MelonLoader\Managed\SystemWebTestShim.dll", @"MelonLoader\Managed\UnityEngine.Il2CppAssetBundleManager.dll", @"MelonLoader\Managed\UnityEngine.Il2CppImageConversionManager.dll", @"MelonLoader\Managed\ValueTupleBridge.dll", @"MelonLoader\Managed\WindowsBase.dll" };
			List<string> log = new List<string>();
			log.Add("-----Verifying MelonLoader Install-----");
			log.Add("");
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

			if (File.Exists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + "Low/It's Happening/PlateUp/Player.log"))
			{
				string[] plateuplogs = File.ReadAllLines(System.Environment.GetFolderPath(System.Environment.SpecialFolder.LocalApplicationData) + "Low/It's Happening/PlateUp/Player.log");
				log.Add("");
				log.Add("");
				log.Add("");
				log.Add("-----PlateUp Logs-----");
				foreach (string x in plateuplogs)
					log.Add(x);
			}

			File.WriteAllLines(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/Debug.log", log.ToArray());
			MessageBox.Show("Debug Log Generated");
		}

		private void button_update_Click(object sender, EventArgs e)
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

	public class PackageManager
	{
		private static List<Package> InstalledPackages = new List<Package>();
		private static MainForm MainForm;

		/*
		 * Package Managment
		 */

		public static string CreatePackageJson(string path, string id, string name, string description, string author, string version, string url, List<string> hardDepends, List<string> incompatables)
		{
			string[] allfiles = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
			Dictionary<string, string> paths = new Dictionary<string, string>();
			foreach (var file in allfiles)
			{
				if (!file.ToLower().Contains("package.json"))
				{
					string x = file.Replace(path, "");
					paths.Add(x, Path.GetDirectoryName(x));
				}
			}
			Package package = new Package(id, name, description, author, version, url, paths);
			if (hardDepends != null)
				package.HardDepends = hardDepends;
			if (incompatables != null)
				package.Incompatable = incompatables;
			package.PackageVersion = 1;
			return JsonConvert.SerializeObject(package);
		}

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
			
			if (package.PackageVersion == 1)
			{
				foreach (string file in package.FilePaths.Keys)
				{
					File.Copy(RefVars.packageManagerTempPath + "\\" + file, SettingsManager.Get<string>("plateupfolder") + "\\" + file, true);
				}
			}
			else
			{
				foreach (string file in package.FilePaths.Keys)
				{
					File.Copy(RefVars.packageManagerTempPath + file, SettingsManager.Get<string>("plateupfolder") + package.FilePaths[file] + "/" + file, true);
				}
			}

			Directory.Delete(RefVars.packageManagerTempPath, true);
			package.IsEnabled = true;
			AddInstalledPackage(package);
			SaveInstalledPackages();
			MainForm.Log("Installed package " + package.Name + " v" + package.Version);
			MainForm.UpdateInstallButtons(true);
		}

		public static void DisablePackage(Package package)
		{
			string pup = SettingsManager.Get<string>("plateupfolder");
			string disabledMods = pup + "/DisabledMods";
			if (!Directory.Exists(disabledMods))
				Directory.CreateDirectory(disabledMods);
			if (!Directory.Exists(disabledMods + "/" + package.ID))
				Directory.CreateDirectory(disabledMods + "/" + package.ID);

			if (package.PackageVersion == 1)
			{
				foreach (string file in package.FilePaths.Keys)
				{
					string path = pup + "/" + file;
					if (!Directory.Exists(disabledMods + "/" + package.ID + "/" + package.FilePaths[file]))
						Directory.CreateDirectory(disabledMods + "/" + package.ID + "/" + package.FilePaths[file]);
					if (File.Exists(path))
						File.Move(path, disabledMods + "/" + package.ID + "/" + file);
				}
			}
			else
			{
				foreach (string file in package.FilePaths.Keys)
				{
					string path = pup + package.FilePaths[file] + "/" + file;
					if (File.Exists(path))
						File.Move(path, disabledMods + "/" + package.ID + "/" + file);
				}
			}
			package.IsEnabled = false;
			SaveInstalledPackages();
			MainForm.RefreshInstalledPackagesPage();
		}

		public static void EnablePackage(Package package)
		{
			string pup = SettingsManager.Get<string>("plateupfolder");
			string disabledMods = pup + "/DisabledMods";

			if (package.PackageVersion == 1)
			{
				foreach (string file in package.FilePaths.Keys)
				{
					if (!Directory.Exists(pup + "/" + package.FilePaths[file]))
						Directory.CreateDirectory(pup + "/" + package.FilePaths[file]);

					if (File.Exists(disabledMods + "/" + package.ID + "/" + file))
						File.Move(disabledMods + "/" + package.ID + "/" + file, pup + "/" + file);
				}
			}
			else
			{
				foreach (string paths in package.FilePaths.Values)
				{
					RefVars.MakeSureDirectoryExists(SettingsManager.Get<string>("plateupfolder") + "/" + paths);
				}

				foreach (string file in package.FilePaths.Keys)
				{
					File.Move(disabledMods + "/" + package.ID + "/" + file, SettingsManager.Get<string>("plateupfolder") + package.FilePaths[file] + "/" + file);
				}
			}
			package.IsEnabled = true;
			SaveInstalledPackages();
			MainForm.RefreshInstalledPackagesPage();
		}

		public static bool UninstallPackage(Package package)
		{
			//Uninstall package files

			MainForm.Log("Uninstalling package " + package.Name + " v" + package.Version + "...");
			if (package.PackageVersion == 1)
			{
				foreach (string file in package.FilePaths.Keys)
				{
					if (File.Exists(SettingsManager.Get<string>("plateupfolder") + "\\" + file))
						File.Delete(SettingsManager.Get<string>("plateupfolder") + "\\" + file);
				}
			}
			else
			{
				foreach (string file in package.FilePaths.Keys)
				{
					if (File.Exists(SettingsManager.Get<string>("plateupfolder") + package.FilePaths[file] + "/" + file))
						File.Delete(SettingsManager.Get<string>("plateupfolder") + package.FilePaths[file] + "/" + file);
				}
			}

			RemoveInstalledPackage(package);
			SaveInstalledPackages();
			MainForm.Log("Uninstalled package " + package.Name + " v" + package.Version);
			return true;
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
			if (!File.Exists(RefVars.installedPackagesFilePath))
				File.WriteAllText(RefVars.installedPackagesFilePath, JsonConvert.SerializeObject(new List<Package>()));
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
				if (pack.ID == package.ID && pack.Name == package.Name && pack.Version == package.Version && pack.URL == package.URL)
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

		public static void DownloadRemotePackage(string downloadURL, Package package)
		{
			RefVars.MakeSureDirectoryExists(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop));
			WebClient webClient = new WebClient();
			currentlyInstalling = package;
			webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Downloaded);
			webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
			webClient.DownloadFileAsync(new Uri(downloadURL), System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/" + package.ID + "-" + package.Version + ".plateupmod");
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
				MainForm.RefreshInstalledPackagesPage();
			}
		}
		private static void Downloaded(object sender, AsyncCompletedEventArgs e)
		{
			if (currentlyInstalling != null)
			{
				MainForm.Log("Downloaded " + currentlyInstalling.Name + " to your desktop.");
				currentlyInstalling = null;
				MainForm.UpdateInstallButtons(true);
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
			try
			{
				Repository repository = JsonConvert.DeserializeObject<Repository>(GetHTMLFromURL(URL + "/REPO"));
				return repository;
			}
			catch
			{
				return new Repository("Invalid Repository", URL, "This package repository is invalid.", new List<Package>{ });
			}
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

	public class Package
	{
		public string ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public string Author { get; set; }
		public string Version { get; set; }
		public string URL { get; set; }
		public bool IsEnabled{ get; set; }

		public List<string> HardDepends = new List<string>();
		public List<string> SoftDepends = new List<string>();
		public List<string> Incompatable = new List<string>();
		public int PackageVersion { get; set; }
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
