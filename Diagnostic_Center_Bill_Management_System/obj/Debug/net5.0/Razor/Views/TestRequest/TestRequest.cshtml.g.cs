#pragma checksum "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\TestRequest\TestRequest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "25174aaa72c87be21ba276852bb1f85a17b0c07c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TestRequest_TestRequest), @"mvc.1.0.view", @"/Views/TestRequest/TestRequest.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"25174aaa72c87be21ba276852bb1f85a17b0c07c", @"/Views/TestRequest/TestRequest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16216cb57cd2c8014bb8f80fd5df3648591500e8", @"/Views/_ViewImports.cshtml")]
    public class Views_TestRequest_TestRequest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Diagnostic_Center_Bill_Management_System.ViewModel.TestRequestViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TestRequest", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("FormId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\TestRequest\TestRequest.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25174aaa72c87be21ba276852bb1f85a17b0c07c4992", async() => {
                WriteLiteral(@"
    <div class=""card"">
        <div class=""card-header  d-flex flex-row align-items-center justify-content-between"">
            <h5 class=""m-0 font-weight-bold text-primary"">Test Request Entry</h5>
        </div>

        <div class=""card-body p-3 m-0"" style=""padding-bottom:0px;"">
            <div class=""container"">


                <div class=""row"">
");
                WriteLiteral(@"                    <div class=""col-6"">
                        <div class=""form-group row"">
                            <label for=""TestName"" class=""col-sm-4 col-form-label"">Name Of The Patient</label>
                            <div class=""col-sm-8"">
                                <input type=""hidden"" class=""form-control"" id=""Sl"" value=""1""/>
                                <input type=""text"" class=""form-control"" id=""Patient"" />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""TestFee"" class=""col-sm-4 col-form-label"">Date Of Birth</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control"" id=""DateOfBirth"" readonly />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""TestFee"" class=""col-sm-4 col-form-label""");
                WriteLiteral(@">Mobile Number</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control"" id=""MblNo"" />
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""TestTypeSetupId"" class=""col-sm-4 col-form-label"">Test Name</label>
                            <div class=""col-sm-8"">
                                <select class=""form-control"" id=""TestSetupId"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25174aaa72c87be21ba276852bb1f85a17b0c07c7349", async() => {
                    WriteLiteral("Select");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 43 "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\TestRequest\TestRequest.cshtml"
                                     foreach (var data in Model.testSetups)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "25174aaa72c87be21ba276852bb1f85a17b0c07c8936", async() => {
#nullable restore
#line 45 "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\TestRequest\TestRequest.cshtml"
                                                            Write(data.TestName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\TestRequest\TestRequest.cshtml"
                                           WriteLiteral(data.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 46 "E:\Assignment\Diagnostic_Center_Bill_Management_System\Views\TestRequest\TestRequest.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                </select>
                            </div>
                        </div>

                        <div class=""form-group row"">
                            <label for=""TestFee"" class=""col-sm-4 col-form-label"">Test Fee</label>
                            <div class=""col-sm-8"">
                                <input type=""text"" class=""form-control"" id=""TestFee"" readonly />
                            </div>
                        </div>

                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-md-4""></div>
                    <div class=""col-md-2"">
                        <button type=""button"" id=""btnSaveProcess"" onclick=""AddMultipleEducation()"" class=""btn btn-success btn-sm"" style=""width:80px;float:right;"">ADD</button>
                    </div>
                    <div class=""col-md-6""></div>
                    
                </div>
                
            </div>
        </div>
   ");
                WriteLiteral(@" </div>
    <div class=""row clearfix"">
        <div class=""col-12"">
            <div class=""card mb-4"" id=""printDiv"">
                <div class=""card-header py-3 d-flex flex-row align-items-center justify-content-between"">
                    <h6 class=""m-0 font-weight-bold"">Patient Test List</h6>
                </div>
                <div class=""card-body"">
                    <table class=""table table-striped table-bordered"" id=""TestRequestTable"">
                        <caption>Patient Test Request</caption>
                        <thead>
                            <tr>
                                <th>SL</th>
                                <th>Name of the Patient</th>
                                <th>Date Of Birth</th>
                                <th>Mobile No</th>
                                <th>Test Name</th>
                                <th>Test Fee</th>
                                <th>Action</th>

                            </tr>
                       ");
                WriteLiteral(@" </thead>
                        <tbody></tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-3"">
            <a class=""btn btn-info btn-group-sm"" id=""pdfBtn"">PDF</a>
        </div>
        <div class=""col-md-6""></div>
        <div class=""col-md-3"">

            <button type=""submit"" id=""submitBtn"" class=""btn btn-success btn-lg"" style=""float:right; margin-top:5px;"">SAVE</button>
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script >

    $(function () {
        $(""#DateOfBirth"").datepicker({
            dateFormat: ""d MM yy"",
            showAnim: ""scale"",
            changeMonth: true,
            changeYear: true,
            yearRange: ""1900:2100""
        });
    });

    $(""#pdfBtn"").click(function () {
        var element = document.getElementById('printDiv');

        html2pdf().from(element).set({
            margin: [30, 10, 5, 10], // top, left, buttom, right
            pagebreak: { avoid: 'tr' },
            jsPDF: { orientation: 'landscape', unit: 'pt', format: 'letter', compressPDF: true }
        }).save();
    });

    $(function () {
        $(""#TestSetupId"").change(function () {
            var TestSetupId = $('#TestSetupId :selected').val();

            //console.log(TestSetupId);

            $.ajax({
                //async: true,
                data: {TestId: TestSetupId},
       ");
            WriteLiteral(@"         dataType: 'json',
                //contentType: ""application/json; charset=utf-8"",
                url: ""/TestRequest/GetTestFee"",
                type: 'post',
                beforeSend: function () {
                },
                success: function (result) {
                    $(""#TestFee"").val(result);
                },
                error: function (xhr, status) { },
                done: function () {

                }
            })
            
        });
    });

    function AddMultipleEducation() {
        var Patient = $('#Patient').val();
        var TestSetupId = $('#TestSetupId :selected').val();
        var TestSetupId1 = $('#TestSetupId :selected').text();
        var DateOfBirth = $('#DateOfBirth').val();
        var MblNo = $('#MblNo').val();
        var TestFee = $('#TestFee').val();

        var sl = parseInt($('#Sl').val());
        

        var row = `<tr id=""edu_${sl}"">
					<td><input type=""hidden"" value=""0"" name=""Id"">${sl}</td>
   ");
            WriteLiteral(@"                 <td><input type=""hidden"" value=""${Patient}"" name=""PatientName"">${Patient}</td>
					<td><input type=""hidden"" value=""${DateOfBirth}"" name=""DOB"">${DateOfBirth}</td>
					<td><input type=""hidden"" value=""${MblNo}"" name=""MobileNo"">${MblNo}</td>
					<td><input type=""hidden"" value=""${TestSetupId}"" name=""TestSetupId"">${TestSetupId1}</td>
					<td><input type=""hidden"" value=""${TestFee}"" name=""ReqTestFee"">${TestFee}</td>
						
					<td><a href=""javascript:void(0)"" onclick=""RemoveRow(${sl})"">X</a></td>
				</tr>`;

        $('#TestRequestTable tbody').append(row);
        $('#Patient').val('');
        $('#TestSetupId').val(0);
        $('#DateOfBirth').val('');
        $('#MblNo').val('');
        $('#TestFee').val('');
        $('#Sl').val(sl + 1);
       
    }
   
    function RemoveRow(sl) {
        var id = '#edu_' + sl;
        $(id).remove();
    }


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Diagnostic_Center_Bill_Management_System.ViewModel.TestRequestViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591