using System.CodeDom;
using WACloudManager.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WACloudManager.Controllers
{
    public class UserController : Controller
    {
        public ActionResult GetUser()
        {
            List<UserVM> list = new List<UserVM>()
            {
                new UserVM()
                {
                    Name = "advantech.com",
                    PassCode = "easlsv9z1vmej3qza0ekvmzelfizvncba"
                }
            };

            var camelCaseFormatt = new JsonSerializerSettings();
            camelCaseFormatt.ContractResolver = new CamelCasePropertyNamesContractResolver();

            var jsonResult = new ContentResult
            {
                Content = JsonConvert.SerializeObject(list, camelCaseFormatt),
                ContentType = "application/json"
            };
            
            return jsonResult;
        }
    }
}