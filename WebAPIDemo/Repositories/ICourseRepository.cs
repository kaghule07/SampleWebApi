using WebAPIDemo.Entities;
using WebAPIDemo.Model;
using System.Collections.Generic;
using System.Linq;
namespace WebAPIDemo.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAllCourse();
        int AddCourse(Course cr);
        int ModifyCourse(Course cr);
        int DeleteCourse(int id);
    }
}
