﻿namespace W0_0W._202300226.DataAnalysis
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			DevExpress.XtraCharts.XYDiagram xyDiagram2 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series2 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SplineSeriesView splineSeriesView2 = new DevExpress.XtraCharts.SplineSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle2 = new DevExpress.XtraCharts.ChartTitle();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.Preview = new DevExpress.XtraBars.BarButtonItem();
			this.Export = new DevExpress.XtraBars.BarButtonItem();
			this.Paramters = new DevExpress.XtraBars.BarButtonItem();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.statusText = new DevExpress.XtraBars.BarStaticItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.chart = new DevExpress.XtraCharts.ChartControl();
			this.xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
			this.parametersView = new W0_0W._202300226.DataAnalysis.ParametersView();
			this.xtraSaveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).BeginInit();
			this.SuspendLayout();
			// 
			// barManager1
			// 
			this.barManager1.AllowCustomization = false;
			this.barManager1.AllowQuickCustomization = false;
			this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
			this.barManager1.DockControls.Add(this.barDockControlTop);
			this.barManager1.DockControls.Add(this.barDockControlBottom);
			this.barManager1.DockControls.Add(this.barDockControlLeft);
			this.barManager1.DockControls.Add(this.barDockControlRight);
			this.barManager1.Form = this;
			this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.barSubItem3,
            this.barButtonItem1,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barSubItem5,
            this.statusText,
            this.Preview,
            this.Export,
            this.Paramters});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 20;
			this.barManager1.StatusBar = this.bar3;
			// 
			// bar1
			// 
			this.bar1.BarName = "Tools";
			this.bar1.DockCol = 0;
			this.bar1.DockRow = 1;
			this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Preview, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Export, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Paramters, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar1.Text = "Tools";
			// 
			// Preview
			// 
			this.Preview.Caption = "预览";
			this.Preview.Id = 17;
			this.Preview.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Preview.ImageOptions.SvgImage")));
			this.Preview.Name = "Preview";
			this.Preview.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Preview_ItemClick);
			// 
			// Export
			// 
			this.Export.Caption = "导出";
			this.Export.Id = 18;
			this.Export.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Export.ImageOptions.SvgImage")));
			this.Export.Name = "Export";
			this.Export.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
			// 
			// Paramters
			// 
			this.Paramters.Caption = "参数设置";
			this.Paramters.Id = 19;
			this.Paramters.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItemParamters.ImageOptions.SvgImage")));
			this.Paramters.Name = "Paramters";
			this.Paramters.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem11_ItemClick);
			// 
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.bar2.OptionsBar.MultiLine = true;
			this.bar2.OptionsBar.UseWholeRow = true;
			this.bar2.Text = "Main menu";
			// 
			// barSubItem1
			// 
			this.barSubItem1.Caption = "数据获取";
			this.barSubItem1.Id = 0;
			this.barSubItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem1.ImageOptions.SvgImage")));
			this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
			this.barSubItem1.Name = "barSubItem1";
			// 
			// barButtonItem1
			// 
			this.barButtonItem1.Caption = "打开历史数据";
			this.barButtonItem1.Id = 4;
			this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
			this.barButtonItem1.Name = "barButtonItem1";
			this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
			// 
			// barSubItem3
			// 
			this.barSubItem3.Caption = "数据分析";
			this.barSubItem3.Id = 2;
			this.barSubItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItem3.ImageOptions.SvgImage")));
			this.barSubItem3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem6),
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem5)});
			this.barSubItem3.Name = "barSubItem3";
			// 
			// barButtonItem6
			// 
			this.barButtonItem6.Caption = "滤波";
			this.barButtonItem6.Id = 9;
			this.barButtonItem6.Name = "barButtonItem6";
			// 
			// barSubItem5
			// 
			this.barSubItem5.Caption = "定标";
			this.barSubItem5.Id = 15;
			this.barSubItem5.Name = "barSubItem5";
			// 
			// bar3
			// 
			this.bar3.BarName = "Status bar";
			this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
			this.bar3.DockCol = 0;
			this.bar3.DockRow = 0;
			this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
			this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.statusText)});
			this.bar3.OptionsBar.AllowQuickCustomization = false;
			this.bar3.OptionsBar.DrawDragBorder = false;
			this.bar3.OptionsBar.UseWholeRow = true;
			this.bar3.Text = "Status bar";
			// 
			// statusText
			// 
			this.statusText.Caption = "##";
			this.statusText.Id = 16;
			this.statusText.Name = "statusText";
			// 
			// barDockControlTop
			// 
			this.barDockControlTop.CausesValidation = false;
			this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
			this.barDockControlTop.Manager = this.barManager1;
			this.barDockControlTop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlTop.Size = new System.Drawing.Size(826, 49);
			// 
			// barDockControlBottom
			// 
			this.barDockControlBottom.CausesValidation = false;
			this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.barDockControlBottom.Location = new System.Drawing.Point(0, 527);
			this.barDockControlBottom.Manager = this.barManager1;
			this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlBottom.Size = new System.Drawing.Size(826, 23);
			// 
			// barDockControlLeft
			// 
			this.barDockControlLeft.CausesValidation = false;
			this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.barDockControlLeft.Location = new System.Drawing.Point(0, 49);
			this.barDockControlLeft.Manager = this.barManager1;
			this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlLeft.Size = new System.Drawing.Size(0, 478);
			// 
			// barDockControlRight
			// 
			this.barDockControlRight.CausesValidation = false;
			this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.barDockControlRight.Location = new System.Drawing.Point(826, 49);
			this.barDockControlRight.Manager = this.barManager1;
			this.barDockControlRight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.barDockControlRight.Size = new System.Drawing.Size(0, 478);
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "定标";
			this.barButtonItem5.Id = 8;
			this.barButtonItem5.Name = "barButtonItem5";
			// 
			// chart
			// 
			xyDiagram2.AxisX.AutoScaleBreaks.MaxCount = 9;
			xyDiagram2.AxisX.Label.TextPattern = "{A}s";
			xyDiagram2.AxisX.Title.Text = "秒";
			xyDiagram2.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
			xyDiagram2.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram2.AxisX.VisualRange.Auto = false;
			xyDiagram2.AxisX.VisualRange.MaxValueSerializable = "9";
			xyDiagram2.AxisX.VisualRange.MinValueSerializable = "0";
			xyDiagram2.AxisX.WholeRange.AutoSideMargins = false;
			xyDiagram2.AxisX.WholeRange.EndSideMargin = 0D;
			xyDiagram2.AxisX.WholeRange.StartSideMargin = 0D;
			xyDiagram2.AxisY.VisibleInPanesSerializable = "-1";
			xyDiagram2.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram2.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram2.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram2.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram2.EnableAxisXScrolling = true;
			xyDiagram2.EnableAxisXZooming = true;
			xyDiagram2.EnableAxisYScrolling = true;
			xyDiagram2.EnableAxisYZooming = true;
			this.chart.Diagram = xyDiagram2;
			this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart.Location = new System.Drawing.Point(0, 49);
			this.chart.Name = "chart";
			series2.Name = "信号量";
			series2.View = splineSeriesView2;
			this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series2};
			this.chart.Size = new System.Drawing.Size(826, 478);
			this.chart.TabIndex = 4;
			chartTitle2.Alignment = System.Drawing.StringAlignment.Near;
			chartTitle2.Text = "峰值:0";
			this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle2});
			// 
			// xtraOpenFileDialog
			// 
			this.xtraOpenFileDialog.FileName = "xtraOpenFileDialog";
			this.xtraOpenFileDialog.Filter = "数据文件(*.dat)|*.dat";
			// 
			// parametersView
			// 
			this.parametersView.Appearance.BackColor = System.Drawing.Color.White;
			this.parametersView.Appearance.Options.UseBackColor = true;
			this.parametersView.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.parametersView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.parametersView.Location = new System.Drawing.Point(0, 49);
			this.parametersView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.parametersView.Name = "parametersView";
			this.parametersView.Size = new System.Drawing.Size(826, 478);
			this.parametersView.TabIndex = 9;
			// 
			// xtraSaveFileDialog
			// 
			this.xtraSaveFileDialog.Filter = "pdf|*pdf|xls|*xls|xlsx|*xlsx|docx|*docx";
			// 
			// Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(826, 550);
			this.Controls.Add(this.chart);
			this.Controls.Add(this.parametersView);
			this.Controls.Add(this.barDockControlLeft);
			this.Controls.Add(this.barDockControlRight);
			this.Controls.Add(this.barDockControlBottom);
			this.Controls.Add(this.barDockControlTop);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "Form";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "信号量分析";
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(splineSeriesView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.BarManager barManager1;
		private DevExpress.XtraBars.Bar bar1;
		private DevExpress.XtraBars.Bar bar2;
		private DevExpress.XtraBars.Bar bar3;
		private DevExpress.XtraBars.BarDockControl barDockControlTop;
		private DevExpress.XtraBars.BarDockControl barDockControlBottom;
		private DevExpress.XtraBars.BarDockControl barDockControlLeft;
		private DevExpress.XtraBars.BarDockControl barDockControlRight;
		private DevExpress.XtraBars.BarSubItem barSubItem1;
		private DevExpress.XtraBars.BarSubItem barSubItem3;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
		private DevExpress.XtraBars.BarButtonItem barButtonItem6;
		private DevExpress.XtraCharts.ChartControl chart;
		private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
		private ParametersView parametersView;
		private DevExpress.XtraBars.BarSubItem barSubItem5;
		private DevExpress.XtraBars.BarStaticItem statusText;
		private DevExpress.XtraBars.BarButtonItem Preview;
		private DevExpress.XtraBars.BarButtonItem Export;
		private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog;
		private DevExpress.XtraBars.BarButtonItem Paramters;
	}
}

