using ExamOnline.Context;
using ExamOnline.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline.Repositories.Data
{
    public class ExaminationRepository : GeneralRepo<Examination, MyContext>
    {
        readonly MyContext _context;
        IConfiguration _configuration;
        public ExaminationRepository(MyContext context, IConfiguration config) : base(context)
        {
            _context = context;
            _configuration = config;
        }

        public override async Task<List<Examination>> GetAll()
        {
            var data = await _context.Examinations.Include("Subjects").Where(D => D.isDelete == false).ToListAsync();
            return data;
        }
    }
}
