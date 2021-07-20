using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.ViewModel
{
    public class BillPayment
    {
        public long Id { set; get; }
        public string Bill_Number { set; get; }
        public string PatientName { set; get; }
        public long? MobileNo { set; get; }
        public DateTime? EntryDate { set; get; }
        public DateTime? DueDate { set; get; }
        public float? ReqTestFee { set; get; }
        public float? PayAmount { set; get; }
        public DateTime? FromDate { set; get; }
        public DateTime? ToDate { set; get; }
    }
}
