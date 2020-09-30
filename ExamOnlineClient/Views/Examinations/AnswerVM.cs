using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnlineClient.Views.Examinations
{
    public class AnswerVM
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string Answers { get; set; }
        public string ExamId { get; set; }
        public int qnummber { get; set; }
    }
}
