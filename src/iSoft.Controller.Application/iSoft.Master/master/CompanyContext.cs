using System.Net;

namespace iSoft.Controller.Application.iSoft.Master.master
{
  public class CompanyContext
  {

    public string GetAll(string authorization)
    {
      var method = $"/Company/List";
      
      try
      {
        return Context.Send(methodHttp.GET, Context.GetProfile.Url + method, "", authorization);
      }
      catch (WebException ex)
      {
        // Handle error
        return string.Empty;
      }

    }

  }
}
