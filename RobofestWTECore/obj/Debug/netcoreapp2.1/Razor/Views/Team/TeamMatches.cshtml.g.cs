#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49e8c8a6c1039987343d3ebb6541305792d2b147"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_TeamMatches), @"mvc.1.0.view", @"/Views/Team/TeamMatches.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/TeamMatches.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_TeamMatches))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49e8c8a6c1039987343d3ebb6541305792d2b147", @"/Views/Team/TeamMatches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamMatches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTECore.Models.ViewModels.TeamMatchDataModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 248, true);
            WriteLiteral("\n<h1>Team Matches</h1>\n<div>\r\n    <input type=\"button\" class=\"btn btn-success\" id=\"listallteams\" value=\"Save Changes\" />\r\n    <input type=\"button\" class=\"btn btn-danger\" id=\"discardchanges\" value=\"Discard Changes\" />\r\n    <a class=\"btn btn-warning\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 308, "\"", 353, 1);
#line 7 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 315, Url.Action("TeamMatchesEdit", "Team"), 315, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(354, 85, true);
            WriteLiteral(">Edit Match Status</a>\r\n    <input type=\"number\" class=\"input-lg\" id=\"numberoffields\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 439, "\"", 463, 1);
#line 8 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 447, Model.NumFields, 447, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(464, 19, true);
            WriteLiteral(" />\r\n</div>\n<br />\n");
            EndContext();
#line 11 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
   int i = 0;

#line default
#line hidden
#line 12 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
 foreach (var match in Model.Matches.OrderBy(m => m.MatchID).ThenBy(m => m.Order))
        {
            i++;
            string idtoinput = i.ToString() + "-" + match.Order;
            string idtoinputbutton = i.ToString() + "-" + match.Order + "-add";
            string idtoinputteam = i.ToString() + "-" + match.Order + "-team";
            string idtoinputbuttonremove = i.ToString() + "-" + match.Order + "-remove";
            string idtoinputround = i.ToString() + "-" + match.Order + "-round";
            string idtoinputcompleted = i.ToString() + "-" + match.Order + "-completed";
            string idtoinputrerun = i.ToString() + "-" + match.Order + "-rerun";
            string idtoinputtestmatch = i.ToString() + "-" + match.Order + "-testmatch";

#line default
#line hidden
            BeginContext(1261, 116, true);
            WriteLiteral("<div style=\"background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1377, "\"", 1392, 1);
#line 23 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1382, idtoinput, 1382, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1393, 71, true);
            WriteLiteral(" class=\"matchentry\">\r\n    <input type=\"text\" class=\"teamentry input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1464, "\"", 1489, 1);
#line 24 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1472, match.TeamNumber, 1472, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1490, 40, true);
            WriteLiteral(" maxlength=\"7\" placeholder=\"Team Number\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1530, "\"", 1549, 1);
#line 24 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1535, idtoinputteam, 1535, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1550, 50, true);
            WriteLiteral(" />\r\n    <input type=\"button\" class=\"btn addafter\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1600, "\"", 1621, 1);
#line 25 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1605, idtoinputbutton, 1605, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1622, 79, true);
            WriteLiteral(" value=\"Add Another Below\" />\r\n    <input type=\"button\" class=\"btn removeentry\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1701, "\"", 1728, 1);
#line 26 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1706, idtoinputbuttonremove, 1706, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1729, 41, true);
            WriteLiteral(" value=\"Delete This Entry\" />\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1770, "\"", 1791, 1);
#line 27 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1776, idtoinputround, 1776, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1792, 59, true);
            WriteLiteral(">Round #</label>\r\n    <input type=\"number\" class=\"input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1851, "\"", 1874, 1);
#line 28 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1859, match.RoundNum, 1859, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1875, "\"", 1895, 1);
#line 28 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 1880, idtoinputround, 1880, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1896, 43, true);
            WriteLiteral(" placeholder=\"Round #\" max=\"2\" min=\"1\" />\r\n");
            EndContext();
#line 29 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Completed == true)
    {

#line default
#line hidden
            BeginContext(1981, 57, true);
            WriteLiteral("        <span class=\"badge badge-pill\">Completed</span>\r\n");
            EndContext();
#line 32 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }
    else if (match.Completed == false)
    {

#line default
#line hidden
            BeginContext(2092, 97, true);
            WriteLiteral("        <span class=\"badge badge-pill\" style=\"background-color:darkorange\">Not Completed</span>\r\n");
            EndContext();
#line 36 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(2196, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 37 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Test == true)
    {

#line default
#line hidden
            BeginContext(2233, 135, true);
            WriteLiteral("        <span class=\"badge badge-pill\" style=\"border: 2px solid deeppink;background-color:lightgray;color:deeppink\">Test Match</span>\r\n");
            EndContext();
#line 40 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(2375, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 41 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
     if (match.Rerun == true)
    {

#line default
#line hidden
            BeginContext(2413, 90, true);
            WriteLiteral("        <span class=\"badge badge-pill\" style=\"background-color:forestgreen\">Rerun</span>\r\n");
            EndContext();
#line 44 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
    }

#line default
#line hidden
            BeginContext(2510, 43, true);
            WriteLiteral("    <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2553, "\"", 2573, 1);
#line 45 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2558, idtoinputrerun, 2558, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2574, 15, true);
            WriteLiteral(" />\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2589, "\"", 2610, 1);
#line 46 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2595, idtoinputrerun, 2595, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2611, 59, true);
            WriteLiteral(">Rerun</label>\r\n    <input type=\"checkbox\" class=\"checkbox\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 2670, "\"", 2694, 1);
#line 47 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2675, idtoinputtestmatch, 2675, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2695, 15, true);
            WriteLiteral(" />\r\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 2710, "\"", 2735, 1);
#line 48 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
WriteAttributeValue("", 2716, idtoinputtestmatch, 2716, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2736, 34, true);
            WriteLiteral(">Test Match</label>\r\n\r\n\r\n\r\n</div>\n");
            EndContext();
#line 53 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamMatches.cshtml"
}

#line default
#line hidden
            BeginContext(2772, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b60bd6bb96f42a08e1e7fe3883005fd", async() => {
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
            BeginContext(2833, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(2834, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a8c86ae85e24d479b47c9056e34f2e5", async() => {
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
            BeginContext(2885, 3014, true);
            WriteLiteral(@"
<script>
    var chat = new signalR.HubConnectionBuilder().withUrl(""/scoreHub"").build();
    var i = 0;
    var reloads = 0;
    chat.on(""reloadRequired"", function () {
        reload += 1
        if (reload >= i) {
            location.reload(true)
        }
    });
    chat.start().then(function () {
        var scheduler = {
            ""schedules"" : []
        }
        $(document).on('click', '#listallteams', function () {
            
            chat.invoke(""clearSchedule"");
            $("".matchentry"").each(function () {
                i += 1;
                var localid = this.id
                var numfields = parseInt($(""#numberoffields"").val())
                var schedule = {

                };
                schedule.TeamNumber = $(this).children(""#"" + localid + ""-team"").val();
                schedule.RoundNum = $(this).children(""#"" + localid + ""-round"").val();
                schedule.CompID = 1;
                schedule.Order = i;
                schedule.Rerun = $(this).children(""#"" + l");
            WriteLiteral(@"ocalid + ""-rerun"").is("":checked"");
                schedule.Test = $(this).children(""#"" + localid + ""-testmatch"").is("":checked"");
                schedule.Completed = false;
                scheduler.schedules.push(schedule);
                completedschedule = JSON.stringify(schedule);
                chat.invoke(""changeMatches"", completedschedule, numfields);
            });
            
        });
        $(document).on('click', '.addafter', function () {
            var clearedstring = this.id.replace(""-add"", """");
            $(""#"" + clearedstring + ""-add"").attr(""disabled"", true)
            var newid = clearedstring.split(""-"")
            var newidstring = newid[0] + ""-"" + (parseInt(newid[1]) + 1)
            $(""<div style='background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px' id='"" + newidstring + ""' class='matchentry'><input type='text' class='teamentry input-sm' value='EMPTY' maxlength='7' placeholder='Team Number' id='"" + newidstring + ""-team' style=");
            WriteLiteral(@"'margin-right:4px'/><input type='button' class='btn addafter' id='"" + newidstring + ""-add' value='Add Another Below' style='margin-right:4px'/><input type='button' class='btn removeentry' id='"" + newidstring + ""-remove' value='Delete This Entry' placeholder='Round #' style='margin-right:4px'/><label for='"" + newidstring + ""-round' style='margin-right:4px'>Round #</label><input type='number' class='input-sm' id='"" + newidstring + ""-round' value=1 max='2' min='1' style='margin-right:4px'/><span class='badge badge-pill' style='background-color:darkorange'>Not Completed</span></div>"").insertAfter(""#"" + clearedstring)
        });
        $(document).on('click', '.removeentry', function () {
            var clearedstring = this.id.replace(""-remove"", """");
            $(""#"" + clearedstring).remove();
        });
        $(""#discardchanges"").on(""click"", function () {
            location.reload(true);
        });
        //
    
    
        
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTECore.Models.ViewModels.TeamMatchDataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
