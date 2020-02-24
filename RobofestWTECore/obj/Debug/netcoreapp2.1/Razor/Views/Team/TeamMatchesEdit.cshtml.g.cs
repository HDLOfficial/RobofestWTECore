#pragma checksum "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ef10aae7013da24a1a3b901c32245aabe17855b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_TeamMatchesEdit), @"mvc.1.0.view", @"/Views/Team/TeamMatchesEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/TeamMatchesEdit.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_TeamMatchesEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ef10aae7013da24a1a3b901c32245aabe17855b", @"/Views/Team/TeamMatchesEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0c74960f6b96bae451f4a9058021941d4cf852", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamMatchesEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RobofestWTE.Models.TeamMatch>>
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
            BeginContext(42, 340, true);
            WriteLiteral(@"
<h1>Team Matches</h1>
<div>
    <input type=""button"" class=""btn btn-danger"" id=""autofill"" value=""Auto Fill Completed"" />
    <input type=""button"" class=""btn btn-danger"" id=""everythingc"" value=""Everything Completed"" />
    <input type=""button"" class=""btn btn-danger"" id=""nothingc"" value=""Nothing Completed"" />
    <a class=""btn btn-warning""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 382, "\"", 423, 1);
#line 8 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 389, Url.Action("TeamMatches", "Team"), 389, 34, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(424, 37, true);
            WriteLiteral(">Edit Match Layout</a>\n</div>\n<br />\n");
            EndContext();
#line 11 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
   int i = 0;

#line default
#line hidden
#line 12 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
 foreach (var match in Model.OrderBy(m => m.MatchID).ThenBy(m => m.Order))
        {
            i++;
            string idtoinput = i.ToString() + "-" + match.Order;
            string idtoinputbutton = i.ToString() + "-" + match.Order + "-completed";
            string idtoinputteam = i.ToString() + "-" + match.Order + "-team";
            string idtoinputbuttontest = i.ToString() + "-" + match.Order + "-test";
            string idtoinputbuttonrerun = i.ToString() + "-" + match.Order + "-rerun";
            string idtoinputround = i.ToString() + "-" + match.Order + "-round";
            string idtoinputcompleted = i.ToString() + "-" + match.Order + "-completed";

#line default
#line hidden
            BeginContext(1150, 116, true);
            WriteLiteral("<div style=\"background-color:lightgray;border-radius:6px;border:10px solid lightgray;z-index:-1;margin-bottom:10px;\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1266, "\"", 1285, 1);
#line 22 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1271, match.MatchID, 1271, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1286, 31, true);
            WriteLiteral(" class=\"matchentry\">\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1317, "\"", 1337, 1);
#line 23 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1323, idtoinputteam, 1323, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1338, 65, true);
            WriteLiteral(">Team #</label>\n    <input type=\"text\" class=\"teamentry input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1403, "\"", 1428, 1);
#line 24 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1411, match.TeamNumber, 1411, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1429, 40, true);
            WriteLiteral(" maxlength=\"7\" placeholder=\"Team Number\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1469, "\"", 1488, 1);
#line 24 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1474, idtoinputteam, 1474, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1489, 23, true);
            WriteLiteral(" disabled />\n    <label");
            EndContext();
            BeginWriteAttribute("for", " for=\"", 1512, "\"", 1533, 1);
#line 25 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1518, idtoinputround, 1518, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1534, 58, true);
            WriteLiteral(">Round #</label>\n    <input type=\"number\" class=\"input-sm\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1592, "\"", 1615, 1);
#line 26 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1600, match.RoundNum, 1600, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 1616, "\"", 1636, 1);
#line 26 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1621, idtoinputround, 1621, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1637, 134, true);
            WriteLiteral(" placeholder=\"Round #\" max=\"2\" min=\"1\" disabled />\n    <input type=\"button\" class=\"btn btn-success completed\" value=\"Toggle Completed\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1771, "\"", 1790, 1);
#line 27 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1776, match.MatchID, 1776, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1791, 88, true);
            WriteLiteral(" />\n    <input type=\"button\" class=\"btn btn-primary testmatch\" value=\"Toggle Test Match\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1879, "\"", 1898, 1);
#line 28 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1884, match.MatchID, 1884, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1899, 79, true);
            WriteLiteral(" />\n    <input type=\"button\" class=\"btn btn-warning rerun\" value=\"Toggle Rerun\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 1978, "\"", 1997, 1);
#line 29 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
WriteAttributeValue("", 1983, match.MatchID, 1983, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1998, 25, true);
            WriteLiteral(" />\n    <span> | </span>\n");
            EndContext();
#line 31 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
     if (match.Completed == true)
    {

#line default
#line hidden
            BeginContext(2063, 56, true);
            WriteLiteral("        <span class=\"badge badge-pill\">Completed</span>\n");
            EndContext();
#line 34 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
    }
    else if (match.Completed == false)
    {

#line default
#line hidden
            BeginContext(2170, 96, true);
            WriteLiteral("        <span class=\"badge badge-pill\" style=\"background-color:darkorange\">Not Completed</span>\n");
            EndContext();
#line 38 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
    }

#line default
#line hidden
            BeginContext(2272, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 39 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
     if (match.Test == true)
    {

#line default
#line hidden
            BeginContext(2307, 134, true);
            WriteLiteral("        <span class=\"badge badge-pill\" style=\"border: 2px solid deeppink;background-color:lightgray;color:deeppink\">Test Match</span>\n");
            EndContext();
#line 42 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
    }

#line default
#line hidden
            BeginContext(2447, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 43 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
     if (match.Rerun == true)
    {

#line default
#line hidden
            BeginContext(2483, 89, true);
            WriteLiteral("        <span class=\"badge badge-pill\" style=\"background-color:forestgreen\">Rerun</span>\n");
            EndContext();
#line 46 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
    }

#line default
#line hidden
            BeginContext(2578, 9, true);
            WriteLiteral("\n\n</div>\n");
            EndContext();
#line 50 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamMatchesEdit.cshtml"
}

#line default
#line hidden
<<<<<<< HEAD
            BeginContext(2621, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df96bfda2730406a8a69f92687980b2a", async() => {
=======
            BeginContext(2589, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "087b3ad308784d87b8de0b8ca037f05f", async() => {
>>>>>>> master
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
            BeginContext(2650, 1, true);
            WriteLiteral("\n");
            EndContext();
<<<<<<< HEAD
            BeginContext(2683, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c192f7c74fdd41ef94e2eb0f09b778e6", async() => {
=======
            BeginContext(2651, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb3f2d57007a4b9797ff3adb9474e674", async() => {
>>>>>>> master
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
            BeginContext(2702, 1186, true);
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
        $("".completed"").on(""click"", function () {
            var matchid = parseInt($(this).attr(""id""))
            chat.invoke(""editSpecificSchedule"", matchid, ""completed"");
        });
        $("".testmatch"").on(""click"", function () {
            var matchid = parseInt($(this).attr(""id""))
            chat.invoke(""editSpecificSchedule"", matchid, ""testmatch"");
        });
        $("".rerun"").on(""click"", function () {
            var matchid = parseInt($(this).attr(""id""))
            chat.invoke(""editSpecificSchedule"", matchid, ""rerun"");
        });
        $(""#autofill"").on(""click"", function () {
            chat.invoke(""autoComplete"");
        });
        $(""#everythingc"").on(""click"", function () {
            chat.invoke(""completeAll"", t");
            WriteLiteral("rue);\n        });\n        $(\"#nothingc\").on(\"click\", function () {\n            chat.invoke(\"completeAll\", false);\n        });\n    \n    \n        \n    });\n</script>");
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
