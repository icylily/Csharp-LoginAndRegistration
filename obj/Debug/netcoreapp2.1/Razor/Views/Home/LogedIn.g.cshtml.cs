#pragma checksum "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\RegisterAndLogin\Views\Home\LogedIn.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1a39f3e111f6fea47b29551f8ffd508c6dcdd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_LogedIn), @"mvc.1.0.view", @"/Views/Home/LogedIn.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/LogedIn.cshtml", typeof(AspNetCore.Views_Home_LogedIn))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\RegisterAndLogin\Views\_ViewImports.cshtml"
using RegisterAndLogin;

#line default
#line hidden
#line 2 "C:\Users\Lili\Desktop\Coding Dojo\CSharp\MVC\RegisterAndLogin\Views\_ViewImports.cshtml"
using RegisterAndLogin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1a39f3e111f6fea47b29551f8ffd508c6dcdd7", @"/Views/Home/LogedIn.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"812ba5f9194d9f77b67b238a1bb41da906359bbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_LogedIn : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 49, true);
            WriteLiteral("<h1>Success!!</h1>\r\n\r\n<a href=\"logout\">Logout</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
