using System;
using System.Windows.Forms;
using CollegeDB.Data;

namespace CollegeDB
{
    public partial class Form1 : Form
    {
        private readonly ICourses myCourses;
        private readonly IMarksData myMarks;
        private readonly IStudents myStudent;


        public Form1(ICourses Courses, IMarksData MarksData, IStudents Students)
        {
            InitializeComponent();

            myCourses = Courses;
            myMarks = MarksData;
            myStudent = Students;

            LoadFormStuff();
        }

        private void LoadFormStuff()
        {
            //Bind all the DGV's to the classes


            //combo box not being passed across
            myStudent.DGVStudent = DGVStudents;
            myMarks.DGVMarks = DGVMarks;
            myCourses.DGVCourse = DGVCourse;

            //fill the Combobox
            cbxCourses.DataSource = myCourses.FillTheCourseComboBox();
            cbxCourses.DisplayMember = "CourseName";
            //set the value member - what data is returned - to the ID
            cbxCourses.ValueMember = "CourseID";
            //cbxCourses.SelectedIndex = 1;

            DGVStudents.DataSource = myStudent.AllStudentsDirect();
            // myStudent.AllStudents();
            DGVCourse.DataSource = myCourses.AllCourses();
            myMarks.AllMarks();
        }


        private void dataGridViewMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //get the index of the selected row
                var rowIndex = e.RowIndex;
                //pass the row data to the row
                var row = DGVMarks.Rows[rowIndex];
                //Pass the data in the cell to the textbox
                txtmarks1.Text = row.Cells[2].Value.ToString();
                txtmarks2.Text = row.Cells[3].Value.ToString();
                txtmarks3.Text = row.Cells[4].Value.ToString();
                txtmarks4.Text = row.Cells[5].Value.ToString();

                myMarks.MarksSummary(row.Cells[1].Value.ToString());
                txtAverageMarks.Text = myMarks.MarksAverage;
                txtMarksOverFifty.Text = myMarks.MarksOverFifty;
                txtMarksFailed.Text = myMarks.MarksUnderFifty;
                lblWorstBest.Text = myMarks.BestWorstStudent;
            }
            catch (Exception)
            {
            }
        }


        private void ClearTextBoxes()
        {
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtPhone.Text = string.Empty;
            myStudent.AllStudents().Wait();
        }


        private void cbxCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            Text = cbxCourses.SelectedValue.ToString();
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            DGVCourse.DataSource = myCourses.AllCourses();
            tabControlAll.SelectTab(2);
            //   UpdateDeleteStudentsActivation(sender);
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            //   StudentAndCourses2();
            //   UpdateDeleteStudentsActivation(sender);
        }

        private void toolStripButton3_Click_1(object sender, EventArgs e)
        {
            //  StudentsAndMarks();
            //     myMarks.AllMarks();
            tabControlAll.SelectTab(1);
            //  StudentsAndMarks3();
            //   UpdateDeleteStudentsActivation(sender);
            //fill the student combobox
            cbxStudents = myStudent.FillTheStudentCBX();
        }

        private void tsAllStudents_Click(object sender, EventArgs e)
        {
            myStudent.AllStudents();
            tabControlAll.SelectTab(0);
            //  UpdateDeleteStudentsActivation(sender);
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //get the index of the selected row
                var rowIndex = e.RowIndex;
                //pass the row data to the row
                var row = DGVStudents.Rows[rowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPhone.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                cbxCourses.Text = row.Cells[4].Value.ToString();

                if (e.ColumnIndex == DGVStudents.Columns["Delete Request"].Index)
                {
                    // Retrieve the task ID.
                    var Studentname = (string)DGVStudents[0, e.RowIndex].Value;

                    Text = "Student to be Deleted - " + Studentname;
                    myStudent.Delete().Wait();
                }
            }
            catch (Exception)
            {
            }
        }

        private void ActivateToolStrips()
        {
            //pass the sender details to ts
            //  ToolStripButton fakeStripButton = (ToolStripButton)sender;


            //If the text on the button is All Students
            //   if (fakeStripButton.Text == "All Students") {
            if (txtID.Text != string.Empty)
            {
                //set the enabled properties to true
                tsDeleteStudent.Enabled = true;
                tsUpdateStudent.Enabled = true;
                tsInsertAdd.Enabled = true;
                //  tsAllStudents.BackColor = Color.WhiteSmoke;
                //  tsAllMarks.BackColor = Color.Transparent;
                //  tsAllCourses.BackColor = Color.Transparent;
            }
            else
            {
                //set the enabled properties to false
                tsDeleteStudent.Enabled = false;
                tsUpdateStudent.Enabled = false;
                tsInsertAdd.Enabled = false;
            }

            if (txtmarks1.Text != string.Empty)
            {
                //set the enabled properties to true
                tsDeleteMarks.Enabled = true;
                tsUpdateMarks.Enabled = true;
                tsInsertMarks.Enabled = true;
                //   tsAllMarks.BackColor = Color.WhiteSmoke;
                //   tsAllStudents.BackColor = Color.Transparent;
                //   tsAllCourses.BackColor = Color.Transparent;
            }
            else
            {
                //set the enabled properties to false
                tsDeleteMarks.Enabled = false;
                tsUpdateMarks.Enabled = false;
                tsInsertMarks.Enabled = false;
            }
            //  if (txtmarks1.Text != string.Empt) {
            //set the enabled properties to true
            tsDeleteCourse.Enabled = true;
            tsUpdateCourse.Enabled = true;
            tsInsertCourse.Enabled = true;
            //  tsAllCourses.BackColor = Color.WhiteSmoke;
            //  tsAllStudents.BackColor = Color.Transparent;
            //  tsAllMarks.BackColor = Color.Transparent;
            //} else { //set the enabled properties to false
            //tsDeleteCourse.Enabled = false;
            //tsUpdateCourse.Enabled = false;
            //tsInsertCourse.Enabled = false;

            //}
        }

        private void tsInsertMarks_Click(object sender, EventArgs e)
        {
            if (txtmarks1.Text != string.Empty && txtmarks2.Text != string.Empty && txtmarks3.Text != string.Empty &&
                txtmarks4.Text != string.Empty)
                using (var context = new collegestudentsEntities())
                {
                    var NewMarks = new Mark();
                    NewMarks.Marks1 = short.Parse(txtmarks1.Text);
                    NewMarks.marks2 = short.Parse(txtmarks2.Text);
                    NewMarks.Marks3 = short.Parse(txtmarks3.Text);
                    NewMarks.Marks4 = short.Parse(txtmarks4.Text);
                    NewMarks.StudIDFK = Convert.ToInt32(cbxStudents.SelectedValue);
                    //Add to entity set of context
                    context.Marks.Add(NewMarks);
                    context.SaveChanges();
                    myMarks.AllMarks();
                }
            else MessageBox.Show("Please complete all the fields");
        }

        private void tsInsertAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != string.Empty && txtAddress.Text != string.Empty && txtPhone.Text != string.Empty)
            {
                myStudent.StudID = Convert.ToInt32(txtID.Text);
                myStudent.Name = txtName.Text;
                myStudent.Address = txtAddress.Text;
                myStudent.Phone = txtPhone.Text;
                myStudent.CourseIDFK = Convert.ToInt32(cbxCourses.SelectedValue);
                myStudent.InsertStudent().Wait();

                ClearTextBoxes();
            }
            else
            {
                MessageBox.Show("Please complete all the fields");
            }
        }

        private void tsBestStudent_Click(object sender, EventArgs e)
        {
            myMarks.MarksBest();
        }

        private void tsUpdateMarks_Click(object sender, EventArgs e)
        {
        }

        private void tsUpdateStudent_Click(object sender, EventArgs e)
        {
            myStudent.StudID = Convert.ToInt32(txtID.Text);
            myStudent.Name = txtName.Text;
            myStudent.Address = txtAddress.Text;
            myStudent.Phone = txtPhone.Text;
            myStudent.CourseIDFK = Convert.ToInt32(cbxCourses.SelectedValue);
            myStudent.UpdateStudent().Wait();
        }

        private void tsNoMarks_Click(object sender, EventArgs e)
        {
            // myMarks.NoMarks();
        }

        private void tsDeleteStudent_Click(object sender, EventArgs e)
        {
            myStudent.Name = txtName.Text;
            if (MessageBox.Show("Do you REALLY want to delete " + myStudent.Name + "?", "Delete Record",
                    MessageBoxButtons.YesNo) != DialogResult.Yes) return;
            try
            {
                myStudent.StudID = Convert.ToInt32(txtID.Text);
                myStudent.Delete().Wait();
            }
            catch (Exception)
            {
                MessageBox.Show("Student has already been deleted or another error has occured ");
            }
        }

        private void AllTextChanged_TextChanged(object sender, EventArgs e)
        {
            ActivateToolStrips();
        }

        private void ToolStripStudents_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
