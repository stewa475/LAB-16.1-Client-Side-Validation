#pragma checksum "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub_2\19_LAB_16.1_CoffeeShopJavaScript\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\ProductsIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94952eda512dff782d0f8d05fd71e91a455f1f7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductsIndex), @"mvc.1.0.view", @"/Views/Product/ProductsIndex.cshtml")]
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
#line 1 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub_2\19_LAB_16.1_CoffeeShopJavaScript\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\_ViewImports.cshtml"
using LAB_11._2_CoffeeShop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub_2\19_LAB_16.1_CoffeeShopJavaScript\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\_ViewImports.cshtml"
using LAB_11._2_CoffeeShop.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94952eda512dff782d0f8d05fd71e91a455f1f7d", @"/Views/Product/ProductsIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29712885550cc76deedb771dbfc067e84f7c5eb9", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductsIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub_2\19_LAB_16.1_CoffeeShopJavaScript\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\ProductsIndex.cshtml"
  
    ViewData["Title"] = "Products";
    List<Product> Products = (List<Product>)ViewData["Products"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""text-left"">

        <h1 class=""display-4"">Menu</h1>
        <br />
        <h2 class=""display-5"">Hot Coffees</h2>
        <p>______________________________________________________________________________________________________________________________________________________________________</p>
        <ul>
");
#nullable restore
#line 14 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub_2\19_LAB_16.1_CoffeeShopJavaScript\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\ProductsIndex.cshtml"
             foreach (Product p in Products)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 531, "\"", 566, 2);
            WriteAttributeValue("", 538, "/Product/Cat?cat=", 538, 17, true);
#nullable restore
#line 16 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub_2\19_LAB_16.1_CoffeeShopJavaScript\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\ProductsIndex.cshtml"
WriteAttributeValue("", 555, p.Category, 555, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 16 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub_2\19_LAB_16.1_CoffeeShopJavaScript\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\ProductsIndex.cshtml"
                                                      Write(p.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 17 "C:\Users\ASteward1\OneDrive - Knex\Documents\GrandCircus_GitHub_2\19_LAB_16.1_CoffeeShopJavaScript\LAB_11.2_CoffeeShop\LAB_11.2_CoffeeShop\Views\Product\ProductsIndex.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n\r\n    </div>\r\n\r\n");
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
