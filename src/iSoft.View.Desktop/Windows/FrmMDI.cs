namespace iSoft.View.Desktop.Windows
{
  public partial class FrmMDI : DevComponents.DotNetBar.Metro.MetroForm
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
    }
  }
}
