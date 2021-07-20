using Diagnostic_Center_Bill_Management_System.Models;
using Diagnostic_Center_Bill_Management_System.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Interfaces
{
    public interface ITestRequest
    {
        Task<long> SaveTestRequest(TestRequest testRequest);
        TestRequest GetAmountAndPay(string BillNo, long? MobileNo);
        Task<bool> UpdatePaymentBill(long Id, float? Amount, DateTime? DueDate);
        Task<IEnumerable<TestRequest>> GetUnpaidBillReport(DateTime? FromDate, DateTime? ToDate);
        float? GetTestFee(long testId);
        List<TestReportViewModel> GetTestReportList(DateTime? FromDate, DateTime? ToDate);
        List<TestTypeReportViewModel> GetTestTypeReportList(DateTime? FromDate, DateTime? ToDate);
    }
}
