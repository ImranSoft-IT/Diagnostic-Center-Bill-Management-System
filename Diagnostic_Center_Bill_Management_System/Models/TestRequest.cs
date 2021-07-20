using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Models
{
    public class TestRequest
    {
        [Key]
        public long Id { set; get; }
        //[Index(IsUnique = true)]
        [MaxLength(255)]
        public string Bill_Number { set; get; }
        public string PatientName { set; get; }
        public DateTime? DOB { set; get; }
        public long MobileNo { set; get; }
        
        [ForeignKey("TestSetup")]
        public long? TestSetupId { set; get; }
        public virtual TestSetup TestSetup { set; get; }
        public float? ReqTestFee { set; get; }
        public DateTime? EntryDate { set; get; }
        public DateTime? DueDate { set; get; }
        public float? PayAmount { set; get; }
        public long? Slno { set; get; }
        
    }
}
