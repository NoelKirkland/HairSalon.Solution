#pragma checksum "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0db93477463214b9e1e6ed5dfaac7da7e575777"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Create), @"mvc.1.0.view", @"/Views/Clients/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Clients/Create.cshtml", typeof(AspNetCore.Views_Clients_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0db93477463214b9e1e6ed5dfaac7da7e575777", @"/Views/Clients/Create.cshtml")]
    public class Views_Clients_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 7 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
            BeginContext(92, 34, false);
#line 9 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(130, 36, false);
#line 10 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(166, 6, true);
            WriteLiteral(" <br>\n");
            EndContext();
            BeginContext(176, 41, false);
#line 12 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model => model.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(221, 101, false);
#line 13 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.PhoneNumber, new { type="tel", pattern="[0-9]{3}-[0-9]{3}-[0-9]{4}" }));

#line default
#line hidden
            EndContext();
            BeginContext(322, 42, true);
            WriteLiteral(" <small>Format: 123-456-7890</small> <br>\n");
            EndContext();
            BeginContext(368, 37, false);
#line 15 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.LabelFor(model => model.Stylist));

#line default
#line hidden
            EndContext();
            BeginContext(409, 30, false);
#line 16 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.DropDownList("StylistId"));

#line default
#line hidden
            EndContext();
            BeginContext(439, 6, true);
            WriteLiteral(" <br>\n");
            EndContext();
            BeginContext(446, 54, true);
            WriteLiteral("  <input type=\"submit\" value=\"Add new client\" /> <br>\n");
            EndContext();
#line 19 "/Users/noelkirkland/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
