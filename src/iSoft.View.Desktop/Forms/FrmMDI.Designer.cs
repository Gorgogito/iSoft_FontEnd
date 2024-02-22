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
      menuStrip1 = new MenuStrip();
      archivoToolStripMenuItem = new ToolStripMenuItem();
      nuevoToolStripMenuItem = new ToolStripMenuItem();
      menuStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
      menuStrip1.Location = new Point(3, 64);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(827, 24);
      menuStrip1.TabIndex = 1;
      menuStrip1.Text = "menuStrip1";
      // 
      // archivoToolStripMenuItem
      // 
      archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem });
      archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      archivoToolStripMenuItem.Size = new Size(60, 20);
      archivoToolStripMenuItem.Text = "Archivo";
      // 
      // nuevoToolStripMenuItem
      // 
      nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
      nuevoToolStripMenuItem.Size = new Size(109, 22);
      nuevoToolStripMenuItem.Text = "Nuevo";
      // 
      // FrmMDI
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(833, 664);
      Controls.Add(menuStrip1);
      FormBorderStyle = FormBorderStyle.FixedSingle;
      IsMdiContainer = true;
      MainMenuStrip = menuStrip1;
      Name = "FrmMDI";
      Sizable = false;
      StartPosition = FormStartPosition.CenterScreen;
      Text = "iSoft";
      WindowState = FormWindowState.Maximized;
      Load += FrmMDI_Load;
      Shown += FrmMDI_Shown;
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem archivoToolStripMenuItem;
    private ToolStripMenuItem nuevoToolStripMenuItem;
  }
}