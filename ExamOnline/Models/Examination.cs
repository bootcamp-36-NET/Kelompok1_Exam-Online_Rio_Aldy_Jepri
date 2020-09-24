using ExamOnline.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ExamOnline.Models
{
    [Table("tb_t_examination")]
    public class Examination : BaseModel
    {
        [Key]
        public string Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset RescheduleDate { get; set; }
        public double Score { get; set; }
        public bool isDelete { get; set; }


        public string EmployeeId { get; set; }
        [ForeignKey("Subjects")]
        public string SubjectId { get; set; }
    }
}
