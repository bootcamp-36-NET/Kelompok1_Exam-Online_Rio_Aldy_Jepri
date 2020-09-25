﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExamOnline.Base;
using ExamOnline.Context;
using ExamOnline.Models;
using ExamOnline.Repositories.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController : BaseController<Answer, AnswerRepo>
    {
        readonly AnswerRepo _answerRepo;
        readonly MyContext _context;
        RandomDigit randDig = new RandomDigit();
        public AnswersController(MyContext context,AnswerRepo answerRepo) : base(answerRepo)
        {
            _context = context;
            _answerRepo = answerRepo;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<int>> Update(string id, Answer entity)
        {
            var getId = await _answerRepo.GetById(id);
            getId.Answers = entity.Answers;
            getId.QuestionId = entity.QuestionId;
            getId.Status = entity.Status;
            SetStatus(getId.QuestionId);
            var data = await _answerRepo.Update(getId);
            if (data.Equals(null))
            {
                return BadRequest("Something Wrong! Please check again");
            }
            return data;
        }

        public void SetStatus(string id)
        {
            var getSts = _context.Answer.Include("Question").FirstOrDefault(x=>x.QuestionId == id);
            if (getSts.Question.Key == getSts.Answers)
            {
                getSts.Status = true;
            }
        }
       // [Route ("Generate")]
        public Question GenerateQuestion()
        {
            var list = _context.Question.ToArray();
            var eof = list.Length;
            var number = randDig.GenerateRandom();
            var number2 = Convert.ToInt32(number);
            
            if (number2 <= eof)
            {
               var question = list[number2];
               return question;
            }
            else
            {
                return GenerateQuestion();
            }
        }

        public class RandomDigit
        {
            private Random _random = new Random();
            public string GenerateRandom()
            {
                return _random.Next(0, 10).ToString("D2");
            }
        }
    }
}