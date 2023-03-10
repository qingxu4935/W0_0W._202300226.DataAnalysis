using System;
using System.IO;
using System.Reactive.Disposables;
using System.Windows.Forms;
using DevExpress.XtraCharts.Printing;
using DevExpress.XtraPrinting;
using DevExpress.XtraSplashScreen;
using Splat;
using W0_0W._202300226.DataAnalysis.Model;

namespace W0_0W._202300226.DataAnalysis;

public partial class Form : DevExpress.XtraEditors.XtraForm
{
	public Form()
	{
		InitializeComponent();
	}

	/// <summary>
	/// 打开历史数据
	/// </summary>
	void OpenHistoryFile_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		//文件对话框，只有选中文件，才继续
		if (xtraOpenFileDialog.ShowDialog(this) == DialogResult.OK)
		{
			//获取选中文件路径
			var fileName = xtraOpenFileDialog.FileName;

			//界面弹出等待框
			using (ShowProgress())
			{
				//获取一个信号量工厂
				var signalFactory = Locator.Current.GetService<SignalFactory>();
				//加载数据
				signalFactory.Load(fileName);

				//获取要配置的series
				var series = chart.Series[0];
				//指定series数据源
				series.DataSource = signalFactory.Signals;
				//指定x轴数据源
				series.ArgumentDataMember = nameof(Signal.Second);
				//指定y轴数据源
				series.ValueDataMembers[0] = nameof(Signal.Value);

				//在chart标题中显示设备号和峰值
				chart.Titles[0].Text = $"#{signalFactory.DeviceName} - 峰值: {signalFactory.MaxValue}";
				//状态栏显示历史文件的路径
				statusText.Caption = fileName;
				if (parametersView.Visible)
				{
					parametersView.Visible = false;
				}
			}
		}
	}

	//打印预览
	void Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		chart.ShowPrintPreview();
	}

	//导出
	void Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		//文件保存对话框，只有添文件名才能继续操作
		if (xtraSaveFileDialog.ShowDialog() == DialogResult.OK)
		{
			//缩放模式
			chart.OptionsPrint.SizeMode = PrintSizeMode.Zoom;
			//获取文件路径
			var filename = xtraSaveFileDialog.FileName;
			//获取文件扩展名
			var extension = Path.GetExtension(filename);
			using (ShowProgress())
			{
				switch (extension)
				{
					//导出PDF
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
					//导出XLS
					case ".xls":
						chart.ExportToXls(filename);
						break;
					//导出XLSX
					case ".xlsx":
						chart.ExportToXlsx(filename);
						break;
					//导出DOCX
					case ".docx":
						chart.ExportToDocx(filename);
						break;
				}
			}
		}
	}

	//打开配置界面
	void Parameters_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		parametersView.Visible = true;
		parametersView.BringToFront();
	}

	/// <summary>
	/// 等待框
	/// </summary>
	/// <returns></returns>
	IDisposable ShowProgress()
	{
		var progressPanelHandle = SplashScreenManager.ShowOverlayForm(this, OverlayWindowOptions.Default);
		return Disposable.Create(() => SplashScreenManager.CloseOverlayForm(progressPanelHandle));
	}
}