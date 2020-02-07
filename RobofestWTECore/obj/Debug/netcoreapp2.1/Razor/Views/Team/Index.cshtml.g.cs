#pragma checksum "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a31ecffd7ad981aa3aceb199dae7e6300d6f76f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/Index.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_Index))]
namespace RobofestWTECore.Pages.Team
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/_ViewImports.cshtml"
using RobofestWTECore;

#line default
#line hidden
#line 3 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/_ViewImports.cshtml"
using RobofestWTECore.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a31ecffd7ad981aa3aceb199dae7e6300d6f76f", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0c74960f6b96bae451f4a9058021941d4cf852", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IOrderedEnumerable<RobofestWTE.Models.TeamDataModel>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(95, 2195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3eeb95ac189542cdbb3ad7c3635e904d", async() => {
                BeginContext(101, 858, true);
                WriteLiteral(@"
    <h2>Team Management</h2>

    <table class=""table table-hover"">
        <tr style=""font-size:20px"">
            <th style=""background-color:#ffffff"">
                Team #
            </th>
            <th style=""background-color:#ffffff"">
                Team Name
            </th>
            <th style=""background-color:#ffd1ba"">
                R1 Score
            </th>
            <th style=""background-color:#ffd1ba"">
                R1 Time
            </th>
            <th style=""background-color:#fffaba"">
                R2 Score
            </th>
            <th style=""background-color:#fffaba"">
                R2 Time
            </th>
            <th style=""background-color:#ffffff"">
                Average
            </th>
            <th style=""background-color:#ffffff"">
                Options
            </th>
        </tr>
");
                EndContext();
#line 36 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
          
            int i = 0;
        

#line default
#line hidden
                BeginContext(1003, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 39 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
         foreach (var teamDataModel in Model)
        {
            i++;

#line default
#line hidden
                BeginContext(1076, 58, true);
                WriteLiteral("            <tr>\n                <td>\n                    ");
                EndContext();
                BeginContext(1135, 60, false);
#line 44 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.TeamNumberBranch));

#line default
#line hidden
                EndContext();
                BeginContext(1195, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(1197, 32, false);
#line 44 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
                                                                             Write(teamDataModel.TeamNumberSpecific);

#line default
#line hidden
                EndContext();
                BeginContext(1229, 64, true);
                WriteLiteral("\n                </td>\n                <td>\n                    ");
                EndContext();
                BeginContext(1294, 52, false);
#line 47 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.TeamName));

#line default
#line hidden
                EndContext();
                BeginContext(1346, 97, true);
                WriteLiteral("\n                </td>\n                <td style=\"background-color:#ffd1ba\">\n                    ");
                EndContext();
                BeginContext(1444, 55, false);
#line 50 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.Round1Score));

#line default
#line hidden
                EndContext();
                BeginContext(1499, 97, true);
                WriteLiteral("\n                </td>\n                <td style=\"background-color:#ffd1ba\">\n                    ");
                EndContext();
                BeginContext(1597, 54, false);
#line 53 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.Round1Time));

#line default
#line hidden
                EndContext();
                BeginContext(1651, 97, true);
                WriteLiteral("\n                </td>\n                <td style=\"background-color:#fffaba\">\n                    ");
                EndContext();
                BeginContext(1749, 55, false);
#line 56 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.Round2Score));

#line default
#line hidden
                EndContext();
                BeginContext(1804, 97, true);
                WriteLiteral("\n                </td>\n                <td style=\"background-color:#fffaba\">\n                    ");
                EndContext();
                BeginContext(1902, 54, false);
#line 59 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.Round2Time));

#line default
#line hidden
                EndContext();
                BeginContext(1956, 64, true);
                WriteLiteral("\n                </td>\n                <td>\n                    ");
                EndContext();
                BeginContext(2021, 56, false);
#line 62 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
               Write(Html.DisplayFor(modelItem => teamDataModel.RoundAverage));

#line default
#line hidden
                EndContext();
                BeginContext(2077, 64, true);
                WriteLiteral("\n                </td>\n                <td>\n                    ");
                EndContext();
                BeginContext(2142, 72, false);
#line 65 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = teamDataModel.TeamID }));

#line default
#line hidden
                EndContext();
                BeginContext(2214, 41, true);
                WriteLiteral("\n                </td>\n            </tr>\n");
                EndContext();
#line 68 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/Index.cshtml"
        }

#line default
#line hidden
                BeginContext(2265, 18, true);
                WriteLiteral("\n    </table>\n   \n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IOrderedEnumerable<RobofestWTE.Models.TeamDataModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
