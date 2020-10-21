using System.Collections.Generic; 
using Microsoft.AspNetCore.Mvc; 

namespace CmdApi.Controllers
{
    //inheriting ControllerBase is because you dont want other stuffs of MVC and its an api 
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetString()
        {
            return new string[] { "This", "Is", "hard", "Coded" };
        }
        [HttpGet]
        public ActionResult<string> GetString2()
        {
            return "this";
        }
       
    }
}