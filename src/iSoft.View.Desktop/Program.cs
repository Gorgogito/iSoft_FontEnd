using System;
using System.IO;
using System.Windows.Forms;
using iSoft.Controller.Application;

namespace iSoft.View.Desktop
{
  internal static class Program
  {
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      using (StreamReader jsonStream = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "/Profile.json"))
      {
        var json = jsonStream.ReadToEnd();
        Context.SetApiContext(json);
      }

      Application.Run(new Windows.FrmMDI());
    }
  }
}