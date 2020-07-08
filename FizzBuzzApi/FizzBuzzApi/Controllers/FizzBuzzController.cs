using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FizzBuzzApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FizzBuzzApi.Controllers
{
    [Route("api/[controller]")]
    public class FizzBuzzController : Controller
    {
        // GET api/values/5
        [HttpGet("{id}")]
        public List<string> Get(int id)
        {

            var results = FizzBuzz.Go(id);
            return results;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
