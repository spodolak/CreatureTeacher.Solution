#pragma checksum "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a837e09c981e3590d43a80da763428645a310e79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Creatures_Create), @"mvc.1.0.view", @"/Views/Creatures/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Creatures/Create.cshtml", typeof(AspNetCore.Views_Creatures_Create))]
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
#line 1 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/_ViewImports.cshtml"
using CreatureTeacher;

#line default
#line hidden
#line 2 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/_ViewImports.cshtml"
using CreatureTeacher.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a837e09c981e3590d43a80da763428645a310e79", @"/Views/Creatures/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"930d563035fbf74b8dfc0ca0abd0db7f045e0c5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Creatures_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CreatureTeacher.Models.Creature>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Creatures/Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 1 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
  
	ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(39, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(79, 90, true);
            WriteLiteral("\n<div class=\"mdl-grid\">\n  <div class=\"mdl-cell mdl-cell--6-col\">\n\t\t<div id=\"creature\">\n\t\t\t");
            EndContext();
            BeginContext(170, 29, false);
#line 10 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
       Write(Html.Partial("_ShowCreature"));

#line default
#line hidden
            EndContext();
            BeginContext(199, 18, true);
            WriteLiteral("\n\t\t</div>\n\t</div>\n");
            EndContext();
            BeginContext(270, 45, true);
            WriteLiteral("  <div class=\"mdl-cell mdl-cell--6-col\">\n\n\t\t\t");
            EndContext();
            BeginContext(315, 1234, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a837e09c981e3590d43a80da763428645a310e794939", async() => {
                BeginContext(362, 318, true);
                WriteLiteral(@"
				<div class=""mdl-textfield mdl-js-textfield mdl-textfield--floating-label"">
					<label for=""name"" class=""mdl-textfield__label"">Creature Name</label>
					<input id=""name"" name=""name"" type=""text"" class=""mdl-textfield__input"" required>
				</div>
				<div class=""mdl-textfield mdl-js-textfield getmdl-select"">
					");
                EndContext();
                BeginContext(681, 33, false);
#line 22 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
               Write(Html.LabelFor(model => model.Eye));

#line default
#line hidden
                EndContext();
                BeginContext(714, 6, true);
                WriteLiteral("\n\t\t\t\t\t");
                EndContext();
                BeginContext(721, 70, false);
#line 23 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
               Write(Html.DropDownList("EyeId", null, new { @class="mdl-textfield__input"}));

#line default
#line hidden
                EndContext();
                BeginContext(791, 80, true);
                WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"mdl-textfield mdl-js-textfield getmdl-select\">\n\t\t\t\t\t");
                EndContext();
                BeginContext(872, 35, false);
#line 26 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
               Write(Html.LabelFor(model => model.Mouth));

#line default
#line hidden
                EndContext();
                BeginContext(907, 6, true);
                WriteLiteral("\n\t\t\t\t\t");
                EndContext();
                BeginContext(914, 72, false);
#line 27 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
               Write(Html.DropDownList("MouthId", null, new { @class="mdl-textfield__input"}));

#line default
#line hidden
                EndContext();
                BeginContext(986, 81, true);
                WriteLiteral("\t\n\t\t\t\t</div>\n\t\t\t\t<div class=\"mdl-textfield mdl-js-textfield getmdl-select\">\n\t\t\t\t\t");
                EndContext();
                BeginContext(1068, 34, false);
#line 30 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
               Write(Html.LabelFor(model => model.Head));

#line default
#line hidden
                EndContext();
                BeginContext(1102, 6, true);
                WriteLiteral("\n\t\t\t\t\t");
                EndContext();
                BeginContext(1109, 71, false);
#line 31 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
               Write(Html.DropDownList("HeadId", null, new { @class="mdl-textfield__input"}));

#line default
#line hidden
                EndContext();
                BeginContext(1180, 80, true);
                WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<div class=\"mdl-textfield mdl-js-textfield getmdl-select\">\n\t\t\t\t\t");
                EndContext();
                BeginContext(1261, 34, false);
#line 34 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
               Write(Html.LabelFor(model => model.Tail));

#line default
#line hidden
                EndContext();
                BeginContext(1295, 6, true);
                WriteLiteral("\n\t\t\t\t\t");
                EndContext();
                BeginContext(1302, 71, false);
#line 35 "/Users/katysolovewicz/Desktop/CreatureTeacher.Solution/CreatureTeacher/Views/Creatures/Create.cshtml"
               Write(Html.DropDownList("TailId", null, new { @class="mdl-textfield__input"}));

#line default
#line hidden
                EndContext();
                BeginContext(1373, 169, true);
                WriteLiteral("\n\t\t\t\t</div>\n\t\t\t\t<br>\n\t\t\t\t<button class=\"mdl-button mdl-js-button mdl-button--raised mdl-js-ripple-effect mdl-button--accent\" type=\"submit\">Make Me a Friend!</button>\n\t\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1549, 17, true);
            WriteLiteral("\n\t</div>\n</div>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CreatureTeacher.Models.Creature> Html { get; private set; }
    }
}
#pragma warning restore 1591
