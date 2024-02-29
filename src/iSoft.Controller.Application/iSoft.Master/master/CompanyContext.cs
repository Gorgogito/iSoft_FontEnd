using System.Net;

namespace iSoft.Controller.Application.iSoft.Master.master
{
  public class CompanyContext
  {

    public string List(string authorization)
    {
      var method = $"/Company/List";
      
      try
      {
        //return Context.Send(methodHttp.GET, Context.GetProfile.Url + method, "", authorization);
        return Context.Send(RestSharp.Method.Get, Context.GetProfile.Url, method, "", authorization);
      }
      catch (WebException ex)
      {
        // Handle error
        return string.Empty;
      }

    }

    public string GetById(string authorization, string keyId)
    {

      string json;
      var method = $"/Company/GetByID";
      json = "{\r\n\"keyId\": \"" + keyId + "\"\r\n}";

      try
      {
        return Context.Send(RestSharp.Method.Patch, Context.GetProfile.Url, method, json, authorization);
        //return Context.Send(methodHttp.PATCH, Context.GetProfile.Url + method, json, authorization);
      }
      catch (WebException ex)
      {
        // Handle error
        return string.Empty;
      }

    }

  }
}
