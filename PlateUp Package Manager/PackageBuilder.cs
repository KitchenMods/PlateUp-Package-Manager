using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlateUp_Package_Manager
{
	public partial class PackageBuilder : Form
	{
		public PackageBuilder()
		{
			InitializeComponent();
		}

        private void button1_Click(object sender, EventArgs e)
        {
			string path = "";
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					path = fbd.SelectedPath;
					textBox_packageFiles.Text = path;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(textBox_packageid.Text)
				&& !string.IsNullOrWhiteSpace(textBox_packageName.Text)
				&& !string.IsNullOrWhiteSpace(textBox_packageDescription.Text)
				&& !string.IsNullOrWhiteSpace(textBox_packageAuthor.Text)
				&& !string.IsNullOrWhiteSpace(textBox_packageVersion.Text)
				&& !string.IsNullOrWhiteSpace(textBox_packageURL.Text)
				&& !string.IsNullOrWhiteSpace(textBox_packageFiles.Text))
			{
				List<string> depends = new List<string>();
				foreach (string x in listBox1.Items)
					depends.Add(x);
				
				string packageJson = PackageManager.CreatePackageJson(textBox_packageFiles.Text,
					textBox_packageid.Text,
					textBox_packageName.Text,
					textBox_packageDescription.Text,
					textBox_packageAuthor.Text,
					textBox_packageVersion.Text,
					textBox_packageURL.Text,
					depends);

				string packagePath = Path.Combine(textBox_packageFiles.Text, "PACKAGE.json");
				File.WriteAllText(packagePath, packageJson);

				ZipFile.CreateFromDirectory(textBox_packageFiles.Text, Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop), textBox_packageid.Text + "-" + textBox_packageVersion.Text + ".plateupmod"));
				MessageBox.Show("Package created!");

			}
		}

		private void button_dependsAdd_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(textBox_dependAuthor.Text)
				&& !string.IsNullOrWhiteSpace(textBox_dependID.Text)
				&& !string.IsNullOrWhiteSpace(textBox_dependVersion.Text))
			{
				listBox1.Items.Add(textBox_dependAuthor.Text + "," + textBox_dependID.Text + "," + textBox_dependVersion.Text);
			}
		}

		private void button_dependsRemove_Click(object sender, EventArgs e)
		{
			//Remove item from listbox if item is selected
			if (listBox1.SelectedIndex != -1)
			{
				listBox1.Items.RemoveAt(listBox1.SelectedIndex);
			}
		}

		private void PackageBuilder_Load(object sender, EventArgs e)
		{
			this.MaximumSize = this.Size;
			this.MinimumSize = this.Size;
		}
	}
}
