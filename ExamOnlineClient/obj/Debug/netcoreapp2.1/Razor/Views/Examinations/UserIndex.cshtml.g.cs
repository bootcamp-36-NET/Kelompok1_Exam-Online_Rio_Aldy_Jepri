#pragma checksum "C:\Users\aldi\Desktop\Github BC36 Finale Finale\Kelompok1_Exam-Online_Rio_Aldy_Jepri\ExamOnlineClient\Views\Examinations\UserIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a310b4ebdd2fa0eec7a5970aaf6ee1b218ef9e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Examinations_UserIndex), @"mvc.1.0.view", @"/Views/Examinations/UserIndex.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Examinations/UserIndex.cshtml", typeof(AspNetCore.Views_Examinations_UserIndex))]
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
#line 1 "C:\Users\aldi\Desktop\Github BC36 Finale Finale\Kelompok1_Exam-Online_Rio_Aldy_Jepri\ExamOnlineClient\Views\_ViewImports.cshtml"
using ExamOnlineClient;

#line default
#line hidden
#line 2 "C:\Users\aldi\Desktop\Github BC36 Finale Finale\Kelompok1_Exam-Online_Rio_Aldy_Jepri\ExamOnlineClient\Views\_ViewImports.cshtml"
using ExamOnlineClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a310b4ebdd2fa0eec7a5970aaf6ee1b218ef9e8", @"/Views/Examinations/UserIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4278384e0eb77a721edc8fa7b67c71ee04e00835", @"/Views/_ViewImports.cshtml")]
    public class Views_Examinations_UserIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Script/UserIndex.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\aldi\Desktop\Github BC36 Finale Finale\Kelompok1_Exam-Online_Rio_Aldy_Jepri\ExamOnlineClient\Views\Examinations\UserIndex.cshtml"
  
    ViewData["Title"] = "UserIndex";
    Layout = "~/Views/Layout/_Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 434, true);
            WriteLiteral(@"


<div class=""content-wrapper"">
    <!-- START PAGE CONTENT-->
    <!-- Modal -->
    <div class=""page-heading"">
        <h1 class=""page-title"">Manage Job List</h1>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""/""><i class=""la la-home font-20""></i></a>
            </li>
        </ol>
    </div>
    <div class=""page-content fade-in-up"">
        <div class=""ibox"">
");
            EndContext();
            BeginContext(651, 2193, true);
            WriteLiteral(@"            <div class=""ibox-body"">
                <div class=""col-lg-6"">
                    <div class=""form-group"">
                        <input name=""Id"" class=""form-control"" type=""hidden""
                               placeholder="""" id=""Id"" />
                    </div>
                    <div class=""form-group"">
                        <label class=""form-control-label"" for=""EmployeeId"">Employee ID : </label>
                        <a id=""EmployeeId""></a>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""form-group"">
                        <label class=""form-control-label"" for=""Subject"">Subject : </label>
                        <a id=""Subject""></a>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""form-group"">
                        <label class=""form-control-label"" for=""Schedule"">Schedule : </label>
                        <a id=""Creat");
            WriteLiteral(@"edDate""></a>
                    </div>
                </div>
                <hr>

                <div data-toggle=""modal"" data-target=""#exampleModal"" onclick=""ClearScreen();"">
                    &nbsp;&nbsp;&nbsp;
                    <button data-toggle=""tooltip"" data-placement=""right"" data-animation=""false"" title=""Add"">
                        <i class=""fa fa-clock-o""></i>
                    </button> <a> Reschedule
                </div>
            </div>
        </div>
    </div>
    <!-- END PAGE CONTENT-->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Division</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hi");
            WriteLiteral("dden=\"true\">&times;</span>\r\n                    </button>\r\n                </div>\r\n                <div class=\"modal-body\">\r\n                    ");
            EndContext();
            BeginContext(2844, 296, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e85fd8de58c456fab92ac0eb9b70a03", async() => {
                BeginContext(2850, 283, true);
                WriteLiteral(@"
                        <div class=""form-group form-group-default"">
                            <label for=""schedule"">Start date:</label>
                            <input type=""datetime-local"" id=""Schedule"" name=""schedule"">
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3140, 410, true);
            WriteLiteral(@"
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" id=""Update"" onclick=""Update();"" data-dismiss=""modal"" class=""btn btn-success button button4"">Edit</button>
                    <button type=""button"" data-dismiss=""modal"" class=""btn btn-warning button button4"">Cancel</button>
                </div>
            </div>
        </div>
    </div>
");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3571, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(3581, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db88ecdb4409468cb1183496c4cd14bb", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3629, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
