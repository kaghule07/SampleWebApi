using WebAPIDemo.Entities;
using WebAPIDemo.Model;
using System.Collections.Generic;
using System.Linq;
namespace WebAPIDemo.Services
{
    public interface ICourseServices
    {
        IEnumerable<Course> GetAllCourse();
        int AddCourse(Course cr);
        int ModifyCourse(Course cr);
        int DeleteCourse(int id);
    }
}
