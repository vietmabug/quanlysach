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

    public partial class BookReturnTable
    {
        public int BookReturnID { get; set; }
        [Required(ErrorMessage = "Please select book")]
        public int BookID { get; set; }
        [Required(ErrorMessage = "Please select employee")]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage = "Please select issue date")]
        [DataType(DataType.Date)]
        public System.DateTime IssueDate { get; set; }
        [Required(ErrorMessage = "Please select issue date")]
        [DataType(DataType.Date)]
        public System.DateTime ReturnDate { get; set; }
        [Required(ErrorMessage = "Please select return date")]
        [DataType(DataType.Date)]
        public System.DateTime CurrentDate { get; set; }
        public int UserID { get; set; }
    
        public virtual BookTable BookTable { get; set; }
        public virtual EmployeeTable EmployeeTable { get; set; }
        public virtual UserTable UserTable { get; set; }
    }
}
