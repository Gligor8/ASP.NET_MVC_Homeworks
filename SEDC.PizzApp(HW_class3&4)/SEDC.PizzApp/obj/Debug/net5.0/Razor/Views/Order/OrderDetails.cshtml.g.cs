#pragma checksum "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G5\Class 05\SEDC.PizzApp\SEDC.PizzApp\Views\Order\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e785d85902ee56a260ce67c2cc0a4aa0f45d8fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderDetails), @"mvc.1.0.view", @"/Views/Order/OrderDetails.cshtml")]
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
#line 1 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G5\Class 05\SEDC.PizzApp\SEDC.PizzApp\Views\_ViewImports.cshtml"
using SEDC.PizzApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G5\Class 05\SEDC.PizzApp\SEDC.PizzApp\Views\_ViewImports.cshtml"
using SEDC.PizzApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e785d85902ee56a260ce67c2cc0a4aa0f45d8fd", @"/Views/Order/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c61a5641bf918fa021ea3a268adf36fda618d58", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("//(============================= Homework 3 =============================)\r\n\r\n\r\n\r\n<h1>Order details</h1>\r\n<ul>\r\n    <li>ID: ");
#nullable restore
#line 8 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G5\Class 05\SEDC.PizzApp\SEDC.PizzApp\Views\Order\OrderDetails.cshtml"
       Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Full name: ");
#nullable restore
#line 9 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G5\Class 05\SEDC.PizzApp\SEDC.PizzApp\Views\Order\OrderDetails.cshtml"
               Write("Mr/s." + Model.User.FirstName + Model.User.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Pizza: ");
#nullable restore
#line 10 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G5\Class 05\SEDC.PizzApp\SEDC.PizzApp\Views\Order\OrderDetails.cshtml"
          Write(Model.Pizza);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Price: ");
#nullable restore
#line 11 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G5\Class 05\SEDC.PizzApp\SEDC.PizzApp\Views\Order\OrderDetails.cshtml"
          Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Delivered: ");
#nullable restore
#line 12 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G5\Class 05\SEDC.PizzApp\SEDC.PizzApp\Views\Order\OrderDetails.cshtml"
              Write(Model.Delivered);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\Gligor\Desktop\Code Classes\ASP.NET_MVC\MVC_Classes\skwd9-net-08-aspnetmvc\G5\Class 05\SEDC.PizzApp\SEDC.PizzApp\Views\Order\OrderDetails.cshtml"
  
    string statusDelivery = "Not yet delivered.";

    Model.Delivered = true;

    if (Model.Delivered)
    {
        statusDelivery = "Delivered!";
    }

    for (int i = 0; i < 10; i++)
    {
        statusDelivery += i.ToString();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
