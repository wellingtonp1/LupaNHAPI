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
    public class LightController : ControllerBase
    {
        private readonly LightServices _LightServices;

        public LightController(LightServices LightServices)
        {
            _LightServices = LightServices;
        }

        [HttpGet]
        public ActionResult<List<LightIssue>> Get() =>
            _LightServices.Get();

        [HttpGet("{id:length(24)}", Name = "GetLightIssue")]
        public ActionResult<LightIssue> Get(string id)
        {
            var LightIssue = _LightServices.Get(id);

            if (LightIssue == null)
            {
                return NotFound();
            }

            return LightIssue;
        }

        [HttpPost]
        public ActionResult<LightIssue> Create(LightIssue LightIssue)
        {
            _LightServices.Create(LightIssue);

            return CreatedAtRoute("GetLightIssue", new { id = LightIssue.Id.ToString() }, LightIssue);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, LightIssue LightIssueIn)
        {
            var LightIssue = _LightServices.Get(id);

            if (LightIssue == null)
            {
                return NotFound();
            }

            _LightServices.Update(id, LightIssueIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var LightIssue = _LightServices.Get(id);

            if (LightIssue == null)
            {
                return NotFound();
            }

            _LightServices.Remove(LightIssue.Id);

            return NoContent();
        }
    }
}
