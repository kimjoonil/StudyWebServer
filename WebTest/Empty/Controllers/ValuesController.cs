using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Empty.Models;

namespace Empty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public List<MessageTest> Get()
        {
            List<MessageTest> messages = new List<MessageTest>();
            messages.Add(new MessageTest() { Message = "Hello Web API 1!" });
            messages.Add(new MessageTest() { Message = "Hello Web API 2!" });
            messages.Add(new MessageTest() { Message = "Hello Web API 3!" });

            return messages;
        }
    }
}
