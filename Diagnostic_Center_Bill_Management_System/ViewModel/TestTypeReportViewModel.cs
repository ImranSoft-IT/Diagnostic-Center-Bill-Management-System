using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.ViewModel
{
    public class TestTypeReportViewModel
    {
        //[Key]
        public int TestTypeSetupId { set; get; }
        public string TestType_Name { set; get; }
        public int totalTestType { set; get; }
        public decimal TotalTypeAmount { set; get; }
    }
}
