#pragma checksum "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12930008d1e6c132490c5e3a8ddee18cc15283e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
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
#line 1 "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12930008d1e6c132490c5e3a8ddee18cc15283e5", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""d-flex justify-content-around mb-6"">
    <h1 class=""text-center""><a href=""/"">Chefs</a> | Dishes</h1>
    <a href=""newDish"" class=""btn btn-lg btn-outline-primary"">Add a Dish</a>
</div>
<div class=""mt-4"">
    <h3 class=""text-decoration-underline"">Yum, take a look at our tasty dishes!</h3>
</div>
<div>
    <table class=""table table-striped table-hover"">
        <tr>
            <th>Name</th>
            <th>Chef</th>
            <th>Tastiness</th>
            <th>Calories</th>
        </tr>
");
#nullable restore
#line 16 "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/Home/Dishes.cshtml"
         foreach (Dish d in ViewBag.AllDishes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 19 "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/Home/Dishes.cshtml"
           Write(d.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 20 "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/Home/Dishes.cshtml"
           Write(d.Creator.ChefFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 20 "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/Home/Dishes.cshtml"
                                     Write(d.Creator.ChefLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 21 "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/Home/Dishes.cshtml"
           Write(d.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 22 "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/Home/Dishes.cshtml"
           Write(d.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 24 "/Users/tito/Desktop/Coding_Dojo/CSharp/ORM/ChefsNDishes/Views/Home/Dishes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>");
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
