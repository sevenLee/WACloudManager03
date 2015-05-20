using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WACloudManager.Models;

namespace WACloudManager.Controllers
{
    public class SsoController : Controller
    {

        // GET: Sso
        public ActionResult Index()
        {

            ViewBag.message = Profile.GetPropertyValue("WACloudLoginPortalUrl");
            
            
            return View();
        }

        public ActionResult Signin(String id, String returnUrl)
        {
            String checkResult = RRTool.WebTool.GET(Profile.GetPropertyValue("WACloudLoginPortalUrl")+id,"WACloudManager");
            String StatusCode = "";

            Account myAccount = new Account();
            Domain myDomain = new Domain();

            try
            {
                var myJR = System.Web.Helpers.Json.Decode(checkResult);
                foreach (var p in myJR)
                {

                    if (p.Key == "StatusCode")
                    {
                        StatusCode = Convert.ToString(p.Value);
                    }
                    if (p.Key == "Domain")
                    {
                        foreach (var i in p.Value)
                        {
                            Session["Domain." + i.Key] = i.Value;  // Session["Domain.DomainName"] == "abc.advantech.com"
                        }
                    }
                    if (p.Key == "Account")
                    {
                        foreach (var j in p.Value)
                        {
                            Session["Account." + j.Key] = j.Value; // Session["Account.UserName"] == "admin"
                        }
                    }
                }
            }
            catch (Exception)
            {
                StatusCode = "500";
            }

            ViewBag.message = StatusCode;


            return View();
        }

        public ActionResult signout()
        {
            Session.RemoveAll();
            return View();
        }
    }
}