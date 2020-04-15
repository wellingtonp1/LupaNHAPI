using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LupaNHAPI.Models;
using LupaNHAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LupaNHAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WaterController : ControllerBase
    {
        private readonly WaterServices _WaterServices;

        public WaterController(WaterServices WaterServices)
        {
            _WaterServices = WaterServices;
        }

        [HttpGet]
        public ActionResult<List<WaterIssue>> Get() =>
            _WaterServices.Get();

        [HttpGet("{id:length(24)}", Name = "GetWaterIssue")]
        public ActionResult<WaterIssue> Get(string id)
        {
            var WaterIssue = _WaterServices.Get(id);

            if (WaterIssue == null)
            {
                return NotFound();
            }

            return WaterIssue;
        }

        [HttpPost]
        public ActionResult<WaterIssue> Create(WaterIssue WaterIssue)
        {
            _WaterServices.Create(WaterIssue);

            return CreatedAtRoute("GetWaterIssue", new { id = WaterIssue.Id.ToString() }, WaterIssue);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, WaterIssue WaterIssueIn)
        {
            var WaterIssue = _WaterServices.Get(id);

            if (WaterIssue == null)
            {
                return NotFound();
            }

            _WaterServices.Update(id, WaterIssueIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var WaterIssue = _WaterServices.Get(id);

            if (WaterIssue == null)
            {
                return NotFound();
            }

            _WaterServices.Remove(WaterIssue.Id);

            return NoContent();
        }
    }
}