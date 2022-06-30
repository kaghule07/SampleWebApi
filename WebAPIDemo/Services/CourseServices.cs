using WebAPIDemo.Model;
using WebAPIDemo.Repositories;
using System;
using System.Collections.Generic;
namespace WebAPIDemo.Services
{
    public class CourseServices:ICourseServices
    {
        private readonly ICourseRepository _iCourseRepo;
        public CourseServices(ICourseRepository iCourseRepo)
        {
           _iCourseRepo=iCourseRepo;    
        }

        public int AddCourse(Course cr)
        {
            return _iCourseRepo.AddCourse(cr);
        }

        public int DeleteCourse(int id)
        {
            return _iCourseRepo.DeleteCourse(id);   
        }

        public IEnumerable<Course> GetAllCourse()
        {
            return _iCourseRepo.GetAllCourse(); 

        }

        public int ModifyCourse(Course cr)
        {
            return _iCourseRepo.ModifyCourse(cr);
        }
    }
}
