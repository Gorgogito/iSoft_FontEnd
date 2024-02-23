using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace iSoft.Controller.Application
{

  public enum methodHttp
  {
    GET = 1,
    POST = 2,
    PUT = 3,
    DELETE = 4,
    PATCH = 5
  }

  public static class Context
  {

    private static UseProfile getProfile;

    public static UseProfile GetProfile { get { return getProfile; } }

    public static void SetApiContext(string json)
    { getProfile = JsonConvert.DeserializeObject<UseProfile>(json); }


    private static string CreateHttpMethod(methodHttp method)
    {
      switch (method)
      {
        case methodHttp.GET:
          return "GET";
        case methodHttp.POST:
          return "POST";
        case methodHttp.PUT:
          return "PUT";
        case methodHttp.DELETE:
          return "DELETE";
        case methodHttp.PATCH:
          return "PATCH";
        default:
          throw new NotImplementedException("Not implemented http method");
      }
    }

    public static string Send(methodHttp method, string uri, string request, string authorization)
    {
      //var method = $"/Authenticate/Authenticate";
      var api = (HttpWebRequest)WebRequest.Create(uri);

      api.Method = CreateHttpMethod(method);
      api.ContentType = "application/json";
      api.Accept = "application/json";

      try
      {
        if (request == null) { request = ""; }
        if (request.Length > 0)
        {
          using (var streamWriter = new StreamWriter(api.GetRequestStream()))
          {
            streamWriter.Write(request);
            streamWriter.Flush();
            streamWriter.Close();
          }
        }
        if (authorization == null) { authorization = ""; }
        if (authorization.Length > 0)
        { api.Headers.Add("Authorization", "Bearer " + authorization); }

        using (WebResponse response = api.GetResponse())
        {
          using (Stream strReader = response.GetResponseStream())
          {
            if (strReader == null) return string.Empty;
            using (StreamReader objReader = new StreamReader(strReader))
            {
              string responseBody = objReader.ReadToEnd();
              // Do something with responseBody
              return responseBody;
            }
          }
        }
      }
      catch (WebException ex)
      {
        // Handle error
        return string.Empty;
      }

    }

  }

  public class UseProfile
  {
    public string Url { get; set; }
  }


}

