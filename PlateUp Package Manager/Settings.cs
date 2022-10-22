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
			List<string> check = new List<string> {@"NOTICE.txt", @"version.dll", @"MelonLoader\0Harmony.dll", @"MelonLoader\AssetRipper.VersionUtilities.dll", @"MelonLoader\AssetsTools.NET.dll", @"MelonLoader\bHapticsLib.dll", @"MelonLoader\IndexRange.dll", @"MelonLoader\MelonLoader.dll", @"MelonLoader\MelonLoader.xml", @"MelonLoader\Mono.Cecil.dll", @"MelonLoader\Mono.Cecil.Mdb.dll", @"MelonLoader\Mono.Cecil.Pdb.dll", @"MelonLoader\Mono.Cecil.Rocks.dll", @"MelonLoader\MonoMod.RuntimeDetour.dll", @"MelonLoader\MonoMod.Utils.dll", @"MelonLoader\Tomlet.dll", @"MelonLoader\ValueTupleBridge.dll", @"MelonLoader\WebSocketDotNet.dll", @"MelonLoader\Dependencies\Bootstrap.dll", @"MelonLoader\Dependencies\MelonStartScreen.dll", @"MelonLoader\Dependencies\CompatibilityLayers\Il2CppUnityTls.dll", @"MelonLoader\Dependencies\CompatibilityLayers\IPA.dll", @"MelonLoader\Dependencies\Il2CppAssemblyGenerator\Il2CppAssemblyGenerator.dll", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\mono-2.0-bdwgc.dll", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\MonoPosixHelper.dll", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\browscap.ini", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\DefaultWsdlHelpGenerator.aspx", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\machine.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\settings.map", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\web.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\2.0\Browsers\Compat.browser", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\DefaultWsdlHelpGenerator.aspx", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\machine.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\settings.map", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\web.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.0\Browsers\Compat.browser", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\DefaultWsdlHelpGenerator.aspx", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\machine.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\settings.map", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\web.config", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\4.5\Browsers\Compat.browser", @"MelonLoader\Dependencies\MonoBleedingEdge.x64\etc\mono\mconfig\config.xml", @"MelonLoader\Dependencies\SupportModules\Mono.dll", @"MelonLoader\Dependencies\SupportModules\Preload.dll", @"MelonLoader\Documentation\CHANGELOG.md", @"MelonLoader\Documentation\LICENSE.md", @"MelonLoader\Documentation\NOTICE.txt", @"MelonLoader\Documentation\README.md", @"MelonLoader\Managed\Accessibility.dll", @"MelonLoader\Managed\Boo.Lang.Compiler.dll", @"MelonLoader\Managed\Boo.Lang.dll", @"MelonLoader\Managed\Boo.Lang.Extensions.dll", @"MelonLoader\Managed\Boo.Lang.Parser.dll", @"MelonLoader\Managed\Boo.Lang.PatternMatching.dll", @"MelonLoader\Managed\Boo.Lang.Useful.dll", @"MelonLoader\Managed\Commons.Xml.Relaxng.dll", @"MelonLoader\Managed\cscompmgd.dll", @"MelonLoader\Managed\CustomMarshalers.dll", @"MelonLoader\Managed\I18N.CJK.dll", @"MelonLoader\Managed\I18N.dll", @"MelonLoader\Managed\I18N.MidEast.dll", @"MelonLoader\Managed\I18N.Other.dll", @"MelonLoader\Managed\I18N.Rare.dll", @"MelonLoader\Managed\I18N.West.dll", @"MelonLoader\Managed\IBM.Data.DB2.dll", @"MelonLoader\Managed\Microsoft.CSharp.dll", @"MelonLoader\Managed\Microsoft.Web.Infrastructure.dll", @"MelonLoader\Managed\Mono.CompilerServices.SymbolWriter.dll", @"MelonLoader\Managed\Mono.CSharp.dll", @"MelonLoader\Managed\Mono.Data.Sqlite.dll", @"MelonLoader\Managed\Mono.Data.Tds.dll", @"MelonLoader\Managed\Mono.Messaging.dll", @"MelonLoader\Managed\Mono.Posix.dll", @"MelonLoader\Managed\Mono.Security.dll", @"MelonLoader\Managed\Mono.WebBrowser.dll", @"MelonLoader\Managed\mscorlib.dll", @"MelonLoader\Managed\netstandard.dll", @"MelonLoader\Managed\Newtonsoft.Json.dll", @"MelonLoader\Managed\Newtonsoft.Json.xml", @"MelonLoader\Managed\Novell.Directory.Ldap.dll", @"MelonLoader\Managed\SMDiagnostics.dll", @"MelonLoader\Managed\System.ComponentModel.Composition.dll", @"MelonLoader\Managed\System.ComponentModel.DataAnnotations.dll", @"MelonLoader\Managed\System.Configuration.dll", @"MelonLoader\Managed\System.Configuration.Install.dll", @"MelonLoader\Managed\System.Core.dll", @"MelonLoader\Managed\System.Data.DataSetExtensions.dll", @"MelonLoader\Managed\System.Data.dll", @"MelonLoader\Managed\System.Data.Entity.dll", @"MelonLoader\Managed\System.Data.Linq.dll", @"MelonLoader\Managed\System.Data.OracleClient.dll", @"MelonLoader\Managed\System.Data.Services.Client.dll", @"MelonLoader\Managed\System.Data.Services.dll", @"MelonLoader\Managed\System.Design.dll", @"MelonLoader\Managed\System.DirectoryServices.dll", @"MelonLoader\Managed\System.DirectoryServices.Protocols.dll", @"MelonLoader\Managed\System.dll", @"MelonLoader\Managed\System.Drawing.Design.dll", @"MelonLoader\Managed\System.Drawing.dll", @"MelonLoader\Managed\System.EnterpriseServices.dll", @"MelonLoader\Managed\System.IdentityModel.dll", @"MelonLoader\Managed\System.IdentityModel.Selectors.dll", @"MelonLoader\Managed\System.IO.Compression.dll", @"MelonLoader\Managed\System.IO.Compression.FileSystem.dll", @"MelonLoader\Managed\System.Json.dll", @"MelonLoader\Managed\System.Management.dll", @"MelonLoader\Managed\System.Messaging.dll", @"MelonLoader\Managed\System.Net.dll", @"MelonLoader\Managed\System.Net.Http.dll", @"MelonLoader\Managed\System.Net.Http.Formatting.dll", @"MelonLoader\Managed\System.Net.Http.WebRequest.dll", @"MelonLoader\Managed\System.Numerics.dll", @"MelonLoader\Managed\System.Numerics.Vectors.dll", @"MelonLoader\Managed\System.Reflection.Context.dll", @"MelonLoader\Managed\System.Runtime.Caching.dll", @"MelonLoader\Managed\System.Runtime.DurableInstancing.dll", @"MelonLoader\Managed\System.Runtime.Remoting.dll", @"MelonLoader\Managed\System.Runtime.Serialization.dll", @"MelonLoader\Managed\System.Runtime.Serialization.Formatters.Soap.dll", @"MelonLoader\Managed\System.Security.dll", @"MelonLoader\Managed\System.ServiceModel.Activation.dll", @"MelonLoader\Managed\System.ServiceModel.Discovery.dll", @"MelonLoader\Managed\System.ServiceModel.dll", @"MelonLoader\Managed\System.ServiceModel.Internals.dll", @"MelonLoader\Managed\System.ServiceModel.Routing.dll", @"MelonLoader\Managed\System.ServiceModel.Web.dll", @"MelonLoader\Managed\System.ServiceProcess.dll", @"MelonLoader\Managed\System.Transactions.dll", @"MelonLoader\Managed\System.Web.Abstractions.dll", @"MelonLoader\Managed\System.Web.ApplicationServices.dll", @"MelonLoader\Managed\System.Web.dll", @"MelonLoader\Managed\System.Web.DynamicData.dll", @"MelonLoader\Managed\System.Web.Extensions.Design.dll", @"MelonLoader\Managed\System.Web.Extensions.dll", @"MelonLoader\Managed\System.Web.Http.dll", @"MelonLoader\Managed\System.Web.Http.SelfHost.dll", @"MelonLoader\Managed\System.Web.Http.WebHost.dll", @"MelonLoader\Managed\System.Web.Mvc.dll", @"MelonLoader\Managed\System.Web.Razor.dll", @"MelonLoader\Managed\System.Web.RegularExpressions.dll", @"MelonLoader\Managed\System.Web.Routing.dll", @"MelonLoader\Managed\System.Web.Services.dll", @"MelonLoader\Managed\System.Web.WebPages.Deployment.dll", @"MelonLoader\Managed\System.Web.WebPages.dll", @"MelonLoader\Managed\System.Web.WebPages.Razor.dll", @"MelonLoader\Managed\System.Windows.Forms.DataVisualization.dll", @"MelonLoader\Managed\System.Windows.Forms.dll", @"MelonLoader\Managed\System.Xaml.dll", @"MelonLoader\Managed\System.Xml.dll", @"MelonLoader\Managed\System.Xml.Linq.dll", @"MelonLoader\Managed\SystemWebTestShim.dll", @"MelonLoader\Managed\UnityEngine.Il2CppAssetBundleManager.dll", @"MelonLoader\Managed\UnityEngine.Il2CppImageConversionManager.dll", @"MelonLoader\Managed\ValueTupleBridge.dll", @"MelonLoader\Managed\WindowsBase.dll" };
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

			File.WriteAllLines(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/Debug.log", log.ToArray());
			MessageBox.Show("Debug Log Generated");
		}
    }
}
