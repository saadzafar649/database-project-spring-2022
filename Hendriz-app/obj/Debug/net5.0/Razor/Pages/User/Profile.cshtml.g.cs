#pragma checksum "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "406f29d6c13f84477fcf475f8a93babd39f2e211"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Hendriz_app.Pages.User.Pages_User_Profile), @"mvc.1.0.razor-page", @"/Pages/User/Profile.cshtml")]
namespace Hendriz_app.Pages.User
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"406f29d6c13f84477fcf475f8a93babd39f2e211", @"/Pages/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a897ea0afb5603696d38c428370217a6662a9019", @"/Pages/_ViewImports.cshtml")]
    public class Pages_User_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    var total = 0;
</script>

<div style=""height:100px""></div>



<!--Profile or user details-->
<div class=""row justify-content-center"">
    <div class=""col-9"" style=""background-color:whitesmoke;border-radius:30px"">
        <div style=""height:20px""></div>
        <h6 class=""row"" style=""margin-left:50px "">Profile</h6>

        <div class=""dropdown-divider""></div>
        <div style=""height:20px""></div>

        <div class=""row"" style=""margin-left:50px;"">
            <div class=""col-2"">
                <h6>Name</h6>
            </div>
            <div class=""col-8"" style=""margin-right:50px;"">
                <p6>");
#nullable restore
#line 28 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
               Write(Model.userdetails.name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p6>
            </div>
        </div>

        <div style=""height:20px""></div>


        <div class=""row"" style=""margin-left:50px;"">
            <div class=""col-2"">
                <h6>Email</h6>
            </div>
            <div class=""col-8"" style=""margin-right:50px;"">
                <p6>");
#nullable restore
#line 40 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
               Write(Model.userdetails.email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p6>
            </div>
        </div>

        <div style=""height:20px""></div>


        <div class=""row"" style=""margin-left:50px;"">
            <div class=""col-2"">
                <h6>Phone No</h6>
            </div>
            <div class=""col-8"" style=""margin-right:50px;"">
                <p6>");
#nullable restore
#line 52 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
               Write(Model.userdetails.phoneNo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p6>
            </div>
        </div>

        <div style=""height:20px""></div>


        <div class=""row"" style=""margin-left:50px;"">
            <div class=""col-2"">
                <h6>Order Address</h6>
            </div>
            <div class=""col-8"" style=""margin-right:50px;"">
                <p6>");
#nullable restore
#line 64 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
               Write(Model.userdetails.address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p6>
            </div>
        </div>

        <div style=""height:20px""></div>
        <div class=""row justify-content-start"" style=""margin-left:50px;"">
            <button onclick=""LogOut()"" style=""width:120px;height:35px;margin-right:50px;border-radius:30px;background-color:rgb(255 106 0)"">Log Out</button>
        </div>
        <div style=""height:40px""></div>
    </div>
</div>

<div style=""height:20px""></div>



<!--Cart items-->
<div class=""row justify-content-center"">
    <div class=""col-9"" style=""background-color:whitesmoke;border-radius:30px"">
        <div style=""height:20px""></div>
        <h6 class=""row"" style=""margin-left:50px "">Shopping Cart</h6>
");
#nullable restore
#line 85 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
         for (int i = 0; i < Model.items.Count; i++)
        {
            int totalprice = (Model.items[i].quantity * (Model.items[i].price - Model.items[i].price * Model.items[i].discount / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral("            <script>\r\n        total += ");
#nullable restore
#line 89 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
            Write(totalprice);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n            </script>\r\n");
            WriteLiteral("            <div class=\"row items\"");
            BeginWriteAttribute("id", " id=\"", 2781, "\"", 2808, 1);
#nullable restore
#line 92 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
WriteAttributeValue("", 2786, Model.items[i].ItemId, 2786, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin:20px\">\r\n                <div class=\"col-lg-3\" style=\"background-color:whitesmoke;\">\r\n                    <div class=\"container\" style=\"margin-top: 10px; margin-bottom: 10px; \">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 3030, "\"", 3057, 1);
#nullable restore
#line 95 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
WriteAttributeValue("", 3036, Model.items[i].image, 3036, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""No image of product found"" style=""max-height:120px;max-width:120px;"" />
                    </div>
                </div>
                <div class=""col"" style=""background-color:whitesmoke;"">
                    <div class=""container"" style=""margin-top: 30px; "">
                        <h5>");
#nullable restore
#line 100 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
                       Write(Model.items[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p>");
#nullable restore
#line 101 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
                      Write(Model.items[i].color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <div class=\"text-end\">\r\n                        <div");
            BeginWriteAttribute("style", " style=\"", 3542, "\"", 3550, 0);
            EndWriteAttribute();
            BeginWriteAttribute("value", " value=", 3551, "", 3582, 1);
#nullable restore
#line 104 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
WriteAttributeValue("", 3558, Model.items[i].quantity, 3558, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <h6>Quantity: ");
#nullable restore
#line 105 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
                                     Write(Model.items[i].quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-2"" style=""background-color:whitesmoke;"">
                    <div class=""container text-lg-end"" id=""price"" style=""margin-top: 30px; "">
                        <h5>$ ");
#nullable restore
#line 111 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
                          Write(Model.items[i].quantity*(Model.items[i].price - Model.items[i].price * Model.items[i].discount / 100));

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp;</h5>\r\n                    </div>\r\n                    <div class=\"container text-lg-end\">\r\n                        <button style=\"border: none; background-color: whitesmoke\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4229, "\"", 4285, 5);
            WriteAttributeValue("", 4239, "removeitem(", 4239, 11, true);
#nullable restore
#line 114 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
WriteAttributeValue("", 4250, totalprice, 4250, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4261, ",", 4261, 1, true);
#nullable restore
#line 114 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
WriteAttributeValue("", 4262, Model.items[i].ItemId, 4262, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4284, ")", 4284, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            <p style=""text-decoration: underline;color:red;font-size:11px"">Remove</p>
                        </button>
                    </div>
                </div>
                <div class=""dropdown-divider""></div>
            </div>
");
#nullable restore
#line 121 "C:\Users\Saad\Desktop\database-project-spring-2022\Hendriz-app\Pages\User\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""row justify-content-end"" style=""margin-left:50px;"">
            <div class=""col-2"">
                <p5>Total: </p5>
            </div>
            <div class=""col-1"" style=""margin-right:50px;"">
                <p id=""total"">
                </p>
            </div>
        </div>

        <div style=""height:20px""></div>
        <div class=""row justify-content-end"">
            <button onclick=""Placeorder()"" style=""width:120px;height:35px;margin-right:50px;border-radius:30px;background-color:rgb(255 106 0)"">Place order</button>
        </div>
        <div style=""height:20px""></div>
    </div>
</div>



<script>
    var totalelement = document.getElementById('total');
    totalelement.innerHTML = '$' + total.toString();
    
    function removeitem(price, id) {
        console.log(id);
        $.ajax({
            url: 'Profile?handler=RemoveItem',
            type: ""GET"",
            data: {
                ""itemid"": parseInt(id),
            },
           ");
            WriteLiteral(@" error: function (xhr, textStatus, errorThrown) {
                alert(""Internal server error"");
            }
        })
            .done(function (result) {
                document.getElementById(id).remove();
                total -= price;
                totalelement.innerHTML = '$' + total.toString();
            })
            .fail(function (result) {
                console.log(result);
            });
    }

    function Placeorder() {
        if (total == 0) {
            alert(""No object in cart to order"");
            return;
        }
        $.ajax({
            url: 'Profile?handler=PlaceOrder',
            type: ""GET"",
            error: function (xhr, textStatus, errorThrown) {
                alert(""Internal server error"");
            }
            
            
        })
            .done(function (result) {
                document.querySelectorAll('.items').forEach(item => {
                    item.remove();
                });
                var to");
            WriteLiteral(@"talelement = document.getElementById('total');
                total = 0;
                totalelement.innerHTML = '$' + total.toString();
            })
            
        .fail(function (result) {
            console.log(result);
        });
    }

    function LogOut() {
        $.ajax({
            url: 'Profile?handler=LogOut',
            type: ""GET"",
            error: function (xhr, textStatus, errorThrown) {
                alert(""Internal server error"");
            }
        })
            .done(function (result) {
                window.location.replace('/Auth/Login');
            })
            .fail(function (result) {
                console.log(result);
            });
    }
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Hendriz_app.Pages.User.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hendriz_app.Pages.User.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Hendriz_app.Pages.User.ProfileModel>)PageContext?.ViewData;
        public Hendriz_app.Pages.User.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
