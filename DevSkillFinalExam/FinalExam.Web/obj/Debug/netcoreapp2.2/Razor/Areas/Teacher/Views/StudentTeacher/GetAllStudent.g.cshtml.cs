#pragma checksum "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "881ed46beea0bafe9ee12be818b113326b261171"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Teacher_Views_StudentTeacher_GetAllStudent), @"mvc.1.0.view", @"/Areas/Teacher/Views/StudentTeacher/GetAllStudent.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Teacher/Views/StudentTeacher/GetAllStudent.cshtml", typeof(AspNetCore.Areas_Teacher_Views_StudentTeacher_GetAllStudent))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"881ed46beea0bafe9ee12be818b113326b261171", @"/Areas/Teacher/Views/StudentTeacher/GetAllStudent.cshtml")]
    public class Areas_Teacher_Views_StudentTeacher_GetAllStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalExam.Data.Entities.Student>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/vendor/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/bootstrap.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
  
    ViewData["Title"] = "GetAllStudent";
    Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
            BeginContext(155, 275, true);
            WriteLiteral(@"
<div id=""content-wrapper"">

    <div class=""container-fluid"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""#"">Student</a>
            </li>
            <li class=""breadcrumb-item active"">List</li>
        </ol>
");
            EndContext();
#line 16 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
         if (Model.Any())
        {

#line default
#line hidden
            BeginContext(468, 943, true);
            WriteLiteral(@"            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fas fa-table""></i>
                    Student List
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-bordered"" id=""studentDataTable"" width=""100%"" cellspacing=""0"">
                            <thead>
                                <tr>
                                    <th>Id</th>
                                    <th>Name</th>
                                    <th>Age</th>
                                    <th>Email</th>
                                    <th>Phone</th>
                                    <th>Address</th>                                    
                                    <th>Action</th>
                                </tr>
                            </thead>
");
            EndContext();
            BeginContext(1697, 37, true);
            WriteLiteral("                            <tbody>\r\n");
            EndContext();
#line 44 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
                                 foreach (var student in Model)
                                {

#line default
#line hidden
            BeginContext(1834, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1913, 10, false);
#line 47 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
                                   Write(student.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1923, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1971, 12, false);
#line 48 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
                                   Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1983, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2031, 11, false);
#line 49 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
                                   Write(student.Age);

#line default
#line hidden
            EndContext();
            BeginContext(2042, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2090, 13, false);
#line 50 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
                                   Write(student.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2103, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2151, 19, false);
#line 51 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
                                   Write(student.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2170, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(2218, 15, false);
#line 52 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
                                   Write(student.Address);

#line default
#line hidden
            EndContext();
            BeginContext(2233, 141, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n                                        <a asp-controller=\"Student\" asp-action=\"EditStudent\"");
            EndContext();
            BeginWriteAttribute("asp-route-studentId", "\r\n                                           asp-route-studentId=\"", 2374, "\"", 2451, 1);
#line 55 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
WriteAttributeValue("", 2440, student.Id, 2440, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2452, 365, true);
            WriteLiteral(@" class=""btn btn-primary"">
                                            Edit
                                        </a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                        <input type=""button"" id=""btnDelete"" class=""btn btn-danger"" value=""Delete"">

                                    </td>
                                </tr>
");
            EndContext();
#line 62 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"

                                }

#line default
#line hidden
            BeginContext(2854, 241, true);
            WriteLiteral("\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card-footer small text-muted\">Updated yesterday at 11:59 PM</div>\r\n            </div>\r\n");
            EndContext();
#line 71 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"
        }
        else
        {


#line default
#line hidden
            BeginContext(3133, 416, true);
            WriteLiteral(@"            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fas fa-table""></i>
                    Student List
                </div>
                <div class=""card-body"">
                    <h2>No Student Found!</h2>
                </div>
                <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
            </div>
");
            EndContext();
#line 85 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Areas\Teacher\Views\StudentTeacher\GetAllStudent.cshtml"

        }

#line default
#line hidden
            BeginContext(3562, 1326, true);
            WriteLiteral(@"
    </div>
    <footer class=""sticky-footer"">
        <div class=""container my-auto"">
            <div class=""copyright text-center my-auto"">
                <span>Copyright © Your Website 2019</span>
            </div>
        </div>
    </footer>


</div>
<div class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <form action=""/Student/DeleteStudent"" method=""post"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Delete Item</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    <p>Do you want to delete this record?</p>

                    <input type=""hidden"" id=""modalId"" name=""id"" value="""" />

                </div>
                <di");
            WriteLiteral(@"v class=""modal-footer"">
                    <button type=""submit"" class=""btn btn-danger"">Yes, Delete!</button>
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancel</button>
                </div>
            </form>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(4888, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "881ed46beea0bafe9ee12be818b113326b26117112505", async() => {
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
            BeginContext(4937, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(4939, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "881ed46beea0bafe9ee12be818b113326b26117113685", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4984, 601, true);
            WriteLiteral(@"
<script>
    $(function () {
        $(""#studentDataTable"").DataTable();
    });

    $('#studentDataTable tbody').on('click', '#btnDelete', function () {
        debugger;
        var currentRow = $(this).closest(""tr"");
        var studentId = currentRow.find('td:eq(0)').text();
        //alert(studentId);
        var data = $('#studentDataTable').DataTable().row(currentRow).data();
        console.log(data);

        DeleteStudent(studentId);

    });

    function DeleteStudent(id) {
        debugger;
        $(""#modalId"").val(id);
        $("".modal"").show();
    }

");
            EndContext();
            BeginContext(6057, 11, true);
            WriteLiteral("\r\n</script>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalExam.Data.Entities.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
