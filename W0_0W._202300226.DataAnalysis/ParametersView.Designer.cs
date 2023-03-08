namespace W0_0W._202300226.DataAnalysis
{
	partial class ParametersView
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
		///
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsUIButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			this.RateTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.configBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.ValidStartTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.SensitivityTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			this.ItemForRate = new DevExpress.XtraLayout.LayoutControlItem();
			this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
			this.ItemForSensitivity = new DevExpress.XtraLayout.LayoutControlItem();
			this.ItemForValidStart = new DevExpress.XtraLayout.LayoutControlItem();
			this.labelControl = new DevExpress.XtraEditors.LabelControl();
			this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			this.DeviceNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
			this.dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.RateTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ValidStartTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SensitivityTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForRate)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForSensitivity)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForValidStart)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.DeviceNameTextEdit.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			this.dataLayoutControl1.AllowCustomization = false;
			this.dataLayoutControl1.Controls.Add(this.RateTextEdit);
			this.dataLayoutControl1.Controls.Add(this.ValidStartTextEdit);
			this.dataLayoutControl1.Controls.Add(this.SensitivityTextEdit);
			this.dataLayoutControl1.Controls.Add(this.DeviceNameTextEdit);
			this.dataLayoutControl1.DataSource = this.configBindingSource;
			this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataLayoutControl1.Location = new System.Drawing.Point(0, 30);
			this.dataLayoutControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dataLayoutControl1.Name = "dataLayoutControl1";
			this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(751, 1398, 650, 400);
			this.dataLayoutControl1.Root = this.layoutControlGroup1;
			this.dataLayoutControl1.Size = new System.Drawing.Size(933, 551);
			this.dataLayoutControl1.TabIndex = 0;
			// 
			// RateTextEdit
			// 
			this.RateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configBindingSource, "Rate", true));
			this.RateTextEdit.Location = new System.Drawing.Point(96, 36);
			this.RateTextEdit.Name = "RateTextEdit";
			this.RateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.RateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.RateTextEdit.Properties.Mask.EditMask = "##0.000";
			this.RateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.RateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.RateTextEdit.Size = new System.Drawing.Size(699, 20);
			this.RateTextEdit.StyleController = this.dataLayoutControl1;
			this.RateTextEdit.TabIndex = 4;
			// 
			// configBindingSource
			// 
			this.configBindingSource.DataSource = typeof(W0_0W._202300226.DataAnalysis.Config);
			// 
			// ValidStartTextEdit
			// 
			this.ValidStartTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configBindingSource, "ValidStart", true));
			this.ValidStartTextEdit.Location = new System.Drawing.Point(96, 12);
			this.ValidStartTextEdit.Name = "ValidStartTextEdit";
			this.ValidStartTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.ValidStartTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.ValidStartTextEdit.Properties.Mask.EditMask = "N0";
			this.ValidStartTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.ValidStartTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.ValidStartTextEdit.Size = new System.Drawing.Size(825, 20);
			this.ValidStartTextEdit.StyleController = this.dataLayoutControl1;
			this.ValidStartTextEdit.TabIndex = 5;
			// 
			// SensitivityTextEdit
			// 
			this.SensitivityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configBindingSource, "Sensitivity", true));
			this.SensitivityTextEdit.Location = new System.Drawing.Point(96, 60);
			this.SensitivityTextEdit.Name = "SensitivityTextEdit";
			this.SensitivityTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			this.SensitivityTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			this.SensitivityTextEdit.Properties.Mask.EditMask = "N0";
			this.SensitivityTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			this.SensitivityTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			this.SensitivityTextEdit.Size = new System.Drawing.Size(825, 20);
			this.SensitivityTextEdit.StyleController = this.dataLayoutControl1;
			this.SensitivityTextEdit.TabIndex = 6;
			// 
			// layoutControlGroup1
			// 
			this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			this.layoutControlGroup1.GroupBordersVisible = false;
			this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2,
            this.ItemForSensitivity,
            this.ItemForValidStart,
            this.layoutControlItem1});
			this.layoutControlGroup1.Name = "Root";
			this.layoutControlGroup1.Size = new System.Drawing.Size(933, 551);
			this.layoutControlGroup1.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			this.layoutControlGroup2.AllowDrawBackground = false;
			this.layoutControlGroup2.GroupBordersVisible = false;
			this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForRate,
            this.simpleLabelItem1});
			this.layoutControlGroup2.Location = new System.Drawing.Point(0, 24);
			this.layoutControlGroup2.Name = "autoGeneratedGroup0";
			this.layoutControlGroup2.Size = new System.Drawing.Size(913, 24);
			// 
			// ItemForRate
			// 
			this.ItemForRate.Control = this.RateTextEdit;
			this.ItemForRate.Location = new System.Drawing.Point(0, 0);
			this.ItemForRate.Name = "ItemForRate";
			this.ItemForRate.Size = new System.Drawing.Size(787, 24);
			this.ItemForRate.Text = "采样率";
			this.ItemForRate.TextSize = new System.Drawing.Size(72, 14);
			// 
			// simpleLabelItem1
			// 
			this.simpleLabelItem1.AllowHotTrack = false;
			this.simpleLabelItem1.Location = new System.Drawing.Point(787, 0);
			this.simpleLabelItem1.Name = "simpleLabelItem1";
			this.simpleLabelItem1.Size = new System.Drawing.Size(126, 24);
			this.simpleLabelItem1.Text = "k/s";
			this.simpleLabelItem1.TextSize = new System.Drawing.Size(72, 14);
			// 
			// ItemForSensitivity
			// 
			this.ItemForSensitivity.Control = this.SensitivityTextEdit;
			this.ItemForSensitivity.Location = new System.Drawing.Point(0, 48);
			this.ItemForSensitivity.Name = "ItemForSensitivity";
			this.ItemForSensitivity.Size = new System.Drawing.Size(913, 24);
			this.ItemForSensitivity.Text = "灵敏度";
			this.ItemForSensitivity.TextSize = new System.Drawing.Size(72, 14);
			// 
			// ItemForValidStart
			// 
			this.ItemForValidStart.Control = this.ValidStartTextEdit;
			this.ItemForValidStart.Location = new System.Drawing.Point(0, 0);
			this.ItemForValidStart.Name = "ItemForValidStart";
			this.ItemForValidStart.Size = new System.Drawing.Size(913, 24);
			this.ItemForValidStart.Text = "有效数据起点";
			this.ItemForValidStart.TextSize = new System.Drawing.Size(72, 14);
			// 
			// labelControl
			// 
			this.labelControl.AllowHtmlString = true;
			this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
			this.labelControl.Appearance.Options.UseFont = true;
			this.labelControl.Appearance.Options.UseForeColor = true;
			this.labelControl.Appearance.Options.UseTextOptions = true;
			this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
			this.labelControl.Location = new System.Drawing.Point(0, 0);
			this.labelControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.labelControl.Name = "labelControl";
			this.labelControl.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
			this.labelControl.Size = new System.Drawing.Size(933, 30);
			this.labelControl.TabIndex = 1;
			this.labelControl.Text = "参数";
			// 
			// windowsUIButtonPanelMain
			// 
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
			this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
			this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
			this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
			this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
			this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
			this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
			this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
			this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
			this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
			this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
			windowsUIButtonImageOptions1.ImageUri.Uri = "Save;Size32x32;GrayScaled";
			windowsUIButtonImageOptions2.ImageUri.Uri = "SaveAndClose;Size32x32;GrayScaled";
			this.windowsUIButtonPanelMain.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("保存", true, windowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("保存并关闭", true, windowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false)});
			this.windowsUIButtonPanelMain.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
			this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.windowsUIButtonPanelMain.EnableImageTransparency = true;
			this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
			this.windowsUIButtonPanelMain.Location = new System.Drawing.Point(0, 581);
			this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(5);
			this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 65);
			this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(70, 65);
			this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
			this.windowsUIButtonPanelMain.Size = new System.Drawing.Size(933, 65);
			this.windowsUIButtonPanelMain.TabIndex = 3;
			this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
			this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
			this.windowsUIButtonPanelMain.ButtonClick += new DevExpress.XtraBars.Docking2010.ButtonEventHandler(this.windowsUIButtonPanelMain_ButtonClick);
			// 
			// DeviceNameTextEdit
			// 
			this.DeviceNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.configBindingSource, "DeviceName", true));
			this.DeviceNameTextEdit.Location = new System.Drawing.Point(96, 84);
			this.DeviceNameTextEdit.Name = "DeviceNameTextEdit";
			this.DeviceNameTextEdit.Size = new System.Drawing.Size(825, 20);
			this.DeviceNameTextEdit.StyleController = this.dataLayoutControl1;
			this.DeviceNameTextEdit.TabIndex = 7;
			// 
			// layoutControlItem1
			// 
			this.layoutControlItem1.Control = this.DeviceNameTextEdit;
			this.layoutControlItem1.CustomizationFormText = "设备号";
			this.layoutControlItem1.Location = new System.Drawing.Point(0, 72);
			this.layoutControlItem1.Name = "layoutControlItem1";
			this.layoutControlItem1.Size = new System.Drawing.Size(913, 459);
			this.layoutControlItem1.Text = "设备号";
			this.layoutControlItem1.TextSize = new System.Drawing.Size(72, 14);
			// 
			// ParametersView
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			this.Controls.Add(this.dataLayoutControl1);
			this.Controls.Add(this.labelControl);
			this.Controls.Add(this.windowsUIButtonPanelMain);
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "ParametersView";
			this.Size = new System.Drawing.Size(933, 646);
			this.Load += new System.EventHandler(this.ParametersView_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
			this.dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.RateTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ValidStartTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SensitivityTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForRate)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForSensitivity)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ItemForValidStart)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.DeviceNameTextEdit.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
		private DevExpress.XtraEditors.LabelControl labelControl;
		private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
		private System.Windows.Forms.BindingSource configBindingSource;
		private DevExpress.XtraEditors.TextEdit RateTextEdit;
		private DevExpress.XtraEditors.TextEdit ValidStartTextEdit;
		private DevExpress.XtraEditors.TextEdit SensitivityTextEdit;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
		private DevExpress.XtraLayout.LayoutControlItem ItemForRate;
		private DevExpress.XtraLayout.LayoutControlItem ItemForValidStart;
		private DevExpress.XtraLayout.LayoutControlItem ItemForSensitivity;
		private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
		private DevExpress.XtraEditors.TextEdit DeviceNameTextEdit;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
	}
}
