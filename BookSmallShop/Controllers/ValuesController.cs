﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookSmallShopServer;
using BookSmallShopServer.DatabaseTable;
using Microsoft.AspNetCore.Mvc;

namespace BookSmallShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            int id = 1;
            T_PersonalCenter_User t_PersonalCenter_ = UserService.GetById(id);

            return new string[] { "value1", "value2" };

        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
