using iSoft.Controller.Core.iSoft.Master.identy;
using iSoft.View.Desktop.Utilities;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace iSoft.View.Desktop
{
  public partial class FrmLogin : MaterialForm
  {


    #region « VARIABLES INTERNAS »

    AuthenticateRepository businessUser;

    #endregion

    public FrmLogin()
    {
      InitializeComponent();

      var materialSkinManager = MaterialSkinManager.Instance;
      materialSkinManager.AddFormToManage(this);
      materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
      materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
      //materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple700, Primary.Purple900, Primary.Purple500, Accent.LightBlue200, TextShade.WHITE);

      businessUser = new AuthenticateRepository();

    }



    #region « EVENTOS DE TEXTBOX »

    #region « Usuario »

    private void TxtUsuario_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
    {
      if (e.KeyChar == DoCmd.Strings.Chr((int)Keys.Enter))
      {
        TxtPassword.Select();
      }
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

      //var data = (from ent in businessUser.Login(TxtUsuario.Text, TxtPassword.Text)
      //            select ent).ToList();
      var data =businessUser.Login(TxtUsuario.Text, TxtPassword.Text);

      //if (data.Count > 0)
      //{

      //  Definition.User.KeyId = data[0].KeyId;
      //  Definition.User.UserName = data[0].UserName;
      //  Definition.User.Password = data[0].Password;
      //  Definition.User.Description = data[0].Description;
      //  Definition.User.Names = data[0].Names;
      //  Definition.User.Surnames = data[0].Surnames;
      //  Definition.User.Phone = data[0].Phone;
      //  Definition.User.EMail = data[0].EMail;
      //  Definition.User.Image = data[0].Image;
      //  Definition.User.Token = data[0].Token;
      //  Definition.User.RoleId = data[0].RoleId;
      //  Definition.User.StateId = data[0].StateId;
      //  Definition.User.IsSystem = data[0].IsSystem;

      //  this.Close();

      //}
      //else
      //{
      //  MessageBox.Show(
      //    "Usuario no existe.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //  TxtUsuario.Select();
      //}
    }

    private void BtCancelar_Click(object sender, System.EventArgs e)
    {
      this.Close();
      Application.Exit();
    }

    #endregion

    #endregion


  }
}
