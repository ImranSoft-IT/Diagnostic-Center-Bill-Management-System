#pragma checksum "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\TestRequest\BillPayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e133d19b94fb01c7c9cdea3194fe993f052ac2ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestRequest_BillPayment), @"mvc.1.0.view", @"/Views/TestRequest/BillPayment.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\_ViewImports.cshtml"
using Diagnostic_Center_Bill_Management_System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\_ViewImports.cshtml"
using Diagnostic_Center_Bill_Management_System.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e133d19b94fb01c7c9cdea3194fe993f052ac2ef", @"/Views/TestRequest/BillPayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16216cb57cd2c8014bb8f80fd5df3648591500e8", @"/Views/_ViewImports.cshtml")]
    public class Views_TestRequest_BillPayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Diagnostic_Center_Bill_Management_System.ViewModel.BillPayment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BillPayment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\TestRequest\BillPayment.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <div class=""card-header  d-flex flex-row align-items-center justify-content-between"">
        <h5 class=""m-0 font-weight-bold text-primary"">Search Bill</h5>
    </div>

    <div class=""card-body p-3 m-0"" style=""padding-bottom:0px;"">
        <div class=""container"">
            <div class=""row"">

                <div class=""col-6"">
                    <div class=""form-group row"">
                        <label for=""TestType_Name"" class=""col-sm-4 col-form-label"">Bill No:</label>
                        <div class=""col-sm-8"">
                            <input type=""text"" class=""form-control"" id=""Bill_Number"" name=""Bill_Number"" />
                        </div>
                    </div>
                    <h5 class=""align-content-center"">OR</h5>
                    <div class=""form-group row"">
                        <label for=""Slno"" class=""col-sm-4 col-form-label"">Mobile No:</label>
                        <div class=""col-sm-8"">
                            <input t");
            WriteLiteral(@"ype=""text"" class=""form-control"" id=""MobileNo"" name=""MobileNo"" />
                        </div>
                    </div>
                </div>
            </div>

            <div class=""row"">

                <div class=""col-md-5""></div>
                <div class=""col-md-2"">
                    <button type=""button"" onclick=""GetPatientBill()"" id=""SearchBtn"" class=""btn btn-success btn-sm"" style=""float:left; margin-top:5px;"">Search</button>
                </div>
                <div class=""col-md-5""></div>
            </div>

        </div>
    </div>
</div>
<div class=""card"">
    <div class=""card-header  d-flex flex-row align-items-center justify-content-between"">
        <h5 class=""m-0 font-weight-bold text-primary"">Payment</h5>
    </div>

    <div class=""card-body p-3 m-0"" style=""padding-bottom:0px;"">
        <div class=""container"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e133d19b94fb01c7c9cdea3194fe993f052ac2ef7092", async() => {
                WriteLiteral("\r\n\r\n                <div class=\"row\">\r\n                    <input type=\"hidden\" id=\"Id\" name=\"Id\"");
                BeginWriteAttribute("value", " value=\"", 2193, "\"", 2201, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
                    <div class=""col-6"">
                        <div class=""form-group row"">
                            <label for=""TestType_Name"" class=""col-sm-4 col-form-label"">Patient Name:</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control"" id=""PatientName"" name=""PatientName"" readonly />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""TestType_Name"" class=""col-sm-4 col-form-label"">Amount:</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control"" id=""PayAmount"" name=""PayAmount"" readonly/>
                            </div>
                        </div>

                        <div class=""form-group row"">
                            <label for=""Slno"" class=""col-sm-4 col-form-label"">Due Date:</label>
                          ");
                WriteLiteral("  <div class=\"col-sm-8\">\r\n                                <input type=\"text\" class=\"form-control\" id=\"DueDate\" name=\"DueDate\"");
                BeginWriteAttribute("value", " value=\"", 3351, "\"", 3396, 1);
#nullable restore
#line 72 "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\TestRequest\BillPayment.cshtml"
WriteAttributeValue("", 3359, DateTime.Now.ToString("dd-MMM-yyyy"), 3359, 37, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" readonly />
                            </div>
                        </div>
                    </div>
                </div>

                <div class=""row"">
                    <div class=""col-md-5""></div>
                    <div class=""col-md-2"">
                        <button type=""submit"" id=""submit"" class=""btn btn-success btn-lg"" style=""float:left; margin-top:5px;"">Pay</button>
                    </div>
                    <div class=""col-md-5""></div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e133d19b94fb01c7c9cdea3194fe993f052ac2ef11397", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>

    $(function () {
        $(""#DueDate"").datepicker({
            dateFormat: ""d MM yy"",
            showAnim: ""scale"",
            changeMonth: true,
            changeYear: true,
            yearRange: ""1900:2100""
        });
    });

    function GetPatientBill() {

        var billNo = $('#Bill_Number').val();
        var mblNo = $('#MobileNo').val();

        $.ajax({
            async: true,
            data: { BillNo: billNo, MblNo: mblNo },
            dataType: 'json',
            //contentType: ""application/json; charset=utf-8"",
            url: ""/TestRequest/PatientBill"",
            type: 'POST',
            beforeSend: function () {
            },
            success: function (result) {
                $(""#PayAmount"").val(result.reqTestFee);
                $(""#PatientName"").val(result.patientName);
                $(""#Id"").val(result.id);
            },
            error: function (xhr, status) {
                window.alert(status)
            },
");
            WriteLiteral("            done: function () {\r\n\r\n            }\r\n        })\r\n    }\r\n\r\n\r\n\r\n\r\n\r\n\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Diagnostic_Center_Bill_Management_System.ViewModel.BillPayment> Html { get; private set; }
    }
}
#pragma warning restore 1591
