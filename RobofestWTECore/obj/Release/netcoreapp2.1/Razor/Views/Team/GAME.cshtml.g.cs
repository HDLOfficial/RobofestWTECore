#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80a65b637238446e6e398ec05b7c1a93029a1aae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_GAME), @"mvc.1.0.view", @"/Views/Team/GAME.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/GAME.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_GAME))]
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
#line 1 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\_ViewImports.cshtml"
using RobofestWTECore;

#line default
#line hidden
#line 3 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\_ViewImports.cshtml"
using RobofestWTECore.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a65b637238446e6e398ec05b7c1a93029a1aae", @"/Views/Team/GAME.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_GAME : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTE.Models.GamePageModel>
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(80, 114, true);
            WriteLiteral("<style>\r\n    table{\r\n        border:0px;\r\n        border-collapse:collapse;\r\n        width:100%\r\n    }\r\n</style>\r\n");
            EndContext();
            BeginContext(194, 2413, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ef13a4709a44a3888b5d5c8f4ff09a3", async() => {
                BeginContext(200, 386, true);
                WriteLiteral(@"
    <h2 style=""text-align:center"">Competition Index</h2>
    <div width=""100%"" style=""background-color:lightgray;border:1px lightgray solid;border-radius:10px;margin:10px"">
        <table style=""text-align:center;font-size:25px;margin:10px"">
            <tr>
                <td width=""33%""></td>
                <td width=""33%"" style=""padding-bottom:10px"">
                    ");
                EndContext();
                BeginContext(587, 36, false);
#line 20 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
                EndContext();
                BeginContext(623, 186, true);
                WriteLiteral("\r\n                </td>\r\n                <td width=\"33%\"></td>\r\n            </tr>\r\n\r\n            <tr style=\"font-size:20px\">\r\n                <td width=\"33%\">\r\n                    GAME #");
                EndContext();
                BeginContext(810, 38, false);
#line 27 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
                     Write(Html.DisplayFor(model => model.GameID));

#line default
#line hidden
                EndContext();
                BeginContext(848, 79, true);
                WriteLiteral("\r\n                </td>\r\n                <td width=\"33%\">\r\n                    ");
                EndContext();
                BeginContext(928, 36, false);
#line 30 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
               Write(Html.DisplayFor(model => model.Desc));

#line default
#line hidden
                EndContext();
                BeginContext(964, 59, true);
                WriteLiteral("\r\n                </td>\r\n                <td width=\"33%\">\r\n");
                EndContext();
#line 33 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
                       
                        int competitions = Model.Competitions.Count;
                    

#line default
#line hidden
                BeginContext(1141, 20, true);
                WriteLiteral("                    ");
                EndContext();
                BeginContext(1162, 12, false);
#line 36 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
               Write(competitions);

#line default
#line hidden
                EndContext();
                BeginContext(1174, 766, true);
                WriteLiteral(@" Competitions
                </td>
            </tr>
        </table>
    </div>
    <h3 style=""text-align:center"">All Competitions:</h3>
    <table>
        <tr style=""font-size:20px;border-bottom:5px black solid"">
            <th style=""background-color:#ffffff;width:1%;padding-right:5px"">
                ID 
            </th>
            <th style=""background-color:#ffffff"">
                Location
            </th>
            <th style=""background-color:#ffffff"">
                Date
            </th>
            <th>
                Extra
            </th>
            <th>
                # of Teams
            </th>
            <th style=""background-color:#ffffff"">
                Options
            </th>
        </tr>
");
                EndContext();
#line 63 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
         foreach (var item in Model.Competitions.OrderByDescending(a => a.Date))
        {

#line default
#line hidden
                BeginContext(2033, 90, true);
                WriteLiteral("        <tr>\r\n            <td style=\"background-color:#ffffff;width:1%\">\r\n                ");
                EndContext();
                BeginContext(2124, 11, false);
#line 67 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
           Write(item.CompID);

#line default
#line hidden
                EndContext();
                BeginContext(2135, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2191, 13, false);
#line 70 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
           Write(item.Location);

#line default
#line hidden
                EndContext();
                BeginContext(2204, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2260, 9, false);
#line 73 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
           Write(item.Date);

#line default
#line hidden
                EndContext();
                BeginContext(2269, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2325, 14, false);
#line 76 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
           Write(item.ExtraData);

#line default
#line hidden
                EndContext();
                BeginContext(2339, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2395, 14, false);
#line 79 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
           Write(item.TeamCount);

#line default
#line hidden
                EndContext();
                BeginContext(2409, 55, true);
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                EndContext();
                BeginContext(2465, 67, false);
#line 82 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
           Write(Html.ActionLink("Details", "Competition", new { id = item.CompID }));

#line default
#line hidden
                EndContext();
                BeginContext(2532, 36, true);
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
                EndContext();
#line 85 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\GAME.cshtml"
        }

#line default
#line hidden
                BeginContext(2579, 21, true);
                WriteLiteral("\r\n    </table>\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTE.Models.GamePageModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
