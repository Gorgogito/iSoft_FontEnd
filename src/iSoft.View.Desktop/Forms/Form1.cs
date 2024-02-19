using MaterialSkin;
using MaterialSkin.Controls;

namespace iSoft.View.Desktop
{
  public partial class FrmLogin : MaterialForm
  {
    public FrmLogin()
    {
      InitializeComponent();

      var materialSkinManager = MaterialSkinManager.Instance;
      materialSkinManager.AddFormToManage(this);
      materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
      materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue800, Primary.Blue900, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
      //materialSkinManager.ColorScheme = new ColorScheme(Primary.Purple700, Primary.Purple900, Primary.Purple500, Accent.LightBlue200, TextShade.WHITE);
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
