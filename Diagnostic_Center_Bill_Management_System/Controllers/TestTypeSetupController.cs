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
    public class TestTypeSetupController : Controller
    {
        private readonly ITestTypeSetup testTypeService;

        public TestTypeSetupController(ITestTypeSetup _testTypeService)
        {
            testTypeService = _testTypeService;
        }
        public async Task<IActionResult> TestTypeList()
        {
            var model = new TestTypeViewModel
            {
                testTypes = await testTypeService.GetTestType()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> TestTypeList([FromForm] TestTypeViewModel model)
        {
            bool flag = false;
            try {

                string temp = await testTypeService.IsThisNamePresent(model.TestType_Name);
                if (temp.ToLower() == model.TestType_Name.ToLower())
                {
                    ModelState.AddModelError("TestType", "This Test Type Already Taken. Please Try Another Test Type.");
                    flag = true;
                }

            } 
            catch ( Exception ex) 
            {

            }
            

            if(flag == false)
            {
                var data = new TestTypeSetup
                {
                    Id = model.Id,
                    TestType_Name = model.TestType_Name,
                    //Slno = model.Slno
                };
                await testTypeService.SaveTestType(data);
            }
            
            return RedirectToAction(nameof(TestTypeList));
        }

       

        
    }
}
