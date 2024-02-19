using DataAccess.Abstracts;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {   
        List<Course> _courses;
        
        public CourseDal()
        {
            _courses = new List<Course>()
            {
                new Course { Id = 1, Name = "C# + Angular", Description = "Yazılım Geliştirici Yetiştirici Kampı (C# + Angular)", CategoryId = 1, InstructorId = 1 },
                new Course { Id = 2, Name = "Javascript", Description = "Yazılım Geliştirici Yetiştirici Kampı (Javascript)", CategoryId = 1, InstructorId = 1 },
                new Course { Id = 3, Name = "Java + React", Description = "Yazılım Geliştirici Yetiştirici Kampı (Java + React)", CategoryId = 1, InstructorId = 1 },
                new Course { Id = 4, Name = ".Net", Description = "Senior Yazılım Geliştirici Kampı (.Net)", CategoryId = 1, InstructorId = 1 }

            };
        }


        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public void Delete(Course course)
        {
            _courses.Remove(_courses.SingleOrDefault(c => c.Id == course.Id));

        }

        public Course Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Course> GettAll()
        {
            return _courses;
        }

        public void Update(Course course)
        {
            Course courseToUpdate = _courses.SingleOrDefault(c => c.Id == course.Id);
            courseToUpdate.Name = course.Name;
            courseToUpdate.Description = course.Description;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
        }
    }
}
