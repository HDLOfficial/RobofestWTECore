#pragma checksum "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatches.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41bc184f7c12c4110a191c525fa6589bc1b9d69b"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41bc184f7c12c4110a191c525fa6589bc1b9d69b", @"/Views/Team/TeamMatches.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0c74960f6b96bae451f4a9058021941d4cf852", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamMatches : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RobofestWTE.Models.TeamMatch>>
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
            BeginContext(42, 119, true);
            WriteLiteral("\n<h1>Team Matches</h1>\n<input type=\"button\" class=\"btn btn-success\" id=\"listallteams\" value=\"List All Teams (TEST)\" />\n");
            EndContext();
#line 5 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatches.cshtml"
   int i = 0;

#line default
#line hidden
#line 6 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatches.cshtml"
 foreach (var match in Model.OrderBy(m => m.MatchID).ThenBy(m => m.Order))
{
    i++;
    string idtoinput = i.ToString() + "-" + match.Order;
    string idtoinputbutton = i.ToString() + "-" + match.Order + "-add";
    string idtoinputteam = i.ToString() + "-" + match.Order + "-team";
    string idtoinputbuttonremove = i.ToString() + "-" + match.Order + "-remove";

#line default
#line hidden
            BeginContext(543, 119, true);
            WriteLiteral("    <div style=\"background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 662, "\"", 677, 1);
#line 13 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatches.cshtml"
WriteAttributeValue("", 667, idtoinput, 667, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(678, 65, true);
            WriteLiteral(" class=\"matchentry\">\n        <input type=\"text\" class=\"teamentry\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 743, "\"", 768, 1);
#line 14 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatches.cshtml"
WriteAttributeValue("", 751, match.TeamNumber, 751, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(769, 40, true);
            WriteLiteral(" maxlength=\"7\" placeholder=\"Team Number\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 809, "\"", 828, 1);
#line 14 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatches.cshtml"
WriteAttributeValue("", 814, idtoinputteam, 814, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(829, 64, true);
            WriteLiteral("/>\n        <input type=\"button\" class=\"btn btn-warning addafter\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 893, "\"", 914, 1);
#line 15 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatches.cshtml"
WriteAttributeValue("", 898, idtoinputbutton, 898, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(915, 93, true);
            WriteLiteral(" value=\"Add Another Below\" />\n        <input type=\"button\" class=\"btn btn-danger removeentry\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1008, "\"", 1035, 1);
#line 16 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatches.cshtml"
WriteAttributeValue("", 1013, idtoinputbuttonremove, 1013, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1036, 41, true);
            WriteLiteral(" value=\"Delete This Entry\" />\n    </div>\n");
            EndContext();
#line 18 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatches.cshtml"
}

#line default
#line hidden
            BeginContext(1079, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47bc5ddeb16248c28b2ba0f64e2086db", async() => {
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
            BeginContext(1140, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(1141, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0923fb35d1a4c9cb8dea21680dd3b80", async() => {
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
            BeginContext(1192, 2154, true);
            WriteLiteral(@"
<script>
    var chat = new signalR.HubConnectionBuilder().withUrl(""/scoreHub"").build();
    chat.on(""reloadRequired"", function () {
        location.reload(true);
    });
    chat.start().then(function () {
        var scheduler = {
            ""schedules"" : []
        }
        $(document).on('click', '#listallteams', function () {
            var i = 0;
            chat.invoke(""clearSchedule"");
            $("".matchentry"").each(function () {
                i += 1;
                var localid = this.id
                var schedule = {

                };
                schedule.TeamNumber = $(this).children(""#"" + localid + ""-team"").val();
                schedule.RoundNum = 1;
                schedule.CompID = 1;
                schedule.Order = i;
                schedule.Rerun = false;
                schedule.Test = false;
                schedule.Completed = false;
                scheduler.schedules.push(schedule);
                completedschedule = JSON.stringify(schedule);
                chat.in");
            WriteLiteral(@"voke(""changeMatches"", completedschedule);
            });
            
        });
        $(document).on('click', '.addafter', function () {
            var clearedstring = this.id.replace(""-add"", """");
            var newid = clearedstring.split(""-"")
            var newidstring = newid[0] + ""-"" + (parseInt(newid[1]) + 1)
            $(""<div style='background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px' id='"" + newidstring + ""' class='matchentry'><input type='text' class='teamentry' value='EMPTY' maxlength='7' placeholder='Team Number' id='"" + newidstring + ""-team'/><input type='button' class='btn btn-warning addafter' id='"" + newidstring + ""-add' value='Add Another Below'/><input type='button' class='btn btn-danger removeentry' id='"" + newidstring + ""-remove' value='Delete This Entry'/></div>"").insertAfter(""#"" + clearedstring)
        });
        $(document).on('click', '.removeentry', function () {
            var clearedstring = this.id.replace(""-remove"", """")");
            WriteLiteral(";\n            $(\"#\" + clearedstring).remove();\n        });\n        //\n    \n    \n        \n    });\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RobofestWTE.Models.TeamMatch>> Html { get; private set; }
    }
}
#pragma warning restore 1591
