#pragma checksum "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0963a67a4c040d290609d599c2b6fc382bec7d4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ThongKe_TK_NhaVanChuyen), @"mvc.1.0.view", @"/Areas/Admin/Views/ThongKe/TK_NhaVanChuyen.cshtml")]
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
#line 1 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Areas\Admin\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Areas\Admin\Views\_ViewImports.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0963a67a4c040d290609d599c2b6fc382bec7d4b", @"/Areas/Admin/Views/ThongKe/TK_NhaVanChuyen.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06652b0cc81f2d191b5af8090e20dd00b01c0e55", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ThongKe_TK_NhaVanChuyen : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
  
    ViewData["Title"] = "Thống kê nhà vận chuyển";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";


#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
  
    var list_nvc = (SortedList<string, int>)ViewBag.ListNVC; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   -
<div class=""card"">
    <div class=""card-body"">
        <div class=""d-flex justify-content-between align-items-center"">
            <h5>Thống kê nhà vận chuyển </h5>

        </div>
        <div class=""m-t-30"">
            <div class=""table-responsive"">
                <table class=""table table-hover"">
                    <thead>
                        <tr>
                            <th>Tên nhà vận chuyển</th>
                            <th>Số lượng</th>

                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 29 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
                         if (list_nvc != null)
                        {
                            foreach (var item in list_nvc)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 35 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
                                   Write(item.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 38 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
                                   Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n\r\n                                </tr>\r\n");
#nullable restore
#line 42 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Areas\Admin\Views\ThongKe\TK_NhaVanChuyen.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
