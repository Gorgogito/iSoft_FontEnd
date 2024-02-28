using iSoft.Controller.Application.iSoft.Master.process;
using iSoft.Cross.Common;
using Newtonsoft.Json;

namespace iSoft.Controller.Core.iSoft.Master.process
{
  public class EncryptingRepository
  {

    EncryptingContext _context;

    public EncryptingRepository()
    {
      _context = new EncryptingContext();
    }

    public Response<string> Encrypt(string stringValue)
    {      
      var json = _context.Encrypt(stringValue);
      Response<string> models = JsonConvert.DeserializeObject<Response<string>>(json);
      return models;
    }

    public Response<string> Decrypt(string stringValue)
    {
      var json = _context.Decrypt(stringValue);
      Response<string> models = JsonConvert.DeserializeObject<Response<string>>(json);
      return models;
    }

  }
}
