namespace iSoft.View.Desktop
{
  public static class Definition
  {

    public struct Company
    {
      public static string KeyId { set; get; }
      public static string Ruc { set; get; }
      public static string Description { set; get; }
      public string Observation { get; set; }
      public string Address { get; set; }
      public string Agent { get; set; }
      public string Phone { get; set; }
      public string EMail { get; set; }
      public string Web { get; set; }
      public static string StateId { get; set; }
      public static bool IsSystem { get; set; }

    }

    public struct User
    {
      public static string KeyId { get; set; }
      public static string UserName { get; set; }
      public static string Password { get; set; }
      public static string Description { get; set; }
      public static string Names { get; set; }
      public static string Surnames { get; set; }
      public static string Phone { get; set; }
      public static string EMail { get; set; }
      public static byte[] Image { get; set; }
      public static string Token { get; set; }
      public static string RoleId { get; set; }
      public static string StateId { get; set; }
      public static bool IsSystem { get; set; }
    }

  }
}
