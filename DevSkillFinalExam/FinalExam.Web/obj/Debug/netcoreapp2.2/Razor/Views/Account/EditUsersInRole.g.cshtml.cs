#pragma checksum "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4d896e87cbbe3b468629fe78a4d7999c5cb8990"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_EditUsersInRole), @"mvc.1.0.view", @"/Views/Account/EditUsersInRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/EditUsersInRole.cshtml", typeof(AspNetCore.Views_Account_EditUsersInRole))]
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
#line 1 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\_ViewImports.cshtml"
using FinalExam.Web;

#line default
#line hidden
#line 2 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\_ViewImports.cshtml"
using FinalExam.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d896e87cbbe3b468629fe78a4d7999c5cb8990", @"/Views/Account/EditUsersInRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a63ec1f20e7a48382a6bf6263c57ef3d4765e344", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_EditUsersInRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<FinalExam.Web.ViewModels.UserRoleViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
  
    ViewData["Title"] = "EditUsersInRole";
    Layout = "~/Views/Shared/_CustomLayout.cshtml";

#line default
#line hidden
            BeginContext(161, 276, true);
            WriteLiteral(@"
<div id=""content-wrapper"">

    <div class=""container-fluid"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item"">
                <a href=""#"">Role</a>
            </li>
            <li class=""breadcrumb-item active"">Overview</li>
        </ol>
");
            EndContext();
#line 16 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
         if (Model.Any())
        {

#line default
#line hidden
            BeginContext(475, 184, true);
            WriteLiteral("            <div class=\"card mb-3\">\r\n                <div class=\"card-header\">\r\n                    <i class=\"fas fa-table\"></i>\r\n                    Adding/Removing User To The Role: ");
            EndContext();
            BeginContext(660, 16, false);
#line 21 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
                                                 Write(ViewBag.RoleName);

#line default
#line hidden
            EndContext();
            BeginContext(676, 42, true);
            WriteLiteral("\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(718, 1192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d896e87cbbe3b468629fe78a4d7999c5cb89906387", async() => {
                BeginContext(738, 47, true);
                WriteLiteral("\r\n                    <div class=\"card-body\">\r\n");
                EndContext();
#line 25 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
                         for (int i = 0; i < Model.Count; i++)
                        {

#line default
#line hidden
                BeginContext(876, 90, true);
                WriteLiteral("                            <div class=\"form-check m-1\">\r\n                                ");
                EndContext();
                BeginContext(966, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d896e87cbbe3b468629fe78a4d7999c5cb89907241", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 28 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].UserId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1016, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1050, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d896e87cbbe3b468629fe78a4d7999c5cb89909097", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 29 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].UserName);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1102, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1136, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4d896e87cbbe3b468629fe78a4d7999c5cb899010955", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 30 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].IsSelected);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1201, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(1235, 161, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d896e87cbbe3b468629fe78a4d7999c5cb899012688", async() => {
                    BeginContext(1298, 38, true);
                    WriteLiteral("\r\n                                    ");
                    EndContext();
                    BeginContext(1337, 17, false);
#line 32 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
                               Write(Model[i].UserName);

#line default
#line hidden
                    EndContext();
                    BeginContext(1354, 34, true);
                    WriteLiteral("\r\n                                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#line 31 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model[i].IsSelected);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1396, 38, true);
                WriteLiteral("\r\n                            </div>\r\n");
                EndContext();
#line 35 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
                        }

#line default
#line hidden
                BeginContext(1461, 198, true);
                WriteLiteral("                        <div class=\"card-footer\">\r\n                            <input type=\"submit\" value=\"Update\" class=\"btn btn-primary\"\r\n                                   style=\"width:auto\" />\r\n");
                EndContext();
                BeginContext(1827, 76, true);
                WriteLiteral("                        </div>\r\n                    </div>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1910, 117, true);
            WriteLiteral("\r\n                <div class=\"card-footer small text-muted\">Updated yesterday at 11:59 PM</div>\r\n            </div>\r\n");
            EndContext();
#line 46 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"
        }
        else
        {


#line default
#line hidden
            BeginContext(2065, 410, true);
            WriteLiteral(@"            <div class=""card mb-3"">
                <div class=""card-header"">
                    <i class=""fas fa-table""></i>
                    User List
                </div>
                <div class=""card-body"">
                    <h2>No User Found!</h2>
                </div>
                <div class=""card-footer small text-muted"">Updated yesterday at 11:59 PM</div>
            </div>
");
            EndContext();
#line 60 "E:\New folder\DevSkillFinalExam\FinalExam.Web\Views\Account\EditUsersInRole.cshtml"

        }

#line default
#line hidden
            BeginContext(2488, 273, true);
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

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<FinalExam.Web.ViewModels.UserRoleViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
