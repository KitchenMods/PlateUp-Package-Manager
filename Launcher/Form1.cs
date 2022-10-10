using System;
using System.IO.Compression;
using System.IO;
using System.Windows.Forms;

namespace Launcher
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        private void Form1_Load(object sender, EventArgs e)
		{
			string path = Application.StartupPath;
			Console.WriteLine(path);


			if (File.Exists(path + "/update.zip"))
			{
				if (!Directory.Exists(path + "/temp"))
					Directory.CreateDirectory(path + "/temp");
				ZipFile.ExtractToDirectory(path + "/update.zip", path + "/temp");

				DirectoryInfo d = new DirectoryInfo(path + "/temp");
				FileInfo[] Files = d.GetFiles();

				foreach (FileInfo file in Files)
				{
					File.Copy(file.FullName, path + "/" + file.Name, true);
				}

				Directory.Delete(path + "/temp", true);
				File.Delete(path + "/update.zip");
			}

			if (File.Exists(path + "/PlateUp Package Manager.exe"))
				System.Diagnostics.Process.Start(path + "/PlateUp Package Manager.exe");

			Application.Exit();
		}
	}
}
