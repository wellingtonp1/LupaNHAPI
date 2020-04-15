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
        public class SewerController : ControllerBase
        {
            private readonly SewerServices _SewerServices;

            public SewerController(SewerServices SewerServices)
            {
                _SewerServices = SewerServices;
            }

            [HttpGet]
            public ActionResult<List<SewerIssue>> Get() =>
                _SewerServices.Get();

            [HttpGet("{id:length(24)}", Name = "GetSewerIssue")]
            public ActionResult<SewerIssue> Get(string id)
            {
                var SewerIssue = _SewerServices.Get(id);

                if (SewerIssue == null)
                {
                    return NotFound();
                }

                return SewerIssue;
            }

            [HttpPost]
            public ActionResult<SewerIssue> Create(SewerIssue SewerIssue)
            {
                _SewerServices.Create(SewerIssue);

                return CreatedAtRoute("GetSewerIssue", new { id = SewerIssue.Id.ToString() }, SewerIssue);
            }

            [HttpPut("{id:length(24)}")]
            public IActionResult Update(string id, SewerIssue SewerIssueIn)
            {
                var SewerIssue = _SewerServices.Get(id);

                if (SewerIssue == null)
                {
                    return NotFound();
                }

                _SewerServices.Update(id, SewerIssueIn);

                return NoContent();
            }

            [HttpDelete("{id:length(24)}")]
            public IActionResult Delete(string id)
            {
                var SewerIssue = _SewerServices.Get(id);

                if (SewerIssue == null)
                {
                    return NotFound();
                }

                _SewerServices.Remove(SewerIssue.Id);

                return NoContent();
            }
      }
 }
