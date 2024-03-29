﻿namespace iSoft.View.Desktop
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
      components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
      TxtUsuario = new MaterialSkin.Controls.MaterialTextBox();
      materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
      pictureBox1 = new PictureBox();
      materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
      materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
      BtnSesion = new MaterialSkin.Controls.MaterialButton();
      pictureBox2 = new PictureBox();
      materialButton1 = new MaterialSkin.Controls.MaterialButton();
      BtnPasswordView = new PictureBox();
      TxtPassword = new MaterialSkin.Controls.MaterialTextBox();
      ImgList = new ImageList(components);
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
      ((System.ComponentModel.ISupportInitialize)BtnPasswordView).BeginInit();
      SuspendLayout();
      // 
      // TxtUsuario
      // 
      TxtUsuario.AnimateReadOnly = false;
      TxtUsuario.BorderStyle = BorderStyle.None;
      TxtUsuario.Depth = 0;
      TxtUsuario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
      TxtUsuario.LeadingIcon = null;
      TxtUsuario.LeaveOnEnterKey = true;
      TxtUsuario.Location = new Point(108, 227);
      TxtUsuario.MaxLength = 50;
      TxtUsuario.MouseState = MaterialSkin.MouseState.OUT;
      TxtUsuario.Multiline = false;
      TxtUsuario.Name = "TxtUsuario";
      TxtUsuario.Size = new Size(537, 36);
      TxtUsuario.TabIndex = 0;
      TxtUsuario.Text = "";
      TxtUsuario.TrailingIcon = null;
      TxtUsuario.UseTallSize = false;
      TxtUsuario.Enter += TxtUsuario_Enter;
      // 
      // materialLabel1
      // 
      materialLabel1.AutoSize = true;
      materialLabel1.Depth = 0;
      materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
      materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H3;
      materialLabel1.Location = new Point(286, 106);
      materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
      materialLabel1.Name = "materialLabel1";
      materialLabel1.Size = new Size(140, 58);
      materialLabel1.TabIndex = 2;
      materialLabel1.Text = "LOGIN";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
      pictureBox1.Location = new Point(68, 227);
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
      materialLabel2.Location = new Point(108, 192);
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
      materialLabel3.Location = new Point(108, 282);
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
      BtnSesion.Location = new Point(68, 408);
      BtnSesion.Margin = new Padding(4, 6, 4, 6);
      BtnSesion.MouseState = MaterialSkin.MouseState.HOVER;
      BtnSesion.Name = "BtnSesion";
      BtnSesion.NoAccentTextColor = Color.Empty;
      BtnSesion.Size = new Size(285, 39);
      BtnSesion.TabIndex = 2;
      BtnSesion.Text = "Iniciar Sesión";
      BtnSesion.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
      BtnSesion.UseAccentColor = false;
      BtnSesion.UseVisualStyleBackColor = true;
      BtnSesion.Click += BtnSesion_Click;
      // 
      // pictureBox2
      // 
      pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
      pictureBox2.Location = new Point(68, 317);
      pictureBox2.Name = "pictureBox2";
      pictureBox2.Size = new Size(34, 35);
      pictureBox2.TabIndex = 6;
      pictureBox2.TabStop = false;
      // 
      // materialButton1
      // 
      materialButton1.AutoSize = false;
      materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      materialButton1.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
      materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
      materialButton1.Depth = 0;
      materialButton1.HighEmphasis = true;
      materialButton1.Icon = null;
      materialButton1.Location = new Point(360, 408);
      materialButton1.Margin = new Padding(4, 6, 4, 6);
      materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
      materialButton1.Name = "materialButton1";
      materialButton1.NoAccentTextColor = Color.Empty;
      materialButton1.Size = new Size(285, 39);
      materialButton1.TabIndex = 3;
      materialButton1.Text = "Cancelar";
      materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
      materialButton1.UseAccentColor = false;
      materialButton1.UseVisualStyleBackColor = true;
      materialButton1.Click += BtCancelar_Click;
      // 
      // BtnPasswordView
      // 
      BtnPasswordView.Location = new Point(621, 323);
      BtnPasswordView.Name = "BtnPasswordView";
      BtnPasswordView.Size = new Size(24, 25);
      BtnPasswordView.SizeMode = PictureBoxSizeMode.StretchImage;
      BtnPasswordView.TabIndex = 6;
      BtnPasswordView.TabStop = false;
      BtnPasswordView.Tag = "0";
      BtnPasswordView.Click += BtnPasswordView_Click;
      // 
      // TxtPassword
      // 
      TxtPassword.AnimateReadOnly = false;
      TxtPassword.BorderStyle = BorderStyle.None;
      TxtPassword.Depth = 0;
      TxtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
      TxtPassword.LeadingIcon = null;
      TxtPassword.Location = new Point(108, 318);
      TxtPassword.MaxLength = 50;
      TxtPassword.MouseState = MaterialSkin.MouseState.OUT;
      TxtPassword.Multiline = false;
      TxtPassword.Name = "TxtPassword";
      TxtPassword.Password = true;
      TxtPassword.Size = new Size(508, 36);
      TxtPassword.TabIndex = 1;
      TxtPassword.Text = "";
      TxtPassword.TrailingIcon = null;
      TxtPassword.UseTallSize = false;
      TxtPassword.Enter += TxtPassword_Enter;
      TxtPassword.KeyPress += TxtPassword_KeyPress;
      // 
      // ImgList
      // 
      ImgList.ColorDepth = ColorDepth.Depth32Bit;
      ImgList.ImageStream = (ImageListStreamer)resources.GetObject("ImgList.ImageStream");
      ImgList.TransparentColor = Color.Transparent;
      ImgList.Images.SetKeyName(0, "eye.png");
      ImgList.Images.SetKeyName(1, "eye-no.png");
      // 
      // FrmLogin
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(712, 579);
      Controls.Add(BtnPasswordView);
      Controls.Add(pictureBox2);
      Controls.Add(materialButton1);
      Controls.Add(BtnSesion);
      Controls.Add(materialLabel3);
      Controls.Add(materialLabel2);
      Controls.Add(pictureBox1);
      Controls.Add(materialLabel1);
      Controls.Add(TxtPassword);
      Controls.Add(TxtUsuario);
      FormBorderStyle = FormBorderStyle.FixedDialog;
      MaximizeBox = false;
      MinimizeBox = false;
      Name = "FrmLogin";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "LOGIN";
      FormClosing += FrmLogin_FormClosing;
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
      ((System.ComponentModel.ISupportInitialize)BtnPasswordView).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MaterialSkin.Controls.MaterialTextBox TxtUsuario;
    private MaterialSkin.Controls.MaterialLabel materialLabel1;
    private PictureBox pictureBox1;
    private MaterialSkin.Controls.MaterialLabel materialLabel2;
    private MaterialSkin.Controls.MaterialLabel materialLabel3;
    private MaterialSkin.Controls.MaterialButton BtnSesion;
    private PictureBox pictureBox2;
    private MaterialSkin.Controls.MaterialButton materialButton1;
    private PictureBox BtnPasswordView;
    private MaterialSkin.Controls.MaterialTextBox TxtPassword;
    private ImageList ImgList;
  }
}
