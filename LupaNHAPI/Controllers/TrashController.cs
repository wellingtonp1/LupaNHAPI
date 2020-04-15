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
    public class TrashController : ControllerBase
    {
        private readonly TrashServices _TrashServices;

        public TrashController(TrashServices TrashServices)
        {
            _TrashServices = TrashServices;
        }

        [HttpGet]
        public ActionResult<List<TrashIssue>> Get() =>
            _TrashServices.Get();

        [HttpGet("{id:length(24)}", Name = "GetTrashIssue")]
        public ActionResult<TrashIssue> Get(string id)
        {
            var TrashIssue = _TrashServices.Get(id);

            if (TrashIssue == null)
            {
                return NotFound();
            }

            return TrashIssue;
        }

        [HttpPost]
        public ActionResult<TrashIssue> Create(TrashIssue TrashIssue)
        {
            _TrashServices.Create(TrashIssue);

            return CreatedAtRoute("GetTrashIssue", new { id = TrashIssue.Id.ToString() }, TrashIssue);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, TrashIssue TrashIssueIn)
        {
            var TrashIssue = _TrashServices.Get(id);

            if (TrashIssue == null)
            {
                return NotFound();
            }

            _TrashServices.Update(id, TrashIssueIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var TrashIssue = _TrashServices.Get(id);

            if (TrashIssue == null)
            {
                return NotFound();
            }

            _TrashServices.Remove(TrashIssue.Id);

            return NoContent();
        }
    }
}