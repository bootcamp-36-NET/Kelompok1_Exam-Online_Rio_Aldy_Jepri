#pragma checksum "C:\Users\aldi\Desktop\resolve BC36 github finale\Kelompok1_Exam-Online_Rio_Aldy_Jepri\ExamOnlineClient\Views\Questions\ManageQuestions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb04f9577742c39f0cfb3eacc217b7d9e36d609e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_ManageQuestions), @"mvc.1.0.view", @"/Views/Questions/ManageQuestions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/ManageQuestions.cshtml", typeof(AspNetCore.Views_Questions_ManageQuestions))]
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
#line 1 "C:\Users\aldi\Desktop\resolve BC36 github finale\Kelompok1_Exam-Online_Rio_Aldy_Jepri\ExamOnlineClient\Views\_ViewImports.cshtml"
using ExamOnlineClient;

#line default
#line hidden
#line 2 "C:\Users\aldi\Desktop\resolve BC36 github finale\Kelompok1_Exam-Online_Rio_Aldy_Jepri\ExamOnlineClient\Views\_ViewImports.cshtml"
using ExamOnlineClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb04f9577742c39f0cfb3eacc217b7d9e36d609e", @"/Views/Questions/ManageQuestions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4278384e0eb77a721edc8fa7b67c71ee04e00835", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_ManageQuestions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Script/Questions.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\aldi\Desktop\resolve BC36 github finale\Kelompok1_Exam-Online_Rio_Aldy_Jepri\ExamOnlineClient\Views\Questions\ManageQuestions.cshtml"
  
    ViewData["Title"] = "ManageQuestions";
    Layout = "~/Views/Layout/_Layout.cshtml";

#line default
#line hidden
            BeginContext(100, 694, true);
            WriteLiteral(@"
<div class=""content-wrapper"">
    <!-- START PAGE CONTENT-->
    <!-- Modal -->
    <div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header no-bd"">
                    <h5 class=""modal-title""><span class=""fw-mediumbold"">Job List</span></h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>

                <div class=""modal-body"">
                    ");
            EndContext();
            BeginContext(794, 3354, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0cc73601dfd421f82aaa8970c2ab7e6", async() => {
                BeginContext(800, 3341, true);
                WriteLiteral(@"
                        <div class=""row"">
                            <input type=""text"" id=""Id"" name=""Id"" class=""form-control"" hidden>
                            <div class=""col-sm-12"">
                                <div class=""form-group form-group-default"">
                                    <label>Subject</label>
                                    <select class=""form-control"" id=""SubOption"" name=""SubOption""></select>
                                </div>
                            </div>
                            <div class=""col-sm-12"">
                                <div class=""form-group form-group-default"">
                                    <label>Question</label>
                                    <input type=""text"" id=""QuestionDetail"" name=""QuestionDetail"" class=""form-control"" placeholder=""Question Detail"">
                                </div>
                            </div>
                            <div class=""col-sm-12"">
                                <div cla");
                WriteLiteral(@"ss=""form-group form-group-default"">
                                    <label>Option A</label>
                                    <input type=""text"" id=""OptionA"" name=""OptionA"" class=""form-control"" placeholder=""Option A"">
                                </div>
                            </div>
                            <div class=""col-sm-12"">
                                <div class=""form-group form-group-default"">
                                    <label>Option B</label>
                                    <input type=""text"" id=""OptionB"" name=""OptionB"" class=""form-control"" placeholder=""Option B"">
                                </div>
                            </div>
                            <div class=""col-sm-12"">
                                <div class=""form-group form-group-default"">
                                    <label>Option C</label>
                                    <input type=""text"" id=""OptionC"" name=""OptionC"" class=""form-control"" placeholder=""Option C"">
     ");
                WriteLiteral(@"                           </div>
                            </div>
                            <div class=""col-sm-12"">
                                <div class=""form-group form-group-default"">
                                    <label>Option D</label>
                                    <input type=""text"" id=""OptionD"" name=""OptionD"" class=""form-control"" placeholder=""Option D"">
                                </div>
                            </div>
                            <div class=""col-sm-12"">
                                <div class=""form-group form-group-default"">
                                    <label>Option E</label>
                                    <input type=""text"" id=""OptionE"" name=""OptionE"" class=""form-control"" placeholder=""Option E"">
                                </div>
                            </div>
                            <div class=""col-sm-12"">
                                <div class=""form-group form-group-default"">
                               ");
                WriteLiteral(@"     <label>Key</label>
                                    <input type=""text"" id=""Key"" name=""Key"" class=""form-control"" placeholder=""Key"">
                                </div>
                            </div>
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
            BeginContext(4148, 1202, true);
            WriteLiteral(@"
                </div>
                <div class=""modal-footer no-bd"">
                    <button type=""button"" id=""add"" class=""btn btn-outline-success"" data-dismiss=""modal"" onclick=""Save();"">Insert</button>
                    <button type=""button"" id=""update"" class=""btn btn-outline-warning"" data-dismiss=""modal"" onclick=""Update();"">Update</button>
                    <button type=""button"" class=""btn btn-outline-danger"" data-dismiss=""modal"">Close</button>
                </div>
            </div>
        </div>
    </div>


    <div class=""page-heading"">
        <h1 class=""page-title"">Manage Questions</h1>
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""/""><i class=""la la-home font-20""></i></a>
            </li>
        </ol>
        <div data-toggle=""modal"" data-target=""#myModal"" onclick=""ClearScreen();"">
            <button class=""btn btn-outline-success btn-circle"" data-toggle=""tooltip"" data-placement=""right"" data-animation=""false"" ti");
            WriteLiteral("tle=\"Add\">\r\n                <i class=\"fa fa-plus\"></i>\r\n            </button>\r\n        </div>\r\n    </div>\r\n    <div class=\"page-content fade-in-up\">\r\n        <div class=\"ibox\">\r\n");
            EndContext();
            BeginContext(5473, 860, true);
            WriteLiteral(@"            <div class=""ibox-body"">

                <table class=""table table-striped table-bordered table-hover"" id=""ManageQuestions"" cellspacing=""0"" width=""100%"">
                    <thead>
                        <tr>
                            <th>No</th>
                            <th>Questions</th>
                            <th>Subject</th>
                            <th>Option A</th>
                            <th>Option B</th>
                            <th>Option C</th>
                            <th>Option D</th>
                            <th>Option E</th>
                            <th>Key</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                </table>
            </div>
        </div>
    </div>
    <!-- END PAGE CONTENT-->
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6350, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(6356, 48, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e7ddc2e593646b7aaa65d7a16a91c88", async() => {
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
                BeginContext(6404, 2, true);
                WriteLiteral("\r\n");
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
