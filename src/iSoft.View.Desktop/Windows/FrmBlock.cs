using iSoft.Controller.Core.iSoft.Master.process;
using System;
using System.Windows.Forms;

namespace iSoft.View.Desktop.Windows
{
  public partial class FrmBlock : DevComponents.DotNetBar.Office2007Form
  {

    #region VARIABLES

    EncryptingRepository decryptingRepository;

    #endregion

    #region CONSTRUCTORES Y DESTRUCTORES

    public FrmBlock()
    {
      InitializeComponent();
      decryptingRepository = new EncryptingRepository();
    }

    #endregion

    #region FORMULARIO

    private void FrmBlock_Shown(object sender, EventArgs e)
    {
      TxtPassword.ButtonCustom.Image = imageList1.Images[01];
      TxtPassword.UseSystemPasswordChar = true;
      TxtPassword.Tag = "ON";
    }

    #endregion

    #region SWITCH

    private void swhLockUnlock_ValueChanged(object sender, EventArgs e)
    {
      if (swhLockUnlock.Value == true)
      { GrpPassword.Visible = true; TxtPassword.Text = string.Empty; }
      else { GrpPassword.Visible = false; }
    }

    #endregion

    #region BOTONES

    private void BtnClosePassword_Click(object sender, EventArgs e)
    {
      GrpPassword.Visible = false;

      swhLockUnlock.Visible = false;

      swhLockUnlock.SuspendLayout();
      swhLockUnlock.Value = false;
      swhLockUnlock.Refresh();
      swhLockUnlock.ResumeLayout();

      swhLockUnlock.Visible = true;
      swhLockUnlock.Select();
    }

    private void BtnUnlock_Click(object sender, EventArgs e)
    {

      if (TxtPassword.Text != decryptingRepository.Decrypt(Definition.User.Password).Data)
      {
        DevComponents.DotNetBar.MessageBoxEx.Show(
          "Contraseña incorrecta.", "Blocked", MessageBoxButtons.OK, MessageBoxIcon.Information);
        swhLockUnlock.Visible = false;

        swhLockUnlock.SuspendLayout();
        swhLockUnlock.Value = false;
        swhLockUnlock.Refresh();
        swhLockUnlock.ResumeLayout();

        swhLockUnlock.Visible = true;
        swhLockUnlock.Select();
        return;
      }
      else
      {
        this.Close();
      }
    }

    private void BtnLock_Click(object sender, EventArgs e)
    {
      this.Close();
      Application.Exit();
    }

    #endregion

    #region TEXTBOXS

    private void TxtPassword_TextChanged(object sender, EventArgs e)
    {
      if (TxtPassword.Text == string.Empty)
      { BtnUnlock.Enabled = false; }
      else { BtnUnlock.Enabled = true; }
    }

    private void TxtPassword_ButtonCustomClick(object sender, EventArgs e)
    {
      if (TxtPassword.Tag.ToString() == "ON")
      {
        TxtPassword.ButtonCustom.Image = imageList1.Images[00];
        TxtPassword.UseSystemPasswordChar = false;
        TxtPassword.Tag = "OFF";
      }
      else if (TxtPassword.Tag.ToString() == "OFF")
      {
        TxtPassword.ButtonCustom.Image = imageList1.Images[01];
        TxtPassword.UseSystemPasswordChar = true;
        TxtPassword.Tag = "ON";
      }
    }

    #endregion

  }
}
