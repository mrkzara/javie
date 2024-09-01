using MyFirstDapperProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDapperProject.Service
{
    
    public class CourseService
    {
        CourseRepository courseRepository;
        
        public CourseModel GetCourseById(int id)
        {
            courseRepository = new CourseRepository();
            return courseRepository.GetById(id);
        }
    }
}
