#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75e8bb51a529fc242cdf5de8ba4df622d7576bf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_MatchManager), @"mvc.1.0.view", @"/Views/Team/MatchManager.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/MatchManager.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_MatchManager))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e8bb51a529fc242cdf5de8ba4df622d7576bf2", @"/Views/Team/MatchManager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_MatchManager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTE.Models.MatchDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("crossorigin", new global::Microsoft.AspNetCore.Html.HtmlString("anonymous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(81, 3773, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2f8549bfa86d4079bb5458cdd92091f6", async() => {
                BeginContext(87, 1752, true);
                WriteLiteral(@"
    <style>
        .tabcontent {
            display: none;
            padding: 6px 12px;
            border: 1px solid #ccc;
            border-top: none;
        }
        /* Style the tab */
        .tab {
            overflow: hidden;
            border: 1px solid #ccc;
            background-color: #f1f1f1;
        }

            /* Style the buttons inside the tab */
            .tab button {
                background-color: inherit;
                float: left;
                border: none;
                outline: none;
                cursor: pointer;
                padding: 14px 16px;
                transition: 0.3s;
                font-size: 17px;
            }

                /* Change background color of buttons on hover */
                .tab button:hover {
                    background-color: #ddd;
                }

                /* Create an active/current tablink class */
                .tab button.active {
                    background-color: ");
                WriteLiteral(@"#ccc;
                }
    </style>
    <h2>Team Management</h2>
    <input type=""button"" value=""Round 1"" class=""tablinks"" onclick=""openCity(event, 'Round1')"" />
    <input type=""button"" value=""Round 2"" class=""tablinks"" onclick=""openCity(event, 'Round2')"" />
    <table class=""table table-hover tabcontent"" id=""Round1"">
        <tr style=""font-size:20px"">
            <th style=""background-color:#ffffff"">
                Team ID
            </th>
            <th style=""background-color:#ffffff"">
                Team #
            </th>
            <th style=""background-color:#ffffff"">
                Team Name
            </th>
            <th>
                Select:
            </th>
        </tr>
");
                EndContext();
#line 61 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
          
            int i = 0;
            int r = 1;
            var Fields = Model.RunningFields;
        

#line default
#line hidden
                BeginContext(1957, 8, true);
                WriteLiteral("        ");
                EndContext();
#line 66 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
         foreach (var Team in Model.R1List.Where(a => a.FieldR1 == 0).OrderBy(a => a.TeamNumberBranch).ThenBy(a => a.TeamNumberSpecific))
        {
            {
                i++;
            }

#line default
#line hidden
                BeginContext(2159, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2220, 41, false);
#line 73 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
               Write(Html.DisplayFor(modelItem => Team.TeamID));

#line default
#line hidden
                EndContext();
                BeginContext(2261, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2329, 51, false);
#line 76 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
               Write(Html.DisplayFor(modelItem => Team.TeamNumberBranch));

#line default
#line hidden
                EndContext();
                BeginContext(2380, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(2382, 23, false);
#line 76 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
                                                                    Write(Team.TeamNumberSpecific);

#line default
#line hidden
                EndContext();
                BeginContext(2405, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(2473, 43, false);
#line 79 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
               Write(Html.DisplayFor(modelItem => Team.TeamName));

#line default
#line hidden
                EndContext();
                BeginContext(2516, 117, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    Select\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 85 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
        }

#line default
#line hidden
                BeginContext(2644, 478, true);
                WriteLiteral(@"
    </table>
    <table class=""table table-hover tabcontent"" id=""Round2"">
        <tr style=""font-size:20px"">
            <th style=""background-color:#ffffff"">
                Team ID
            </th>
            <th style=""background-color:#ffffff"">
                Team #
            </th>
            <th style=""background-color:#ffffff"">
                Team Name
            </th>
            <th>
                Select:
            </th>
        </tr>
");
                EndContext();
#line 103 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
         foreach (var Team in Model.R2List.Where(a => a.FieldR2 == 0).OrderByDescending(a => a.TeamNumberBranch).ThenByDescending(a => a.TeamNumberSpecific))
        {
            {
                i++;
            }

#line default
#line hidden
                BeginContext(3344, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3405, 41, false);
#line 110 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
               Write(Html.DisplayFor(modelItem => Team.TeamID));

#line default
#line hidden
                EndContext();
                BeginContext(3446, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3514, 51, false);
#line 113 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
               Write(Html.DisplayFor(modelItem => Team.TeamNumberBranch));

#line default
#line hidden
                EndContext();
                BeginContext(3565, 1, true);
                WriteLiteral("-");
                EndContext();
                BeginContext(3567, 23, false);
#line 113 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
                                                                    Write(Team.TeamNumberSpecific);

#line default
#line hidden
                EndContext();
                BeginContext(3590, 67, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(3658, 43, false);
#line 116 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
               Write(Html.DisplayFor(modelItem => Team.TeamName));

#line default
#line hidden
                EndContext();
                BeginContext(3701, 117, true);
                WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    Select\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 122 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\MatchManager.cshtml"
        }

#line default
#line hidden
                BeginContext(3829, 18, true);
                WriteLiteral("\r\n    </table>\r\n\r\n");
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
            BeginContext(3854, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3856, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7324390c3f594f418bbc4cd2e5d85682", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3942, 1462, true);
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
<script src=""Scripts/jquery-3.1.1.min.js""></script>
<!--Reference the SignalR library. -->
<script src=""Scripts/jquery.signalR-2.2.1.min.js""></script>
<!--Reference the autogenerated SignalR hub script. -->
<script src=""signalr/hubs""></script>
<script>
    function openCity(evt, cityName) {
        var i, tabcontent, tablinks;
        tabcontent = document.getElementsByClassName(""tabcontent"");
        for (i = 0; i < tabcontent.length; i++) {
            tabcontent[i].style.display = ""none"";
        }
        tablinks = document.getElementsByClassName(""tablinks"");
        for (i = 0; i < tablin");
            WriteLiteral(@"ks.length; i++) {
            tablinks[i].className = tablinks[i].className.replace("" active"", """");
        }
        document.getElementById(cityName).style.display = ""block"";
        evt.currentTarget.className += "" active"";
    }
</script>
<script>
    $(function () {
        var chat = $.connection.scoreHub;
        chat.client.changelist = function () {
            location.reload(true);
        };
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTE.Models.MatchDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
