#pragma checksum "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6e73775defe15633ef73e15fbf1f7a16df88b76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_GioHang_Index_GioHang), @"mvc.1.0.view", @"/Views/GioHang/Index_GioHang.cshtml")]
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
#line 1 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\_ViewImports.cshtml"
using doan;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
using doan.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6e73775defe15633ef73e15fbf1f7a16df88b76", @"/Views/GioHang/Index_GioHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41b37742cf350e2c7d5a13df020201896b51862", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_GioHang_Index_GioHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/DonDatHang/Index_DDH"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("checkout"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
  
    ViewData["Title"] = "Giỏ hàng";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
  
    List<GioHang> list_cart_item = (List<GioHang>)ViewBag.carts;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Begin Main Content Area -->
<main class=""main-content"">
    <div class=""breadcrumb-area"" style=""height:150px"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <ul>
                            <li>
                                <a href=""/home"" style=""font-family:'Segoe UI'; font-size: 18px"">Trang chủ <i class=""pe-7s-angle-right""></i></a>
                            </li>
                            <li style=""font-family:'Segoe UI'; font-size: 18px"">Giỏ hàng</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
#nullable restore
#line 30 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
     if (list_cart_item == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"text-center p-100 section-space-bottom-100\" style=\"text-align: center; justify-content: center\">\r\n            <p");
            BeginWriteAttribute("class", " class=\"", 1121, "\"", 1129, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"font-family:\'Segoe UI\'; font-size: 18px\">Giỏ hàng của bạn đang trống!</p>\r\n            <br/>   \r\n            <a class=\"btn btn-custom-size lg-size btn-warning btn-dark-hover rounded\" href=\"/Sanpham\">Mua sắm ngay!</a>\r\n        </div>\r\n");
#nullable restore
#line 37 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"cart-area pt-9 section-space-bottom-100\">\r\n                <div class=\"container\">\r\n                    <div class=\"row\">\r\n                        <div class=\"col-12\">\r\n");
#nullable restore
#line 44 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                               
                                var tongtien = 0;
                            

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""table-content table-responsive"">
                                    <table class=""table"">
                                        <thead>
                                            <tr>
                                                <th class=""product_remove"">Xóa</th>
                                                <th class=""product-thumbnail"">Hình ảnh</th>
                                                <th class=""cart-product-name"">Tên sản phẩm</th>
                                                <th class=""product-price"">Giá sản phẩm</th>
                                                <th class=""product-quantity"">Số lượng</th>
                                                <th class=""product-subtotal"">Tổng tiền</th>
                                            </tr>
                                        </thead>
                                        <tbody>
");
#nullable restore
#line 60 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                              
                                                var stt = 0;
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                             foreach (var item in list_cart_item)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td class=\"product_remove\">\r\n");
#nullable restore
#line 67 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                                      
                                                        stt += 1;
                                                        var id_del = "delete_cart" + @stt.ToString();
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6e73775defe15633ef73e15fbf1f7a16df88b769441", async() => {
                WriteLiteral("\r\n                                                        <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 3552, "\"", 3606, 3);
                WriteAttributeValue("", 3562, "document.getElementById(\'", 3562, 25, true);
#nullable restore
#line 72 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 3587, id_del, 3587, 7, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3594, "\').submit();", 3594, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                            <i class=\"pe-7s-close\" title=\"Remove\"></i>\r\n                                                        </a>\r\n                                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3404, "/GioHang/Delete_cart?product_id=", 3404, 32, true);
#nullable restore
#line 71 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 3436, item.sanpham.MaSp, 3436, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 71 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 3474, id_del, 3474, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                                </td>
                                                <td class=""product-thumbnail"">
                                                    <a href=""javascript:void(0)"">
                                                        <img");
            BeginWriteAttribute("src", " src=\"", 4117, "\"", 4136, 1);
#nullable restore
#line 80 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 4123, item.hinhanh, 4123, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4137, "\"", 4156, 1);
#nullable restore
#line 80 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 4143, item.hinhanh, 4143, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\">\r\n                                                    </a>\r\n                                                </td>\r\n                                                <td class=\"product-name\"><a");
            BeginWriteAttribute("href", " href=\"", 4368, "\"", 4401, 3);
            WriteAttributeValue("", 4375, "/{", 4375, 2, true);
#nullable restore
#line 83 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 4377, item.sanpham.MaSp, 4377, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4395, "}.html", 4395, 6, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 83 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                                                                                         Write(item.sanpham.TenSp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n                                                <td class=\"product-price\"><span class=\"amount\">");
#nullable restore
#line 84 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                                                                          Write(item.sanpham.GiaTien.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></td>\r\n                                                <td class=\"quantity\">\r\n");
#nullable restore
#line 86 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                                      
                                                        var sl = @item.Soluong;
                                                        var id_minus = "minus_cart" + @stt.ToString();
                                                        var id_plus = "plus_cart" + @stt.ToString();
                                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <div class=\"row p-5\">\r\n                                                        <div class=\"col-4 dec qtybutton\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6e73775defe15633ef73e15fbf1f7a16df88b7616222", async() => {
                WriteLiteral("\r\n                                                                <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 5468, "\"", 5524, 3);
                WriteAttributeValue("", 5478, "document.getElementById(\'", 5478, 25, true);
#nullable restore
#line 94 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 5503, id_minus, 5503, 9, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 5512, "\').submit();", 5512, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                    <i class=\"fa fa-minus\"></i>\r\n                                                                </a>\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 5300, "/GioHang/Minus_quantity?product_id=", 5300, 35, true);
#nullable restore
#line 93 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 5335, item.sanpham.MaSp, 5335, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 5353, "&sl=", 5353, 4, true);
#nullable restore
#line 93 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 5357, sl, 5357, 3, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 93 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 5380, id_minus, 5380, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                        </div>\r\n                                                        <div class=\"col-4 cart-plus-minus-box\">");
#nullable restore
#line 99 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                                                                          Write(sl);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                                        <div class=\"col-4 inc qtybutton\">\r\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6e73775defe15633ef73e15fbf1f7a16df88b7620500", async() => {
                WriteLiteral("\r\n                                                                <a href=\"#\"");
                BeginWriteAttribute("onclick", " onclick=\"", 6265, "\"", 6320, 3);
                WriteAttributeValue("", 6275, "document.getElementById(\'", 6275, 25, true);
#nullable restore
#line 102 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
WriteAttributeValue("", 6300, id_plus, 6300, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6308, "\').submit();", 6308, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                                                    <i class=\"fa fa-plus\"></i>\r\n                                                                </a>\r\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6099, "/GioHang/Plus_quantity?product_id=", 6099, 34, true);
#nullable restore
#line 101 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 6133, item.sanpham.MaSp, 6133, 18, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 6151, "&sl=", 6151, 4, true);
#nullable restore
#line 101 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 6155, sl, 6155, 3, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 101 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
AddHtmlAttributeValue("", 6178, id_plus, 6178, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                                        </div>
                                                       
                                                        
                                                    </div>      
                                                </td>
");
#nullable restore
#line 111 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                                  
                                                    var sump = @sl * @item.sanpham.GiaTien;
                                                    tongtien += Convert.ToInt32(sump);
                                                

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <td class=\"product-subtotal\"><span class=\"amount\">");
#nullable restore
#line 115 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                                                                             Write(sump.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></td>\r\n                                            </tr>\r\n");
#nullable restore
#line 117 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                                <div class=""row"">
                                    <div class=""col-12"">
                                        <div class=""coupon-all"">
                                            <div class=""coupon"">
                                                <input id=""coupon_code"" class=""input-text"" name=""coupon_code""");
            BeginWriteAttribute("value", " value=\"", 7872, "\"", 7880, 0);
            EndWriteAttribute();
            WriteLiteral(@" placeholder=""Mã voucher"" type=""text"">
                                                <input class=""button btn-warning rounded btn-dark-hover"" name=""apply_coupon"" value=""Áp dụng"" type=""submit"">
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""row"">
                                    <div class=""col-md-5 ml-auto"">
                                        <div class=""cart-page-total"">
                                    <h2 style=""font-family:'Segoe UI'; color:orangered"">Thành tiền</h2>
                                            <ul>
                                        <li style=""font-family:'Segoe UI'; font-size:18px"">Tổng tiền: <span>");
#nullable restore
#line 136 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
                                                                                                       Write(tongtien.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</span></li>\r\n                                </ul>\r\n                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6e73775defe15633ef73e15fbf1f7a16df88b7627637", async() => {
                WriteLiteral("\r\n                                                    <a class=\"button btn-warning rounded btn-dark-hover\" href=\"#\" onclick=\"document.getElementById(\'checkout\').submit();\">Thanh toán</a>\r\n                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 148 "C:\Users\TRAN VAN QUANG\source\repos\framework_Fivemen\Views\GioHang\Index_GioHang.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </main>\r\n<!-- Main Content Area End Here -->");
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
