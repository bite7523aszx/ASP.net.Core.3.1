#pragma checksum "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1648f4110ddd6eec66c08fc0ec3a555fd2f7205"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Sale_Index), @"mvc.1.0.view", @"/Views/Sale/Index.cshtml")]
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
#line 1 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\_ViewImports.cshtml"
using WebApplication3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1648f4110ddd6eec66c08fc0ec3a555fd2f7205", @"/Views/Sale/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463d1c12e8fc14b2589daa67feec3183fea97611", @"/Views/_ViewImports.cshtml")]
    public class Views_Sale_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication3.Models.Salecs>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "_Layout";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    span {\r\n        color: red;\r\n    }\r\n</style>\r\n<h1 class=\"text-center\">銷售</h1>\r\n<table class=\"table container text-center\">\r\n\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gamename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n               每一個遊戲賣出的金額\r\n            </th>\r\n");
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 32 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
           Write(Html.DisplayFor(modelitem => item.Gamename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
            WriteLiteral("            <th>\r\n");
#nullable restore
#line 42 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
                 if (item.count <= 10)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>");
#nullable restore
#line 44 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
                     Write(item.count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 45 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
               Write(item.count);

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
                               
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </th>\r\n            <th>\r\n                NT$");
#nullable restore
#line 52 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
              Write(item.price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
          
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n\r\n    </tbody>\r\n</table>\r\n<div>\r\n    總收入:NT$");
#nullable restore
#line 63 "C:\Users\KeNa\Desktop\20210525finall\WebApplication3\Views\Sale\Index.cshtml"
      Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication3.Models.Salecs>> Html { get; private set; }
    }
}
#pragma warning restore 1591