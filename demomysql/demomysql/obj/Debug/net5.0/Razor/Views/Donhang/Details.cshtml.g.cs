#pragma checksum "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da3494e4a529ccc146c0f10d85ef751dd9fb0e2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Donhang_Details), @"mvc.1.0.view", @"/Views/Donhang/Details.cshtml")]
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
#line 2 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\_ViewImports.cshtml"
using demomysql;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
using demomysql.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da3494e4a529ccc146c0f10d85ef751dd9fb0e2b", @"/Views/Donhang/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f81c5a8f26a2633761712ca0e5b925eaff2a7779", @"/Views/_ViewImports.cshtml")]
    public class Views_Donhang_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ctdh>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
  
    Donhang donhang = ViewBag.donghang;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h3>Thông tin đơn hàng: #");
#nullable restore
#line 10 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                    Write(donhang.Madonhang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<div class=\"mt-5 col-md-12\"><strong>Ngày đặt hàng:</strong>  ");
#nullable restore
#line 11 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                                        Write(donhang.Ngaydat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n<address class=\"p-l-10 m-t-10\">\r\n    <span class=\"font-weight-semibold text-dark\"><strong>Họ tên:</strong> ");
#nullable restore
#line 14 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                                                     Write(donhang.Hoten);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br>\r\n    <span><strong>Số điện thoại:</strong> ");
#nullable restore
#line 15 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                     Write(donhang.Sdt);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><br>\r\n    <span> <strong>Địa chỉ:</strong>  ");
#nullable restore
#line 16 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                 Write(donhang.Thanhpho);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 16 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                                    Write(donhang.Quan);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 16 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                                                   Write(donhang.Diachi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n</address>\r\n<div class=\"mt-5 col-md-12\"> <strong>Tình trạng thanh toán:</strong> ");
#nullable restore
#line 18 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                                                Write(donhang.Tinhtrangthanhtoan);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div class=\"mt-5 col-md-12 mb-5\"> <strong>Tổng tiền:</strong> ");
#nullable restore
#line 19 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                                         Write(donhang.Tongdon.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</div>\r\n\r\n");
#nullable restore
#line 21 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
 if (donhang.MavoucherNavigation != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>Tên voucher: ");
#nullable restore
#line 23 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
               Write(donhang.MavoucherNavigation.Tenma);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Tỷ lệ giảm: ");
#nullable restore
#line 24 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
              Write(donhang.MavoucherNavigation.Tyle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</p>\r\n    <p>Giá giảm:");
#nullable restore
#line 25 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
            Write((Model.Sum(x=> x.Soluong*x.Dongia)* donhang.MavoucherNavigation.Tyle/100).Value.ToString("#,##0") );

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <hr>\r\n");
#nullable restore
#line 27 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-responsive table-bordered"">
    <tbody>
        <tr>
            <th style=""width:25%"">Mã đơn hàng</th>
            <th style=""width:25%"">Sản phẩm</th>
            <th>Số lượng</th>
            <th>Đơn giá</th>
            <th>Thành tiền</th>
        </tr>
");
#nullable restore
#line 37 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
         if (Model != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td style=\"width:20%\"><a class=\"account-order-id\" href=\"javascript:void(0)\">#");
#nullable restore
#line 42 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                                                                            Write(item.Madonhang);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                    <td>");
#nullable restore
#line 43 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                   Write(item.MaspNavigation.Tensp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"width:20%\">");
#nullable restore
#line 44 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                     Write(item.Soluong);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"width:20%\">");
#nullable restore
#line 45 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                                     Write(item.Dongia.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 47 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
                    Write((item.Soluong *item.Dongia).Value.ToString("#,##0") );

#line default
#line hidden
#nullable disable
            WriteLiteral("VNĐ\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 50 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "F:\HTTT tren framework\GitHubchinhthuc\framework_IS220.1_09\demomysql\demomysql\Views\Donhang\Details.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ctdh>> Html { get; private set; }
    }
}
#pragma warning restore 1591
