#pragma checksum "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7190e6cf93013ec076ac3d838181b480c678fe2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StudentList), @"mvc.1.0.view", @"/Views/Home/StudentList.cshtml")]
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
#line 1 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\_ViewImports.cshtml"
using Assignment2_SheheryarIzhar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\_ViewImports.cshtml"
using Assignment2_SheheryarIzhar.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7190e6cf93013ec076ac3d838181b480c678fe2d", @"/Views/Home/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"797216a320e9ac6721683342275a94de9697fc3d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Assignment2_SheheryarIzhar.Models.Student>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/AddStudent/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Home/EditStudent/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
  
    ViewData["Title"] = "StudentList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Student Records</h1>\r\n\r\n<p>\r\n");
            WriteLiteral("  <a");
            BeginWriteAttribute("href", " href=\"", 198, "\"", 205, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default btn-rounded mb-4\" data-toggle=\"modal\" data-target=\"#modalContactForm\" style=\"font-weight: 600; border: 1px solid black\">Create Student</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1140, "\"", 1147, 0);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1168, "\"", 1229, 7);
            WriteAttributeValue("", 1178, "GetStudentRecord(", 1178, 17, true);
#nullable restore
#line 41 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
WriteAttributeValue("", 1195, item.Id, 1195, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1203, ",\'", 1204, 3, true);
#nullable restore
#line 41 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
WriteAttributeValue("", 1206, item.Name, 1206, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1216, "\',", 1216, 2, true);
#nullable restore
#line 41 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
WriteAttributeValue(" ", 1218, item.Age, 1219, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1228, ")", 1228, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#modalContactForm2\">Edit |</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1294, "\"", 1301, 0);
            EndWriteAttribute();
            WriteLiteral(" data-toggle=\"modal\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1322, "\"", 1381, 7);
            WriteAttributeValue("", 1332, "StudentDetails(", 1332, 15, true);
#nullable restore
#line 42 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
WriteAttributeValue("", 1347, item.Id, 1347, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1355, ",\'", 1356, 3, true);
#nullable restore
#line 42 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
WriteAttributeValue("", 1358, item.Name, 1358, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1368, "\',", 1368, 2, true);
#nullable restore
#line 42 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
WriteAttributeValue(" ", 1370, item.Age, 1371, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1380, ")", 1380, 1, true);
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#modalContactForm3\">Details |</a>\r\n");
            WriteLiteral("                ");
#nullable restore
#line 45 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\Sheheryar Izhar\source\repos\Assignment2_SheheryarIzhar\Assignment2_SheheryarIzhar\Views\Home\StudentList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<div class=""modal fade"" id=""modalContactForm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
  aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header text-center"">
        <h4 class=""modal-title w-100 font-weight-bold"">Create Student</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7190e6cf93013ec076ac3d838181b480c678fe2d11823", async() => {
                WriteLiteral(@"        
        <div class=""modal-body mx-3"">
        
        <div class=""md-form mb-5"">
          <i class=""fas fa-envelope prefix grey-text""></i>
          <input type=""hidden"" name=""Id"">
          <input type=""text"" name=""Name"" id=""textbox1"" class=""form-control validate"">
          <label data-error=""wrong"" data-success=""right"" for=""form29"">Student Name</label>
        </div>

        <div class=""md-form mb-5"">
          <i class=""fas fa-tag prefix grey-text""></i>
          <input type=""number"" name=""Age"" id=""textbox2"" class=""form-control validate"">
          <label data-error=""wrong"" data-success=""right"" for=""form32"">Student Age</label>
        </div>

      </div>
      <div class=""modal-footer d-flex justify-content-center"">
        <button class=""btn btn-unique"">Add Student<i class=""fas fa-paper-plane-o ml-1""></i></button>
      </div>
      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
  </div>
</div>



<div class=""modal fade"" id=""modalContactForm2"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
  aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header text-center"">
        <h4 class=""modal-title w-100 font-weight-bold"">Edit Student</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7190e6cf93013ec076ac3d838181b480c678fe2d14840", async() => {
                WriteLiteral(@"        
        <div class=""modal-body mx-3"">
        
        <div class=""md-form mb-5"">
          <i class=""fas fa-envelope prefix grey-text""></i>
          <input type=""hidden"" name=""Id"" id=""exittextbox0"">
          <input type=""text"" name=""Name"" id=""exittextbox1"" class=""form-control validate"">
          <label data-error=""wrong"" data-success=""right"" for=""form29"">Student Name</label>
        </div>

        <div class=""md-form mb-5"">
          <i class=""fas fa-tag prefix grey-text""></i>
          <input type=""number"" name=""Age"" id=""edittextbox2"" class=""form-control validate"">
          <label data-error=""wrong"" data-success=""right"" for=""form32"">Student Age</label>
        </div>

      </div>
      <div class=""modal-footer d-flex justify-content-center"">
        <button class=""btn btn-unique"">Update Student<i class=""fas fa-paper-plane-o ml-1""></i></button>
      </div>
      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
  </div>
</div>


<div class=""modal fade"" id=""modalContactForm3"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
  aria-hidden=""true"">
  <div class=""modal-dialog"" role=""document"">
    <div class=""modal-content"">
      <div class=""modal-header text-center"">
        <h4 class=""modal-title w-100 font-weight-bold"">Student Details</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
        <div class=""modal-body mx-3"">
        
        <div class=""md-form mb-5"">
          <i class=""fas fa-envelope prefix grey-text""></i>
          <h4 id=""detailsbox0""></h4>
        </div>

        <div class=""md-form mb-5"">
          <i class=""fas fa-tag prefix grey-text""></i>
          <h4 id=""detailsbox1""></h4>
        </div>

        <div class=""md-form mb-5"">
          <i class=""fas fa-tag prefix grey-text""></i>
          <h4 id=""detailsbox2""></h4>
        <");
            WriteLiteral(@"/div>

      </div>
    </div>
  </div>
</div>



<script>

    function GetStudentRecord(id ,name = ""h"", age = 2){
        console.log(""fuck"");
        console.log(name, age, id);
    document.getElementById(""exittextbox0"").value = id;
    document.getElementById(""exittextbox1"").value = name;
    document.getElementById(""edittextbox2"").value = age;

    }

    function StudentDetails(id ,name = ""h"", age = 2){
        console.log(""fuck"");
        console.log(name, age, id);
    document.getElementById(""detailsbox0"").innerHTML = ""Id: ""+ id;
    document.getElementById(""detailsbox1"").innerHTML = ""Name: "" + name;
    document.getElementById(""detailsbox2"").innerHTML = ""Age: "" + age;

    }


</script>







");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Assignment2_SheheryarIzhar.Models.Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591