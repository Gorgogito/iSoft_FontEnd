using Newtonsoft.Json;

namespace iSoft.Controller.Application
{
  public static class Context
  {

    private static UseProfile getProfile;

    public static UseProfile GetProfile { get { return getProfile; } }

    public static void SetApiContext(string json)
    { getProfile = JsonConvert.DeserializeObject<UseProfile>(json); }

  }

  public class UseProfile
  {
    public string Url { get; set; }
  }

}

