using DataAccess.Abstracts;
using Entities.Concretes;
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
                new Instructor(){InstructorId=1,InstructorName="Melih Gacav"},
                new Instructor(){InstructorId=2,InstructorName="Hasan Sabbah"}
            };
        }

        public void Add(Instructor instructor)
        {
            _instructors.Add(instructor);
        }

        public void Delete(int instructorId)
        {
            Instructor InstructorToDelete = _instructors.SingleOrDefault(p => p.InstructorId == instructorId);
            _instructors.Remove(InstructorToDelete);
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetInstructor(int instructorId)
        {
            Instructor instructor = _instructors.SingleOrDefault(p => p.InstructorId == instructorId);
            return instructor;
        }

        public void Update(Instructor UpdatedInstructor)
        {
            Instructor instructor = _instructors.SingleOrDefault(p => p.InstructorId == UpdatedInstructor.InstructorId);
            instructor.InstructorName = UpdatedInstructor.InstructorName;
        }         
    }
}
