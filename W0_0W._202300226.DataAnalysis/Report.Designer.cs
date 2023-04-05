namespace W0_0W._202300226.DataAnalysis;

partial class Report
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

	#region Designer generated code

	/// <summary>
	/// Required method for Designer support - do not modify
	/// the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
			this.components = new System.ComponentModel.Container();
			DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo objectConstructorInfo1 = new DevExpress.DataAccess.ObjectBinding.ObjectConstructorInfo();
			DevExpress.DataAccess.ObjectBinding.Parameter parameter1 = new DevExpress.DataAccess.ObjectBinding.Parameter();
			this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
			this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
			this.Detail = new DevExpress.XtraReports.UI.DetailBand();
			this.xrChart1 = new DevExpress.XtraReports.UI.XRChart();
			this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
			this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel6 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
			this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
			this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.xrChart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// TopMargin
			// 
			this.TopMargin.Name = "TopMargin";
			// 
			// BottomMargin
			// 
			this.BottomMargin.Name = "BottomMargin";
			// 
			// Detail
			// 
			this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrChart1});
			this.Detail.HeightF = 200F;
			this.Detail.Name = "Detail";
			// 
			// xrChart1
			// 
			this.xrChart1.BorderColor = System.Drawing.Color.Black;
			this.xrChart1.Borders = DevExpress.XtraPrinting.BorderSide.None;
			this.xrChart1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrChart1.Name = "xrChart1";
			this.xrChart1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
			this.xrChart1.SizeF = new System.Drawing.SizeF(650F, 200F);
			// 
			// ReportHeader
			// 
			this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.xrLabel6,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3,
            this.xrLabel2,
            this.xrLabel1});
			this.ReportHeader.Name = "ReportHeader";
			// 
			// xrLabel9
			// 
			this.xrLabel9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'{0:yyyy-MM-dd}\',[TestTime])")});
			this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(416.6667F, 43.41668F);
			this.xrLabel9.Multiline = true;
			this.xrLabel9.Name = "xrLabel9";
			this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel9.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel9.Text = "xrLabel9";
			// 
			// xrLabel8
			// 
			this.xrLabel8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[MaxValue]")});
			this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(416.6667F, 77F);
			this.xrLabel8.Multiline = true;
			this.xrLabel8.Name = "xrLabel8";
			this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel8.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel8.Text = "xrLabel8";
			// 
			// xrLabel7
			// 
			this.xrLabel7.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[TesterName]")});
			this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(152.0833F, 43.41668F);
			this.xrLabel7.Multiline = true;
			this.xrLabel7.Name = "xrLabel7";
			this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel7.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel7.Text = "xrLabel7";
			// 
			// xrLabel6
			// 
			this.xrLabel6.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 77F);
			this.xrLabel6.Multiline = true;
			this.xrLabel6.Name = "xrLabel6";
			this.xrLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel6.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel6.Text = "测试设备：";
			// 
			// xrLabel5
			// 
			this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(285.4167F, 77F);
			this.xrLabel5.Multiline = true;
			this.xrLabel5.Name = "xrLabel5";
			this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel5.SizeF = new System.Drawing.SizeF(79.16661F, 23F);
			this.xrLabel5.Text = "峰值：";
			// 
			// xrLabel4
			// 
			this.xrLabel4.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[DeviceName]")});
			this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(152.0833F, 77F);
			this.xrLabel4.Multiline = true;
			this.xrLabel4.Name = "xrLabel4";
			this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel4.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel4.Text = "测试设备：";
			// 
			// xrLabel3
			// 
			this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(285.4167F, 43.41668F);
			this.xrLabel3.Multiline = true;
			this.xrLabel3.Name = "xrLabel3";
			this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel3.SizeF = new System.Drawing.SizeF(79.16664F, 23F);
			this.xrLabel3.Text = "测试时间：";
			// 
			// xrLabel2
			// 
			this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(48.95833F, 43.41668F);
			this.xrLabel2.Multiline = true;
			this.xrLabel2.Name = "xrLabel2";
			this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel2.SizeF = new System.Drawing.SizeF(100F, 23F);
			this.xrLabel2.Text = "测试人员：";
			// 
			// xrLabel1
			// 
			this.xrLabel1.Font = new DevExpress.Drawing.DXFont("Microsoft YaHei", 20F, DevExpress.Drawing.DXFontStyle.Bold);
			this.xrLabel1.ForeColor = System.Drawing.Color.Black;
			this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
			this.xrLabel1.Multiline = true;
			this.xrLabel1.Name = "xrLabel1";
			this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
			this.xrLabel1.SizeF = new System.Drawing.SizeF(203.125F, 33.41667F);
			this.xrLabel1.StylePriority.UseFont = false;
			this.xrLabel1.StylePriority.UseForeColor = false;
			this.xrLabel1.Text = "测试报告";
			// 
			// objectDataSource1
			// 
			parameter1.Name = "config";
			parameter1.Type = typeof(global::W0_0W._202300226.DataAnalysis.Model.Config);
			parameter1.ValueInfo = "(Collection)";
			objectConstructorInfo1.Parameters.AddRange(new DevExpress.DataAccess.ObjectBinding.Parameter[] {
            parameter1});
			this.objectDataSource1.Constructor = objectConstructorInfo1;
			this.objectDataSource1.DataSource = typeof(global::W0_0W._202300226.DataAnalysis.Model.SignalFactory);
			this.objectDataSource1.Name = "objectDataSource1";
			// 
			// XtraReport1
			// 
			this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader});
			this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
			this.DataSource = this.objectDataSource1;
			this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
			this.Version = "22.2";
			((System.ComponentModel.ISupportInitialize)(this.xrChart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

	}

	#endregion

	private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
	private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
	private DevExpress.XtraReports.UI.DetailBand Detail;
	private DevExpress.XtraReports.UI.XRChart xrChart1;
	private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
	private DevExpress.XtraReports.UI.XRLabel xrLabel1;
	private DevExpress.XtraReports.UI.XRLabel xrLabel5;
	private DevExpress.XtraReports.UI.XRLabel xrLabel4;
	private DevExpress.XtraReports.UI.XRLabel xrLabel3;
	private DevExpress.XtraReports.UI.XRLabel xrLabel2;
	public DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
	private DevExpress.XtraReports.UI.XRLabel xrLabel9;
	private DevExpress.XtraReports.UI.XRLabel xrLabel8;
	private DevExpress.XtraReports.UI.XRLabel xrLabel7;
	private DevExpress.XtraReports.UI.XRLabel xrLabel6;
}
