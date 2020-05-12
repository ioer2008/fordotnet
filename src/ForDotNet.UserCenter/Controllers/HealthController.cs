﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ForDotNet.UserCenter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get() 
        {
            return Ok();
        }

        [Authorize]
        [HttpGet("{id}")]
        public IActionResult GetName(int id) 
        {
            return new JsonResult("Wangyingpan"+id);
        }
    }
}