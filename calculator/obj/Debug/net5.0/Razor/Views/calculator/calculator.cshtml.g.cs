#pragma checksum "C:\Users\Matin\ikt201\calculator\Views\calculator\calculator.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d55a563f239aba4f5fa9de544fe15b03fbb300d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_calculator_calculator), @"mvc.1.0.view", @"/Views/calculator/calculator.cshtml")]
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
#line 1 "C:\Users\Matin\ikt201\calculator\Views\_ViewImports.cshtml"
using calculator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matin\ikt201\calculator\Views\_ViewImports.cshtml"
using calculator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d55a563f239aba4f5fa9de544fe15b03fbb300d3", @"/Views/calculator/calculator.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3d893fd8a48f011089468847d38c53c8b39171", @"/Views/_ViewImports.cshtml")]
    public class Views_calculator_calculator : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Matin\ikt201\calculator\Views\calculator\calculator.cshtml"
  
    ViewBag.Title = "title";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<input class=""screen ""  id=""screen"">
<button class=""number"" id = ""num ""  value  = ""0"" type=""button"" >0</button>
<button class=""number"" type=""button"" value  = ""1"" >1</button>
<button class=""number"" type=""button"" value  = ""2""  >2</button>
<button class=""number"" type=""button"" value  = ""3""  >3</button>
<button class=""number"" type=""button"" value  = ""4""  >4</button>
<button class=""number"" type=""button"" value  = ""5""  >5</button>
<button class=""number"" type=""button"" value  = ""6""  >6</button>
<button class=""number"" type=""button"" value  = ""7""  >7</button>
<button class=""number"" type=""button"" value  = ""8""  >8</button>
<button class=""number"" type=""button"" value  = ""9""  >9</button>
<button class=""number"" type=""button"" value  = "".""  >.</button>
<button class=""operator"" id = ""sum"" value  = ""+"" type=""button')"">+</button>
<button class=""operator"" id = ""minus"" value  = ""-"" type=""button')"">-</button>
<button class=""operator"" id = ""gang"" value  = ""*"" type=""button')"">*</button>
<button class=""operator"" id =  ""delli");
            WriteLiteral("ng\" value  = \"/\" type=\"button\')\">/</button>\r\n<button class=\"equal\" id =  \"equal\"  type=\"button\')\">=</button>\r\n<button class=\"c\" id = \"c\" type=\"button\')\">C</button>\r\n<button class=\"ce\" id = \"ce\" type=\"button\')\">CE</button>\r\n\r\n");
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
