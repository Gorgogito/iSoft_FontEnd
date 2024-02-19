namespace iSoft.View.Desktop
{
  partial class FrmLogin
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
      TxtUsuario = new MaterialSkin.Controls.MaterialTextBox();
      TxtPassword = new MaterialSkin.Controls.MaterialTextBox2();
      materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
      pictureBox1 = new PictureBox();
      materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
      materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
      BtnSesion = new MaterialSkin.Controls.MaterialButton();
      pictureBox2 = new PictureBox();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
      SuspendLayout();
      // 
      // TxtUsuario
      // 
      TxtUsuario.AnimateReadOnly = false;
      TxtUsuario.BorderStyle = BorderStyle.None;
      TxtUsuario.Depth = 0;
      TxtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
      TxtUsuario.LeadingIcon = null;
      TxtUsuario.Location = new Point(94, 227);
      TxtUsuario.MaxLength = 50;
      TxtUsuario.MouseState = MaterialSkin.MouseState.OUT;
      TxtUsuario.Multiline = false;
      TxtUsuario.Name = "TxtUsuario";
      TxtUsuario.Size = new Size(404, 50);
      TxtUsuario.TabIndex = 0;
      TxtUsuario.Text = "";
      TxtUsuario.TrailingIcon = null;
      // 
      // TxtPassword
      // 
      TxtPassword.AnimateReadOnly = false;
      TxtPassword.BackgroundImageLayout = ImageLayout.None;
      TxtPassword.CharacterCasing = CharacterCasing.Normal;
      TxtPassword.Depth = 0;
      TxtPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
      TxtPassword.HideSelection = true;
      TxtPassword.LeadingIcon = null;
      TxtPassword.Location = new Point(94, 317);
      TxtPassword.MaxLength = 32767;
      TxtPassword.MouseState = MaterialSkin.MouseState.OUT;
      TxtPassword.Name = "TxtPassword";
      TxtPassword.PasswordChar = '●';
      TxtPassword.PrefixSuffixText = null;
      TxtPassword.ReadOnly = false;
      TxtPassword.RightToLeft = RightToLeft.No;
      TxtPassword.SelectedText = "";
      TxtPassword.SelectionLength = 0;
      TxtPassword.SelectionStart = 0;
      TxtPassword.ShortcutsEnabled = true;
      TxtPassword.Size = new Size(404, 48);
      TxtPassword.TabIndex = 1;
      TxtPassword.TabStop = false;
      TxtPassword.Text = "materialTextBox21";
      TxtPassword.TextAlign = HorizontalAlignment.Left;
      TxtPassword.TrailingIcon = null;
      TxtPassword.UseSystemPasswordChar = true;
      // 
      // materialLabel1
      // 
      materialLabel1.AutoSize = true;
      materialLabel1.Depth = 0;
      materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
      materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
      materialLabel1.Location = new Point(214, 83);
      materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
      materialLabel1.Name = "materialLabel1";
      materialLabel1.Size = new Size(140, 58);
      materialLabel1.TabIndex = 2;
      materialLabel1.Text = "LOGIN";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
      pictureBox1.Location = new Point(54, 232);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(34, 35);
      pictureBox1.TabIndex = 3;
      pictureBox1.TabStop = false;
      // 
      // materialLabel2
      // 
      materialLabel2.AutoSize = true;
      materialLabel2.Depth = 0;
      materialLabel2.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
      materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
      materialLabel2.Location = new Point(94, 200);
      materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
      materialLabel2.Name = "materialLabel2";
      materialLabel2.Size = new Size(74, 24);
      materialLabel2.TabIndex = 4;
      materialLabel2.Text = "Usuario:";
      // 
      // materialLabel3
      // 
      materialLabel3.AutoSize = true;
      materialLabel3.Depth = 0;
      materialLabel3.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
      materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
      materialLabel3.Location = new Point(94, 290);
      materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
      materialLabel3.Name = "materialLabel3";
      materialLabel3.Size = new Size(94, 24);
      materialLabel3.TabIndex = 4;
      materialLabel3.Text = "Password:";
      // 
      // BtnSesion
      // 
      BtnSesion.AutoSize = false;
      BtnSesion.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      BtnSesion.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
      BtnSesion.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      BtnSesion.Depth = 0;
      BtnSesion.HighEmphasis = true;
      BtnSesion.Icon = null;
      BtnSesion.Location = new Point(54, 430);
      BtnSesion.Margin = new Padding(4, 6, 4, 6);
      BtnSesion.MouseState = MaterialSkin.MouseState.HOVER;
      BtnSesion.Name = "BtnSesion";
      BtnSesion.NoAccentTextColor = Color.Empty;
      BtnSesion.Size = new Size(444, 39);
      BtnSesion.TabIndex = 5;
      BtnSesion.Text = "Iniciar Sesión";
      BtnSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      BtnSesion.UseAccentColor = false;
      BtnSesion.UseVisualStyleBackColor = true;
      // 
      // pictureBox2
      // 
      pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
      pictureBox2.Location = new Point(54, 323);
      pictureBox2.Name = "pictureBox2";
      pictureBox2.Size = new Size(34, 35);
      pictureBox2.TabIndex = 6;
      pictureBox2.TabStop = false;
      // 
      // FrmLogin
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(569, 573);
      Controls.Add(pictureBox2);
      Controls.Add(BtnSesion);
      Controls.Add(materialLabel3);
      Controls.Add(materialLabel2);
      Controls.Add(pictureBox1);
      Controls.Add(materialLabel1);
      Controls.Add(TxtPassword);
      Controls.Add(TxtUsuario);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      FormStyle = FormStyles.ActionBar_None;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FrmLogin";
      Padding = new Padding(3, 24, 3, 3);
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Form1";
      Load += Form1_Load;
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MaterialSkin.Controls.MaterialTextBox TxtUsuario;
    private MaterialSkin.Controls.MaterialTextBox2 TxtPassword;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private PictureBox pictureBox1;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private MaterialSkin.Controls.MaterialButton BtnSesion;
    private PictureBox pictureBox2;
  }
}
