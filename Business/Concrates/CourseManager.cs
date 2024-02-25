using Business.Abstracts;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CourseManager: ICourseManager
    {
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
           _courseDal = courseDal;
        }

        public void Add(Course course)
        {
            _courseDal.Add(course);
        }

        public void Delete(int courseId)
        {
            _courseDal.Delete(courseId);
        }

        public List<Course> GetAll()
        {
            return _courseDal.CourseAll();
        }

        public Course GetCourse(int courseId)
        {
           return _courseDal.GetCourse(courseId);
        }

        public void Update(Course UpdatedCourse)
        {
            _courseDal.Update(UpdatedCourse);
        }
    }
}
