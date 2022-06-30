using WebAPIDemo.Entities;
using WebAPIDemo.Model;
using System.Collections.Generic;
using System.Linq;
namespace WebAPIDemo.Repositories
{
    public class CourseRepository:ICourseRepository
    {
        RepositoriesContext2 context;
        public CourseRepository(RepositoriesContext2 context) //DI
        {
            this.context = context;
        }

        public int AddCourse(Course cr)
        {
            context.Courses.Add(cr);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteCourse(int id)
        {
            var cr=context.Courses.Where(cr=>cr.Id==id).SingleOrDefault();
            if(cr!=null)
            {
                context.Courses.Remove(cr);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<Course> GetAllCourse()
        {
            return context.Courses.ToList();
        }

        public int ModifyCourse(Course cr)
        {
            var crs = context.Courses.Where(c => c.Id == cr.Id).SingleOrDefault();
            if(crs!=null)
            {
                crs.Name= cr.Name; ;
                crs.Fees = cr.Fees;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
