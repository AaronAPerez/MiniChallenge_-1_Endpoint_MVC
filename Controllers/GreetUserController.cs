using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MiniChallenge__1_Endpoint_MVC.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreetController : ControllerBase
    {
        [HttpGet]
        public string GreetUser(string name){  
            return "Hello " + name + "," + " it's good to see you" + "!";
        } 
    }
}
