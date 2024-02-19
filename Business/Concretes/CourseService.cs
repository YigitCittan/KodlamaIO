using Business.Abstracts;
using DataAccess.Abstracts;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CourseService : ICourseService
    {   
        ICourseDal  _courseDal;

        public CourseService (ICourseDal courseDal) 
        {
            _courseDal = courseDal;
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GettAll();
        }   

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
    }
}
