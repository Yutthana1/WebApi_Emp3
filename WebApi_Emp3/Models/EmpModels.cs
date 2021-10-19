using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Emp3.Models
{
    public class EmpModels
    {
        [Key]
        public int emp_ID { get; set; }
        public string nameEmp { get; set; }
        public string designation { get; set; }
        public string address { get; set; }
        public double salary { get; set; }
        public DateTime dateTime { get; set; }
    }
}
