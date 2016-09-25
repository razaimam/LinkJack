using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Web.Http;

namespace LinkJack.Controllers
{
    [RoutePrefix("api")]
    public class HomeController : ApiController
    {


        [Route("profile")]
        public string getdata()
        {

            return "Ankit";

        }
    }
}
