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
using System.Runtime.ExceptionServices;

namespace PlateUp_Package_Manager
{
	public partial class FirstLaunchForm : Form
	{
		public FirstLaunchForm()
		{
			InitializeComponent();
		}

		private void FirstLaunchForm_Load(object sender, EventArgs e)
		{
			RefVars.UniversalOnFormLoad(this);
			RefVars.MakeSureDirectoryExists(RefVars.packageManagerPath);
			RefVars.MakeSureFileExists(RefVars.settingsFilePath);
			textBox1.Text = FindPlateUpGame();
			label_messages.Text = messages[messagesIndex];
		}

		private List<string> messages = new List<string> {
			"Hey there! It looks like you're new around here.",
			"Before we can get started remodeling your new kitchen, we need your help!",
			"We've tried to find your PlateUp.exe location! Let us know how we did below!",
			"open_panel"};
		
		private List<string> aftermessages = new List<string> {
			"Thanks for that!",
			"We can't wait to help you remodel your new kitchen!",
			"Let's get started!",
			"continue"};
		private int messagesIndex = 0;
		private bool hasGameFolderBeenFound = false;

		private void button_next_Click(object sender, EventArgs e)
		{
			messagesIndex++;
			if (!hasGameFolderBeenFound)
			{
				if (messages.Count >= (messagesIndex - 1))
				{
					if (messages[messagesIndex].Equals("open_panel"))
					{
						button_next.Visible = false;
						panel2.Visible = true;
					}
					else
						label_messages.Text = messages[messagesIndex];
				}
			}
			else
			{
				if (aftermessages.Count >= (messagesIndex - 1))
				{
					if (aftermessages[messagesIndex].Equals("continue"))
					{
						MainForm form = new MainForm();
						this.Hide();
						form.ShowDialog();
						this.Close();
						
					}
					else
						label_messages.Text = aftermessages[messagesIndex];
				}
			}
		}

		private string FindPlateUpGame()
		{
			String path = "";
			DriveInfo[] allDrives = DriveInfo.GetDrives();
			foreach (DriveInfo d in allDrives)
			{
				if (File.Exists(d.Name + @"Program Files (x86)\Steam\config\libraryfolders.vdf"))
				{
					path = d.Name + @"Program Files (x86)\Steam\config\libraryfolders.vdf";
				}
			}
			if (path != "")
			{
				string[] libraryinfo = File.ReadAllLines(path);
				string currentPath = "";
				foreach (string line in libraryinfo)
				{
					if (line.Contains("path"))
						currentPath = line;
					if (line.Contains("\"1599600\""))
					{
						if (File.Exists(currentPath.Split('"')[3].Replace(@"\\", @"\") + @"\steamapps\common\PlateUp\PlateUp\PlateUp.exe"))
							return currentPath.Split('"')[3].Replace(@"\\", @"\") + @"\steamapps\common\PlateUp\PlateUp\PlateUp.exe";
						break;
					}
				}
			}
			return "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Title = "Select PlateUp.exe";
			dialog.ShowDialog();
			if (dialog.FileName != "")
			{
				textBox1.Text = dialog.FileName;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox1.Text.Contains("PlateUp.exe"))
			{
				SettingsManager.Set("plateupexe", textBox1.Text);
				SettingsManager.Set("plateupfolder", textBox1.Text.Replace(@"\PlateUp.exe", ""));
				SettingsManager.Save();

				hasGameFolderBeenFound = true;
				messagesIndex = 0;
				button_next.Visible = true;
				panel2.Visible = false;
			}
			else
			{
				label3.Text = "Hmm. That doesn't look right? Please try again.";
			}
		}
	}
}
