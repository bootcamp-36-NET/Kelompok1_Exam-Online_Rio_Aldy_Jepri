using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnlineClient.ViewModels
{
    public class ResultVM
    {
        public string EmployeeId { set; get; }
        public string Score { set; get; }
        public string Subject { set; get; }
        public DateTimeOffset examDate { set; get; }
    }
}
