using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Models
{
    public class TestSetup
    {
        [Key]
        public long Id { set; get; }
        //[Index(IsUnique = true)]
        [MaxLength(255)]
        public string TestName { set; get; }
        public float? TestFee { set; get; }
        public long? Slno { set; get; }
        [ForeignKey("TestTypeSetup")]
        public long? TestTypeSetupId { set; get; }
        public virtual TestTypeSetup TestTypeSetup { set; get; }
        public virtual ICollection<TestRequest> TestRequest { set; get; }
    }
}
