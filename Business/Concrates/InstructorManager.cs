using Business.Abstracts;
using DataAccess.Abstracts;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class InstructorManager : IInstructorManager
    {
        IInstructorDal _ınstructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _ınstructorDal = instructorDal;
        }
        public void Add(Instructor instructor)
        {
            _ınstructorDal.Add(instructor);
        }

        public void Delete(int instructorId)
        {
            _ınstructorDal.Delete(instructorId);
        }

        public Instructor GetInstructor(int instructorId)
        {
            return _ınstructorDal.GetInstructor(instructorId);
        }

        public List<Instructor> GetAll()
        {
            return _ınstructorDal.GetAll();
        }

        public void Update(Instructor UpdatedInstructor)
        {
            _ınstructorDal.Update(UpdatedInstructor);
        }
    }
}
