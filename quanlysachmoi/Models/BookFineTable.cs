//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace quanlysachmoi.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class BookFineTable
    {
        public int BookFineID { get; set; }
        [Required(ErrorMessage = "Please select emloyee")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please select book")]
        public int BookID { get; set; }
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please select date")]
        [DataType(DataType.Date)]
        public System.DateTime FineDate { get; set; }
        [Required(ErrorMessage = "Please enter panetly")]
        public double FineAmount { get; set; }
        [Required(ErrorMessage = "Please select emloyee")]
        public Nullable<double> ReceiveAmount { get; set; }
        [Required(ErrorMessage = "Please enter no of days")]
        public int NoOfDays { get; set; }
    
        public virtual BookTable BookTable { get; set; }
        public virtual EmployeeTable EmployeeTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
