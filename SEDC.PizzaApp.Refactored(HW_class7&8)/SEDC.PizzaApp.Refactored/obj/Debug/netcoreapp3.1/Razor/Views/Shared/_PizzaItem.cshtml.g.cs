#pragma checksum "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Shared\_PizzaItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97543b51d1998b4b9b5aeaf27c1f690b18cf6b7b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PizzaItem), @"mvc.1.0.view", @"/Views/Shared/_PizzaItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97543b51d1998b4b9b5aeaf27c1f690b18cf6b7b", @"/Views/Shared/_PizzaItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03933a415ca5203c020e54dc41fdffd9435b4d65", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PizzaItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PizzaViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Shared\_PizzaItem.cshtml"
Write(Html.HiddenFor(x => x.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Pizza ");
#nullable restore
#line 4 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Shared\_PizzaItem.cshtml"
     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 4 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Shared\_PizzaItem.cshtml"
                 Write(Model.Size);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h4>Price ");
#nullable restore
#line 5 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G4\Class10\SEDC.PizzaApp.Refactored\SEDC.PizzaApp.Refactored\Views\Shared\_PizzaItem.cshtml"
     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ??????.</h4>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
