using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cc_alpha_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Test>> Get()
        {
            using(var db = new TestContext())
            {
                var data = db.Tests.ToList();
                return data;
            }
        }
    }
}
