#pragma checksum "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49423baaeb6c19e5205ffb22f07e7bb9667e95f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49423baaeb6c19e5205ffb22f07e7bb9667e95f5", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Blog\Detail.cshtml"
  
    Layout = "_Layout";
    ViewBag.Title = "Tin tức";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Main -->\r\n\r\n<div class=\"container\" style=\"margin-top:70px\">\r\n     <h2 class=\"about__heading display-4 my-5 py-3\">\r\n        ");
#nullable restore
#line 10 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Blog\Detail.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </h2>

<div id=""blog-content"" class=""card card-cascade wider reverse mb-5"">
 
  <!-- Card image -->
  <div class=""view view-cascade overlay"">
    <img class=""card-img-top"" src=""https://mdbootstrap.com/img/Photos/Slides/img%20(70).jpg""
      alt=""Card image cap"">
    <a href=""#!"">
      <div class=""mask rgba-white-slight""></div>
    </a>
  </div>

  <!-- Card content -->
  <div class=""card-body card-body-cascade text-center mb-5"">

    <!-- Title -->
    <strong>20/12/2020</strong>
    <!-- Subtitle -->
    <!-- Text -->
    <p class=""card-text"">
        ");
#nullable restore
#line 32 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Blog\Detail.cshtml"
   Write(Html.Raw(@Model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <div class=\"content\">\r\n        ");
#nullable restore
#line 35 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Blog\Detail.cshtml"
   Write(Html.Raw(@Model.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n  </div>\r\n</div>\r\n</div>\r\n<!-- Card -->\r\n\r\n");
            DefineSection("Css", async() => {
                WriteLiteral(@"
    <style>
        #blog-content p{
            font-size: 14px !important;
        }
        #blog-content h4{
            font-size: 20px !important;
        }
        #blog-content h6{
            font-size: 18px !important;
        }

        .pagination a{
            font-size: 16px !important;
        }
    </style>
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
