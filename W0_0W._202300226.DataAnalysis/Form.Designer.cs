namespace W0_0W._202300226.DataAnalysis
{
	partial class Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.LineSeriesView lineSeriesView2 = new DevExpress.XtraCharts.LineSeriesView();
			DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.LineSeriesView lineSeriesView3 = new DevExpress.XtraCharts.LineSeriesView();
			DevExpress.XtraCharts.Series series4 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.LineSeriesView lineSeriesView4 = new DevExpress.XtraCharts.LineSeriesView();
			DevExpress.XtraCharts.Series series5 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.LineSeriesView lineSeriesView5 = new DevExpress.XtraCharts.LineSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle1 = new DevExpress.XtraCharts.ChartTitle();
			barManager1 = new DevExpress.XtraBars.BarManager(components);
			bar1 = new DevExpress.XtraBars.Bar();
			Paramters = new DevExpress.XtraBars.BarButtonItem();
			openData = new DevExpress.XtraBars.BarButtonItem();
			Preview = new DevExpress.XtraBars.BarButtonItem();
			bar3 = new DevExpress.XtraBars.Bar();
			statusText = new DevExpress.XtraBars.BarStaticItem();
			barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			chart = new DevExpress.XtraCharts.ChartControl();
			xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(components);
			((System.ComponentModel.ISupportInitialize)barManager1).BeginInit();
			((System.ComponentModel.ISupportInitialize)chart).BeginInit();
			((System.ComponentModel.ISupportInitialize)xyDiagram1).BeginInit();
			((System.ComponentModel.ISupportInitialize)series1).BeginInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView1).BeginInit();
			((System.ComponentModel.ISupportInitialize)series2).BeginInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView2).BeginInit();
			((System.ComponentModel.ISupportInitialize)series3).BeginInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView3).BeginInit();
			((System.ComponentModel.ISupportInitialize)series4).BeginInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView4).BeginInit();
			((System.ComponentModel.ISupportInitialize)series5).BeginInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView5).BeginInit();
			SuspendLayout();
			// 
			// barManager1
			// 
			barManager1.AllowCustomization = false;
			barManager1.AllowQuickCustomization = false;
			barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar3 });
			barManager1.DockControls.Add(barDockControlTop);
			barManager1.DockControls.Add(barDockControlBottom);
			barManager1.DockControls.Add(barDockControlLeft);
			barManager1.DockControls.Add(barDockControlRight);
			barManager1.Form = this;
			barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { statusText, Preview, Paramters, openData });
			barManager1.MaxItemId = 21;
			barManager1.StatusBar = bar3;
			// 
			// bar1
			// 
			bar1.BarName = "Tools";
			bar1.DockCol = 0;
			bar1.DockRow = 0;
			bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Paramters, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, openData, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph), new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph) });
			bar1.Text = "Tools";
			// 
			// Paramters
			// 
			Paramters.Caption = "参数设置";
			Paramters.Id = 19;
			Paramters.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Paramters.ImageOptions.SvgImage");
			Paramters.Name = "Paramters";
			Paramters.ItemClick += Parameters_ItemClick;
			// 
			// openData
			// 
			openData.Caption = "打开历史数据";
			openData.Id = 20;
			openData.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("openData.ImageOptions.SvgImage");
			openData.Name = "openData";
			openData.ItemClick += OpenData_ItemClick;
			// 
			// Preview
			// 
			Preview.Caption = "报告";
			Preview.Id = 17;
			Preview.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("Preview.ImageOptions.SvgImage");
			Preview.Name = "Preview";
			Preview.ItemClick += Preview_ItemClick;
			// 
			// bar3
			// 
			bar3.BarName = "Status bar";
			bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			bar3.DockCol = 0;
			bar3.DockRow = 0;
			bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(statusText) });
			bar3.OptionsBar.AllowQuickCustomization = false;
			bar3.OptionsBar.DrawDragBorder = false;
			bar3.OptionsBar.UseWholeRow = true;
			bar3.Text = "Status bar";
			// 
			// statusText
			// 
			statusText.Caption = "##";
			statusText.Id = 16;
			statusText.Name = "statusText";
			// 
			// barDockControlTop
			// 
			barDockControlTop.CausesValidation = false;
			barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			barDockControlTop.Location = new System.Drawing.Point(0, 0);
			barDockControlTop.Manager = barManager1;
			barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			barDockControlTop.Size = new System.Drawing.Size(826, 24);
			// 
			// barDockControlBottom
			// 
			barDockControlBottom.CausesValidation = false;
			barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			barDockControlBottom.Location = new System.Drawing.Point(0, 527);
			barDockControlBottom.Manager = barManager1;
			barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			barDockControlBottom.Size = new System.Drawing.Size(826, 23);
			// 
			// barDockControlLeft
			// 
			barDockControlLeft.CausesValidation = false;
			barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			barDockControlLeft.Location = new System.Drawing.Point(0, 24);
			barDockControlLeft.Manager = barManager1;
			barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			barDockControlLeft.Size = new System.Drawing.Size(0, 503);
			// 
			// barDockControlRight
			// 
			barDockControlRight.CausesValidation = false;
			barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			barDockControlRight.Location = new System.Drawing.Point(826, 24);
			barDockControlRight.Manager = barManager1;
			barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			barDockControlRight.Size = new System.Drawing.Size(0, 503);
			// 
			// chart
			// 
			xyDiagram1.AxisX.AutoScaleBreaks.MaxCount = 9;
			xyDiagram1.AxisX.Label.DXFont = new DevExpress.Drawing.DXFont("Microsoft YaHei", 8F);
			xyDiagram1.AxisX.Label.TextPattern = "{A}s";
			xyDiagram1.AxisX.Title.DXFont = new DevExpress.Drawing.DXFont("Microsoft YaHei", 12F);
			xyDiagram1.AxisX.Title.Text = "秒";
			xyDiagram1.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram1.AxisX.WholeRange.AutoSideMargins = false;
			xyDiagram1.AxisX.WholeRange.EndSideMargin = 0D;
			xyDiagram1.AxisX.WholeRange.StartSideMargin = 0D;
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
			xyDiagram1.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram1.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram1.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram1.EnableAxisXScrolling = true;
			xyDiagram1.EnableAxisXZooming = true;
			xyDiagram1.EnableAxisYScrolling = true;
			xyDiagram1.EnableAxisYZooming = true;
			chart.Diagram = xyDiagram1;
			chart.Dock = System.Windows.Forms.DockStyle.Fill;
			chart.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right;
			chart.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside;
			chart.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight;
			chart.Legend.MarkerMode = DevExpress.XtraCharts.LegendMarkerMode.CheckBoxAndMarker;
			chart.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True;
			chart.Location = new System.Drawing.Point(0, 24);
			chart.Name = "chart";
			series1.Name = "信号量";
			series1.View = lineSeriesView1;
			series2.Name = "定标";
			series2.View = lineSeriesView2;
			series3.Name = "限幅滤波法";
			series3.View = lineSeriesView3;
			series4.Name = "中位值滤波法";
			series4.View = lineSeriesView4;
			series5.Name = "算术平均滤波法";
			series5.View = lineSeriesView5;
			chart.SeriesSerializable = (new DevExpress.XtraCharts.Series[] { series1, series2, series3, series4, series5 });
			chart.Size = new System.Drawing.Size(826, 503);
			chart.TabIndex = 4;
			chartTitle1.Alignment = System.Drawing.StringAlignment.Near;
			chartTitle1.DXFont = new DevExpress.Drawing.DXFont("Microsoft YaHei", 18F);
			chartTitle1.Text = "峰值:0";
			chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] { chartTitle1 });
			// 
			// xtraOpenFileDialog
			// 
			xtraOpenFileDialog.FileName = "xtraOpenFileDialog";
			xtraOpenFileDialog.Filter = "数据文件(*.dat)|*.dat";
			// 
			// Form
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(826, 550);
			Controls.Add(chart);
			Controls.Add(barDockControlLeft);
			Controls.Add(barDockControlRight);
			Controls.Add(barDockControlBottom);
			Controls.Add(barDockControlTop);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "Form";
			StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			Text = "信号量分析";
			((System.ComponentModel.ISupportInitialize)barManager1).EndInit();
			((System.ComponentModel.ISupportInitialize)xyDiagram1).EndInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView1).EndInit();
			((System.ComponentModel.ISupportInitialize)series1).EndInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView2).EndInit();
			((System.ComponentModel.ISupportInitialize)series2).EndInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView3).EndInit();
			((System.ComponentModel.ISupportInitialize)series3).EndInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView4).EndInit();
			((System.ComponentModel.ISupportInitialize)series4).EndInit();
			((System.ComponentModel.ISupportInitialize)lineSeriesView5).EndInit();
			((System.ComponentModel.ISupportInitialize)series5).EndInit();
			((System.ComponentModel.ISupportInitialize)chart).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraCharts.ChartControl chart;
		private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
		private DevExpress.XtraBars.BarStaticItem statusText;
		private DevExpress.XtraBars.BarButtonItem Preview;
		private DevExpress.XtraBars.BarButtonItem Paramters;
		private DevExpress.XtraBars.BarButtonItem openData;
	}
}

