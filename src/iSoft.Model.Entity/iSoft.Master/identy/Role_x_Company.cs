using System;

namespace iSoft.Model.Entity.iSoft.Master.identy
{
  public class Role_x_Company 
  {

    public string RoleId { get; set; }
    public string CompanyId { get; set; }
    public string StateId { get; set; }
    public bool IsSystem { get; set; }
    public DateTime CreatedDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime LastModifiedDate { get; set; }
    public string LastModifiedBy { get; set; }

  }
}
