#pragma checksum "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5aaa3a0caa7c241282b150fcfa1c9577867ee33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_TeamCreate), @"mvc.1.0.view", @"/Views/Team/TeamCreate.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/TeamCreate.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_TeamCreate))]
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
#line 1 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\_ViewImports.cshtml"
using RobofestWTECore;

#line default
#line hidden
#line 3 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\_ViewImports.cshtml"
using RobofestWTECore.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5aaa3a0caa7c241282b150fcfa1c9577867ee33", @"/Views/Team/TeamCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTE.Models.StudentTeam>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(79, 1213, true);
            WriteLiteral(@"<style>
    .btn-group {
        display: flex;
    }

    .btn {
        flex: 1
    }

    btn-default: {
        background-color: gray
    }

    .footer {
        position: fixed;
        left: 0;
        bottom: 0;
        width: 100%;
        background-color: #ecbb06;
        color: white;
        text-align: center;
    }

    .createforms {
        border: none;
        border-bottom: 2px solid gray;
        padding-left: 2px;
        transition: 0.3s;
        border-radius: 4px;
    }

        .createforms:hover {
            background-color: #ededed;
            padding-left: 5px;
        }

        .createforms:focus {
            border-bottom: 2px solid red;
            background-color: #ededed;
            padding-left: 5px;
        }

        .createforms:disabled {
            cursor: not-allowed;
            padding-left: 2px;
            transition: 0.3s;
        }

            .createforms:disabled:hover, .createforms:disabled:active {
  ");
            WriteLiteral("              cursor: not-allowed;\r\n                background-color: red;\r\n                padding-left: 5px;\r\n                opacity: 0.6;\r\n            }\r\n</style>\r\n<h2>Create</h2>\r\n\r\n\r\n");
            EndContext();
#line 64 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(1327, 23, false);
#line 66 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1354, 108, true);
            WriteLiteral("    <div class=\"form-horizontal\" style=\"text-align:center\">\r\n        <h4>Team</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(1463, 64, false);
#line 71 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1527, 141, true);
            WriteLiteral("\r\n    </div>\r\n    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\r\n        ");
            EndContext();
            BeginContext(1669, 95, false);
#line 74 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.CompID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1764, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(1775, 70, false);
#line 75 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.CompID, new { @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(1845, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(1864, 84, false);
#line 77 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.CompID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1950, 127, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\r\n        ");
            EndContext();
            BeginContext(2078, 97, false);
#line 79 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.TeamName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2175, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2186, 72, false);
#line 80 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.TeamName, new { @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(2258, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(2277, 86, false);
#line 82 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.TeamName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2365, 127, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\r\n        ");
            EndContext();
            BeginContext(2493, 105, false);
#line 84 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.TeamNumberBranch, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2598, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(2609, 96, false);
#line 85 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.TeamNumberBranch, new { Value = "1000", @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(2705, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(2724, 94, false);
#line 87 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.TeamNumberBranch, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2820, 127, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\r\n        ");
            EndContext();
            BeginContext(2948, 107, false);
#line 89 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.TeamNumberSpecific, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3055, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(3066, 95, false);
#line 90 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.TeamNumberSpecific, new { Value = "1", @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(3161, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(3180, 96, false);
#line 92 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.TeamNumberSpecific, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3278, 127, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\r\n        ");
            EndContext();
            BeginContext(3406, 97, false);
#line 94 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.Location, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3503, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(3514, 72, false);
#line 95 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.Location, new { @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(3586, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(3605, 86, false);
#line 97 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3693, 127, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\r\n        ");
            EndContext();
            BeginContext(3821, 94, false);
#line 99 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.Coach, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3915, 10, true);
            WriteLiteral("\r\n        ");
            EndContext();
            BeginContext(3926, 69, false);
#line 100 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.Coach, new { @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(3995, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
            BeginContext(4014, 83, false);
#line 102 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.Coach, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4099, 183, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center\">\r\n        <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\r\n    </div>\r\n");
            EndContext();
#line 106 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\TeamCreate.cshtml"
}

#line default
#line hidden
            BeginContext(4285, 688, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.0/jquery.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js"" integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>



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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RobofestWTE.Models.StudentTeam> Html { get; private set; }
    }
}
#pragma warning restore 1591