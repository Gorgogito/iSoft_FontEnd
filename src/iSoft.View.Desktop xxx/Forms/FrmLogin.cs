using iSoft.Controller.Core.iSoft.Master.identy;
using iSoft.View.Desktop.Utilities;
using MaterialSkin;
using MaterialSkin.Controls;

namespace iSoft.View.Desktop
{
  public partial class FrmLogin : MaterialForm
  {

    #region « VARIABLES INTERNAS »

    AuthenticateRepository businessUser;
    bool IsDeath;

    #endregion

    public FrmLogin()
    {
      InitializeComponent();

      var materialSkinManager = MaterialSkinManager.Instance;
      materialSkinManager.AddFormToManage(this);
      materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
      materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

      businessUser = new AuthenticateRepository();

      BtnPasswordView.Tag = "0";
      BtnPasswordView.Image = ImgList.Images[0];
      TxtPassword.Password = true;
      TxtPassword.Refresh();
      IsDeath = true;
    }

    #region « EVENTOS DE TEXTBOX »

    #region « Usuario »

    private void TxtUsuario_Enter(object sender, EventArgs e)
    {
      TxtUsuario.SelectAll();
    }

    private void TxtPassword_Enter(object sender, System.EventArgs e)
    {
      TxtPassword.SelectAll();
    }

    private void TxtPassword_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
      if (e.KeyChar == DoCmd.Strings.Chr((int)Keys.Enter))
      {
        BtnSesion.Select();
        BtnSesion_Click(BtnSesion, e);
      }
    }

    #endregion

    #region « EVENTOS DE BOTONES »

    private void BtnSesion_Click(object sender, System.EventArgs e)
    {

      if (TxtUsuario.Text == string.Empty)
      {
        MessageBox.Show(
        "Ingrese usuario", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
      }

      var response = businessUser.Login(TxtUsuario.Text, TxtPassword.Text);

      if (response.IsSuccess)
      {
        if (response.Data != null)
        {
          Definition.User.KeyId = response.Data.KeyId;
          Definition.User.UserName = response.Data.UserName;
          Definition.User.Password = response.Data.Password;
          Definition.User.Description = response.Data.Description;
          Definition.User.Names = response.Data.Names;
          Definition.User.Surnames = response.Data.Surnames;
          Definition.User.Phone = response.Data.Phone;
          Definition.User.EMail = response.Data.EMail;
          Definition.User.Token = response.Data.Token;
          Definition.User.RoleId = response.Data.RoleId;
          Definition.User.StateId = response.Data.StateId;
          Definition.User.IsSystem = response.Data.IsSystem;
          IsDeath = false;
          this.Close();
        }
        else
        {
          MessageBox.Show(
            "Usuario no existe.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
          TxtUsuario.Select();
        }
      }
      else
      {
        MessageBox.Show(
          response.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        TxtUsuario.Select();
      }

    }

    private void BtCancelar_Click(object sender, System.EventArgs e)
    {
      IsDeath = true;
      this.Close();
    }

    #endregion

    #endregion

    private void BtnPasswordView_Click(object sender, EventArgs e)
    {
      if (BtnPasswordView.Tag == "0")
      {
        BtnPasswordView.Tag = "1";
        BtnPasswordView.Image = ImgList.Images[1];
        TxtPassword.Password = false;
        TxtPassword.Refresh();
        //TxtPassword.UseSystemPasswordChar = false;
        //TxtPassword.PasswordChar =char.Parse("");
      }
      else if (BtnPasswordView.Tag == "1")
      {
        BtnPasswordView.Tag = "0";
        BtnPasswordView.Image = ImgList.Images[0];
        TxtPassword.Password = true;
        TxtPassword.Refresh();
        //TxtPassword.UseSystemPasswordChar = true;
        //TxtPassword.PasswordChar = DoCmd.Strings.Chr(9679);
      }

    }

    private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (IsDeath == true)
      {
        Application.Exit();
      }
    }
  }
}
