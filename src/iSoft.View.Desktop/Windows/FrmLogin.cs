﻿using iSoft.Controller.Core.iSoft.Master.identy;
using iSoft.View.Desktop.Utilities;
using System.Windows.Forms;
using System;
using System.Drawing;
using iSoft.Controller.Core.iSoft.Master.master;

namespace iSoft.View.Desktop.Windows
{
  public partial class FrmLogin : DevComponents.DotNetBar.Metro.MetroForm
  {
    #region « VARIABLES INTERNAS »

    AuthenticateRepository businessUser;
    CompanyRepository businessEmp;
    bool IsDeath;

    #endregion

    public FrmLogin()
    {
      InitializeComponent();

      businessUser = new AuthenticateRepository();
      businessEmp = new CompanyRepository();
    }

    #region « Usuario »

    private void TxtUsuario_Enter(object sender, EventArgs e)
    {
      TxtUsuario.SelectAll();
    }

    private void TxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
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
        BtnAceptar.Select();
        BtnLogin_Click(BtnAceptar, e);
      }
    }

    #endregion

    #region « EVENTOS DE BOTONES »

    private void BtnLogin_Click(object sender, System.EventArgs e)
    {

      if (TxtUsuario.Text == string.Empty)
      {
        MessageBox.Show(
        "Ingrese usuario", "LOGIN", MessageBoxButtons.OK, MessageBoxIcon.Information); return;
      }

      var responseUsr = businessUser.Login(TxtUsuario.Text, TxtPassword.Text);

      if (responseUsr.IsSuccess)
      {
        if (responseUsr.Data != null)
        {
          Definition.User.KeyId = responseUsr.Data.KeyId;
          Definition.User.UserName = responseUsr.Data.UserName;
          Definition.User.Password = responseUsr.Data.Password;
          Definition.User.Description = responseUsr.Data.Description;
          Definition.User.Names = responseUsr.Data.Names;
          Definition.User.Surnames = responseUsr.Data.Surnames;
          Definition.User.Phone = responseUsr.Data.Phone;
          Definition.User.EMail = responseUsr.Data.EMail;
          Definition.User.Token = responseUsr.Data.Token;
          Definition.User.RoleId = responseUsr.Data.RoleId;
          Definition.User.StateId = responseUsr.Data.StateId;
          Definition.User.IsSystem = responseUsr.Data.IsSystem;
          //IsDeath = false;
          //this.Close();
          GrpEmpresa.Enabled = true;

          var responseEmp = businessEmp.GetAll(Definition.User.Token);

          if (responseEmp.IsSuccess)
          {
            if (responseEmp.Data != null)
            {
              Definition.Company.KeyId = responseEmp.Data.KeyId;
            }
          }
          CboEmpresa.Select();
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
          responseUsr.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
        TxtUsuario.Select();
      }

    }

    private void BtnCancelar_Click(object sender, System.EventArgs e)
    {
      IsDeath = true;
      this.Close();
    }

    #endregion

    #region « Formulario »

    private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (IsDeath == true)
      {
        Application.Exit();
      }
    }

    private void FrmLogin_Shown(object sender, EventArgs e)
    {
      //var emps = (from ent in businessCompany.SelectAll() select new { ent.KeyId, ent.Description }).ToList();
      //CboEmpresa.DataSource = emps;
      //CboEmpresa.DisplayMembers = "Description";
      //CboEmpresa.ValueMember = "KeyId";

      this.BackColor = Color.FromArgb(45, 45, 48);
      TxtUsuario.BackColor = Color.FromArgb(45, 45, 48);
      TxtPassword.BackColor = Color.FromArgb(45, 45, 48);
      CboEmpresa.BackColor = Color.FromArgb(45, 45, 48);
      CboEmpresa.ForeColor = Color.White;
      CboEmpresa.Focus();
    }

    #endregion

    private void TxtPassword_ButtonCustomClick(object sender, EventArgs e)
    {
      if (TxtPassword.ButtonCustom.Symbol == "")
      {
        TxtPassword.ButtonCustom.Symbol = "";
        TxtPassword.UseSystemPasswordChar = false;
      }
      else if (TxtPassword.ButtonCustom.Symbol == "")
      {
        TxtPassword.ButtonCustom.Symbol = "";
        TxtPassword.UseSystemPasswordChar = true;
      }
    }
  }
}