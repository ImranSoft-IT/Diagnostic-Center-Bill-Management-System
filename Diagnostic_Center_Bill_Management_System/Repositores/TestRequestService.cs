using Diagnostic_Center_Bill_Management_System.Data;
using Diagnostic_Center_Bill_Management_System.Interfaces;
using Diagnostic_Center_Bill_Management_System.Models;
using Diagnostic_Center_Bill_Management_System.ViewModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Repositores
{
    public class TestRequestService : ITestRequest
    {
        private readonly AppDbContext _context;
        public IConfiguration configuration { get; }

        private string con;
        public TestRequestService(AppDbContext context, IConfiguration config)
        {
            _context = context;
            configuration = config;
            con = configuration.GetConnectionString("DefaultConnection").ToString();
        }

        public TestRequest GetAmountAndPay(string BillNo, long? MobileNo)
        {
            TestRequest testRequests = null;
            if (BillNo != null)
            {
                 testRequests = _context.TestRequests.Where(r => r.Bill_Number == BillNo).FirstOrDefault();
            }
            else
            {
                 testRequests = _context.TestRequests.Where(r => r.MobileNo == MobileNo).FirstOrDefault();
            }
            
            return testRequests;
        }


        public async Task<long> SaveTestRequest(TestRequest testRequest)
        {
            try
            {
                if (testRequest.Id != 0)
                {
                    _context.TestRequests.Update(testRequest);
                }
                else
                {
                    _context.TestRequests.Add(testRequest);
                }
                await _context.SaveChangesAsync();
                return testRequest.Id;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<IEnumerable<TestRequest>> GetUnpaidBillReport(DateTime? FromDate, DateTime? ToDate)
        {
            IEnumerable<TestRequest> testRequests = await _context.TestRequests.Where(r => r.EntryDate >= FromDate && r.EntryDate <= ToDate &&
            (r.ReqTestFee - r.PayAmount) > 0).ToListAsync();
            return testRequests;
        }
        public async Task<bool> UpdatePaymentBill(long Id, float? Amount, DateTime? DueDate)
        {
            TestRequest testRequest = await _context.TestRequests.FindAsync(Id);
            if (testRequest != null)
            {
                testRequest.PayAmount = Amount;
                testRequest.DueDate = DueDate;
                return 1 == await _context.SaveChangesAsync();
            }
            else
            {
                return 1 == 0;
            }
        }

        public float? GetTestFee(long testId)
        {
            float? TestFee =  _context.TestSetups.Where(s => s.Id == testId).Select(s => s.TestFee).FirstOrDefault();
            return TestFee;
        }

        public  List<TestReportViewModel> GetTestReportList(DateTime? FromDate, DateTime? ToDate)
        {
            List<TestReportViewModel> testReports = new List<TestReportViewModel>();

            SqlConnection connection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("Proc_TestWiseReport", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@FormDate", FromDate));
            command.Parameters.Add(new SqlParameter("@Todate", ToDate));

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TestReportViewModel testVM = new TestReportViewModel();

                testVM.TestSetupId = reader["TestSetupId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TestSetupId"]);
                testVM.TestName = reader["TestName"].ToString(); 
                testVM.TotalTest = reader["TotalTest"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TotalTest"]);
                testVM.TotalAmount = reader["TotalAmount"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["TotalAmount"]);

                testReports.Add(testVM);
            }
             return testReports;
        }

        public List<TestTypeReportViewModel> GetTestTypeReportList(DateTime? FromDate, DateTime? ToDate)
        {
            List<TestTypeReportViewModel> testTypeReports = new List<TestTypeReportViewModel>();

            SqlConnection connection = new SqlConnection(con);
            SqlCommand command = new SqlCommand("Proc_TestTypeWiseReport", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add(new SqlParameter("@FormDate", FromDate));
            command.Parameters.Add(new SqlParameter("@Todate", ToDate));

            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                TestTypeReportViewModel testTypeVM = new TestTypeReportViewModel();

                testTypeVM.TestTypeSetupId = reader["TestTypeSetupId"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TestTypeSetupId"]);
                testTypeVM.TestType_Name = reader["TestType_Name"].ToString();
                testTypeVM.totalTestType = reader["totalTestType"] == DBNull.Value ? 0 : Convert.ToInt32(reader["totalTestType"]);
                testTypeVM.TotalTypeAmount = reader["TotalTypeAmount"] == DBNull.Value ? 0 : Convert.ToDecimal(reader["TotalTypeAmount"]);

                testTypeReports.Add(testTypeVM);
            }
            return testTypeReports;
        }
    }
}
