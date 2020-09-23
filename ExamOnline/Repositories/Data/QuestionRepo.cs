using ExamOnline.Context;
using ExamOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline.Repositories.Data
{
    public class QuestionRepo : GeneralRepo<Question, MyContext>
    {
        public QuestionRepo(MyContext context) : base(context)
        {

        }
    }
}
