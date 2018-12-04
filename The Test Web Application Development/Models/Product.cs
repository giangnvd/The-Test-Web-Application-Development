using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace The_Test_Web_Application_Development.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Subject { get; set; }
        [Display(Name ="Start Time")]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [Display(Name = "Exam Date")]
        [DataType(DataType.Date)]
        public DataType ExamDate { get; set; }
        [Display(Name = "Exam Durarion ")]
        public int ExamDurarion { get; set; }
        [Display(Name = "Class Room")]
        public string ClassRoom { get; set; }
        public string Faculty { get; set; }

    }
}