using System.IO;
using System.Windows.Forms;
using DevExpress.XtraCharts.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
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

				var progressPanelHandle = ShowProgressPanel();

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

				CloseProgressPanel(progressPanelHandle);
			}
		}

		void barSubItemParameters_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			parametersView.Visible = true;
			parametersView.BringToFront();
		}

		IOverlaySplashScreenHandle ShowProgressPanel()
		{
			return SplashScreenManager.ShowOverlayForm(this, OverlayWindowOptions.Default);
		}

		void CloseProgressPanel(IOverlaySplashScreenHandle handle)
		{
			SplashScreenManager.CloseOverlayForm(handle);
		}

		void Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			chart.ShowPrintPreview();
		}

		void Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (xtraSaveFileDialog.ShowDialog() == DialogResult.OK)
			{
				chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom;
				var filename = xtraSaveFileDialog.FileName;
				var ext = Path.GetExtension(filename);
				var progressPanelHandle = ShowProgressPanel();
				switch (ext)
				{
					case ".pdf":
						{
							chart.OptionsPrint.ImageFormat = PrintImageFormat.Metafile;
							var options = new PdfExportOptions
							{
								ConvertImagesToJpeg = false
							};

							chart.ExportToPdf(filename, options);

							break;
						}
					case ".xls":
						chart.ExportToXls(filename);
						break;
					case ".xlsx":
						chart.ExportToXlsx(filename);
						break;
					case ".docx":
						chart.ExportToDocx(filename);
						break;
				}
				CloseProgressPanel(progressPanelHandle);
			}
		}
	}
}
