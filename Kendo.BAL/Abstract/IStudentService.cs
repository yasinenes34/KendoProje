using Kendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendo.BAL.Abstract
{
    public interface IStudentService
    {
        List<Student> GetListBl();
        void StudentAddBl(Student student);
        void StudentRemoveBl(Student student);
        Student GetByID(int id);
        void StudentUpdateBl(Student student);
    }
}
