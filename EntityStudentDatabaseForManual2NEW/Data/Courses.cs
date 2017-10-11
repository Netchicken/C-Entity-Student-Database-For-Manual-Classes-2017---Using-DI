using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CollegeDB.Data;

namespace CollegeDB
{
    internal class Courses : ICourses
    {

        public DataGridView DGVCourse { get; set; }

        public IEnumerable AllCourses()
        {
            //Our standard Using statement passing all the data to context 
            using (var context = new collegestudentsEntities())
            {
                //What ever we want our code to do we do it in here
                //Pass our fields across to a variable
                var alldata = from c in context.Courses
                              select new
                              {
                                  c.CourseID,
                                  c.CourseName,
                                  c.CourseTime
                              };
                return alldata.ToList();
            }
        }

        public IEnumerable FillTheCourseComboBox()
        {
            // this query fills the course combobox. collegestudentsEntities
            using (var context = new collegestudentsEntities())
            {
                //create a query to grab the course name and ID
                var courses = from c in context.Courses select new { c.CourseName, c.CourseID };
                return courses.ToList();
            }

        }

        /// <summary>
        ///     Navigation property should be of entity type of collection of related entities. Including some navigation property
        ///     means joining your current entity with some related entity or entities. That allows eager loading of data from
        ///     several tables in single query. LastName is not a navigation property - it is simple field, and it will be loaded
        ///     by default, you don't need to include it:
        ///     http://stackoverflow.com/questions/20637776/a-specified-include-path-is-not-valid-the-entitytype-does-not-declare-a-navigat
        /// </summary>
        /// <returns></returns>
        public IEnumerable EagerLoading()
        {
            using (var context = new collegestudentsEntities())
            {
                var eagerloadingCourse = context.Student_Details.Select(c => c.CourseIDFK);
                //   var eagerloadingCourse = context.Courses.Include("CourseID.CourseName");
                return eagerloadingCourse.ToList();
            }
        }
    }
}
