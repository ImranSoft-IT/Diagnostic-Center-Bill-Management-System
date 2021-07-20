using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Models
{
    public class TestTypeSetup
    {
        [Key]
        public long Id { set; get; }
        //[Index(IsUnique = true)]
        [MaxLength(255)]
        public string TestType_Name { set; get; }
        public long? Slno { set; get; }
        public virtual ICollection<TestSetup> TestSetup { set; get; }
    }
}
