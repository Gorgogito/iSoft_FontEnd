﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace iSoft.Model.Entity.iSoft.Master.identy
{
  public  class Authenticate
  {

    public string? KeyId { get; set; }
    public string? UserName { get; set; }
    public string? Password { get; set; }
    public string? Description { get; set; }
    public string? Names { get; set; }
    public string? Surnames { get; set; }
    public string? Phone { get; set; }
    public string? EMail { get; set; }

    //[Column(Order = 9)]
    //public byte Image { get; set; }

    public string? Token { get; set; }
    public string? RoleId { get; set; }
    public string? StateId { get; set; }
    public string? IsSystem { get; set; }

  }
}
