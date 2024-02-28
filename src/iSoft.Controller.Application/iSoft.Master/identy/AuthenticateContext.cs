using System.Net;

namespace iSoft.Controller.Application.iSoft.Master.identy
{
  public class AuthenticateContext
  {

    public string Login(string userName, string password)
    {
      string json;
      var method = $"/Authenticate/Authenticate";      
      json = "{\r\n  \"userName\": \"" + userName + "\",\r\n  \"password\": \"" + password + "\"\r\n}";

      try
      {
        return Context.SendNew(RestSharp.Method.Post , Context.GetProfile.Url,  method, json, "");
      }
      catch (WebException ex)
      {
        // Handle error
        return string.Empty;
      }

    }

  }
}
