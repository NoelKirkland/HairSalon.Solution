#pragma checksum "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2114cdb2b81a7e7efa0b94780c659f9d78c603e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stylists_Create), @"mvc.1.0.view", @"/Views/Stylists/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Stylists/Create.cshtml", typeof(AspNetCore.Views_Stylists_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2114cdb2b81a7e7efa0b94780c659f9d78c603e3", @"/Views/Stylists/Create.cshtml")]
    public class Views_Stylists_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Stylist>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 29, true);
            WriteLiteral("<h4> Add a New Stylist </h4>\n");
            EndContext();
#line 7 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
 using (Html.BeginForm()) 
{
  

#line default
#line hidden
            BeginContext(122, 34, false);
#line 9 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(160, 36, false);
#line 10 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(196, 6, true);
            WriteLiteral(" <br>\n");
            EndContext();
            BeginContext(206, 43, false);
#line 12 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.LabelFor(model => model.StationNumber));

#line default
#line hidden
            EndContext();
            BeginContext(253, 45, false);
#line 13 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.TextBoxFor(model => model.StationNumber));

#line default
#line hidden
            EndContext();
            BeginContext(298, 6, true);
            WriteLiteral(" <br>\n");
            EndContext();
            BeginContext(308, 39, false);
#line 15 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.LabelFor(model => model.Specialty));

#line default
#line hidden
            EndContext();
            BeginContext(351, 41, false);
#line 16 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
Write(Html.TextBoxFor(model => model.Specialty));

#line default
#line hidden
            EndContext();
            BeginContext(392, 58, true);
            WriteLiteral(" <br>\n  <input type=\"submit\" value=\"Add a new stylist\" />\n");
            EndContext();
#line 18 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Stylists/Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Stylist> Html { get; private set; }
    }
}
#pragma warning restore 1591
