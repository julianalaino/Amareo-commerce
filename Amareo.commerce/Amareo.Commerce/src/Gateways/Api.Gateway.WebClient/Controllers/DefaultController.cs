﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Gateway.WebClient.Controllers
{
    [Route("/")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public string index()
        {
            return ("running..");
        }
    }
}
