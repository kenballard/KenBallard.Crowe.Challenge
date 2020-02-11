using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KenBallard.Crowe.Challenge.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace KenBallard.Crowe.Challenge.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingService _greetingService;

        public GreetingController(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        [HttpGet]
        public string Get()
        {
            return _greetingService.Get();
        }
    }
}
