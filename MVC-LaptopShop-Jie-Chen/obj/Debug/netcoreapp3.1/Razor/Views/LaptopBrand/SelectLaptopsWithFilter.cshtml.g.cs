#pragma checksum "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5ffbe77fb87186cf30011cb407891bfd588f6b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_LaptopBrand_SelectLaptopsWithFilter), @"mvc.1.0.view", @"/Views/LaptopBrand/SelectLaptopsWithFilter.cshtml")]
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
#line 1 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\_ViewImports.cshtml"
using MVC_LaptopShop_Jie_Chen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\_ViewImports.cshtml"
using MVC_LaptopShop_Jie_Chen.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5ffbe77fb87186cf30011cb407891bfd588f6b5", @"/Views/LaptopBrand/SelectLaptopsWithFilter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b51a2fcc1a8f101dbf02b74cf16b6baedce5c1c", @"/Views/_ViewImports.cshtml")]
    public class Views_LaptopBrand_SelectLaptopsWithFilter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Laptop>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h2>These are Laptops\' brand and year/price fliter :</h2>\r\n    <br />\r\n");
#nullable restore
#line 4 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            Select Brand :  ");
#nullable restore
#line 7 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
                       Write(Html.DropDownList("Name"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"submit\" value=\"Select Brand\" />\r\n        </div>\r\n        <div>\r\n            Select Order :  ");
#nullable restore
#line 11 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
                       Write(Html.DropDownList("OrderChoices"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"submit\" value=\"Select Order\" />\r\n        </div>\r\n        <div>\r\n            Select Input Number :  ");
#nullable restore
#line 15 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
                              Write(Html.Editor("Number"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            <input type=""submit"" value=""Input number"" />
            <ul>
                <li>Year input range : 2016-2020 --Find All laptops newer than your choice year.</li>
                <li>Price input range : 899.99-2599.99 --Find All laptops cheaper than your input price.</li>
            </ul>

        </div>
");
#nullable restore
#line 23 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
     if (Model != null)
    {
        foreach (var laptop in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                Laptop: ");
#nullable restore
#line 29 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
                   Write(laptop.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("  Price: ");
#nullable restore
#line 29 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
                                         Write(laptop.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Year: ");
#nullable restore
#line 29 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
                                                             Write(laptop.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <br />\r\n");
#nullable restore
#line 32 "D:\2021 MITT\Intro-LINQ-NET\LINQ-MVC-LaptopShop\MVC-LaptopShop-Jie-Chen\Views\LaptopBrand\SelectLaptopsWithFilter.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Laptop>> Html { get; private set; }
    }
}
#pragma warning restore 1591