using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorManager
    {
        void Add(Instructor instructor);
        void Delete(int instructorId);
        void Update(Instructor UpdatedInstructor);
        Instructor GetInstructor(int instructorId);
        List<Instructor> GetAll();
    }
}

