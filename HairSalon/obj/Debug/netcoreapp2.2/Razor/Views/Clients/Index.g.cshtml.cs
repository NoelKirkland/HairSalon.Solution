#pragma checksum "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb27b5ec5061261f2e8c51bd99ef63d6a7d221b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Index.cshtml", typeof(AspNetCore.Views_Clients_Index))]
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
#line 5 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb27b5ec5061261f2e8c51bd99ef63d6a7d221b", @"/Views/Clients/Index.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(91, 19, true);
            WriteLiteral("\n<h2>Clients</h2>\n\n");
            EndContext();
#line 10 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
            BeginContext(136, 73, true);
            WriteLiteral("  <h3>You must add at least one stylist before you can add a client</h3>\n");
            EndContext();
#line 13 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(211, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 15 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 foreach (Client client in Model)
{

#line default
#line hidden
            BeginContext(248, 6, true);
            WriteLiteral("  <li>");
            EndContext();
            BeginContext(255, 74, false);
#line 17 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 Write(Html.ActionLink($"{client.Name}", "Details", new { id = client.ClientId }));

#line default
#line hidden
            EndContext();
            BeginContext(329, 3, true);
            WriteLiteral(" | ");
            EndContext();
            BeginContext(333, 19, false);
#line 17 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
                                                                               Write(client.Stylist.Name);

#line default
#line hidden
            EndContext();
            BeginContext(352, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 18 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
}

#line default
#line hidden
            BeginContext(360, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 20 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 if (@Model.Count != 0)
{

#line default
#line hidden
            BeginContext(387, 3, true);
            WriteLiteral("<p>");
            EndContext();
            BeginContext(391, 45, false);
#line 22 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
Write(Html.ActionLink("Add a New Client", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(436, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
#line 23 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
