using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSoft.View.Desktop.Forms
{
  public partial class FrmMDI : MaterialForm
  {
    public FrmMDI()
    {
      InitializeComponent();
    }

    private void FrmMDI_Load(object sender, EventArgs e)
    {
      FrmLogin FLogin = new FrmLogin();
      FLogin.ShowDialog();
    }
  }
}
