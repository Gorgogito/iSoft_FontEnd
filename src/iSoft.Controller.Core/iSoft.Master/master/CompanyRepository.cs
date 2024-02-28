using iSoft.Controller.Application.iSoft.Master.master;
using iSoft.Cross.Common;
using iSoft.Model.Entity.iSoft.Master.master;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace iSoft.Controller.Core.iSoft.Master.master
{
  public class CompanyRepository
  {

    CompanyContext _context;

    public CompanyRepository()
    {
      _context = new CompanyContext();
    }

    public Response<List<Company>> List(string authorization)
    {
      var json = _context.List(authorization);

      Response<List<Company>> models = JsonConvert.DeserializeObject<Response<List<Company>>>(json);

      return models;
    }

    public Response<Company> GetById(string authorization, string keyId)
    {
      var json = _context.GetById(authorization, keyId);

      Response<Company> models = JsonConvert.DeserializeObject<Response<Company>>(json);

      return models;
    }


  }
}
