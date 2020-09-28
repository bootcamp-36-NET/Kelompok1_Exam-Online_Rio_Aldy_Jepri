using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline.ViewModels
{
    public class ExaminationVM
    {
        public string Id { get; set; }
        public bool isDelete { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset? RescheduleDate { get; set; }
        public int Score { get; set; }
        public string EmployeeId { get; set; }
        public string SubjectId { get; set; }
    }
}
