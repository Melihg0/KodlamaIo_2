using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(int instructorId);
        void Update(Instructor UpdatedInstructor);
        Instructor GetInstructor(int instructorId);
        List<Instructor> GetAll();
    }
}
