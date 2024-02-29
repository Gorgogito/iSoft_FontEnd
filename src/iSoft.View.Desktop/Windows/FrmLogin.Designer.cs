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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
      this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
      this.BtnCancelar = new DevComponents.DotNetBar.ButtonX();
      this.BtnAceptar = new DevComponents.DotNetBar.ButtonX();
      this.TxtUsuario = new DevComponents.DotNetBar.Controls.TextBoxX();
      this.TxtPassword = new DevComponents.DotNetBar.Controls.TextBoxX();
      this.labelX4 = new DevComponents.DotNetBar.LabelX();
      this.CboEmpresa = new DevComponents.DotNetBar.Controls.ComboTree();
      this.labelX3 = new DevComponents.DotNetBar.LabelX();
      this.labelX2 = new DevComponents.DotNetBar.LabelX();
      this.labelX1 = new DevComponents.DotNetBar.LabelX();
      this.line2 = new DevComponents.DotNetBar.Controls.Line();
      this.BtnLogin = new DevComponents.DotNetBar.ButtonX();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.SuspendLayout();
      // 
      // highlighter1
      // 
      this.highlighter1.ContainerControl = this;
      this.highlighter1.CustomHighlightColors = new System.Drawing.Color[0];
      // 
      // BtnCancelar
      // 
      this.BtnCancelar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
      this.BtnCancelar.ColorTable = DevComponents.DotNetBar.eButtonColor.MagentaWithBackground;
      this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.BtnCancelar.ImageTextSpacing = 10;
      this.BtnCancelar.Location = new System.Drawing.Point(45, 457);
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
      this.BtnAceptar.ImageTextSpacing = 10;
      this.BtnAceptar.Location = new System.Drawing.Point(45, 408);
      this.BtnAceptar.Name = "BtnAceptar";
      this.BtnAceptar.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
      this.BtnAceptar.Size = new System.Drawing.Size(580, 40);
      this.BtnAceptar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.BtnAceptar.TabIndex = 36;
      this.BtnAceptar.Text = "&Ingresar";
      this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
      // 
      // TxtUsuario
      // 
      this.TxtUsuario.AutoSelectAll = true;
      // 
      // 
      // 
      this.TxtUsuario.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
      this.TxtUsuario.Border.Class = "TextBoxBorder";
      this.TxtUsuario.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.TxtUsuario.DisabledBackColor = System.Drawing.Color.White;
      this.TxtUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.highlighter1.SetHighlightOnFocus(this.TxtUsuario, true);
      this.TxtUsuario.Location = new System.Drawing.Point(157, 154);
      this.TxtUsuario.MaxLength = 0;
      this.TxtUsuario.Name = "TxtUsuario";
      this.TxtUsuario.Size = new System.Drawing.Size(465, 29);
      this.TxtUsuario.TabIndex = 0;
      this.TxtUsuario.WatermarkColor = System.Drawing.Color.DimGray;
      this.TxtUsuario.WatermarkText = "Ingrese usuario";
      this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
      this.TxtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUsuario_KeyPress);
      // 
      // TxtPassword
      // 
      this.TxtPassword.AutoSelectAll = true;
      // 
      // 
      // 
      this.TxtPassword.Border.BorderBottomWidth = 1;
      this.TxtPassword.Border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(132)))));
      this.TxtPassword.Border.Class = "TextBoxBorder";
      this.TxtPassword.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
      this.TxtPassword.ButtonCustom.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.TxtPassword.ButtonCustom.Visible = true;
      this.TxtPassword.DisabledBackColor = System.Drawing.Color.White;
      this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.highlighter1.SetHighlightOnFocus(this.TxtPassword, true);
      this.TxtPassword.Location = new System.Drawing.Point(156, 189);
      this.TxtPassword.Name = "TxtPassword";
      this.TxtPassword.Size = new System.Drawing.Size(465, 29);
      this.TxtPassword.TabIndex = 23;
      this.TxtPassword.UseSystemPasswordChar = true;
      this.TxtPassword.WatermarkColor = System.Drawing.Color.DimGray;
      this.TxtPassword.WatermarkText = "Ingresa tu contraseña";
      this.TxtPassword.ButtonCustomClick += new System.EventHandler(this.TxtPassword_ButtonCustomClick);
      this.TxtPassword.Enter += new System.EventHandler(this.TxtUsuario_Enter);
      this.TxtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPassword_KeyPress);
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
      this.labelX4.ForeColor = System.Drawing.Color.Black;
      this.labelX4.Location = new System.Drawing.Point(29, 17);
      this.labelX4.Name = "labelX4";
      this.labelX4.Size = new System.Drawing.Size(112, 57);
      this.labelX4.TabIndex = 41;
      this.labelX4.Text = "Login";
      // 
      // CboEmpresa
      // 
      this.CboEmpresa.BackColor = System.Drawing.SystemColors.Window;
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
      this.CboEmpresa.ButtonDropDown.Visible = true;
      this.CboEmpresa.ColumnsVisible = false;
      this.CboEmpresa.Enabled = false;
      this.CboEmpresa.EnterKeyTogglesPopup = false;
      this.CboEmpresa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.CboEmpresa.ForeColor = System.Drawing.SystemColors.WindowText;
      this.CboEmpresa.Location = new System.Drawing.Point(156, 349);
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
      this.labelX3.ForeColor = System.Drawing.SystemColors.WindowText;
      this.labelX3.Location = new System.Drawing.Point(49, 350);
      this.labelX3.Name = "labelX3";
      this.labelX3.Size = new System.Drawing.Size(71, 24);
      this.labelX3.TabIndex = 24;
      this.labelX3.Text = "Empresa:";
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
      this.labelX2.ForeColor = System.Drawing.SystemColors.WindowText;
      this.labelX2.Location = new System.Drawing.Point(50, 153);
      this.labelX2.Name = "labelX2";
      this.labelX2.Size = new System.Drawing.Size(64, 24);
      this.labelX2.TabIndex = 24;
      this.labelX2.Text = "Usuario:";
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
      this.labelX1.ForeColor = System.Drawing.SystemColors.WindowText;
      this.labelX1.Location = new System.Drawing.Point(49, 188);
      this.labelX1.Name = "labelX1";
      this.labelX1.Size = new System.Drawing.Size(91, 24);
      this.labelX1.TabIndex = 24;
      this.labelX1.Text = "Contraseña:";
      // 
      // line2
      // 
      this.line2.BackColor = System.Drawing.Color.Transparent;
      this.line2.ForeColor = System.Drawing.Color.Gray;
      this.line2.Location = new System.Drawing.Point(42, 305);
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
      this.BtnLogin.Location = new System.Drawing.Point(45, 244);
      this.BtnLogin.Name = "BtnLogin";
      this.BtnLogin.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor();
      this.BtnLogin.Size = new System.Drawing.Size(580, 40);
      this.BtnLogin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
      this.BtnLogin.TabIndex = 36;
      this.BtnLogin.Text = "&LOGIN";
      this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "eye-no.png");
      this.imageList1.Images.SetKeyName(1, "eye.png");
      // 
      // FrmLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BottomLeftCornerSize = 0;
      this.BottomRightCornerSize = 0;
      this.ClientSize = new System.Drawing.Size(670, 538);
      this.ControlBox = false;
      this.Controls.Add(this.CboEmpresa);
      this.Controls.Add(this.labelX3);
      this.Controls.Add(this.labelX1);
      this.Controls.Add(this.labelX2);
      this.Controls.Add(this.TxtPassword);
      this.Controls.Add(this.labelX4);
      this.Controls.Add(this.TxtUsuario);
      this.Controls.Add(this.line2);
      this.Controls.Add(this.BtnCancelar);
      this.Controls.Add(this.BtnLogin);
      this.Controls.Add(this.BtnAceptar);
      this.DoubleBuffered = true;
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
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
    private DevComponents.DotNetBar.LabelX labelX4;
    private DevComponents.DotNetBar.Controls.ComboTree CboEmpresa;
    private DevComponents.DotNetBar.LabelX labelX3;
    private DevComponents.DotNetBar.LabelX labelX2;
    internal DevComponents.DotNetBar.Controls.TextBoxX TxtUsuario;
    private DevComponents.DotNetBar.LabelX labelX1;
    internal DevComponents.DotNetBar.Controls.TextBoxX TxtPassword;
    internal DevComponents.DotNetBar.Controls.Line line2;
    internal DevComponents.DotNetBar.ButtonX BtnCancelar;
    internal DevComponents.DotNetBar.ButtonX BtnAceptar;
    internal DevComponents.DotNetBar.ButtonX BtnLogin;
    private System.Windows.Forms.ImageList imageList1;
  }
}