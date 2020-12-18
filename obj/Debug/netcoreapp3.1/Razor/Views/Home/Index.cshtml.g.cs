#pragma checksum "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dad220b6f0bbcd92753eb7952416f2e70a6d3ed5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dad220b6f0bbcd92753eb7952416f2e70a6d3ed5", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Trang chủ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
 <!-- HEADER  -->
    <header class=""header"">
        <div class=""container d-flex justify-content-between align-items-center h-100 text-center"">
            <div class=""header__content mx-auto"">
                <div class=""header__heading"">
                    VeXeRe - Hệ thống đặt vé xe khách Việt Nam
                </div>
");
            WriteLiteral(@"            </div>
        </div>
    </header>
    <!-- BANNER  -->

    <div class=""banner"">
        <div class=""container"">
            <h2 class=""banner__heading heading"">
                <h1>Ưu đãi nổi bật</h1>
            </h2>
            <div class=""row"">
                <div class=""col-12 col-md-4"">
                    <div class=""banner__item"">
                        <img class=""img-fluid"" src=""./assets/images/banner-home-(1).png""");
            BeginWriteAttribute("alt", " alt=\"", 1803, "\"", 1809, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                            class=""banner__item-img"">
                    </div>
                </div>
                <div class=""col-12 col-md-4"">
                    <div class=""banner__item"">
                        <img class=""img-fluid"" src=""./assets/images/banner-home.png""");
            BeginWriteAttribute("alt", " alt=\"", 2098, "\"", 2104, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""banner__item-img"">
                    </div>
                </div>
                <div class=""col-12 col-md-4"">
                    <div class=""banner__item"">
                        <img class=""img-fluid"" src=""./assets/images/banner-trang-chu-ok.png""");
            BeginWriteAttribute("alt", " alt=\"", 2372, "\"", 2378, 0);
            EndWriteAttribute();
            WriteLiteral(@"
                            class=""banner__item-img"">
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- SERVICE  -->
    <div class=""service"">
        <div class=""container"">
            <h2 class=""service__heading heading"">
                <h1>Hệ thống vé xe khách Limo</h1>
            </h2>
            <div class=""row"">
                <div class=""col-6 col-md-3"">
                    <div class=""service__item d-flex justify-content-center"">
                        <div class=""d-flex"">
                            <img src=""./assets/images/static-icon-1.svg""");
            BeginWriteAttribute("alt", " alt=\"", 3017, "\"", 3023, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""service__item-img"">
                            <div class=""service__item-content "">
                                <h4 class=""service__item-qty"">
                                    5000+
                                </h4>
                                <span class=""service__title"">
                                    Tuyến đường
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-6 col-md-3"">
                    <div class=""service__item d-flex justify-content-center"">
                        <div class=""d-flex"">
                            <img src=""./assets/images/static-icon-2.svg""");
            BeginWriteAttribute("alt", " alt=\"", 3781, "\"", 3787, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""service__item-img"">
                            <div class=""service__item-content "">
                                <h4 class=""service__item-qty"">
                                    10+
                                </h4>
                                <span class=""service__title"">
                                    Nhà xe
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-6 col-md-3"">
                    <div class=""service__item d-flex justify-content-center"">
                        <div class=""d-flex"">
                            <img src=""./assets/images/static-icon-3.svg""");
            BeginWriteAttribute("alt", " alt=\"", 4538, "\"", 4544, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""service__item-img"">
                            <div class=""service__item-content "">
                                <h4 class=""service__item-qty"">
                                    500+
                                </h4>
                                <span class=""service__title"">
                                    Đại lý bán vé
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-6 col-md-3"">
                    <div class=""service__item d-flex justify-content-center"">
                        <div class=""d-flex"">
                            <img src=""./assets/images/static-icon-4.svg""");
            BeginWriteAttribute("alt", " alt=\"", 5303, "\"", 5309, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""service__item-img"">
                            <div class=""service__item-content "">
                                <h4 class=""service__item-qty"">
                                    6+
                                </h4>
                                <span class=""service__title"">
                                    Bến xe
                                </span>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <!-- ROOM HOT -->
    <div class=""room-hot"">
        <div class=""container"">
            <h2 class=""room-hot__heading heading"">
                <h1>Vé sale</h1>
            </h2>
            <div class=""row"">

");
#nullable restore
#line 139 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
                 foreach (var item in  ViewBag.Tickets)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 col-md-3\">\r\n                        <div class=\"room-hot__item\">\r\n                            <div class=\"room-hot__img\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 6380, "\"", 6405, 1);
#nullable restore
#line 144 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
WriteAttributeValue("", 6386, item.Car.Thumbnail, 6386, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 6406, "\"", 6412, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <h2 class=\"room-hot__title\">                           \r\n                                ");
#nullable restore
#line 147 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
                           Write(item.Route.StartPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 147 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
                                                    Write(item.Route.EndPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </h2>\r\n                            <p class=\"room-hot__price\">\r\n                                ");
#nullable restore
#line 150 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" vnđ
                            </p>
                            <div class=""room-hot__author d-flex justify-content-between "">
                                <span class=""room-hot__author-name"">
                                    <i class=""far fa-smile""></i>
                                    <a");
            BeginWriteAttribute("href", " href=\"", 7057, "\"", 7064, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral("                                    </a>\r\n                                </span>\r\n                                <span class=\"room-hot__author-phone\">\r\n                                    <i class=\"fas fa-mobile-alt\"></i>\r\n");
            WriteLiteral("                                </span>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 166 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

            </div>
        </div>
    </div>

    <!-- NEWS  -->

    <div class=""news"">
        <div class=""container"">
            <h2 class=""news__heading heading"">
                <h1>Tin tức</h1>
            </h2>
            <div class=""row"">

");
#nullable restore
#line 257 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
             foreach (var item in ViewBag.Posts)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12 col-md-3\">\r\n                        <div class=\"news__item\">\r\n                            <div class=\"news__img\">\r\n                                <img class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 12076, "\"", 12097, 1);
#nullable restore
#line 262 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
WriteAttributeValue("", 12082, item.Thumbnail, 12082, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 12098, "\"", 12104, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            </div>\r\n                            <h2 class=\"news__title\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 12232, "\"", 12260, 2);
            WriteAttributeValue("", 12239, "/blog/detail/", 12239, 13, true);
#nullable restore
#line 265 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
WriteAttributeValue("", 12252, item.Id, 12252, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                    ");
#nullable restore
#line 266 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
                               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </a>\r\n                            </h2>\r\n                            <div class=\"news__description\">\r\n                                ");
#nullable restore
#line 270 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
                           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 274 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Home\Index.cshtml"
                
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            DefineSection("Script", async() => {
                WriteLiteral(@"
     <script>
        $(function () {
            $('input[id$=datepicker]').datepicker({
                dateFormat: 'dd/mm/yy'
            });
            const now = new Date();
            $(""#datepicker"").val(now.toLocaleDateString('en-GB'));
        });

    </script>
    ");
            }
            );
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
