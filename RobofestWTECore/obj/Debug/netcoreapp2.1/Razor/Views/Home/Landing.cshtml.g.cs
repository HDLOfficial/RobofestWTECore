#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c993b8267283d513033c70d2614d316ad272803"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Home.Views_Home_Landing), @"mvc.1.0.view", @"/Views/Home/Landing.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Landing.cshtml", typeof(RobofestWTECore.Pages.Home.Views_Home_Landing))]
namespace RobofestWTECore.Pages.Home
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c993b8267283d513033c70d2614d316ad272803", @"/Views/Home/Landing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Landing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
  
    ViewBag.Title = "Home Page";

#line default
#line hidden
            BeginContext(41, 70, true);
            WriteLiteral("\r\n<div class=\"jumbotron\" style=\"text-align:center\">\r\n    <h1>Welcome, ");
            EndContext();
            BeginContext(112, 18, false);
#line 6 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
            Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(130, 71, true);
            WriteLiteral("!</h1>\r\n    <h4>Thank you for volunteering for Robofest!</h4>\r\n</div>\r\n");
            EndContext();
#line 9 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
 if (User.IsInRole("Judge")){

#line default
#line hidden
            BeginContext(232, 135, true);
            WriteLiteral("    <div>\r\n        <span style=\"background-color:blue;color:white;padding:10px;font-size:20px\">Judge</span>\r\n        <br />\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 367, "\"", 424, 1);
#line 13 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
WriteAttributeValue("", 374, Url.Action("Competition", "Team", new { id = 1 }), 374, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(425, 53, true);
            WriteLiteral(">Go to the Scoresheet</a>\r\n        <br />\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 478, "\"", 524, 1);
#line 15 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
WriteAttributeValue("", 485, Url.Action("RoundCreateBlank", "Team"), 485, 39, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(525, 39, true);
            WriteLiteral(">Create a Blank Round</a>\r\n    </div>\r\n");
            EndContext();
#line 17 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
}

#line default
#line hidden
#line 18 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
 if (User.IsInRole("Judge")){

#line default
#line hidden
            BeginContext(598, 151, true);
            WriteLiteral("    <div>\r\n        <span style=\"background-color:cornflowerblue;color:white;padding:10px;font-size:20px\">Field Staff</span>\r\n        <br />\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 749, "\"", 806, 1);
#line 22 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
WriteAttributeValue("", 756, Url.Action("MatchKeeper", "Team", new { id = 1 }), 756, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(807, 49, true);
            WriteLiteral(">Field Management</a>\r\n        <br />\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 856, "\"", 913, 1);
#line 24 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
WriteAttributeValue("", 863, Url.Action("Competition", "Team", new { id = 1 }), 863, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(914, 39, true);
            WriteLiteral(">Go to the Scoresheet</a>\r\n    </div>\r\n");
            EndContext();
#line 26 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
}

#line default
#line hidden
#line 27 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
 if (User.IsInRole("Admin")){

#line default
#line hidden
            BeginContext(987, 147, true);
            WriteLiteral("    <div>\r\n        <span style=\"background-color:deeppink;color:white;padding:10px;font-size:20px\">Administrator</span>\r\n        <br />\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1134, "\"", 1191, 1);
#line 31 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
WriteAttributeValue("", 1141, Url.Action("Competition", "Team", new { id = 1 }), 1141, 50, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1192, 36, true);
            WriteLiteral(">Manage Volunteers</a>\r\n    </div>\r\n");
            EndContext();
#line 33 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Home\Landing.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
