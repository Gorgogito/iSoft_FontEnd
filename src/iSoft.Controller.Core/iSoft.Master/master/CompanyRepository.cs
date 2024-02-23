using iSoft.Controller.Application.iSoft.Master.identy;
using iSoft.Controller.Application.iSoft.Master.master;
using iSoft.Cross.Common;
using iSoft.Model.Entity.iSoft.Master.identy;
using iSoft.Model.Entity.iSoft.Master.master;
using Newtonsoft.Json;

namespace iSoft.Controller.Core.iSoft.Master.master
{
  public class CompanyRepository
  {

    CompanyContext _context;

    public CompanyRepository()
    {
      _context = new CompanyContext();
    }

    public Response<Company> GetAll(string authorization)
    {
      var json = _context.GetAll(authorization);

      Response<Company> models = JsonConvert.DeserializeObject<Response<Company>>(json);

      //List<User> models = JsonConvert.DeserializeObject<List<User>>(json);

      return models;
    }


  }
}
