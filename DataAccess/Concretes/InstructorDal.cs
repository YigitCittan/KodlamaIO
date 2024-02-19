using DataAccess.Abstracts;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;


        public InstructorDal()
        {
            _instructors = new List<Instructor>()
            {
                new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ" },
                new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Yaylacı" },
                new Instructor { Id = 3, FirstName = "Yiğit", LastName = "Cittan" }

            };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            Instructor deleteInstructor = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
            _instructors.Remove(deleteInstructor);
        }

        public Instructor Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Instructor> GettAll()
        {
            return _instructors.ToList();
        }

        public void Update(Instructor instructor)
        {
            Instructor updateInstructor = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
            updateInstructor.FirstName = instructor.FirstName;
            updateInstructor.LastName = instructor.LastName;
                
        }
    }
}
       
