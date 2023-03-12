using DevExpress.XtraBars.Docking2010;
using Splat;
using W0_0W._202300226.DataAnalysis.Model;

namespace W0_0W._202300226.DataAnalysis;

public partial class ParametersView : DevExpress.XtraEditors.XtraUserControl
{
	//指定当前配置对象
	readonly Config _config = Locator.Current.GetService<Config>();

	public ParametersView()
	{
		InitializeComponent();
	}

	//将_config绑定到界面
	void ParametersView_Load(object sender, System.EventArgs e)
	{
		configBindingSource.Add(_config);
	}

	void windowsUIButtonPanelMain_ButtonClick(object sender, ButtonEventArgs e)
	{
		switch (((WindowsUIButton)e.Button).Caption)
		{
			case "保存":
				_config.Save();
				break;
			case "保存并关闭":
				_config.Save();
				Visible = false;
				break;
		}
	}
}