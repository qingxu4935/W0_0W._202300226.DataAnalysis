using System;
using System.Windows.Forms;

namespace W0_0W._202300226.DataAnalysis;

static class Program
{
	[STAThread]
	static void Main()
	{
		System.Threading.Thread.CurrentThread.CurrentCulture
			= System.Threading.Thread.CurrentThread.CurrentUICulture
				= new System.Globalization.CultureInfo("zh-CN");
		DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware();

		ApplicationConfiguration.Initialize();
		App.Init();
		Application.Run(new Form());
	}
}