using System.Windows.Forms;

namespace CollegeDB
{
    public interface IMarksData
    {

        string MarksAverage { get; set; }
        string MarksOverFifty { get; set; }
        string MarksUnderFifty { get; set; }
        string BestWorstStudent { get; set; }
        DataGridView DGVMarks { get; set; }
        void AllMarks();
        void MarksSummary(string StudentID);
        void MarksBest();
        void NoMarks();
        void StudentsAndMarks3();
    }
}

