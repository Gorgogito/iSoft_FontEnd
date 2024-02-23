namespace iSoft.View.Desktop.Windows
{
  partial class FrmLogin
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
      this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
      this.BtnCancelar = new DevComponents.DotNetBar.ButtonX();
      this.BtnAceptar = new DevComponents.DotNetBar.ButtonX();
      this.labelX4 = new DevComponents.DotNetBar.LabelX();
      this.GrpEmpresa = new DevComponents.DotNetBar.Controls.GroupPanel();
      this.CboEmpresa = new DevComponents.DotNetBar.Controls.ComboTree();
      this.labelX3 = new DevComponents.DotNetBar.LabelX();
      this.groupPanel2 = new DevComponents.DotNetBar.Controls.GroupPanel();
      this.labelX2 = new DevComponents.DotNetBar.LabelX();
      this.TxtUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
      this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
      this.labelX1 = new DevComponents.DotNetBar.LabelX();
      this.TxtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
      this.line2 = new DevComponents.DotNetBar.Controls.Line();
      this.BtnLogin = new DevComponents.DotNetBar.ButtonX();
      this.GrpEmpresa.SuspendLayout();
      this.groupPanel2.SuspendLayout();
      this.groupPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // highlighter1
      // 
      this.highlighter1.ContainerControl = this;
      this.highlighter1.CustomHighlightColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204))))),
        System.Drawing.Color.Empty};
      this.highlighter1.FocusHighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Custom;
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
      this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.highlighter1.SetHighlightColor(this.BtnCancelar, DevComponents.DotNetBar.Validator.eHighlightColor.Custom);
      this.BtnCancelar.ImageTextSpacing = 10;
      this.BtnCancelar.Location = new System.Drawing.Point(45, 574);
      this.BtnCancelar.Name = "BtnCancelar";
      this.BtnCancelar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
      this.BtnCancelar.Size = new System.Drawing.Size(580, 40);
      this.BtnCancelar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.BtnCancelar.TabIndex = 37;
      this.BtnCancelar.Text = "&Cancelar";
      this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
      // 
      // BtnAceptar
      // 
      this.BtnAceptar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.BtnAceptar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
      this.BtnAceptar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.highlighter1.SetHighlightColor(this.BtnAceptar, DevComponents.DotNetBar.Validator.eHighlightColor.Custom);
      this.BtnAceptar.ImageTextSpacing = 10;
      this.BtnAceptar.Location = new System.Drawing.Point(45, 504);
      this.BtnAceptar.Name = "BtnAceptar";
      this.BtnAceptar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
      this.BtnAceptar.Size = new System.Drawing.Size(580, 40);
      this.BtnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.BtnAceptar.TabIndex = 36;
      this.BtnAceptar.Text = "&Ingresar";
      // 
      // labelX4
      // 
      this.labelX4.AutoSize = true;
      this.labelX4.BackColor = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX4.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelX4.ForeColor = System.Drawing.Color.White;
      this.labelX4.Location = new System.Drawing.Point(49, 12);
      this.labelX4.Name = "labelX4";
      this.labelX4.Size = new System.Drawing.Size(112, 57);
      this.labelX4.TabIndex = 41;
      this.labelX4.Text = "Login";
      // 
      // GrpEmpresa
      // 
      this.GrpEmpresa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.GrpEmpresa.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.GrpEmpresa.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
      this.GrpEmpresa.Controls.Add(this.CboEmpresa);
      this.GrpEmpresa.Controls.Add(this.labelX3);
      this.GrpEmpresa.DisabledBackColor = System.Drawing.Color.Empty;
      this.GrpEmpresa.Enabled = false;
      this.GrpEmpresa.Location = new System.Drawing.Point(44, 430);
      this.GrpEmpresa.Name = "GrpEmpresa";
      this.GrpEmpresa.Size = new System.Drawing.Size(586, 36);
      // 
      // 
      // 
      this.GrpEmpresa.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.GrpEmpresa.Style.BackColorGradientAngle = 90;
      this.GrpEmpresa.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.GrpEmpresa.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.GrpEmpresa.Style.BorderBottomWidth = 2;
      this.GrpEmpresa.Style.BorderColor = System.Drawing.Color.DarkGray;
      this.GrpEmpresa.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.GrpEmpresa.Style.BorderLeftWidth = 1;
      this.GrpEmpresa.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.GrpEmpresa.Style.BorderRightWidth = 1;
      this.GrpEmpresa.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.GrpEmpresa.Style.BorderTopWidth = 1;
      this.GrpEmpresa.Style.CornerDiameter = 4;
      this.GrpEmpresa.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
      this.GrpEmpresa.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
      this.GrpEmpresa.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.GrpEmpresa.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
      // 
      // 
      // 
      this.GrpEmpresa.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      // 
      // 
      // 
      this.GrpEmpresa.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.GrpEmpresa.TabIndex = 40;
      // 
      // CboEmpresa
      // 
      this.CboEmpresa.BackColor = System.Drawing.Color.Black;
      // 
      // 
      // 
      this.CboEmpresa.BackgroundStyle.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.CboEmpresa.BackgroundStyle.BorderBottomWidth = 1;
      this.CboEmpresa.BackgroundStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
      this.CboEmpresa.BackgroundStyle.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.CboEmpresa.BackgroundStyle.BorderRightWidth = 1;
      this.CboEmpresa.BackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.CboEmpresa.BackgroundStyle.BorderTopWidth = 1;
      this.CboEmpresa.BackgroundStyle.Class = "TextBoxBorder";
      this.CboEmpresa.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.CboEmpresa.ButtonDropDown.Symbol = "";
      this.CboEmpresa.ButtonDropDown.Visible = true;
      this.CboEmpresa.ColumnsVisible = false;
      this.CboEmpresa.EnterKeyTogglesPopup = false;
      this.CboEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CboEmpresa.ForeColor = System.Drawing.Color.White;
      this.CboEmpresa.Location = new System.Drawing.Point(112, 0);
      this.CboEmpresa.Name = "CboEmpresa";
      this.CboEmpresa.SelectionBoxStyle = DevComponents.AdvTree.eSelectionStyle.FullRowSelect;
      this.CboEmpresa.Size = new System.Drawing.Size(466, 29);
      this.CboEmpresa.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.CboEmpresa.TabIndex = 34;
      this.CboEmpresa.WatermarkColor = System.Drawing.Color.DimGray;
      this.CboEmpresa.WatermarkText = "Seleccione empresa";
      // 
      // labelX3
      // 
      this.labelX3.AutoSize = true;
      this.labelX3.BackColor = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelX3.ForeColor = System.Drawing.Color.White;
      this.labelX3.Location = new System.Drawing.Point(5, 1);
      this.labelX3.Name = "labelX3";
      this.labelX3.Size = new System.Drawing.Size(71, 24);
      this.labelX3.TabIndex = 24;
      this.labelX3.Text = "Empresa:";
      // 
      // groupPanel2
      // 
      this.groupPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.groupPanel2.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.groupPanel2.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
      this.groupPanel2.Controls.Add(this.labelX2);
      this.groupPanel2.Controls.Add(this.TxtUsuario);
      this.groupPanel2.DisabledBackColor = System.Drawing.Color.Empty;
      this.groupPanel2.Location = new System.Drawing.Point(44, 116);
      this.groupPanel2.Name = "groupPanel2";
      this.groupPanel2.Size = new System.Drawing.Size(586, 36);
      // 
      // 
      // 
      this.groupPanel2.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.groupPanel2.Style.BackColorGradientAngle = 90;
      this.groupPanel2.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.groupPanel2.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.groupPanel2.Style.BorderBottomWidth = 2;
      this.groupPanel2.Style.BorderColor = System.Drawing.Color.DarkGray;
      this.groupPanel2.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.groupPanel2.Style.BorderLeftWidth = 1;
      this.groupPanel2.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.groupPanel2.Style.BorderRightWidth = 1;
      this.groupPanel2.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.groupPanel2.Style.BorderTopWidth = 1;
      this.groupPanel2.Style.CornerDiameter = 4;
      this.groupPanel2.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
      this.groupPanel2.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
      this.groupPanel2.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
      this.groupPanel2.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
      // 
      // 
      // 
      this.groupPanel2.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      // 
      // 
      // 
      this.groupPanel2.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.groupPanel2.TabIndex = 39;
      // 
      // labelX2
      // 
      this.labelX2.AutoSize = true;
      this.labelX2.BackColor = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelX2.ForeColor = System.Drawing.Color.White;
      this.labelX2.Location = new System.Drawing.Point(5, 1);
      this.labelX2.Name = "labelX2";
      this.labelX2.Size = new System.Drawing.Size(64, 24);
      this.labelX2.TabIndex = 24;
      this.labelX2.Text = "Usuario:";
      // 
      // TxtUsuario
      // 
      this.TxtUsuario.AutoSelectAll = true;
      this.TxtUsuario.BackColor = System.Drawing.Color.Black;
      // 
      // 
      // 
      this.TxtUsuario.Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.TxtUsuario.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.TxtUsuario.Border.BorderBottomColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
      this.TxtUsuario.Border.BorderBottomWidth = 1;
      this.TxtUsuario.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
      this.TxtUsuario.Border.BorderLeftColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.TxtUsuario.Border.BorderRightColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.TxtUsuario.Border.BorderTopColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.TxtUsuario.Border.Class = "RibbonClientPanel";
      this.TxtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.TxtUsuario.DisabledBackColor = System.Drawing.Color.White;
      this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtUsuario.ForeColor = System.Drawing.Color.White;
      this.highlighter1.SetHighlightOnFocus(this.TxtUsuario, true);
      this.TxtUsuario.Location = new System.Drawing.Point(112, 2);
      this.TxtUsuario.MaxLength = 0;
      this.TxtUsuario.Name = "TxtUsuario";
      this.TxtUsuario.Size = new System.Drawing.Size(465, 24);
      this.TxtUsuario.TabIndex = 0;
      this.TxtUsuario.WatermarkColor = System.Drawing.Color.DimGray;
      this.TxtUsuario.WatermarkText = "Ingrese usuario";
      this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
      this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
      // 
      // groupPanel1
      // 
      this.groupPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.groupPanel1.CanvasColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
      this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
      this.groupPanel1.Controls.Add(this.labelX1);
      this.groupPanel1.Controls.Add(this.TxtPassword);
      this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
      this.groupPanel1.Location = new System.Drawing.Point(44, 187);
      this.groupPanel1.Name = "groupPanel1";
      this.groupPanel1.Size = new System.Drawing.Size(586, 35);
      // 
      // 
      // 
      this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
      this.groupPanel1.Style.BackColorGradientAngle = 90;
      this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
      this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.groupPanel1.Style.BorderBottomWidth = 2;
      this.groupPanel1.Style.BorderColor = System.Drawing.Color.DarkGray;
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
      this.groupPanel1.TabIndex = 38;
      // 
      // labelX1
      // 
      this.labelX1.AutoSize = true;
      this.labelX1.BackColor = System.Drawing.Color.Transparent;
      // 
      // 
      // 
      this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.labelX1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelX1.ForeColor = System.Drawing.Color.White;
      this.labelX1.Location = new System.Drawing.Point(5, 1);
      this.labelX1.Name = "labelX1";
      this.labelX1.Size = new System.Drawing.Size(91, 24);
      this.labelX1.TabIndex = 24;
      this.labelX1.Text = "Contraseña:";
      // 
      // TxtPassword
      // 
      this.TxtPassword.AutoSelectAll = true;
      this.TxtPassword.BackColor = System.Drawing.Color.Black;
      // 
      // 
      // 
      this.TxtPassword.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
      this.TxtPassword.Border.BorderBottomWidth = 1;
      this.TxtPassword.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
      this.TxtPassword.Border.Class = "RibbonClientPanel";
      this.TxtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.TxtPassword.ButtonCustom.Symbol = "";
      this.TxtPassword.ButtonCustom.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.TxtPassword.ButtonCustom.Visible = true;
      this.TxtPassword.DisabledBackColor = System.Drawing.Color.White;
      this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TxtPassword.ForeColor = System.Drawing.Color.White;
      this.highlighter1.SetHighlightOnFocus(this.TxtPassword, true);
      this.TxtPassword.Location = new System.Drawing.Point(112, 2);
      this.TxtPassword.Name = "TxtPassword";
      this.TxtPassword.Size = new System.Drawing.Size(465, 24);
      this.TxtPassword.TabIndex = 23;
      this.TxtPassword.UseSystemPasswordChar = true;
      this.TxtPassword.WatermarkColor = System.Drawing.Color.DimGray;
      this.TxtPassword.WatermarkText = "Ingresa tu contraseña";
      this.TxtPassword.ButtonCustomClick += new System.EventHandler(this.TxtPassword_ButtonCustomClick);
      this.TxtPassword.Enter += new System.EventHandler(this.TxtUsuario_Enter);
      this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
      // 
      // line2
      // 
      this.line2.BackColor = System.Drawing.Color.Transparent;
      this.line2.ForeColor = System.Drawing.Color.White;
      this.line2.Location = new System.Drawing.Point(39, 361);
      this.line2.Name = "line2";
      this.line2.Size = new System.Drawing.Size(586, 10);
      this.line2.TabIndex = 35;
      this.line2.Text = "line2";
      this.line2.Thickness = 2;
      // 
      // BtnLogin
      // 
      this.BtnLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.BtnLogin.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
      this.BtnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnLogin.ImageTextSpacing = 10;
      this.BtnLogin.Location = new System.Drawing.Point(52, 263);
      this.BtnLogin.Name = "BtnLogin";
      this.BtnLogin.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
      this.BtnLogin.Size = new System.Drawing.Size(580, 40);
      this.BtnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.BtnLogin.TabIndex = 36;
      this.BtnLogin.Text = "&LOGIN";
      this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
      // 
      // FrmLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BottomLeftCornerSize = 0;
      this.BottomRightCornerSize = 0;
      this.ClientSize = new System.Drawing.Size(670, 679);
      this.ControlBox = false;
      this.Controls.Add(this.labelX4);
      this.Controls.Add(this.GrpEmpresa);
      this.Controls.Add(this.groupPanel2);
      this.Controls.Add(this.groupPanel1);
      this.Controls.Add(this.line2);
      this.Controls.Add(this.BtnCancelar);
      this.Controls.Add(this.BtnLogin);
      this.Controls.Add(this.BtnAceptar);
      this.DoubleBuffered = true;
      this.ForeColor = System.Drawing.Color.White;
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "FrmLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "LOGIN";
      this.TopLeftCornerSize = 0;
      this.TopRightCornerSize = 0;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
      this.Shown += new System.EventHandler(this.FrmLogin_Shown);
      this.GrpEmpresa.ResumeLayout(false);
      this.GrpEmpresa.PerformLayout();
      this.groupPanel2.ResumeLayout(false);
      this.groupPanel2.PerformLayout();
      this.groupPanel1.ResumeLayout(false);
      this.groupPanel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    private DevComponents.DotNetBar.LabelX labelX4;
    private DevComponents.DotNetBar.Controls.GroupPanel GrpEmpresa;
    private DevComponents.DotNetBar.Controls.ComboTree CboEmpresa;
    private DevComponents.DotNetBar.LabelX labelX3;
    private DevComponents.DotNetBar.Controls.GroupPanel groupPanel2;
    private DevComponents.DotNetBar.LabelX labelX2;
    internal DevComponents.DotNetBar.Controls.TextBoxX TxtUsuario;
    private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
    private DevComponents.DotNetBar.LabelX labelX1;
    internal DevComponents.DotNetBar.Controls.TextBoxX TxtPassword;
    internal DevComponents.DotNetBar.Controls.Line line2;
    internal DevComponents.DotNetBar.ButtonX BtnCancelar;
    internal DevComponents.DotNetBar.ButtonX BtnAceptar;
    internal DevComponents.DotNetBar.ButtonX BtnLogin;
  }
}