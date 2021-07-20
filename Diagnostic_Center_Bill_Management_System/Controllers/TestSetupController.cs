using Diagnostic_Center_Bill_Management_System.Interfaces;
using Diagnostic_Center_Bill_Management_System.Models;
using Diagnostic_Center_Bill_Management_System.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diagnostic_Center_Bill_Management_System.Controllers
{
    public class TestSetupController : Controller
    {
        private readonly ITestTypeSetup testTypeService;
        private readonly ITestSetup testService;

        public TestSetupController(ITestTypeSetup _testTypeService, ITestSetup _testService)
        {
            testService = _testService;
            testTypeService = _testTypeService;
        }
        public async Task<IActionResult> TestSetup()
        {
            var model = new TestSetupViewModel
            {
                testTypes = await testTypeService.GetTestType(),
                testSetups = await testService.GetTestSetup(),
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> TestSetup([FromForm] TestSetupViewModel model)
        {
            bool flag = false;
            try
            {

                string temp = await testService.IsThisNamePresent(model.TestName);
                if (temp.ToLower() == model.TestName.ToLower())
                {
                    ModelState.AddModelError("TestType", "This Test Type Already Taken. Please Try Another Test Type.");
                    flag = true;
                }

            }
            catch (Exception ex)
            {

            }

            if (flag == false)
            {
                var data = new TestSetup
                {
                    Id = model.Id,
                    TestName = model.TestName,
                    TestFee = model.TestFee,
                    TestTypeSetupId = model.TestTypeSetupId

                };
                await testService.SaveTestSetup(data);
            }
            return RedirectToAction(nameof(TestSetup));
        }

        
    }
}
