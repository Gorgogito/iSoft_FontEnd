using System.Net;

namespace iSoft.Controller.Application.iSoft.Master.process
{
  public class EncryptingContext
  {

    public string Encrypt(string stringValue)
    {
      string json;
      var method = $"/Encrypting/EncryptString";
      json = " \"" + stringValue + "\"";
      try
      {
        return Context.Send(methodHttp.PATCH, Context.GetProfile.Url + method, json, "");
      }
      catch (WebException ex)
      {
        // Handle error
        return string.Empty;
      }

    }

    public string Decrypt(string stringValue)
    {      
      string json;
      var method = $"/Encrypting/DecryptString";
      json = " \"" + stringValue + "\"";
      string result;
      try
      {
        return Context.Send(methodHttp.PATCH, Context.GetProfile.Url + method, json, "");
      }
      catch (WebException ex)
      {
        // Handle error
        return string.Empty;
      }

    }

  }
}
