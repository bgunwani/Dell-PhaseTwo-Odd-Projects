using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreWebAPIFundamentals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public static List<string> values = new List<string>()
        {
            "ValueOne", "ValueTwo", "ValueThree"
        };
        [Route("vals")]
        [HttpGet]
        public List<string> ListOfValues()
        {
            return values;
        }
        [Route("vals/{index}")]
        [HttpGet]
        public string ValueByIndex(int index)
        {
            return values[index];
        }
        [Route("vals")]
        [HttpPost]
        public void AddValue([FromBody]string value)
        {
            values.Add(value);
        }
        [Route("vals/{index}")]
        [HttpPut]
        public void UpdateValue(int index, [FromBody]string value)
        {
            values[index] = value;
        }
        [Route("vals/{index}")]
        [HttpDelete]
        public void RemoveValue(int index)
        {
            values.RemoveAt(index);
        }
    }
}
