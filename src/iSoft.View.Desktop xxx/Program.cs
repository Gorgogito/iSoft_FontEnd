using iSoft.Controller.Application;
using System;

namespace iSoft.View.Desktop
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {


      //// To customize application configuration such as set high DPI settings or default font,
      //// see https://aka.ms/applicationconfiguration.
      //ApplicationConfiguration.Initialize();
      //  Application.Run(new FrmLogin());
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      using (StreamReader jsonStream = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + "/Profile.json"))
      {
        var json = jsonStream.ReadToEnd();
        Context.SetApiContext(json);
      }
      Application.Run(new Forms.FrmMDI());
    }




  }
}