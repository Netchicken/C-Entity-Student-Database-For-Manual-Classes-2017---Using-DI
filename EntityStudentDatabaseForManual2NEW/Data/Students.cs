using System.Collections;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeDB.Data;

namespace CollegeDB
{
    internal class Students : IStudents
    {
        public int StudID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int CourseIDFK { get; set; }
        public DataGridView DGVStudent { get; set; }


        public IEnumerable AllStudentsDirect()
        {
            //Our standard Using statement passing all the data to context 
            using (var context = new collegestudentsEntities())
            {
                var students = (from s in context.Student_Details
                                select new { s.StudID, s.Name, s.Phone, s.Address, s.Course.CourseName }).ToList();

                return students;
            }
        }


        //http://msdn.microsoft.com/en-us/library/bxt3k60s%28v=vs.110%29.aspx - important

        //not sure the async is doing anything
        public async Task AllStudents()
        {
            //Our standard Using statement passing all the data to context 
            using (var context = new collegestudentsEntities())
            {
                //What ever we want our code to do we do it in here
                //Pass our fields across to a variable
                // var students = from s in context.Student_Details select s;

                var students = await (from s in context.Student_Details
                                      select new { s.StudID, s.Name, s.Phone, s.Address, s.Course.CourseName })
                    .ToArrayAsync();

                // var students2 = context.Student_Details.Select(s => new {s.StudID, s.Name, s.Phone});


                DGVStudent.AutoGenerateColumns = false;
                //      dataGridView1.AutoSize = true;
                DGVStudent.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.AllCells;
                // Set the column header style.
                //DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();
                //dataGridView1.ColumnHeadersDefaultCellStyle = columnHeaderStyle;
                //dataGridView1.Rows.Clear();
                //dataGridView1.Columns.Clear(); 
                //create the columns in the dgv
                DGVStudent.ColumnCount = 7;
                DGVStudent.Columns[0].Name = "ID";
                DGVStudent.Columns[1].Name = "Name";
                DGVStudent.Columns[2].Name = "Phone";
                DGVStudent.Columns[3].Name = "Address";
                DGVStudent.Columns[4].Name = "Course Name";
                DGVStudent.Columns[5].Name = "Current";
                //   dataGridView1.Columns[5].Visible = false;
                //pass data across to the dgv

                //   students.ForEachAsync(s => dataGridView1.Rows.Add(s.StudID, s.Name, s.Phone, s.Address, s.Course));,
                //   List<bool> CurrentStudents = new List<bool>();


                foreach (var s in students.ToArray()) //add data to the dgv
                    DGVStudent.Rows.Add(s.StudID, s.Name, s.Phone, s.Address, s.CourseName);

                //        CurrentStudents.Add(Convert.ToBoolean(s.IsCurrentStudent));


                //http://stackoverflow.com/questions/19484551/c-sharp-entity-navigation-not-working-when-returning-all-data-to-a-manually-crea

                //-------------CheckBoxes----------------------

                var checkBox = new DataGridViewCheckBoxColumn();

                checkBox.ThreeState = false;
                checkBox.Name = "Enrolled";
                checkBox.DisplayIndex = 6;
                checkBox.FalseValue = "False";
                checkBox.TrueValue = "True";
                checkBox.DataPropertyName = "Current";
                //  checkBox.CellTemplate.Style.BackColor = System.Drawing.Color.LightBlue;
                //   checkBox.CellTemplate = new DataGridViewCheckboxCellFilter(); 

                //loop through all data and change cells accordingly
                foreach (DataGridViewRow dr in DGVStudent.Rows)
                    if (dr.Cells[5].Value != null)
                        if (dr.Cells[5].Value.ToString() == "True")
                        {
                            //   dr.Cells[6].Value = "True";
                            //    dr.DataGridView.Name.Where(d => d.Equals("Enrolled")).Select(d => d.);
                            dr.Cells[0].Style.BackColor = Color.Chartreuse;
                        }
                        else
                        {
                            dr.Cells[1].Value = dr.Cells[5].Value;
                            //   dr.Cells[6].Value = "False";

                            dr.Cells[0].Style.BackColor = Color.Black;
                        }


                DGVStudent.Columns.Add(checkBox);


                //---------- combobox added ------------------------

                var coursename = await (from c in context.Courses select new { c.CourseName, c.CourseID }).ToListAsync();

                //http://msdn.microsoft.com/en-us/library/ms404353.aspx
                //http://nickstips.wordpress.com/2010/11/19/c-datagridviewcomboboxcolumn-displaying-different-values-in-drop-down-list/
                //http://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.columns.aspx


                var comboBoxColumn = new DataGridViewComboBoxColumn();
                comboBoxColumn.DataSource = coursename.ToList();
                comboBoxColumn.HeaderText = "Course Name";
                comboBoxColumn.ValueMember = "CourseID";
                comboBoxColumn.DisplayMember = "Coursename";
                //cell is blank unless you click on it
                comboBoxColumn.DisplayStyleForCurrentCellOnly = true;
                //   comboBoxColumn.DataPropertyName = "1";
                //set the column number that you want it to be in
                comboBoxColumn.DisplayIndex = 7;
                DGVStudent.Columns.Add(comboBoxColumn);

                //---------- Buttons added ------------------------

                //http://msdn.microsoft.com/en-us/library/system.windows.forms.datagridviewbuttoncell.aspx
                //just an ordinary button
                var BtnDelete = new Button();
                BtnDelete.Text = "Delete?";
                //    BtnDelete.Click += new EventHandler(BtnDelete_click);
                BtnDelete.Dock = DockStyle.Top;
                //     Controls.Add(BtnDelete);


                // Add a button column. 
                var buttonColumn = new DataGridViewButtonColumn();
                buttonColumn.DisplayIndex = 8;
                buttonColumn.HeaderText = "Delete S";
                buttonColumn.Name = "Delete Request";
                buttonColumn.Text = "Delete?";
                buttonColumn.UseColumnTextForButtonValue = true;

                DGVStudent.Columns.Add(buttonColumn);
                //does this even work, we are not saving changes
                //  await context.SaveChangesAsync(); 
            }
            //------------Add a new Column ---------------------------
            //                var CourseNameForStudents = from s in context.Student_Details select s.Course.CourseName;
            //              DataGridViewTextBoxColumn CourseNameColumn = new DataGridViewTextBoxColumn();

            //              CourseNameColumn.HeaderText = "Course Name";

            //              foreach (var c in CourseNameForStudents.ToArray())
            //              {

            //              }
            //dataGridView1.Columns.Insert(4, CourseNameColumn);
            // Add a CellClick handler to handle clicks in the button column.
            //dataGridView1.CellClick +=
            //    new DataGridViewCellEventHandler(dataGridView1_CellContentClick);

            //   dataGridView1.DataSource = students.ToList();
            //save any changes
        }


        public async Task UpdateStudent()
        {
            using (var context = new collegestudentsEntities())
            {
                var query = from s in context.Student_Details where s.StudID == StudID select s;
                var student = query.FirstOrDefault(); //gets the first one although we know there is only one
                student.Name = Name;
                student.Address = Address;
                student.Phone = Phone;
                student.CourseIDFK = CourseIDFK;

                await context.SaveChangesAsync();
            }
        }

        public async Task InsertStudent()
        {
            //In order to create or insert new date we first instantiate a new type. We then update the values of the properties. Next we add it to the underlying set of the context and then save that back to the database.


            using (var context = new collegestudentsEntities())
            {
                var contact = new Student_Details();
                contact.Name = Name;
                contact.Address = Address;
                contact.Phone = Phone;
                contact.CourseIDFK = CourseIDFK;
                //Add to entity set of context
                context.Student_Details.Add(contact);


                // add new marks to cascade up the student details. 

                var marks = new Mark();
                marks.Marks1 = 0;
                marks.marks2 = 0;
                marks.Marks3 = 0;
                marks.Marks4 = 0;
                marks.StudIDFK = contact.StudID;
                context.Marks.Add(marks);

                await context.SaveChangesAsync();
                //      ClearTextBoxes();
            }
        }


        public async Task Delete()
        {
            //Our standard Using statement passing all the data to context 

            using (var context = new collegestudentsEntities())
            {
                //select the row you want to delete

                var contact = (from s in context.Student_Details where s.StudID == StudID select s).SingleOrDefault();

                //run remove command
                context.Student_Details.Remove(contact);
                //save the changes
                await context.SaveChangesAsync();
                //ClearTextBoxes();
            }
        }

        public ComboBox FillTheStudentCBX()
        {
            // this query fills the course combobox. 
            var cbx = new ComboBox();
            using (var context = new collegestudentsEntities())
            {
                //create a query to grab the course name and ID
                var students = from s in context.Student_Details select new { s.Name, s.StudID };
                //pass all the data to a ComboBox
                cbx.DataSource = students.ToList();
                //set the display member - what it shows - to the course name
                cbx.DisplayMember = "Name";
                //set the value member - what data is returned - to the ID
                cbx.ValueMember = "StudID";
                //   cbx.SelectedIndex = 1;
            }

            return cbx;
        }
    }
    //private void StudentsAndMarks() {
    //    //Using Join
    //    using (var context = new collegestudentsEntities1()) {

    //        var alldata = from s in context.Student_Details
    //                      join m in context.Marks
    //                          on s.StudID equals m.StudIDFK into output

    //                      from o in output.DefaultIfEmpty()
    //                      //to add the default to the right hand side

    //                      select new
    //                      {
    //                          o.Student_Details.Name,
    //                          o.Student_Details.StudID,

    //                          o.Marks1,
    //                          o.marks2,
    //                          o.Marks3,
    //                          o.Marks4

    //                      };
    //        DGVStudent.DataSource = alldata.ToList();


    //        context.SaveChanges();

    //        //foreach (var item in alldata)
    //        //{
    //        //    listBox1.Items.Add(item.Name + " " + item.markOne);
    //        //}
    //        }
    //    }

    //private void StudentAndCourses() {
    //    //using join
    //    //This query joins the Courses and the Students table together showing the data baelow
    //    using (var context = new collegestudentsEntities1()) {
    //        var alldata = from c in context.Courses
    //                      join s in context.Student_Details
    //                          on c.CourseID equals s.CourseIDFK
    //                      //when we want to output more than one field we need to use New{ }, 
    //                      select new
    //                      {
    //                          s.Name,
    //                          s.StudID,
    //                          c.CourseName
    //                      };
    //        DGVStudent.DataSource = alldata.ToList();
    //        context.SaveChanges();
    //        }
    //    }

    //private void StudentAndCourses2() {
    //    // using navigation
    //    //This query joins the Courses and the Students table together showing the data baelow
    //    using (var context = new collegestudentsEntities1()) {
    //        var alldata = from s in context.Student_Details
    //                      where s.CourseIDFK == s.Course.CourseID

    //                      select new
    //                      {
    //                          s.Name,
    //                          s.StudID,
    //                          s.Course.CourseName
    //                      };
    //        DGVStudent.DataSource = alldata.ToList();
    //        context.SaveChanges();
    //        }
    //    }
    //public void AllStudentsAuto() {
    //    //   return;
    //    //Our standard Using statement passing all the data to context 
    //    using (var context = new collegestudentsEntities1()) {

    //        var students = from s in context.Student_Details
    //                       select new { s.StudID, s.Name, s.Phone, s.Address, s.Course.CourseName, s.IsCurrentStudent };

    //        DGVStudent.DataSource = students.ToList();
    //        //save any changes
    //        context.SaveChanges();
    //        }

    //    }
}
