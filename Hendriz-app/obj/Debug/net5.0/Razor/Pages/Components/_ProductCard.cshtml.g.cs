#pragma checksum "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d0139deb523a5046a5a3132809d37ac47786aab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hendriz_app.Pages.Components.Pages_Components__ProductCard), @"mvc.1.0.view", @"/Pages/Components/_ProductCard.cshtml")]
namespace Hendriz_app.Pages.Components
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
#line 1 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\_ViewImports.cshtml"
using Hendriz_app;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\_ViewImports.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d0139deb523a5046a5a3132809d37ac47786aab", @"/Pages/Components/_ProductCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a897ea0afb5603696d38c428370217a6662a9019", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Components__ProductCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Models.ProductCard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"product-item\">\r\n        <a");
            BeginWriteAttribute("href", " href=\'", 73, "\'", 106, 2);
            WriteAttributeValue("", 80, "/User/Product?id=", 80, 17, true);
#nullable restore
#line 5 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
WriteAttributeValue("", 97, Model.Id, 97, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=", 112, "", 129, 1);
#nullable restore
#line 5 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
WriteAttributeValue("", 117, Model.image, 117, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 129, "\"", 135, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"max-height:400px\"></a>\r\n        <div class=\"down-content\">\r\n            <a");
            BeginWriteAttribute("href", " href=\'", 218, "\'", 251, 2);
            WriteAttributeValue("", 225, "/User/Product?id=", 225, 17, true);
#nullable restore
#line 7 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
WriteAttributeValue("", 242, Model.Id, 242, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h4>");
#nullable restore
#line 8 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
               Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            </a>\r\n            <h6>$");
#nullable restore
#line 10 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
            Write(Model.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n            <p>");
#nullable restore
#line 11 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
          Write(Model.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n            <p>");
#nullable restore
#line 13 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
          Write(Model.watchcount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Views</p>\r\n            <ul class=\"stars\">\r\n");
#nullable restore
#line 15 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
                   for (int k = 0; k < Model.stars; k++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <i class=\"fa fa-star\"></i>\r\n                </li>\r\n");
#nullable restore
#line 20 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
                }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n            <span>Reviews (");
#nullable restore
#line 23 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Components\_ProductCard.cshtml"
                      Write(Model.reviewCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n        </div>\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Models.ProductCard> Html { get; private set; }
    }
}
#pragma warning restore 1591
