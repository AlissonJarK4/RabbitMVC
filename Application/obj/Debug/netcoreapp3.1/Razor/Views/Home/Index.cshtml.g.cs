#pragma checksum "C:\Users\ALISSON.JARDEL\source\repos\RabbitApp\Application\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7dc07d1d55fd3a4dc8399419d0a1e0ab187fa4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\ALISSON.JARDEL\source\repos\RabbitApp\Application\Views\_ViewImports.cshtml"
using RabbitApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ALISSON.JARDEL\source\repos\RabbitApp\Application\Views\_ViewImports.cshtml"
using RabbitApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7dc07d1d55fd3a4dc8399419d0a1e0ab187fa4a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd3c61f8a9830491decdeecc81ff86eae61c7c3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ALISSON.JARDEL\source\repos\RabbitApp\Application\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""//ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js""></script>
<script>
    function SendMessage() {
        $.get(""/Home/SendMessage"");
    }
    function ReceiveMessage() {
        $.get(""/Home/ReceiveMessage"");

        var x = document.getElementById(""consumer"");
        if (x.style.display === ""none"") {
        x.style.display = ""block"";
        } else {
        x.style.display = ""none"";
        }
    }
</script>
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
<div class=""text-center"">
    <button runat=""server"" useSubmitBehavior=""false"" onclick=""ReceiveMessage()"" id=""consumer"">Create consumer</button>
    <button runat=""server"" useSubmitBehavior=""false"" onclick=""SendMessage()"">Send message</button>
</div>");
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
