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
        public ActionResult<IEnumerable<string>> Get()
        {
            // using(var db = new TestContext())
            // {
            //     var data = db.Tests.ToList();
            //     return Ok(data);
            // }
            return new string[] { "test1", "test2", "test3", "test4", "test5", "string6", "string7", "string8" };

        }
    }
}
