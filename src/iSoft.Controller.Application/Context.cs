using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using RestSharp;

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
      WebResponse response;
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

      }
      catch (WebException ex)
      {
        return string.Empty;
      }
      try
      {
        //response = api.GetResponse();

        Stream strReader = api.GetResponse().GetResponseStream();
        if (strReader == null) return string.Empty;
        using (StreamReader objReader = new StreamReader(strReader))
        {
          string responseBody = objReader.ReadToEnd();
          // Do something with responseBody
          return responseBody;
        }

      }
      catch (WebException ex)
      {
        // Handle error


        return string.Empty;
      }

    }




    public static string SendNew(RestSharp.Method method, string host, string func, string request, string authorization)
    {
      try
      {
        var client = new RestClient(host);
        var req = new RestRequest(func, method);
        if (request == null) { request = ""; }
        if (request.Length > 0) { req.AddJsonBody(request, false); }
        if (authorization == null) { authorization = ""; }
        if (authorization.Length > 0)
        { req.AddHeader("Authorization", "Bearer " + authorization); }

        var response = client.Execute(req);

        return response.Content;

      }
      catch (WebException ex)
      {
        return string.Empty;
      }
    }

  }

  public class UseProfile
  {
    public string Url { get; set; }
  }


}

