#pragma checksum "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da9d47939ba4bfd872bc5c8c743afb55d1ae377e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hendriz_app.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace Hendriz_app.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9d47939ba4bfd872bc5c8c743afb55d1ae377e", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3826b85770bdf71294972715a5ae16f9b88bebe", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<!--Slider-->
<div class=""banner header-text"">
    <div class=""owl-banner owl-carousel"">
        <div class=""banner-item-0"" style=""background-image: url(assets/images/slide_01.jpg);"">
            <div class=""text-content"">
                <h4>Best Offer</h4>
                <h2>New Arrivals On Sale</h2>
            </div>
        </div>
        <div class=""banner-item-0"" style=""background-image: url(assets/images/slide_02.jpg);"">
            <div class=""text-content"">
                <h4>Flash Deals</h4>
                <h2>Get your best products</h2>
            </div>
        </div>
        <div class=""banner-item-0"" style=""background-image: url(assets/images/slide_03.jpg);"">
            <div class=""text-content"">
                <h4>Last Minute</h4>
                <h2>Grab last minute deals</h2>
            </div>
        </div>
    </div>
</div>


<!--Slider end-->
<!--Latest products-->
<div class=""latest-products"">
    <div class=""container"">
        <div class=""row"">");
            WriteLiteral(@"
            <div class=""col-md-12"">
                <div class=""section-heading"">
                    <h2>Latest Products</h2>
                    <a href=""products.html"">view all products <i class=""fa fa-angle-right""></i></a>
                </div>
            </div>
");
#nullable restore
#line 45 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
              
                for (int i = 0; i < 3; i++)
                {
                    string link = "#";
                    string imagesrc = "https://picsum.photos/500/300?random="+@i.ToString();
                    Random rand=new Random();
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-4\">\r\n                        <div class=\"product-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=", 1759, "", 1770, 1);
#nullable restore
#line 53 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
WriteAttributeValue("", 1765, link, 1765, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=", 1775, "", 1789, 1);
#nullable restore
#line 53 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
WriteAttributeValue("", 1780, imagesrc, 1780, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1789, "\"", 1795, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                            <div class=\"down-content\">\r\n                                <a");
            BeginWriteAttribute("href", " href=", 1893, "", 1904, 1);
#nullable restore
#line 55 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
WriteAttributeValue("", 1899, link, 1899, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <h4>Title goes here</h4>\r\n                                </a>\r\n                                <h6>$");
#nullable restore
#line 58 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
                                 Write(rand.Next(1,100)+Math.Round( rand.NextDouble(),2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                                <ul class=""stars"">
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                </ul>
                                <span>");
            WriteLiteral("Reviews (24)</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 81 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</div>


<!--Latest products ends-->


<!--discounted products-->
<div class=""latest-products"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""section-heading"">
                    <h2>Discounted Products</h2>
                    <a href=""products.html"">view all products <i class=""fa fa-angle-right""></i></a>
                </div>
            </div>
");
#nullable restore
#line 101 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
              
                for (int i = 0; i < 3; i++)
                {
                    string link = "#";
                    string imagesrc = "https://picsum.photos/500/300?random=" + @i.ToString();
                    Random rand = new Random();
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"col-md-4\">\r\n                        <div class=\"product-item\">\r\n                            <a");
            BeginWriteAttribute("href", " href=", 4129, "", 4140, 1);
#nullable restore
#line 109 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
WriteAttributeValue("", 4135, link, 4135, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=", 4145, "", 4159, 1);
#nullable restore
#line 109 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
WriteAttributeValue("", 4150, imagesrc, 4150, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4159, "\"", 4165, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                            <div class=\"down-content\">\r\n                                <a");
            BeginWriteAttribute("href", " href=", 4263, "", 4274, 1);
#nullable restore
#line 111 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
WriteAttributeValue("", 4269, link, 4269, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    <h4>Title goes here</h4>\r\n                                </a>\r\n                                <h6>$");
#nullable restore
#line 114 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
                                 Write(rand.Next(1,100)+Math.Round( rand.NextDouble(),2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                <p>Lorem ipsume dolor sit amet, adipisicing elite. Itaque, corporis nulla aspernatur.</p>
                                <ul class=""stars"">
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                    <li>
                                        <i class=""fa fa-star""></i>
                                    </li>
                                </ul>
                                <span>");
            WriteLiteral("Reviews (24)</span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 137 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n<!--discounted products ends-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
