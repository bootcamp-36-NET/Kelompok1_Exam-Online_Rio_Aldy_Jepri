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
    public class AnswersController : BaseController<Answer, AnswerRepo>
    {
        readonly AnswerRepo _answerRepo;
        public AnswersController(AnswerRepo answerRepo) : base(answerRepo)
        {
            _answerRepo = answerRepo;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<int>> Update(string id, Answer entity)
        {
            var getId = await _answerRepo.GetById(id);
            getId.Answers = entity.Answers;
            getId.QuestionId = entity.QuestionId;
            getId.Status = entity.Status;
            var data = await _answerRepo.Update(getId);
            if (data.Equals(null))
            {
                return BadRequest("Something Wrong! Please check again");
            }
            return data;
        }
    }
}