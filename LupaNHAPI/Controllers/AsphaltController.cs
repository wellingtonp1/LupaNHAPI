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
    public class AsphaltController : ControllerBase
    {
        private readonly AsphaltServices _AsphaltServices;

        public AsphaltController(AsphaltServices AsphaltServices)
        {
            _AsphaltServices = AsphaltServices;
        }

        [HttpGet]
        public ActionResult<List<AsphaltIssue>> Get() =>
            _AsphaltServices.Get();

        [HttpGet("{id:length(24)}", Name = "GetAsphaltIssue")]
        public ActionResult<AsphaltIssue> Get(string id)
        {
            var AsphaltIssue = _AsphaltServices.Get(id);

            if (AsphaltIssue == null)
            {
                return NotFound();
            }

            return AsphaltIssue;
        }

        [HttpPost]
        public ActionResult<AsphaltIssue> Create(AsphaltIssue AsphaltIssue)
        {
            _AsphaltServices.Create(AsphaltIssue);

            return CreatedAtRoute("GetAsphaltIssue", new { id = AsphaltIssue.Id.ToString() }, AsphaltIssue);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, AsphaltIssue AsphaltIssueIn)
        {
            var AsphaltIssue = _AsphaltServices.Get(id);

            if (AsphaltIssue == null)
            {
                return NotFound();
            }

            _AsphaltServices.Update(id, AsphaltIssueIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var AsphaltIssue = _AsphaltServices.Get(id);

            if (AsphaltIssue == null)
            {
                return NotFound();
            }

            _AsphaltServices.Remove(AsphaltIssue.Id);

            return NoContent();
        }
    }
}
