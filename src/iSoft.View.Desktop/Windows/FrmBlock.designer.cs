namespace iSoft.View.Desktop.Windows
{
  partial class FrmBlock
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBlock));
      this.GrpPassword = new DevComponents.DotNetBar.Controls.GroupPanel();
      this.BtnClosePassword = new DevComponents.DotNetBar.ButtonX();
      this.BtnUnlock = new DevComponents.DotNetBar.ButtonX();
      this.TxtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
      this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
      this.swhLockUnlock = new DevComponents.DotNetBar.Controls.SwitchButton();
      this.BtnLock = new DevComponents.DotNetBar.ButtonX();
      this.labelX1 = new DevComponents.DotNetBar.LabelX();
      this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
      this.labelX2 = new DevComponents.DotNetBar.LabelX();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.GrpPassword.SuspendLayout();
      this.groupPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // GrpPassword
      // 
      this.GrpPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.GrpPassword.CanvasColor = System.Drawing.SystemColors.Control;
      this.GrpPassword.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
      this.GrpPassword.Controls.Add(this.BtnClosePassword);
      this.GrpPassword.Controls.Add(this.BtnUnlock);
      this.GrpPassword.Controls.Add(this.TxtPassword);
      this.GrpPassword.DisabledBackColor = System.Drawing.Color.Empty;
      this.GrpPassword.Location = new System.Drawing.Point(24, 183);
      this.GrpPassword.Name = "GrpPassword";
      this.GrpPassword.Size = new System.Drawing.Size(437, 49);
      // 
      // 
      // 
      this.GrpPassword.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.GrpPassword.Style.BackColorGradientAngle = 90;
      this.GrpPassword.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.GrpPassword.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.GrpPassword.Style.BorderBottomWidth = 1;
      this.GrpPassword.Style.BorderColor = System.Drawing.Color.DimGray;
      this.GrpPassword.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.GrpPassword.Style.BorderLeftWidth = 1;
      this.GrpPassword.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.GrpPassword.Style.BorderRightWidth = 1;
      this.GrpPassword.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.GrpPassword.Style.BorderTopWidth = 1;
      this.GrpPassword.Style.CornerDiameter = 4;
      this.GrpPassword.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
      this.GrpPassword.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
      this.GrpPassword.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.GrpPassword.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
      // 
      // 
      // 
      this.GrpPassword.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      // 
      // 
      // 
      this.GrpPassword.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.GrpPassword.TabIndex = 11;
      this.GrpPassword.Visible = false;
      // 
      // BtnClosePassword
      // 
      this.BtnClosePassword.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.BtnClosePassword.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
      this.BtnClosePassword.Location = new System.Drawing.Point(393, 8);
      this.BtnClosePassword.Name = "BtnClosePassword";
      this.BtnClosePassword.Size = new System.Drawing.Size(31, 29);
      this.BtnClosePassword.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.BtnClosePassword.Symbol = "";
      this.BtnClosePassword.SymbolSize = 11F;
      this.BtnClosePassword.TabIndex = 5;
      this.BtnClosePassword.Click += new System.EventHandler(this.BtnClosePassword_Click);
      // 
      // BtnUnlock
      // 
      this.BtnUnlock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.BtnUnlock.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
      this.BtnUnlock.Enabled = false;
      this.BtnUnlock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnUnlock.Location = new System.Drawing.Point(318, 8);
      this.BtnUnlock.Name = "BtnUnlock";
      this.BtnUnlock.Size = new System.Drawing.Size(72, 29);
      this.BtnUnlock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.BtnUnlock.TabIndex = 4;
      this.BtnUnlock.Text = "Unlock";
      this.BtnUnlock.Click += new System.EventHandler(this.BtnUnlock_Click);
      // 
      // TxtPassword
      // 
      this.TxtPassword.BackColor = System.Drawing.SystemColors.Window;
      // 
      // 
      // 
      this.TxtPassword.Border.Class = "TextBoxBorder";
      this.TxtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.TxtPassword.ButtonCustom.Visible = true;
      this.TxtPassword.DisabledBackColor = System.Drawing.Color.Black;
      this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtPassword.ForeColor = System.Drawing.SystemColors.WindowText;
      this.highlighter1.SetHighlightOnFocus(this.TxtPassword, true);
      this.TxtPassword.Location = new System.Drawing.Point(6, 8);
      this.TxtPassword.Name = "TxtPassword";
      this.TxtPassword.PreventEnterBeep = true;
      this.TxtPassword.Size = new System.Drawing.Size(307, 29);
      this.TxtPassword.TabIndex = 0;
      this.TxtPassword.UseSystemPasswordChar = true;
      this.TxtPassword.WatermarkText = "Enter your password here...";
      this.TxtPassword.ButtonCustomClick += new System.EventHandler(this.TxtPassword_ButtonCustomClick);
      this.TxtPassword.TextChanged += new System.EventHandler(this.TxtPassword_TextChanged);
      // 
      // groupPanel1
      // 
      this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
      this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
      this.groupPanel1.Controls.Add(this.swhLockUnlock);
      this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
      this.groupPanel1.Location = new System.Drawing.Point(24, 183);
      this.groupPanel1.Name = "groupPanel1";
      this.groupPanel1.Size = new System.Drawing.Size(437, 49);
      // 
      // 
      // 
      this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.groupPanel1.Style.BackColorGradientAngle = 90;
      this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.groupPanel1.Style.BorderBottomWidth = 1;
      this.groupPanel1.Style.BorderColor = System.Drawing.Color.DimGray;
      this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.groupPanel1.Style.BorderLeftWidth = 1;
      this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.groupPanel1.Style.BorderRightWidth = 1;
      this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.groupPanel1.Style.BorderTopWidth = 1;
      this.groupPanel1.Style.CornerDiameter = 4;
      this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
      this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
      this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
      // 
      // 
      // 
      this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      // 
      // 
      // 
      this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.groupPanel1.TabIndex = 10;
      // 
      // swhLockUnlock
      // 
      // 
      // 
      // 
      this.swhLockUnlock.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.swhLockUnlock.Location = new System.Drawing.Point(3, 4);
      this.swhLockUnlock.Name = "swhLockUnlock";
      this.swhLockUnlock.OffText = "Blocked";
      this.swhLockUnlock.OffTextColor = System.Drawing.Color.DarkRed;
      this.swhLockUnlock.OnText = "Unblocked";
      this.swhLockUnlock.OnTextColor = System.Drawing.Color.MidnightBlue;
      this.swhLockUnlock.ShowReadOnlyMarker = false;
      this.swhLockUnlock.Size = new System.Drawing.Size(425, 35);
      this.swhLockUnlock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.swhLockUnlock.SwitchClickTogglesValue = true;
      this.swhLockUnlock.SwitchWidth = 64;
      this.swhLockUnlock.TabIndex = 2;
      this.swhLockUnlock.ValueChanged += new System.EventHandler(this.swhLockUnlock_ValueChanged);
      // 
      // BtnLock
      // 
      this.BtnLock.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.BtnLock.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
      this.BtnLock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnLock.Location = new System.Drawing.Point(375, 11);
      this.BtnLock.Name = "BtnLock";
      this.BtnLock.Size = new System.Drawing.Size(105, 29);
      this.BtnLock.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.BtnLock.TabIndex = 8;
      this.BtnLock.Text = "Logout";
      this.BtnLock.Click += new System.EventHandler(this.BtnLock_Click);
      // 
      // labelX1
      // 
      this.labelX1.BackColor = System.Drawing.Color.Gray;
      // 
      // 
      // 
      this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX1.BackgroundStyle.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
      this.labelX1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelX1.Location = new System.Drawing.Point(2, 4);
      this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.labelX1.Name = "labelX1";
      this.labelX1.Size = new System.Drawing.Size(483, 43);
      this.labelX1.TabIndex = 7;
      this.labelX1.Text = "Screen Locked  ";
      this.labelX1.TextAlignment = System.Drawing.StringAlignment.Center;
      // 
      // highlighter1
      // 
      this.highlighter1.ContainerControl = this;
      // 
      // labelX2
      // 
      // 
      // 
      // 
      this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelX2.Location = new System.Drawing.Point(45, 59);
      this.labelX2.Name = "labelX2";
      this.labelX2.Size = new System.Drawing.Size(403, 97);
      this.labelX2.TabIndex = 13;
      this.labelX2.Text = "Su cuenta fue bloqueada temporalmente.\r\n\r\nPara desbloquear su cuenta, simplemente" +
    " deslice el\r\nbotón e ingrese su contraseña.";
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "eye-no.png");
      this.imageList1.Images.SetKeyName(1, "eye.png");
      // 
      // FrmBlock
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(488, 254);
      this.ControlBox = false;
      this.Controls.Add(this.labelX2);
      this.Controls.Add(this.GrpPassword);
      this.Controls.Add(this.groupPanel1);
      this.Controls.Add(this.BtnLock);
      this.Controls.Add(this.labelX1);
      this.DoubleBuffered = true;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmBlock";
      this.ShowIcon = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.TitleText = "Screen Locked";
      this.Shown += new System.EventHandler(this.FrmBlock_Shown);
      this.GrpPassword.ResumeLayout(false);
      this.groupPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private DevComponents.DotNetBar.Controls.GroupPanel GrpPassword;
    private DevComponents.DotNetBar.ButtonX BtnClosePassword;
    private DevComponents.DotNetBar.ButtonX BtnUnlock;
    private DevComponents.DotNetBar.Controls.TextBoxX TxtPassword;
    private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
    private DevComponents.DotNetBar.Controls.SwitchButton swhLockUnlock;
    private DevComponents.DotNetBar.ButtonX BtnLock;
    private DevComponents.DotNetBar.LabelX labelX1;
    private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    private DevComponents.DotNetBar.LabelX labelX2;
    private System.Windows.Forms.ImageList imageList1;
  }
}