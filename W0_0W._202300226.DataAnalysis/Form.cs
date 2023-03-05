using System.Windows.Forms;
using DevExpress.XtraCharts;
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

				var chartTitle = new ChartTitle();
				chartTitle.Alignment = System.Drawing.StringAlignment.Near;
				chartTitle.Text = $"峰值: {signalRiver.MaxValue}";
				chart.Titles.Add(chartTitle);
			}
		}

		void barSubItemParameters_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			parametersView.Visible = true;
			parametersView.BringToFront();
		}
	}
}
