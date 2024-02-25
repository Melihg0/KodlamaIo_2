using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface ICourseManager
    {   
        List<Course>GetAll();
        void Add(Course course);
        void Delete(int courseId);
        void Update(Course UpdatedCourse);
        Course GetCourse(int courseId);


    }

}
