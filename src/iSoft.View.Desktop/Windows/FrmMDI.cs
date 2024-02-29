using System.Windows.Forms;

namespace iSoft.View.Desktop.Windows
{
  public partial class FrmMDI : DevComponents.DotNetBar.Office2007RibbonForm
  {
    public FrmMDI()
    {
      InitializeComponent();
    }

    private void FrmMDI_Shown(object sender, System.EventArgs e)
    {
      FrmLogin FLogin = new FrmLogin();
      FLogin.ShowDialog();
      this.Show();
      this.Visible = true;

      BtiUser.Text = Definition.User.UserName;
      LbiNombres.Text = Definition.User.Description;
      LbiEMail.Text = Definition.User.EMail;
      //if (Definition.User.Image != null)
      //{
      //  Image img;
      //  img = DoCmd.Formats.ByteArrayToImage(Definition.User.Image);
      //  img = (new Bitmap(img, new Size(48, 48)));
      //  img = DoCmd.Formats.RoundCorners(img, 24, Color.Transparent);
      //  BtiUserImage.Image = img;
      //}

    }

    private void BtiSalir_Click(object sender, System.EventArgs e)
    {
      this.Close();
      Application.Exit();
    }

    private void BtnLock_Click(object sender, System.EventArgs e)
    {
      FrmBlock FBlock = new FrmBlock();
      FBlock.ShowDialog();
    }
  }
}
