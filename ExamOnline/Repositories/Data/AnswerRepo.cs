﻿using ExamOnline.Context;
using ExamOnline.Models;
using ExamOnline.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline.Repositories.Data
{
    public class AnswerRepo : GeneralRepo<Answer, MyContext>
    {
        readonly MyContext _context;
        IConfiguration _configuration;
        public AnswerRepo(MyContext context, IConfiguration config) : base(context)
        {
            _context = context;
            _configuration = config;
        }

        public override async Task<List<Answer>> GetAll()
        {
            List<AnswerVM> list = new List<AnswerVM>();
            var data = await _context.Answer.Include("Question").Where(x => x.isDelete == false).ToListAsync();
            if (data.Count == 0)
            {
                return null;
            }
            return data;
        }
        public override async Task<Answer> GetById(string Id)
        {
            var data = await _context.Answer.Include("Question").SingleOrDefaultAsync(x => x.Id == Id && x.isDelete == false);
            if (!data.Equals(0))
            {
                return data;
            }
            return null;
        }
    }
}
