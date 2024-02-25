using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> CourseAll();
        void Add(Course course);
        void Delete(int courseId);
        void Update(Course UpdatedCourse);
        Course GetCourse(int courseId); 




    }
}
