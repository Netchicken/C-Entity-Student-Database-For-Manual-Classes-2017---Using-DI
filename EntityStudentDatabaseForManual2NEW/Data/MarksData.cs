using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using CollegeDB.Data;

namespace CollegeDB
{
    class MarksData : IMarksData
    {
        public string MarksAverage { get; set; }
        public string MarksOverFifty { get; set; }
        public string MarksUnderFifty { get; set; }
        public string BestWorstStudent { get; set; }


        //public int MarksID { get; set; }
        //public int Marks1 { get; set; }
        //public int Marks2 { get; set; }
        //public int Marks3 { get; set; }
        //public int Marks4 { get; set; }
        //public int StudIDFK { get; set; }

        public DataGridView DGVMarks { get; set; }

        public void AllMarks()
        {
            //using navigation
            using (var context = new collegestudentsEntities())
            {

                var alldata = from m in context.Marks
                              where m.StudIDFK == m.Student_Details.StudID

                              select new
                              {
                                  m.Student_Details.Name,
                                  m.Student_Details.StudID,
                                  m.Marks1,
                                  m.marks2,
                                  m.Marks3,
                                  m.Marks4

                              };
                DGVMarks.DataSource = alldata.ToList();

                // context.SaveChanges();
            }
        }

        //http://stackoverflow.com/questions/19126088/entity-cant-pass-short-int16-values-out
        public void MarksSummary(string StudentID)
        {
            int ID = Convert.ToInt32(StudentID);
            //get the average of the marks using entity
            using (var context = new collegestudentsEntities())
            {
                var StudentMarks = (from m in context.Marks
                                    where m.StudIDFK == ID
                                    select new
                                    {
                                        m.Marks1,
                                        m.marks2,
                                        m.Marks3,
                                        m.Marks4
                                    }).ToList();

                //need to get it out of the entity and into a list and work on the list

                var Marklist = new List<int>();
                //Marklist = StudentMarks.Select(s => new {s.Marks1, s.marks2, s.Marks3, s.Marks4}).ToList();    

                //   Marklist = StudentMarks.ToList();

                // MarkList =  StudentMarks.ToList().ForEach(m => Marklist.Add(m));

                //  Marklist.AddRange(StudentMarks.ToList());

                foreach (var s in StudentMarks)
                {
                    Marklist.Add((int)s.Marks1);
                    Marklist.Add((int)s.marks2);
                    Marklist.Add((int)s.Marks3);
                    Marklist.Add((int)s.Marks4);
                }

                // double av = Convert.ToDouble(Marklist.Average());
                MarksAverage = Marklist.Average().ToString();
                MarksOverFifty = Marklist.Count(s => s > 50).ToString();
                MarksUnderFifty = Marklist.Count(s => s < 50).ToString();

            }
        }

        public void MarksBest()
        {
            //get the average of the marks using entity
            using (var context = new collegestudentsEntities())
            {
                var StudentMarks = (from m in context.Marks

                                    select new
                                    {
                                        m.Student_Details.Name,
                                        //get the total marks
                                        totalmarks = m.Marks1 + m.marks2 + m.Marks3 +
                                                     m.Marks4,
                                    });

                DGVMarks.DataSource = StudentMarks.OrderByDescending(s => s.totalmarks).ToList();

                StudentMarks.OrderByDescending(s => s.totalmarks).Select(s => s.Name).FirstOrDefault();


                BestWorstStudent = "Best Student " + StudentMarks.OrderByDescending(s => s.totalmarks).Select(s => s.Name).FirstOrDefault().ToString() + Environment.NewLine;

                BestWorstStudent += "Worst Student " + StudentMarks.OrderBy(s => s.totalmarks).Select(s => s.Name).FirstOrDefault().ToString();

            }
        }


        public void NoMarks()
        {
            using (var context = new collegestudentsEntities())
            {
                //    var allStudentLambda = context.Marks.Select(s => s.StudIDFK).ToList();
                //      var NoMatch = context.Student_Details.Select(s => s.Name).Where(s => allStudentLambda.Contains(s.StudID)).ToList();

                //var alldata = from s in context.Marks
                //              where s.Marks1 < 0

                //              select new
                //              {
                //                  s.Student_Details.Name
                //              };


                //into output  s.StudIDFK != s.Student_Details.StudID

                //  from o in output.DefaultIfEmpty()
                //to add the default to the right hand side


                //o.Student_Details.Name,
                //o.Student_Details.StudID,

                var alldata = from s in context.Student_Details
                              join m in context.Marks.DefaultIfEmpty()
                              //    where m.StudIDFK == null
                              //       join m in context.Marks 
                              //this assumes there IS a student IDFK
                              on s.StudID equals m.StudIDFK into output
                              //  where s.Marks.Any()
                              from o in output.DefaultIfEmpty() //to add the default to the right hand side
                              select new
                              {
                                  o.Student_Details.Name,
                                  o.Student_Details.StudID,
                                  o.Marks1,
                                  o.marks2,
                                  o.Marks3,
                                  o.Marks4

                              };




                // foreach (var person in alldata)
                //{

                //          listBox1.Items.Add(person);


                //}

                //    dataGridView1.DataSource = alldata.ToList();

                //    dataGridView1.DataSource = NoMatch.ToList();   //alldata.ToList();
            }

        }

        public void StudentsAndMarks3()
        {
            //using the ANY()
            using (var context = new collegestudentsEntities())
            {

                var alldata = from s in context.Student_Details
                              where s.Marks.Any()

                              select new
                              {
                                  s.Name,
                                  s.StudID,
                              };
                // dataGridView1.DataSource = alldata.ToList();
                //context.SaveChanges();

                //foreach (var item in alldata)
                //{
                //    listBox1.Items.Add(item.Name + " " + item.markOne);
                //}
            }
        }



    }
}
