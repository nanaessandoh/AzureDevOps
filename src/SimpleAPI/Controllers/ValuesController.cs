using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    {

        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {

            return new string[] {"Value1","Value2","Value3"};
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {   
            return $"Something Else {id}";
        }

        
    }
}
