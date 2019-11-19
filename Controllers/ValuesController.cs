using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MS_TEST_EJ.Clases_Negocio;

namespace MS_TEST_EJ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        //Constructor
        private readonly INegocio _negocio;
        private readonly ILogger<ValuesController> _log;
        private readonly IConfiguration _config;

        public ValuesController(INegocio negocio, ILogger<ValuesController> log, IConfiguration config)
        {
            _negocio = negocio;
            _log = log;
            _config = config;
        }
        //

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            _log.LogTrace("LOG TRACE");
            _log.LogDebug("LOG DEBUG");
            _log.LogInformation("LOG INFORMATION");
            _log.LogWarning("LOG WARNING");
            _log.LogError("LOG ERROR");
            _log.LogCritical("LOG CRITICAL");
            _log.LogDebug(_config["Logging:LogLevel:Default"]);
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
