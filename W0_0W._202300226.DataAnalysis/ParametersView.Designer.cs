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
			components = new System.ComponentModel.Container();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsuiButtonImageOptions1 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions windowsuiButtonImageOptions2 = new DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions();
			dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
			RateTextEdit = new DevExpress.XtraEditors.TextEdit();
			configBindingSource = new System.Windows.Forms.BindingSource(components);
			ValidStartTextEdit = new DevExpress.XtraEditors.TextEdit();
			SensitivityTextEdit = new DevExpress.XtraEditors.TextEdit();
			DeviceNameTextEdit = new DevExpress.XtraEditors.TextEdit();
			LimitingSignalFilterDeltaTextEdit = new DevExpress.XtraEditors.TextEdit();
			AverageSignalFilterNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			MedianSignalFilterNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
			layoutControlGroup = new DevExpress.XtraLayout.LayoutControlGroup();
			layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
			ItemForRate = new DevExpress.XtraLayout.LayoutControlItem();
			simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
			ItemForSensitivity = new DevExpress.XtraLayout.LayoutControlItem();
			ItemForValidStart = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
			simpleLabelItem2 = new DevExpress.XtraLayout.SimpleLabelItem();
			layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
			layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
			labelControl = new DevExpress.XtraEditors.LabelControl();
			windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).BeginInit();
			dataLayoutControl1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)RateTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)configBindingSource).BeginInit();
			((System.ComponentModel.ISupportInitialize)ValidStartTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)SensitivityTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)DeviceNameTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)LimitingSignalFilterDeltaTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)AverageSignalFilterNumberTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)MedianSignalFilterNumberTextEdit.Properties).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).BeginInit();
			((System.ComponentModel.ISupportInitialize)ItemForRate).BeginInit();
			((System.ComponentModel.ISupportInitialize)simpleLabelItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)ItemForSensitivity).BeginInit();
			((System.ComponentModel.ISupportInitialize)ItemForValidStart).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).BeginInit();
			((System.ComponentModel.ISupportInitialize)simpleLabelItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).BeginInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).BeginInit();
			SuspendLayout();
			// 
			// dataLayoutControl1
			// 
			dataLayoutControl1.AllowCustomization = false;
			dataLayoutControl1.Controls.Add(RateTextEdit);
			dataLayoutControl1.Controls.Add(ValidStartTextEdit);
			dataLayoutControl1.Controls.Add(SensitivityTextEdit);
			dataLayoutControl1.Controls.Add(DeviceNameTextEdit);
			dataLayoutControl1.Controls.Add(LimitingSignalFilterDeltaTextEdit);
			dataLayoutControl1.Controls.Add(AverageSignalFilterNumberTextEdit);
			dataLayoutControl1.Controls.Add(MedianSignalFilterNumberTextEdit);
			dataLayoutControl1.DataSource = configBindingSource;
			dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			dataLayoutControl1.Location = new System.Drawing.Point(0, 30);
			dataLayoutControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			dataLayoutControl1.Name = "dataLayoutControl1";
			dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(751, 1398, 650, 400);
			dataLayoutControl1.Root = layoutControlGroup;
			dataLayoutControl1.Size = new System.Drawing.Size(560, 348);
			dataLayoutControl1.TabIndex = 0;
			// 
			// RateTextEdit
			// 
			RateTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", configBindingSource, "Rate", true));
			RateTextEdit.Location = new System.Drawing.Point(172, 36);
			RateTextEdit.Name = "RateTextEdit";
			RateTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			RateTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			RateTextEdit.Properties.Mask.EditMask = "##0.000";
			RateTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			RateTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			RateTextEdit.Size = new System.Drawing.Size(224, 20);
			RateTextEdit.StyleController = dataLayoutControl1;
			RateTextEdit.TabIndex = 2;
			// 
			// configBindingSource
			// 
			configBindingSource.DataSource = typeof(Model.Config);
			// 
			// ValidStartTextEdit
			// 
			ValidStartTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", configBindingSource, "ValidStart", true));
			ValidStartTextEdit.Location = new System.Drawing.Point(172, 12);
			ValidStartTextEdit.Name = "ValidStartTextEdit";
			ValidStartTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			ValidStartTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			ValidStartTextEdit.Properties.Mask.EditMask = "N0";
			ValidStartTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			ValidStartTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			ValidStartTextEdit.Size = new System.Drawing.Size(376, 20);
			ValidStartTextEdit.StyleController = dataLayoutControl1;
			ValidStartTextEdit.TabIndex = 0;
			// 
			// SensitivityTextEdit
			// 
			SensitivityTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", configBindingSource, "Sensitivity", true));
			SensitivityTextEdit.Location = new System.Drawing.Point(172, 60);
			SensitivityTextEdit.Name = "SensitivityTextEdit";
			SensitivityTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			SensitivityTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			SensitivityTextEdit.Properties.Mask.EditMask = "##";
			SensitivityTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			SensitivityTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			SensitivityTextEdit.Size = new System.Drawing.Size(224, 20);
			SensitivityTextEdit.StyleController = dataLayoutControl1;
			SensitivityTextEdit.TabIndex = 3;
			// 
			// DeviceNameTextEdit
			// 
			DeviceNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", configBindingSource, "DeviceName", true));
			DeviceNameTextEdit.Location = new System.Drawing.Point(172, 84);
			DeviceNameTextEdit.Name = "DeviceNameTextEdit";
			DeviceNameTextEdit.Size = new System.Drawing.Size(376, 20);
			DeviceNameTextEdit.StyleController = dataLayoutControl1;
			DeviceNameTextEdit.TabIndex = 4;
			// 
			// LimitingSignalFilterDeltaTextEdit
			// 
			LimitingSignalFilterDeltaTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", configBindingSource, "LimitingSignalFilterDelta", true));
			LimitingSignalFilterDeltaTextEdit.Location = new System.Drawing.Point(172, 108);
			LimitingSignalFilterDeltaTextEdit.Name = "LimitingSignalFilterDeltaTextEdit";
			LimitingSignalFilterDeltaTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			LimitingSignalFilterDeltaTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			LimitingSignalFilterDeltaTextEdit.Properties.Mask.EditMask = "N0";
			LimitingSignalFilterDeltaTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			LimitingSignalFilterDeltaTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			LimitingSignalFilterDeltaTextEdit.Size = new System.Drawing.Size(376, 20);
			LimitingSignalFilterDeltaTextEdit.StyleController = dataLayoutControl1;
			LimitingSignalFilterDeltaTextEdit.TabIndex = 5;
			// 
			// AverageSignalFilterNumberTextEdit
			// 
			AverageSignalFilterNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", configBindingSource, "AverageSignalFilterNumber", true));
			AverageSignalFilterNumberTextEdit.Location = new System.Drawing.Point(172, 132);
			AverageSignalFilterNumberTextEdit.Name = "AverageSignalFilterNumberTextEdit";
			AverageSignalFilterNumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			AverageSignalFilterNumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			AverageSignalFilterNumberTextEdit.Properties.Mask.EditMask = "N0";
			AverageSignalFilterNumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			AverageSignalFilterNumberTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			AverageSignalFilterNumberTextEdit.Size = new System.Drawing.Size(376, 20);
			AverageSignalFilterNumberTextEdit.StyleController = dataLayoutControl1;
			AverageSignalFilterNumberTextEdit.TabIndex = 6;
			// 
			// MedianSignalFilterNumberTextEdit
			// 
			MedianSignalFilterNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", configBindingSource, "MedianSignalFilterNumber", true));
			MedianSignalFilterNumberTextEdit.Location = new System.Drawing.Point(172, 156);
			MedianSignalFilterNumberTextEdit.Name = "MedianSignalFilterNumberTextEdit";
			MedianSignalFilterNumberTextEdit.Properties.Appearance.Options.UseTextOptions = true;
			MedianSignalFilterNumberTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
			MedianSignalFilterNumberTextEdit.Properties.Mask.EditMask = "N0";
			MedianSignalFilterNumberTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
			MedianSignalFilterNumberTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
			MedianSignalFilterNumberTextEdit.Size = new System.Drawing.Size(376, 20);
			MedianSignalFilterNumberTextEdit.StyleController = dataLayoutControl1;
			MedianSignalFilterNumberTextEdit.TabIndex = 7;
			// 
			// layoutControlGroup
			// 
			layoutControlGroup.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
			layoutControlGroup.GroupBordersVisible = false;
			layoutControlGroup.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { layoutControlGroup2, ItemForSensitivity, ItemForValidStart, layoutControlItem1, simpleLabelItem2, layoutControlItem2, layoutControlItem3, layoutControlItem4 });
			layoutControlGroup.Name = "layoutControlGroup";
			layoutControlGroup.Size = new System.Drawing.Size(560, 348);
			layoutControlGroup.TextVisible = false;
			// 
			// layoutControlGroup2
			// 
			layoutControlGroup2.AllowDrawBackground = false;
			layoutControlGroup2.GroupBordersVisible = false;
			layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] { ItemForRate, simpleLabelItem1 });
			layoutControlGroup2.Location = new System.Drawing.Point(0, 24);
			layoutControlGroup2.Name = "autoGeneratedGroup0";
			layoutControlGroup2.Size = new System.Drawing.Size(540, 24);
			// 
			// ItemForRate
			// 
			ItemForRate.Control = RateTextEdit;
			ItemForRate.Location = new System.Drawing.Point(0, 0);
			ItemForRate.Name = "ItemForRate";
			ItemForRate.Size = new System.Drawing.Size(388, 24);
			ItemForRate.Text = "采样率";
			ItemForRate.TextSize = new System.Drawing.Size(148, 14);
			// 
			// simpleLabelItem1
			// 
			simpleLabelItem1.AllowHotTrack = false;
			simpleLabelItem1.Location = new System.Drawing.Point(388, 0);
			simpleLabelItem1.Name = "simpleLabelItem1";
			simpleLabelItem1.Size = new System.Drawing.Size(152, 24);
			simpleLabelItem1.Text = "k/s";
			simpleLabelItem1.TextSize = new System.Drawing.Size(148, 14);
			// 
			// ItemForSensitivity
			// 
			ItemForSensitivity.Control = SensitivityTextEdit;
			ItemForSensitivity.Location = new System.Drawing.Point(0, 48);
			ItemForSensitivity.Name = "ItemForSensitivity";
			ItemForSensitivity.Size = new System.Drawing.Size(388, 24);
			ItemForSensitivity.Text = "灵敏度";
			ItemForSensitivity.TextSize = new System.Drawing.Size(148, 14);
			// 
			// ItemForValidStart
			// 
			ItemForValidStart.Control = ValidStartTextEdit;
			ItemForValidStart.Location = new System.Drawing.Point(0, 0);
			ItemForValidStart.Name = "ItemForValidStart";
			ItemForValidStart.Size = new System.Drawing.Size(540, 24);
			ItemForValidStart.Text = "有效数据起点";
			ItemForValidStart.TextSize = new System.Drawing.Size(148, 14);
			// 
			// layoutControlItem1
			// 
			layoutControlItem1.Control = DeviceNameTextEdit;
			layoutControlItem1.CustomizationFormText = "设备号";
			layoutControlItem1.Location = new System.Drawing.Point(0, 72);
			layoutControlItem1.Name = "layoutControlItem1";
			layoutControlItem1.Size = new System.Drawing.Size(540, 24);
			layoutControlItem1.Text = "设备号";
			layoutControlItem1.TextSize = new System.Drawing.Size(148, 14);
			// 
			// simpleLabelItem2
			// 
			simpleLabelItem2.AllowHotTrack = false;
			simpleLabelItem2.Location = new System.Drawing.Point(388, 48);
			simpleLabelItem2.Name = "simpleLabelItem2";
			simpleLabelItem2.Size = new System.Drawing.Size(152, 24);
			simpleLabelItem2.Text = "%";
			simpleLabelItem2.TextSize = new System.Drawing.Size(148, 14);
			// 
			// layoutControlItem2
			// 
			layoutControlItem2.Control = LimitingSignalFilterDeltaTextEdit;
			layoutControlItem2.Location = new System.Drawing.Point(0, 96);
			layoutControlItem2.Name = "layoutControlItem2";
			layoutControlItem2.Size = new System.Drawing.Size(540, 24);
			layoutControlItem2.Text = "限幅滤波法-最大偏差值";
			layoutControlItem2.TextSize = new System.Drawing.Size(148, 14);
			// 
			// layoutControlItem3
			// 
			layoutControlItem3.Control = AverageSignalFilterNumberTextEdit;
			layoutControlItem3.Location = new System.Drawing.Point(0, 120);
			layoutControlItem3.Name = "layoutControlItem3";
			layoutControlItem3.Size = new System.Drawing.Size(540, 24);
			layoutControlItem3.Text = "算术平均滤波法-连续采样数";
			layoutControlItem3.TextSize = new System.Drawing.Size(148, 14);
			// 
			// layoutControlItem4
			// 
			layoutControlItem4.Control = MedianSignalFilterNumberTextEdit;
			layoutControlItem4.Location = new System.Drawing.Point(0, 144);
			layoutControlItem4.Name = "layoutControlItem4";
			layoutControlItem4.Size = new System.Drawing.Size(540, 184);
			layoutControlItem4.Text = "中位值滤波法-连续采样数";
			layoutControlItem4.TextSize = new System.Drawing.Size(148, 14);
			// 
			// labelControl
			// 
			labelControl.AllowHtmlString = true;
			labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(140, 140, 140);
			labelControl.Appearance.Options.UseFont = true;
			labelControl.Appearance.Options.UseForeColor = true;
			labelControl.Appearance.Options.UseTextOptions = true;
			labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
			labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
			labelControl.Dock = System.Windows.Forms.DockStyle.Top;
			labelControl.Location = new System.Drawing.Point(0, 0);
			labelControl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			labelControl.Name = "labelControl";
			labelControl.Padding = new System.Windows.Forms.Padding(12, 5, 0, 0);
			labelControl.Size = new System.Drawing.Size(560, 30);
			labelControl.TabIndex = 1;
			labelControl.Text = "参数";
			// 
			// windowsUIButtonPanelMain
			// 
			windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(130, 130, 130);
			windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
			windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(130, 130, 130);
			windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
			windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
			windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
			windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
			windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
			windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(159, 159, 159);
			windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
			windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(159, 159, 159);
			windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
			windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
			windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
			windowsUIButtonPanelMain.BackColor = System.Drawing.Color.Black;
			windowsuiButtonImageOptions1.ImageUri.Uri = "Save;Size32x32;GrayScaled";
			windowsuiButtonImageOptions2.ImageUri.Uri = "SaveAndClose;Size32x32;GrayScaled";
			windowsUIButtonPanelMain.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] { new DevExpress.XtraBars.Docking2010.WindowsUIButton("保存", true, windowsuiButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false), new DevExpress.XtraBars.Docking2010.WindowsUIButton("保存并关闭", true, windowsuiButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1, false) });
			windowsUIButtonPanelMain.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight;
			windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
			windowsUIButtonPanelMain.EnableImageTransparency = true;
			windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
			windowsUIButtonPanelMain.Location = new System.Drawing.Point(0, 378);
			windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(5);
			windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 65);
			windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(70, 65);
			windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
			windowsUIButtonPanelMain.Size = new System.Drawing.Size(560, 65);
			windowsUIButtonPanelMain.TabIndex = 3;
			windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
			windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
			windowsUIButtonPanelMain.ButtonClick += windowsUIButtonPanelMain_ButtonClick;
			// 
			// ParametersView
			// 
			Appearance.BackColor = System.Drawing.Color.White;
			Appearance.Options.UseBackColor = true;
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
			AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
			Controls.Add(dataLayoutControl1);
			Controls.Add(labelControl);
			Controls.Add(windowsUIButtonPanelMain);
			Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			Name = "ParametersView";
			Size = new System.Drawing.Size(560, 443);
			Load += ParametersView_Load;
			((System.ComponentModel.ISupportInitialize)dataLayoutControl1).EndInit();
			dataLayoutControl1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)RateTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)configBindingSource).EndInit();
			((System.ComponentModel.ISupportInitialize)ValidStartTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)SensitivityTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)DeviceNameTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)LimitingSignalFilterDeltaTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)AverageSignalFilterNumberTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)MedianSignalFilterNumberTextEdit.Properties).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlGroup2).EndInit();
			((System.ComponentModel.ISupportInitialize)ItemForRate).EndInit();
			((System.ComponentModel.ISupportInitialize)simpleLabelItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)ItemForSensitivity).EndInit();
			((System.ComponentModel.ISupportInitialize)ItemForValidStart).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem1).EndInit();
			((System.ComponentModel.ISupportInitialize)simpleLabelItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem2).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem3).EndInit();
			((System.ComponentModel.ISupportInitialize)layoutControlItem4).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
		private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup;
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
		private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem2;
		private DevExpress.XtraEditors.TextEdit LimitingSignalFilterDeltaTextEdit;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
		private DevExpress.XtraEditors.TextEdit AverageSignalFilterNumberTextEdit;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
		private DevExpress.XtraEditors.TextEdit MedianSignalFilterNumberTextEdit;
		private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
	}
}
