using System;
using System.Windows.Forms;

namespace W0_0W._202300226.DataAnalysis
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			App.Init();
			Application.Run(new Form());
		}
	}
}
