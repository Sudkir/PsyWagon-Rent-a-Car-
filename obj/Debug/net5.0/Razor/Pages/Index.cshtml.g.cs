#pragma checksum "C:\Users\Admin\Documents\GitHub\PsyWagon\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e67e641260ddd3ec4ebe24f54944892da8fc0346"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(PsyWagonLestes.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace PsyWagonLestes.Pages
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
#line 1 "C:\Users\Admin\Documents\GitHub\PsyWagon\Pages\_ViewImports.cshtml"
using PsyWagonLestes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e67e641260ddd3ec4ebe24f54944892da8fc0346", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd9e5c9fa98724735808ce8d88970fc7119c577b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/MainIndex.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Admin\Documents\GitHub\PsyWagon\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e67e641260ddd3ec4ebe24f54944892da8fc03463755", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



    <div class=""post-wrap"">
          <div class=""post-item"">
       
          
        <div class=""item-content"">
            <div class=""item-icon group""></div>
            <div class=""item-body"">
                <h3>Машины</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla feugiat a quam non blandit.</p>
            </div>
            <div class=""item-footer"">
                <a href=""/Cars/Index"" class=""link""><span>Подробнее</span></a>
            </div>
        </div>
    </div>
    
    



    <div class=""post-item"">
        <div class=""item-content"">
            <div class=""item-icon tree""></div>
            <div class=""item-body"">
                <h3>Аренда</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla feugiat a quam non blandit.</p>
            </div>
            <div class=""item-footer"">
                <a href=""/Cars/ShowCars"" class=""link""><span>Подробнее</span></a>
            </div>
        </div>
    </div>

    <");
            WriteLiteral(@"div class=""post-item"">
        <div class=""item-content"">
            <div class=""item-icon anchor""></div>
            <div class=""item-body"">
                <h3>Расходники</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla feugiat a quam non blandit.</p>
            </div>
            <div class=""item-footer"">
                <a href=""#"" class=""link""><span>Подробнее</span></a>
            </div>
        </div>
    </div>

    <div class=""post-item"">
        <div class=""item-content"">
            <div class=""item-icon video""></div>
            <div class=""item-body"">
                <h3>Аксессуары</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla feugiat a quam non blandit.</p>
            </div>
            <div class=""item-footer"">
                <a href=""#"" class=""link""><span>Подробнее</span></a>
            </div>
        </div>
    </div>

    <div class=""post-item"">
        <div class=""item-content"">
            <div class=""item-");
            WriteLiteral(@"icon photo""></div>
            <div class=""item-body"">
                <h3>Диски</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla feugiat a quam non blandit.</p>
            </div>
            <div class=""item-footer"">
                <a href=""#"" class=""link""><span>Подробнее</span></a>
            </div>
        </div>
    </div>

    <div class=""post-item"">
        <div class=""item-content"">
            <div class=""item-icon gift""></div>
            <div class=""item-body"">
                <h3>О нас</h3>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nulla feugiat a quam non blandit.</p>
            </div>
            <div class=""item-footer"">
                <a href=""/Contact"" class=""link""><span>Подробнее</span></a>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
