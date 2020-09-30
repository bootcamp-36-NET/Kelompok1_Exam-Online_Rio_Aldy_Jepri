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
    public class ResultController : BaseController<Examination, ExaminationRepository>
    {
        private ExaminationRepository _repo;

        public ResultController(ExaminationRepository repo) : base(repo)
        {
            _repo = repo;
        }
        [HttpGet("emp/{Id}")]
        public IActionResult GetByUserId(string Id)
        {
            if (Id == null)
            {
                return BadRequest("Id is null");
            }
            else
            {
                var score = _repo.GetByUser(Id);

                if (score == null)
                {
                    return BadRequest("Data Not Found");
                }
                else
                {
                    return Ok(score);
                }
            }
        }
    }
}