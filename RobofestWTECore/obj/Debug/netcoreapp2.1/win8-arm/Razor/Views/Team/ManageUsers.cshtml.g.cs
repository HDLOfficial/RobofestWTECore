#pragma checksum "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aed2120e94da801e0a706738124667e5a662fd6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RobofestWTECore.Pages.Team.Views_Team_ManageUsers), @"mvc.1.0.view", @"/Views/Team/ManageUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Team/ManageUsers.cshtml", typeof(RobofestWTECore.Pages.Team.Views_Team_ManageUsers))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aed2120e94da801e0a706738124667e5a662fd6f", @"/Views/Team/ManageUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce755af2a7418f0d746543a6139563ea8d84f149", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_ManageUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<RobofestWTE.Models.UserListModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.signalR-2.4.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/signalr/hubs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-3.3.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("integrity", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("crossorigin", new global::Microsoft.AspNetCore.Html.HtmlString("anonymous"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
  
    ViewBag.Title = "Users";

#line default
#line hidden
            BeginContext(86, 3143, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e65ec78dc94d471db9578dedc449efbd", async() => {
                BeginContext(92, 409, true);
                WriteLiteral(@"
    <h2>Volunteer & Student Management</h2>

    <table class=""table table-hover"">
        <tr style=""font-size:20px"">
            <th style=""background-color:#ffffff"">
                Username
            </th>
            <th style=""background-color:#ffffff"">
                Role(s)
            </th>
            <th>
                Add or Remove
            </th>
        </tr>
        
");
                EndContext();
#line 22 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
         foreach (var user in Model)
        {


#line default
#line hidden
                BeginContext(552, 60, true);
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(613, 13, false);
#line 27 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
               Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(626, 44, true);
                WriteLiteral("\r\n                </td>\r\n                <td");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 670, "\"", 689, 1);
#line 29 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 675, user.UserName, 675, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 690, "\"", 712, 1);
#line 29 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 698, user.UserName, 698, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(713, 3, true);
                WriteLiteral(">\r\n");
                EndContext();
#line 30 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                      
                        int i = 0;
                    

#line default
#line hidden
                BeginContext(799, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 33 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                     foreach (var role in user.Roles)
                    {
                        i++;
                        if (role == "Judge")
                        {

#line default
#line hidden
                BeginContext(980, 120, true);
                WriteLiteral("                            <span style=\"background-color:blue;color:white;padding:3px;border-radius:2px\">Judge</span>\r\n");
                EndContext();
#line 39 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }
                        else if (role == "Field Staff")
                        {

#line default
#line hidden
                BeginContext(1211, 131, true);
                WriteLiteral("                            <span style=\"background-color:lightblue;color:black;padding:3px;border-radius:2px\">Field Staff</span>\r\n");
                EndContext();
#line 43 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }
                        else if (role == "Manager")
                        {

#line default
#line hidden
                BeginContext(1449, 131, true);
                WriteLiteral("                            <span style=\"background-color:darkorchid;color:white;padding:3px;border-radius:2px\">Management</span>\r\n");
                EndContext();
#line 47 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }
                        else if (role == "Admin")
                        {

#line default
#line hidden
                BeginContext(1685, 124, true);
                WriteLiteral("                            <span style=\"background-color:deeppink;color:white;padding:3px;border-radius:2px\">Admin</span>\r\n");
                EndContext();
#line 51 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }
                        else if (role == "Banned")
                        {

#line default
#line hidden
                BeginContext(1915, 119, true);
                WriteLiteral("                            <span style=\"border:2px red dashed;color:red;padding:3px;border-radius:2px\">Banned</span>\r\n");
                EndContext();
#line 55 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2118, 139, true);
                WriteLiteral("                            <span style=\"background-color:lightgray;color:black;padding:3px;border-radius:2px\">Student / Spectator</span>\r\n");
                EndContext();
#line 59 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                        }

                    }

#line default
#line hidden
                BeginContext(2309, 20, true);
                WriteLiteral("                    ");
                EndContext();
#line 62 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                     if (i == 0)
                    {

#line default
#line hidden
                BeginContext(2366, 135, true);
                WriteLiteral("                        <span style=\"background-color:lightgray;color:black;padding:3px;border-radius:2px\">Student / Spectator</span>\r\n");
                EndContext();
#line 65 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
                    }

#line default
#line hidden
                BeginContext(2524, 100, true);
                WriteLiteral("                </td>\r\n                <td>\r\n                    <button type=\"button\" class=\"judge\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2624, "\"", 2641, 1);
#line 68 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 2629, user.UserID, 2629, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2642, "\"", 2664, 1);
#line 68 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 2650, user.UserName, 2650, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2665, 74, true);
                WriteLiteral(">Judge</button>\r\n                    <button type=\"button\" class=\"manager\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2739, "\"", 2756, 1);
#line 69 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 2744, user.UserID, 2744, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2757, "\"", 2779, 1);
#line 69 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 2765, user.UserName, 2765, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2780, 79, true);
                WriteLiteral(">Manager</button>\r\n                    <button type=\"button\" class=\"fieldstaff\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2859, "\"", 2876, 1);
#line 70 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 2864, user.UserID, 2864, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2877, "\"", 2899, 1);
#line 70 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 2885, user.UserName, 2885, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2900, 78, true);
                WriteLiteral(">Field Staff</button>\r\n                    <button type=\"button\" class=\"admin\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 2978, "\"", 2995, 1);
#line 71 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 2983, user.UserID, 2983, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2996, "\"", 3018, 1);
#line 71 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3004, user.UserName, 3004, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3019, 73, true);
                WriteLiteral(">Admin</button>\r\n                    <button type=\"button\" class=\"banned\"");
                EndContext();
                BeginWriteAttribute("id", " id=\"", 3092, "\"", 3109, 1);
#line 72 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3097, user.UserID, 3097, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3110, "\"", 3132, 1);
#line 72 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
WriteAttributeValue("", 3118, user.UserName, 3118, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3133, 60, true);
                WriteLiteral(">Banned</button>\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 75 "C:\Users\djree\source\repos\HDLOfficial\RobofestWTECore\RobofestWTECore\Views\Team\ManageUsers.cshtml"
        }

#line default
#line hidden
                BeginContext(3204, 18, true);
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
            BeginContext(3229, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3249, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3255, 61, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "21e774c0bd0a41c6a2b5aafbe0bf7d47", async() => {
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
                BeginContext(3316, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3322, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c1d7d6894d724b2c984a05368f8021ce", async() => {
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
                BeginContext(3360, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(3365, 86, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "297a2622137d45daa213504079dfed7a", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3451, 1550, true);
            WriteLiteral(@"
<script src=""https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.12.9/umd/popper.min.js"" integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q"" crossorigin=""anonymous""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/js/bootstrap.min.js"" integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl"" crossorigin=""anonymous""></script>
<script>
    $(function () {
        // Reference the auto-generated proxy for the hub.
        var chat = $.connection.scoreHub;
        $.connection.hub.start().done(function () {
            $("".judge"").click(function () {
                var username = $(this).val();
                chat.server.updateUserRoleAsync(username, ""Judge"");
            });
            $("".manager"").click(function () {
                var username = $(this).val();
                chat.server.updateUserRoleAsync(username, ""Manager"");
            });
            $("".fieldstaff"").click(function () {
                v");
            WriteLiteral(@"ar username = $(this).val();
                chat.server.updateUserRoleAsync(username, ""FieldStaff"");
            });
            $("".admin"").click(function () {
                var username = $(this).val();
                chat.server.updateUserRoleAsync(username, ""Admin"");
            });
            $("".banned"").click(function () {
                var username = $(this).val();
                chat.server.updateUserRoleAsync(username, ""Banned"");
            });
        
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<RobofestWTE.Models.UserListModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591