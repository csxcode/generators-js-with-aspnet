using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace Generators.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getUser()
        {
            return Json(new { id = 10547, username = "csxcode", valid = true }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getTweets(Int32 userid)
        {
            //you can use userid variable to others operations...
          
            var tweets = new[]
            {
                new {
                    id = 105,
                    tweet = "Test 1",
                    created_at = "05/06/2017"
                },
                new {
                    id = 14587,
                    tweet = "Test 2",
                    created_at = "01/01/2017"
                }
            };

            return Json(tweets, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult getFriends(Int32 userid)
        {
            //you can use userid variable to others operations...

            var friends = new[]
            {
                new {                    
                    full_name = "Brenda Ariza Mora",
                    user_name = "bren_next"                    
                },
                new {
                    full_name = "Christine Ezpinoza Welchz",
                    user_name = "m1000_main"
                },
                 new {
                    full_name = "Yuli Lopez",
                    user_name = "stunt_789"
                }
            };

            return Json(friends, JsonRequestBehavior.AllowGet);
        }

    }
}