using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollegeDB
{
    public interface IStudents
    {
        int StudID { get; set; }
        string Name { get; set; }
        string Address { get; set; }
        string Phone { get; set; }
        int CourseIDFK { get; set; }
        DataGridView DGVStudent { get; set; }
        IEnumerable AllStudentsDirect();
        Task AllStudents();
        Task UpdateStudent();
        Task InsertStudent();
        Task Delete();
        ComboBox FillTheStudentCBX();
    }
}