namespace iSoft.View.Desktop.Forms
{
  partial class FrmMDI
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
      SuspendLayout();
      // 
      // FrmMDI
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(885, 564);
      FormStyle = FormStyles.ActionBar_None;
      IsMdiContainer = true;
      Name = "FrmMDI";
      Padding = new Padding(3, 24, 3, 3);
      Text = "FrmMDI";
      WindowState = FormWindowState.Maximized;
      Load += FrmMDI_Load;
      ResumeLayout(false);
    }

    #endregion
  }
}