using System.Windows.Forms;
using Splat;
using W0_0W._202300226.DataAnalysis.Model;

namespace W0_0W._202300226.DataAnalysis
{
	public partial class Form : DevExpress.XtraEditors.XtraForm
	{
		public Form()
		{
			InitializeComponent();
		}

		void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (xtraOpenFileDialog.ShowDialog(this) == DialogResult.OK)
			{
				var fileName = xtraOpenFileDialog.FileName;


				var signalRiver = new SignalRiver(Locator.Current.GetService<Config>());
				signalRiver.Load(fileName);

				var series = chart.Series[0];
				series.DataSource = signalRiver.Signals;
				series.ArgumentDataMember = nameof(Signal.Second);
				series.ValueDataMembers[0] = nameof(Signal.Value);

				chart.Titles[0].Text = $"#{signalRiver.DeviceName} - 峰值: {signalRiver.MaxValue}";
				statusText.Caption = fileName;
				if (parametersView.Visible)
				{
					parametersView.Visible = false;
				}
			}
		}

		void barSubItemParameters_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			parametersView.Visible = true;
			parametersView.BringToFront();
		}
	}
}
