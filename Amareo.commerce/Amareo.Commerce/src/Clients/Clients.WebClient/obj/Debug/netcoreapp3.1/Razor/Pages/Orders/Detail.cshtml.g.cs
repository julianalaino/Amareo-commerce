#pragma checksum "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0157701abdd53e956770046c624e8f8d8c33a8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Clients.WebClient.Pages.Orders.Pages_Orders_Detail), @"mvc.1.0.razor-page", @"/Pages/Orders/Detail.cshtml")]
namespace Clients.WebClient.Pages.Orders
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
#line 1 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\_ViewImports.cshtml"
using Clients.WebClient;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/orders/{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0157701abdd53e956770046c624e8f8d8c33a8c", @"/Pages/Orders/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68d7a4ff884a08fa95a9da95927203ab7d26f4a1", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Orders_Detail : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
  
    ViewData["Title"] = Model.Order.OrderNumber;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
                 Write(Model.Order.OrderNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<p>Información de la orden de compra</p>\n\n<p><b>Cliente</b>: ");
#nullable restore
#line 11 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
              Write(Model.Order.Client.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p><b>Método de pago</b>: ");
#nullable restore
#line 12 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
                     Write(Model.Order.PaymentType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p><b>Estado</b>: ");
#nullable restore
#line 13 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
             Write(Model.Order.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>

<table class=""table table-hover mt-5"">
    <thead>
        <tr>
            <th>Item</th>
            <th class=""text-right"">Precio</th>
            <th class=""text-right"">Cantidad</th>
            <th class=""text-right"">Total</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 25 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
         foreach (var item in Model.Order.Items)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 28 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
               Write(item.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"width:100px;\" class=\"text-right\">");
#nullable restore
#line 29 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
                                                       Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"width:100px;\" class=\"text-right\">");
#nullable restore
#line 30 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
                                                       Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td style=\"width:140px;\" class=\"text-right\">");
#nullable restore
#line 31 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
                                                       Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 33 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n    <tfoot>\n        <tr>\n            <td colspan=\"3\"></td>\n            <td class=\"text-right font-weight-bold\" style=\"font-size:1.2em;\">");
#nullable restore
#line 38 "C:\Proyectos\Microservicios\Amareo.commerce\Amareo.Commerce\src\Clients\Clients.WebClient\Pages\Orders\Detail.cshtml"
                                                                        Write(Model.Order.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n</table>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clients.WebClient.Pages.Orders.DetailModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clients.WebClient.Pages.Orders.DetailModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Clients.WebClient.Pages.Orders.DetailModel>)PageContext?.ViewData;
        public Clients.WebClient.Pages.Orders.DetailModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591