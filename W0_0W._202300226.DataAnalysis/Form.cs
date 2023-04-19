using System;
using System.Collections.Generic;
using System.Reactive.Disposables;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using Splat;
using W0_0W._202300226.DataAnalysis.Model;

namespace W0_0W._202300226.DataAnalysis;

public partial class Form : XtraForm
{
	public Form()
	{
		InitializeComponent();
	}

	SignalFactory _signalFactory;
	/// <summary>
	/// 打开历史数据
	/// </summary>
	void OpenData_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
				_signalFactory = Locator.Current.GetService<SignalFactory>();
				//加载数据
				_signalFactory.Load(fileName);

				SetSeries(dataChart, "信号量", _signalFactory.Signals);

				SetSeries(analysisChart, "定标", _signalFactory.CalibratedResult);
				SetSeries(analysisChart, "限幅滤波法", _signalFactory.LimitingSignalFilterResult);
				SetSeries(analysisChart, "中位值滤波法", _signalFactory.MedianSignalFilterResult);
				SetSeries(analysisChart, "算术平均滤波法", _signalFactory.AverageSignalFilterResult);

				//在chart标题中显示设备号和峰值
				dataChart.Titles[0].Text = $"设备#{_signalFactory.DeviceName} - 峰值: {_signalFactory.MaxValue:N}, 谷值：{_signalFactory.MinValue:N}";
				//状态栏显示历史文件的路径
				statusText.Caption = fileName;
			}
		}
	}

	static void SetSeries(ChartControl chartControl, string seriesName, IReadOnlyList<Signal> data)
	{
		//获取要配置的series
		var series = chartControl.Series[seriesName];
		//指定series数据源
		series.DataSource = data;
		//指定x轴数据源
		series.ArgumentDataMember = nameof(Signal.Second);
		//指定y轴数据源
		series.ValueDataMembers[0] = nameof(Signal.Value);
	}

	//打印预览
	void Preview_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		if (_signalFactory != null)
		{
			using (ShowProgress())
			{
				var report = new Report();
				report.objectDataSource1.DataSource = _signalFactory;
				report.ShowPreviewDialog();
			}
		}
	}

	//打开配置界面
	void Parameters_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
	{
		var parametersView = new ParametersView();
		XtraDialog.Show(this, parametersView);
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