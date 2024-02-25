using DataAccess.Abstracts;
using Entities.Concretes;
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
                new Course() { Id = 1, CategoryId = 1, InstructorId = 1, CourseName = "C#", CourseDescription = "C# ile yazılım geliştirme kursu." },
                new Course() { Id = 2, CategoryId = 1, InstructorId = 1,CourseName= "Java",CourseDescription="Java ile yazılım geliştirme kursu."},
                new Course() { Id = 3, CategoryId = 1,InstructorId=2,CourseName="Python",CourseDescription="Python ile yazılım geliştirme kursu."},
                new Course() { Id = 4, CategoryId = 2, InstructorId = 2, CourseName = "Ayrık Matematik", CourseDescription = "Algoritma analizi,mantıksal tasarım,kriptografi ile verimli sistemler geliştirmek. " }
            };
        }

        public void Add(Course course)
        {
            _courses.Add(course);
        }

        public List<Course> CourseAll()
        {
            return _courses;
        }

        public void Delete(int courseId)
        {
            Course CourseToDelete = _courses.SingleOrDefault(p => p.Id == courseId);
            _courses.Remove(CourseToDelete); 
            
        }

        public Course GetCourse(int courseId)
        {
            return _courses.SingleOrDefault(c => c.Id == courseId);

        }
        public void Update(Course UpdatedCourse)
        {
            Course course = _courses.SingleOrDefault(p=> p.Id==UpdatedCourse.Id );
            course.InstructorId = UpdatedCourse.InstructorId;
            course.CategoryId = UpdatedCourse.CategoryId;
            course.CourseName = UpdatedCourse.CourseName;
            course.CourseDescription = UpdatedCourse.CourseDescription;
        }

    }
}
