using iSoft.Controller.Application.iSoft.Master.identy;
using iSoft.Cross.Common;
using iSoft.Model.Entity.iSoft.Master.identy;
using Newtonsoft.Json;

namespace iSoft.Controller.Core.iSoft.Master.identy
{
  public class AuthenticateRepository
  {

    AuthenticateContext _context;

    public AuthenticateRepository()
    {
      _context= new AuthenticateContext();
    }

    public Response<User> Login(string userName, string password)
    {
      var json = _context.Login(userName, password);

      Response<User> models = JsonConvert.DeserializeObject<Response<User>>(json);

      //List<User> models = JsonConvert.DeserializeObject<List<User>>(json);

      return models;
    }

  }
}
