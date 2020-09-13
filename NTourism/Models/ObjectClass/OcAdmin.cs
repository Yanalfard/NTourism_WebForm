using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using NTourism.Models.Regular;
using NTourism.Services.Impl;

namespace NTourism.Models.ObjectClass
{
    public class OcAdmin:TblClient
    {
        [Display(Name = "مرا به خاطر بسپار")]
        public bool RememberMe { get; set; }
        public OcAdmin()
        {

        }
        public OcAdmin(TblClient admin)
        {
            Username = admin.Username;
            FirstName = admin.FirstName;
            LastName  = admin.LastName;
            Password = admin.Password;
        }

        internal bool IsExistUser(object userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}