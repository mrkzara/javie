using MyFirstDapperProject.Model;
using MyFirstDapperProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapperProject.Service
{
    public class StudentService
    {
        StudentRepository studentRepository;
        public StudentModel GetStudentById(int id)
        {
            studentRepository = new StudentRepository();
            return studentRepository.GetById(id);
        }
    }
}
