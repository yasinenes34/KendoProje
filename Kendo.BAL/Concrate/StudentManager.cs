using Kendo.BAL.Abstract;
using Kendo.DAL.Abstract;
using Kendo.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kendo.BAL.Concrate
{
    public class StudentManager:IStudentService
    {
        private static bool UpdateDatabase = false;

        IStudnet _student;
        public StudentManager(IStudnet student)
        {
            _student = student;
        }

        public List<Student> GetListBl()
        {
            return _student.GetAll();
        }

        public Student GetByID(int id)
        {
            return _student.get(x => x.ID == id);
        }
        public IEnumerable<Student> Read()
        {
            return GetListBl();
        }

        public void StudentAddBl(Student student)
        {
            if (!UpdateDatabase)
            {
                var first = GetListBl().OrderByDescending(e => e.ID).FirstOrDefault();
                var id = (first != null) ? first.ID : 0;

                student.ID = id + 1;



                GetListBl().Insert(0, student);
            }
            else
            {
                var entity = new Student();

                entity.StudentName = student.StudentName;
                entity.StudentSurname = student.StudentSurname;
                entity.ExcamScore = student.ExcamScore;
                entity.StudnetUniversity = student.StudnetUniversity;
                entity.StudentNo = student.StudentNo;
                _student.Insert(entity);
            }

            _student.Insert(student);
        }

        public void StudentRemoveBl(Student student)
        {
            if (!UpdateDatabase)
            {
                var target = GetListBl().FirstOrDefault(p => p.ID == student.ID);
                if (target != null)
                {
                    _student.Delete(target);
                }

            }

        }

        public void StudentUpdateBl(Student student)
        {
            if (!UpdateDatabase)
            {
                var target = GetByID(student.ID);
                if (target != null)
                {
                    target.StudentName = student.StudentName;
                    target.StudentSurname = student.StudentSurname;
                    target.StudnetUniversity = student.StudnetUniversity;
                    target.StudentNo = student.StudentNo;
                    target.ExcamScore = student.ExcamScore;
                    _student.Update(target);
                }
            }
            else
            {
                var entity = new Student();
                entity.StudentName = student.StudentName;
                entity.StudentSurname = student.StudentSurname;
                entity.StudnetUniversity = student.StudnetUniversity;
                entity.StudentNo = student.StudentNo;
                entity.ExcamScore = student.ExcamScore;
                _student.Update(student);
            }
        }
    }
}
