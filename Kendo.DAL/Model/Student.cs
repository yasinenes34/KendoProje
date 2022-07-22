using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendo.DAL.Model
{
    public class Student
    {
        public int ID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public string StudnetUniversity { get; set; }
        public string StudentNo { get; set; }
        public decimal ExcamScore { get; set; }
    }
}
