#pragma checksum "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5efe1b9cd01b9ddad2a2a6b83163c32c4222bf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
#line 1 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\_ViewImports.cshtml"
using SEDC.PizzaApp.Refactored.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5efe1b9cd01b9ddad2a2a6b83163c32c4222bf2", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03933a415ca5203c020e54dc41fdffd9435b4d65", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserItemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\User\Index.cshtml"
 for (int i = 0; i < Model.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul>\r\n        <li>User name: ");
#nullable restore
#line 6 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\User\Index.cshtml"
                  Write(Model[i].GetFullName());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n    <br />\r\n");
#nullable restore
#line 9 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\User\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591