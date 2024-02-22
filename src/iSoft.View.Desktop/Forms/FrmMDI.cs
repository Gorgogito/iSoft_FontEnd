using MaterialSkin.Controls;


namespace iSoft.View.Desktop.Forms
{
  public partial class FrmMDI :  MaterialForm
  {
    public FrmMDI()
    {
      InitializeComponent();
    }

    private void FrmMDI_Load(object sender, EventArgs e)
    {
    
    }

    private void FrmMDI_Shown(object sender, EventArgs e)
    {
      FrmLogin FLogin = new FrmLogin();
      FLogin.ShowDialog();
      this.Show();
      this.Visible = true;
    }
  }
}
