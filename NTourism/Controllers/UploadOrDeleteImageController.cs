using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NTourism.Repositories.Impl;
using NTourism.Services.Impl;
using NTourism.Models.Regular;
using System.Net;
using NTourism.Models.ObjectClass;
using System.IO;
using System.Threading.Tasks;
using System.Web.Http;
using Newtonsoft.Json;
using NTourism.Models.Dto;


namespace NTourism.Controllers
{
    public class UploadOrDeleteImageController : Controller
    {
        // GET: UploadOrDeleteImage
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult AjaxPostCall(string employeeData)
        {
            System.IO.File.Delete(Server.MapPath("/Resources/Imges/" + employeeData));
            return Json("True");
        }
    }
}