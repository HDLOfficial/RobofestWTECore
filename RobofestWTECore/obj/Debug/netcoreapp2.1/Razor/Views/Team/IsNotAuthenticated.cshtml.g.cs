#pragma checksum "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\IsNotAuthenticated.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33f0147d249caf870f07c1ec588828aac47c2f97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_IsNotAuthenticated), @"mvc.1.0.view", @"/Views/Team/IsNotAuthenticated.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/IsNotAuthenticated.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_IsNotAuthenticated))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33f0147d249caf870f07c1ec588828aac47c2f97", @"/Views/Team/IsNotAuthenticated.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_IsNotAuthenticated : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RobofestWTE.Models.MatchDataModel>
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\djree\source\repos\RobofestWTEOfficial\RobofestWTECore\RobofestWTECore\Views\Team\IsNotAuthenticated.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(81, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(85, 1445, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca39ab92c5ea4ba984b15045b5a04775", async() => {
                BeginContext(91, 1432, true);
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

                    /* Cre");
                WriteLiteral(@"ate an active/current tablink class */
                    .tab button.active {
                        background-color: #ccc;
                    }
        </style>
        <div style=""text-align:center"">
            <h2>Not Allowed!</h2>
            <h3>You are not authenticated to view this page!</h3>
            <button onclick=""goBack()"">Previous Page</button>
        </div>
        
    ");
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
            BeginContext(1530, 105, true);
            WriteLiteral("\r\n    <script>\r\n        function goBack() {\r\n            window.history.back();\r\n        }\r\n    </script>");
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
