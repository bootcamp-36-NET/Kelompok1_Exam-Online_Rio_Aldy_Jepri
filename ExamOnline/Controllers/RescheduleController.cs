using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using ExamOnline.Context;
using ExamOnline.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamOnline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RescheduleController : ControllerBase
    {
        readonly HttpClient API = new HttpClient
        {
            BaseAddress = new Uri("http://winarto-001-site1.dtempurl.com/api/")
        };

        private readonly MyContext _context;


        public RescheduleController(MyContext myContext)
        {
            _context = myContext;
        }

        [HttpGet]
        public async Task<List<ExaminationVM>> GetAll()
        {
            List<ExaminationVM> list = new List<ExaminationVM>();

            var getData = await _context.Examinations.Include("Subjects").Where(Q => Q.RescheduleDate != null && Q.isDelete == false).ToListAsync();

            if (getData.Count == 0)
            {
                return null;
            }
            foreach (var item in getData)
            {
                var user = new ExaminationVM()
                {
                    Id = item.Id,
                    EmployeeId = item.EmployeeId,
                    SubjectId = item.Subjects.Name,
                    CreatedDate = item.CreatedDate,
                    RescheduleDate = item.RescheduleDate

                };
                list.Add(user);
            }
            return list;
        }
    }
}