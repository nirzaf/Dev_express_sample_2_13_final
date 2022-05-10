namespace sample_2_13 {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
      this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
      this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement4 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement5 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement6 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement8 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.accordionControlElement9 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
      this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
      ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
      this.accordionControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // accordionControl1
      // 
      this.accordionControl1.Controls.Add(this.toggleSwitch1);
      this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
      this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement2,
            this.accordionControlElement3,
            this.accordionControlElement4});
      this.accordionControl1.Location = new System.Drawing.Point(0, 0);
      this.accordionControl1.Name = "accordionControl1";
      this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
      this.accordionControl1.Size = new System.Drawing.Size(260, 445);
      this.accordionControl1.TabIndex = 0;
      this.accordionControl1.Text = "accordionControl1";
      this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
      // 
      // accordionControlElement1
      // 
      this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement5,
            this.accordionControlElement6,
            this.accordionControlElement7});
      this.accordionControlElement1.Expanded = true;
      this.accordionControlElement1.Name = "accordionControlElement1";
      this.accordionControlElement1.Text = "Element1";
      // 
      // accordionControlElement2
      // 
      this.accordionControlElement2.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement8,
            this.accordionControlElement9});
      this.accordionControlElement2.Expanded = true;
      this.accordionControlElement2.Name = "accordionControlElement2";
      this.accordionControlElement2.Text = "Element2";
      // 
      // accordionControlElement3
      // 
      this.accordionControlElement3.Name = "accordionControlElement3";
      this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement3.Text = "Element3";
      // 
      // accordionControlElement4
      // 
      this.accordionControlElement4.Name = "accordionControlElement4";
      this.accordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement4.Text = "Element4";
      // 
      // accordionControlElement5
      // 
      this.accordionControlElement5.HeaderControl = this.toggleSwitch1;
      this.accordionControlElement5.HeaderTemplate.AddRange(new DevExpress.XtraBars.Navigation.HeaderElementInfo[] {
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons),
            new DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl)});
      this.accordionControlElement5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("accordionControlElement5.ImageOptions.SvgImage")));
      this.accordionControlElement5.Name = "accordionControlElement5";
      this.accordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement5.Text = "Element5";
      // 
      // accordionControlElement6
      // 
      this.accordionControlElement6.Name = "accordionControlElement6";
      this.accordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement6.Text = "Element6";
      // 
      // accordionControlElement7
      // 
      this.accordionControlElement7.Name = "accordionControlElement7";
      this.accordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement7.Text = "Element7";
      // 
      // accordionControlElement8
      // 
      this.accordionControlElement8.Name = "accordionControlElement8";
      this.accordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement8.Text = "Element8";
      // 
      // accordionControlElement9
      // 
      this.accordionControlElement9.Name = "accordionControlElement9";
      this.accordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
      this.accordionControlElement9.Text = "Element9";
      // 
      // toggleSwitch1
      // 
      this.toggleSwitch1.Location = new System.Drawing.Point(135, 91);
      this.toggleSwitch1.Name = "toggleSwitch1";
      this.toggleSwitch1.Properties.OffText = "Off";
      this.toggleSwitch1.Properties.OnText = "On";
      this.toggleSwitch1.Size = new System.Drawing.Size(95, 18);
      this.toggleSwitch1.TabIndex = 1;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(708, 445);
      this.Controls.Add(this.accordionControl1);
      this.Name = "Form1";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
      this.accordionControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
    private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement5;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement6;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement8;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement9;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
    private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement4;
  }
}

