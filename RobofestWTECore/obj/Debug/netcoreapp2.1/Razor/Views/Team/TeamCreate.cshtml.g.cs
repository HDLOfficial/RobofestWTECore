#pragma checksum "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd6e08ec58f0dfb5af361d1e3a14137fdfdc9b8"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd6e08ec58f0dfb5af361d1e3a14137fdfdc9b8", @"/Views/Team/TeamCreate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b0c74960f6b96bae451f4a9058021941d4cf852", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_TeamCreate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTE.Models.StudentTeam>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(74, 1155, true);
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
                cursor: not-allowed;
              ");
            WriteLiteral("  background-color: red;\n                padding-left: 5px;\n                opacity: 0.6;\n            }\n</style>\n<h2>Create</h2>\n\n\n");
            EndContext();
#line 64 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(1262, 23, false);
#line 66 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1287, 105, true);
            WriteLiteral("    <div class=\"form-horizontal\" style=\"text-align:center\">\n        <h4>Team</h4>\n        <hr />\n        ");
            EndContext();
            BeginContext(1393, 64, false);
#line 71 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1457, 138, true);
            WriteLiteral("\n    </div>\n    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\n        ");
            EndContext();
            BeginContext(1596, 95, false);
#line 74 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.CompID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1691, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(1701, 70, false);
#line 75 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.CompID, new { @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(1771, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(1788, 84, false);
#line 77 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.CompID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1873, 126, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\n        ");
            EndContext();
            BeginContext(2000, 97, false);
#line 79 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.TeamName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2097, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(2107, 72, false);
#line 80 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.TeamName, new { @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(2179, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(2196, 86, false);
#line 82 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.TeamName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2283, 126, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\n        ");
            EndContext();
            BeginContext(2410, 105, false);
#line 84 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.TeamNumberBranch, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2515, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(2525, 96, false);
#line 85 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.TeamNumberBranch, new { Value = "1000", @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(2621, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(2638, 94, false);
#line 87 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.TeamNumberBranch, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2733, 126, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\n        ");
            EndContext();
            BeginContext(2860, 107, false);
#line 89 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.TeamNumberSpecific, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2967, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(2977, 95, false);
#line 90 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.TeamNumberSpecific, new { Value = "1", @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(3072, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(3089, 96, false);
#line 92 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.TeamNumberSpecific, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3186, 126, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\n        ");
            EndContext();
            BeginContext(3313, 97, false);
#line 94 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.Location, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3410, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(3420, 72, false);
#line 95 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.Location, new { @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(3492, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(3509, 86, false);
#line 97 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.Location, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3596, 126, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center;padding-bottom:10px\">\n        ");
            EndContext();
            BeginContext(3723, 94, false);
#line 99 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.LabelFor(model => model.Coach, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3817, 9, true);
            WriteLiteral("\n        ");
            EndContext();
            BeginContext(3827, 69, false);
#line 100 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
   Write(Html.TextBoxFor(model => model.Coach, new { @class = "createforms" }));

#line default
#line hidden
            EndContext();
            BeginContext(3896, 12, true);
            WriteLiteral("\n    </div>\n");
            EndContext();
            BeginContext(3913, 83, false);
#line 102 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
Write(Html.ValidationMessageFor(model => model.Coach, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3997, 180, true);
            WriteLiteral("    <div style=\"display:flex; flex-direction: row; justify-content: center; align-items: center\">\n        <input type=\"submit\" value=\"Create\" class=\"btn btn-default\" />\n    </div>\n");
            EndContext();
#line 106 "/Users/daviado/Downloads/RobofestWTECore/RobofestWTECore/Views/Team/TeamCreate.cshtml"
}

#line default
#line hidden
            BeginContext(4179, 680, true);
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
