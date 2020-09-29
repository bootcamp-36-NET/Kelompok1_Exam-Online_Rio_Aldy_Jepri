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
    public class NotifController : BaseController<Notifications, NotifRepo>
    {
        private readonly NotifRepo _repo;
        public NotifController(NotifRepo repository) : base(repository)
        {
            this._repo = repository;
        }

        [HttpGet("emp/{Id}", Name = "Get notification for employee")]
        public async Task<ActionResult> getNotif (string Id)
        {
            if(Id == null)
            {
                return NotFound("Id is null");
            }
            else
            {
                var notifList = _repo.GetByEmployeeId(Id);
                if(notifList == null)
                {
                    return BadRequest("You don't have notification");
                }
                else
                {
                    return Ok(notifList);
                }
            }
        }

        [HttpPut("read/{Id}")]
        public ActionResult readNotif(string Id)
        {
            if(Id == null)
            {
                return BadRequest("Id is null");
            }
            else
            {
                var read = _repo.ReadNotification(Id);
                if(read == null)
                {
                    return BadRequest("Failed to update");
                }
                else
                {
                    return Ok("Notification read");
                }
            }
        }
    }
}
