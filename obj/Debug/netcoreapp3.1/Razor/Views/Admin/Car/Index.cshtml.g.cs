#pragma checksum "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Car\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9baf084b3e5f572b0523fa56b835e403b3016e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Car_Index), @"mvc.1.0.view", @"/Views/Admin/Car/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9baf084b3e5f572b0523fa56b835e403b3016e62", @"/Views/Admin/Car/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"58fc6815d49b1557eacfc6121e502d4884c4f963", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Car_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Car\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Xe";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- Card deck -->
<div class=""card-deck"">

    <div class=""row w-100"">
        <div class=""col-4"">
            <div class=""card mb-4"">

                <!--Card image-->
                <div class=""view overlay"">
                <img class=""card-img-top"" src=""https://mdbootstrap.com/img/Photos/Others/images/14.jpg""
                    alt=""Card image cap"">
                <a href=""#!"">
                    <div class=""mask rgba-white-slight""></div>
                </a>
                </div>

                <!--Card content-->
                <div class=""card-body"">

                <!--Title-->
                <h4 class=""card-title"">Car #0143</h4>
                <!--Text-->
                <p class=""card-text"">Lưu ý : thay dầu xe cuối tháng này</p>
                <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Lái xe:  </span> Nguyễn Văn A </p>
                <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Phụ xe:  </span> Nguyễn Văn B <");
            WriteLiteral(@"/p>
                <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Thời gian:  </span> 20 : 10 - 15 - 6 - 2020</p>
                <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Hành trình:  </span> Đà Nẵng Hà Nội</p>
                <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Trạng thái: </span>  Đã xuất phát </p>
                <!-- Provides extra visual weight and identifies the primary action in a set of buttons -->
                <button type=""button"" class=""btn btn-light-blue btn-md"">Chi tiết</button>

                </div>

            </div>
        </div>
    </div>

  <!-- Card -->

  <!-- Card -->



</div>
<!-- Card deck -->");
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