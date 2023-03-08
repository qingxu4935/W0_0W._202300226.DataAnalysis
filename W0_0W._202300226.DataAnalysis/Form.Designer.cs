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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
			DevExpress.XtraCharts.XYDiagram xyDiagram3 = new DevExpress.XtraCharts.XYDiagram();
			DevExpress.XtraCharts.Series series3 = new DevExpress.XtraCharts.Series();
			DevExpress.XtraCharts.SplineSeriesView splineSeriesView3 = new DevExpress.XtraCharts.SplineSeriesView();
			DevExpress.XtraCharts.ChartTitle chartTitle3 = new DevExpress.XtraCharts.ChartTitle();
			this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
			this.bar1 = new DevExpress.XtraBars.Bar();
			this.Preview = new DevExpress.XtraBars.BarButtonItem();
			this.bar2 = new DevExpress.XtraBars.Bar();
			this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem3 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem5 = new DevExpress.XtraBars.BarSubItem();
			this.barSubItemParameters = new DevExpress.XtraBars.BarSubItem();
			this.bar3 = new DevExpress.XtraBars.Bar();
			this.statusText = new DevExpress.XtraBars.BarStaticItem();
			this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
			this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
			this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem8 = new DevExpress.XtraBars.BarButtonItem();
			this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
			this.barSubItem4 = new DevExpress.XtraBars.BarSubItem();
			this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
			this.chart = new DevExpress.XtraCharts.ChartControl();
			this.xtraOpenFileDialog = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
			this.parametersView = new W0_0W._202300226.DataAnalysis.ParametersView();
			this.Export = new DevExpress.XtraBars.BarButtonItem();
			this.xtraSaveFileDialog = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
			((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(xyDiagram3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(series3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).BeginInit();
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
            this.barSubItem2,
            this.barSubItem3,
            this.barSubItemParameters,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7,
            this.barButtonItem8,
            this.barButtonItem9,
            this.barSubItem4,
            this.barButtonItem10,
            this.barSubItem5,
            this.statusText,
            this.Preview,
            this.Export});
			this.barManager1.MainMenu = this.bar2;
			this.barManager1.MaxItemId = 19;
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
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.Export, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
			// bar2
			// 
			this.bar2.BarName = "Main menu";
			this.bar2.DockCol = 0;
			this.bar2.DockRow = 0;
			this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
			this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItemParameters, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
			// barSubItemParameters
			// 
			this.barSubItemParameters.Caption = "参数设置";
			this.barSubItemParameters.Id = 3;
			this.barSubItemParameters.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barSubItemParameters.ImageOptions.SvgImage")));
			this.barSubItemParameters.Name = "barSubItemParameters";
			this.barSubItemParameters.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barSubItemParameters_ItemClick);
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
			// barSubItem2
			// 
			this.barSubItem2.Caption = "信道分析";
			this.barSubItem2.Id = 1;
			this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem3),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
			this.barSubItem2.Name = "barSubItem2";
			// 
			// barButtonItem3
			// 
			this.barButtonItem3.Caption = "通道设置";
			this.barButtonItem3.Id = 6;
			this.barButtonItem3.Name = "barButtonItem3";
			// 
			// barButtonItem4
			// 
			this.barButtonItem4.Caption = "信号物理量解析";
			this.barButtonItem4.Id = 7;
			this.barButtonItem4.Name = "barButtonItem4";
			// 
			// barButtonItem2
			// 
			this.barButtonItem2.Caption = "barButtonItem2";
			this.barButtonItem2.Id = 5;
			this.barButtonItem2.Name = "barButtonItem2";
			// 
			// barButtonItem5
			// 
			this.barButtonItem5.Caption = "定标";
			this.barButtonItem5.Id = 8;
			this.barButtonItem5.Name = "barButtonItem5";
			// 
			// barButtonItem7
			// 
			this.barButtonItem7.Caption = "计算峰值";
			this.barButtonItem7.Id = 10;
			this.barButtonItem7.Name = "barButtonItem7";
			// 
			// barButtonItem8
			// 
			this.barButtonItem8.Caption = "采样频率";
			this.barButtonItem8.Id = 11;
			this.barButtonItem8.Name = "barButtonItem8";
			// 
			// barButtonItem9
			// 
			this.barButtonItem9.Caption = "灵敏度";
			this.barButtonItem9.Id = 12;
			this.barButtonItem9.Name = "barButtonItem9";
			// 
			// barSubItem4
			// 
			this.barSubItem4.Caption = "参数";
			this.barSubItem4.Id = 13;
			this.barSubItem4.Name = "barSubItem4";
			// 
			// barButtonItem10
			// 
			this.barButtonItem10.Caption = "参数";
			this.barButtonItem10.Id = 14;
			this.barButtonItem10.ImageOptions.DisabledSvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem10.ImageOptions.DisabledSvgImage")));
			this.barButtonItem10.Name = "barButtonItem10";
			// 
			// chart
			// 
			xyDiagram3.AxisX.AutoScaleBreaks.MaxCount = 9;
			xyDiagram3.AxisX.Label.TextPattern = "{A}s";
			xyDiagram3.AxisX.Title.Text = "秒";
			xyDiagram3.AxisX.Title.Visibility = DevExpress.Utils.DefaultBoolean.Default;
			xyDiagram3.AxisX.VisibleInPanesSerializable = "-1";
			xyDiagram3.AxisX.VisualRange.Auto = false;
			xyDiagram3.AxisX.VisualRange.MaxValueSerializable = "9";
			xyDiagram3.AxisX.VisualRange.MinValueSerializable = "0";
			xyDiagram3.AxisX.WholeRange.AutoSideMargins = false;
			xyDiagram3.AxisX.WholeRange.EndSideMargin = 0D;
			xyDiagram3.AxisX.WholeRange.StartSideMargin = 0D;
			xyDiagram3.AxisY.VisibleInPanesSerializable = "-1";
			xyDiagram3.DefaultPane.EnableAxisXScrolling = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram3.DefaultPane.EnableAxisXZooming = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram3.DefaultPane.EnableAxisYScrolling = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram3.DefaultPane.EnableAxisYZooming = DevExpress.Utils.DefaultBoolean.True;
			xyDiagram3.EnableAxisXScrolling = true;
			xyDiagram3.EnableAxisXZooming = true;
			xyDiagram3.EnableAxisYScrolling = true;
			xyDiagram3.EnableAxisYZooming = true;
			this.chart.Diagram = xyDiagram3;
			this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.chart.Location = new System.Drawing.Point(0, 49);
			this.chart.Name = "chart";
			series3.Name = "信号量";
			series3.View = splineSeriesView3;
			this.chart.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series3};
			this.chart.Size = new System.Drawing.Size(826, 478);
			this.chart.TabIndex = 4;
			chartTitle3.Alignment = System.Drawing.StringAlignment.Near;
			chartTitle3.Text = "峰值:0";
			this.chart.Titles.AddRange(new DevExpress.XtraCharts.ChartTitle[] {
            chartTitle3});
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
			// Export
			// 
			this.Export.Caption = "导出";
			this.Export.Id = 18;
			this.Export.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("Export.ImageOptions.SvgImage")));
			this.Export.Name = "Export";
			this.Export.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
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
			((System.ComponentModel.ISupportInitialize)(xyDiagram3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(splineSeriesView3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(series3)).EndInit();
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
		private DevExpress.XtraBars.BarSubItem barSubItem2;
		private DevExpress.XtraBars.BarSubItem barSubItem3;
		private DevExpress.XtraBars.BarSubItem barSubItemParameters;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem3;
		private DevExpress.XtraBars.BarButtonItem barButtonItem4;
		private DevExpress.XtraBars.BarButtonItem barButtonItem5;
		private DevExpress.XtraBars.BarButtonItem barButtonItem6;
		private DevExpress.XtraBars.BarButtonItem barButtonItem7;
		private DevExpress.XtraBars.BarButtonItem barButtonItem8;
		private DevExpress.XtraBars.BarButtonItem barButtonItem9;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraCharts.ChartControl chart;
		private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFileDialog;
		private ParametersView parametersView;
		private DevExpress.XtraBars.BarButtonItem barButtonItem10;
		private DevExpress.XtraBars.BarSubItem barSubItem4;
		private DevExpress.XtraBars.BarSubItem barSubItem5;
		private DevExpress.XtraBars.BarStaticItem statusText;
		private DevExpress.XtraBars.BarButtonItem Preview;
		private DevExpress.XtraBars.BarButtonItem Export;
		private DevExpress.XtraEditors.XtraSaveFileDialog xtraSaveFileDialog;
	}
}

