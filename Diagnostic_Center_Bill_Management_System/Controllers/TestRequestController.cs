using Diagnostic_Center_Bill_Management_System.Interfaces;
using Diagnostic_Center_Bill_Management_System.Models;
using Diagnostic_Center_Bill_Management_System.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Controllers
{
    public class TestRequestController : Controller
    {
        private readonly ITestTypeSetup testTypeService;
        private readonly ITestSetup testService;
        private readonly ITestRequest testRequest;

        public TestRequestController(ITestTypeSetup _testTypeService, ITestSetup _testService, ITestRequest _testRequest)
        {
            testService = _testService;
            testTypeService = _testTypeService;
            testRequest = _testRequest;
        }
        public async Task<IActionResult> TestRequest()
        {
            var model = new TestRequestViewModel
            {
                testTypes = await testTypeService.GetTestType(),
                testSetups = await testService.GetTestSetup(),
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> TestRequest([FromForm] TestRequestViewModel model)
        {

            if (model.Id != null)
            {
                for (int i = 0; i < model.Id.Length; i++)
                {
                    Random generator = new Random();
                    string ranNo = generator.Next(1, 1000000).ToString();
                    string billNo = "BN-" + ranNo;

                    var TestRequest = new TestRequest
                    {
                        Id = model.Id[i],
                        Bill_Number = billNo,
                        PatientName = model.PatientName[i],
                        DOB = model.DOB[i],
                        MobileNo = model.MobileNo[i],
                        TestSetupId = model.TestSetupId[i],
                        ReqTestFee = model.ReqTestFee[i],
                        EntryDate = DateTime.Now,
                        PayAmount=0

                    };
                    await testRequest.SaveTestRequest(TestRequest);
                }
            }

            return RedirectToAction(nameof(TestRequest));
        }  

        public JsonResult GetTestFee(long TestId)
        {
            float? Fee = testRequest.GetTestFee(TestId);

            return Json(Fee);
        }

        public async Task<IActionResult> BillPayment()
        {
            var model = new BillPayment();
            //{
            //    testTypes = await testTypeService.GetTestType(),
            //    testSetups = await testService.GetTestSetup(),
            //};

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> BillPayment([FromForm] BillPayment model)
        {

            if (model != null)
            {     
                await testRequest.UpdatePaymentBill(model.Id, model.PayAmount,model.DueDate);              
            }

            return RedirectToAction(nameof(BillPayment));
        }


        [HttpPost]
        public JsonResult PatientBill(string BillNo, long? MblNo)
        {

            TestRequest billPayment = testRequest.GetAmountAndPay(BillNo, MblNo);
            
            return Json(billPayment);
        }
        public ActionResult UnpaidBillReport()
        {           
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UnpaidBillList(DateTime FormDate, DateTime ToDate)
        {

            IEnumerable<TestRequest> Unpaidbill = await testRequest.GetUnpaidBillReport(FormDate, ToDate);

            return PartialView("_UnpaidPartialPage", Unpaidbill);
        }

        public ActionResult TestReport()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult TestList(DateTime FormDate, DateTime ToDate)
        {

            List<TestReportViewModel> TestWiseReport =  testRequest.GetTestReportList(FormDate, ToDate);

            return PartialView("_TestReportPartialPage", TestWiseReport);
        }

        public ActionResult TestTypeReport()
        {
            return View();
        }

        [HttpPost]
        public  IActionResult TesTypetList(DateTime FormDate, DateTime ToDate)
        {

            List<TestTypeReportViewModel> testTypeWiseReports =  testRequest.GetTestTypeReportList(FormDate, ToDate);

            return PartialView("_TestTypeReportPartialPage", testTypeWiseReports);
        }

        //public async Task<IEnumerable<EmployeeWithDesignationVM>> GetEmployeeInfoDetailsList(int empId)
        //{
        //    return await _context.employeeWithDesignations.FromSql($"sp_GetEmployeeDetailsList @p0,@p1", empId, string.Empty).ToListAsync();
        //}

    }
}
