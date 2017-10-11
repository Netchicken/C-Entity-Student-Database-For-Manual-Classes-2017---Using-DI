using System.Collections;
using System.Windows.Forms;

namespace CollegeDB
{
    public interface ICourses
    {
        DataGridView DGVCourse { get; set; }
        IEnumerable AllCourses();
        IEnumerable FillTheCourseComboBox();

        /// <summary>
        ///     Navigation property should be of entity type of collection of related entities. Including some navigation property
        ///     means joining your current entity with some related entity or entities. That allows eager loading of data from
        ///     several tables in single query. LastName is not a navigation property - it is simple field, and it will be loaded
        ///     by default, you don't need to include it:
        ///     http://stackoverflow.com/questions/20637776/a-specified-include-path-is-not-valid-the-entitytype-does-not-declare-a-navigat
        /// </summary>
        /// <returns></returns>
        IEnumerable EagerLoading();
    }
}