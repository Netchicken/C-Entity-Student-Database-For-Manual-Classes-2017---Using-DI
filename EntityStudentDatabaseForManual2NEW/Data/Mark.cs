//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CollegeDB.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mark
    {
        public int MarksID { get; set; }
        public short Marks1 { get; set; }
        public short marks2 { get; set; }
        public short Marks3 { get; set; }
        public short Marks4 { get; set; }
        public int StudIDFK { get; set; }
    
        public virtual Student_Details Student_Details { get; set; }
    }
}
