using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamOnline.Base;
using ExamOnline.Models;
using ExamOnline.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExamOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventDetailsController : BaseController<EventDetailsVM, EventDetailsRepo>
    {
        private EventDetailsRepo _repo;

        public EventDetailsController(EventDetailsRepo repository) : base(repository)
        {
            this._repo = repository;
        }

        [HttpGet("events/{Id}", Name = "Get By Event Id")]
        public async Task<ActionResult<List<EventDetailsVM>>> GetEventId(string Id)
        {
            List<EventDetailsVM> item = null;
            item = await _repo.GetEventId(Id);
            if(item == null)
            {
                return NotFound("Data is not found");
            }
            return Ok(item);
        }


        [HttpPut("{Id}")]
        public async Task<ActionResult> Update (string Id, EventDetailsVM details)
        {
            EventDetailsVM item = await _repo.GetById(Id);
            item.EmployeeId = details.EmployeeId;
            int updatedItem = await _repo.Update(item);

            if(updatedItem > 0)
            {
                return Ok("Data is updated");
            }
            return BadRequest("Updated is failed");

        }

        [HttpPut("emp/")]
        public ActionResult DeleteUser(EventDetailsVM eventDetailsVM)
        {
            if(eventDetailsVM == null)
            {
                return BadRequest("Data empty");
            }
            else
            {
                int deletedItem = _repo.DeleteUser(eventDetailsVM);
                if(deletedItem > 0)
                {
                    return Ok("Data deleted");
                }
                else
                {
                    return BadRequest("Delete data failed");
                }
            }
        }
    }
}
