using System.Net;

namespace iSoft.Controller.Application.iSoft.Master.identy
{
  public class AuthenticateContext
  {

    public string Login(string userName, string password)
    {
      string json;
      var method = $"/Authenticate/Authenticate";
      var request = (HttpWebRequest)WebRequest.Create(Context.GetProfile.Url + method);
      request.Method = "GET";
      request.ContentType = "application/json";
      request.Accept = "application/json";

      json = "{\r\n  \"userName\": \"" + userName + "\",\r\n  \"" + password + "\": \"123456789\"\r\n}";

      try
      {
        using (var streamWriter = new StreamWriter(request.GetRequestStream()))
        {
          streamWriter.Write(json);
          streamWriter.Flush();
          streamWriter.Close();
        }
        using (WebResponse response = request.GetResponse())
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
}
