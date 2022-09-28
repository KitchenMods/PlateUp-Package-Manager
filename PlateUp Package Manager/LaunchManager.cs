using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace PlateUp_Package_Manager
{
	public class LaunchManager
	{
		public static void SetupForLaunch()
		{
			if (Directory.Exists(RefVars.packageManagerPath))
			{
				Application.Run(new MainForm());
			}
			else
			{
				Application.Run(new FirstLaunchForm());
			}
		}
	}
}
