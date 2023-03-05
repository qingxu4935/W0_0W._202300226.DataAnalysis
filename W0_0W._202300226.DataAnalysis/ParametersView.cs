using DevExpress.XtraBars.Docking2010;
using Splat;

namespace W0_0W._202300226.DataAnalysis
{
	public partial class ParametersView : DevExpress.XtraEditors.XtraUserControl
	{
		public ParametersView()
		{
			InitializeComponent();
			configBindingSource.Add(Locator.Current.GetService<Config>());
		}

		void windowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
		{
			switch (((WindowsUIButton)e.Button).Caption)
			{
				case "保存":
					Locator.Current.GetService<Config>().Save();
					break;
				case "保存并关闭":
					Locator.Current.GetService<Config>().Save();
					Visible = false;
					break;
			}
		}
	}
}
