#pragma checksum "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\Experiments\ExperimentStoragePage1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da677847f8227f912e7b038f2c9ce0f6adf710e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experiments_ExperimentStoragePage1), @"mvc.1.0.view", @"/Views/Experiments/ExperimentStoragePage1.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Experiments/ExperimentStoragePage1.cshtml", typeof(AspNetCore.Views_Experiments_ExperimentStoragePage1))]
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
#line 1 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS;

#line default
#line hidden
#line 2 "D:\SP stuff\Web Development\kachoweded - Copy\Learner\TMS\Views\_ViewImports.cshtml"
using TMS.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da677847f8227f912e7b038f2c9ce0f6adf710e8", @"/Views/Experiments/ExperimentStoragePage1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b920ee378507dd0789e3303ed664c79361ef06d", @"/Views/_ViewImports.cshtml")]
    public class Views_Experiments_ExperimentStoragePage1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 294, true);
            WriteLiteral(@"<div class=""row justify-content-center"">
	<div class=""col-md-6""><h2>Page 1</h2></div>
</div>

<div class=""row justify-content-center"">
	<div class=""col-md-6 text-center"">
		<input type=""button""
					 id=""gotoPage2Button"" class=""btn btn-primary"" value=""Go to Page 2"" />
	</div>
</div>
");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(311, 350, true);
                WriteLiteral(@"
    <script>
        $('#gotoPage2Button').on('click', function (event) {
            store.set('productData', {
                productId: 13,
                productName: 'AI Code Genie',
                productPrice: 100

            })
            window.location = '/Experiments/ExperimentStoragePage2';
        });
    </script>

");
                EndContext();
            }
            );
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
