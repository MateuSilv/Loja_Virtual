#pragma checksum "C:\Users\mateu\OneDrive\Área de Trabalho\Malwaro_LojaDeGames\Projeto_interdisciplinar\Malwaro\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2579db122761b1651272981fe2ada7188129736b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
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
#line 1 "C:\Users\mateu\OneDrive\Área de Trabalho\Malwaro_LojaDeGames\Projeto_interdisciplinar\Malwaro\Views\_ViewImports.cshtml"
using Malwaro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mateu\OneDrive\Área de Trabalho\Malwaro_LojaDeGames\Projeto_interdisciplinar\Malwaro\Views\_ViewImports.cshtml"
using Malwaro.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mateu\OneDrive\Área de Trabalho\Malwaro_LojaDeGames\Projeto_interdisciplinar\Malwaro\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mateu\OneDrive\Área de Trabalho\Malwaro_LojaDeGames\Projeto_interdisciplinar\Malwaro\Views\_ViewImports.cshtml"
using Malwaro.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2579db122761b1651272981fe2ada7188129736b", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2ccf07700ad65c32c8cfedf63f877953db8c9ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("contact-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mateu\OneDrive\Área de Trabalho\Malwaro_LojaDeGames\Projeto_interdisciplinar\Malwaro\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contato";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""mb-4"">


    <h2 class=""h1-responsive font-weight-bold text-center my-4"">Contate-nos</h2>

    <p class=""text-center w-responsive mx-auto mb-5"">
        Tem alguma dúvida? Não hesite em nos contatar diretamentene.
    </p>

    <div class=""row"">


        <div class=""col-md-9 mb-md-0 mb-5"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2579db122761b1651272981fe2ada7188129736b5076", async() => {
                WriteLiteral(@"


                <div class=""row"">


                    <div class=""col-md-6"">
                        <div class=""md-form mb-0"">
                            <input type=""text"" id=""name"" name=""name"" class=""form-control"">
                            <label for=""name""");
                BeginWriteAttribute("class", " class=\"", 700, "\"", 708, 0);
                EndWriteAttribute();
                WriteLiteral(@">Nome</label>
                        </div>
                    </div>

                    <div class=""col-md-6"">
                        <div class=""md-form mb-0"">
                            <input type=""text"" id=""email"" name=""email"" class=""form-control"">
                            <label for=""email""");
                BeginWriteAttribute("class", " class=\"", 1022, "\"", 1030, 0);
                EndWriteAttribute();
                WriteLiteral(@">Email</label>
                        </div>
                    </div>


                </div>

                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""md-form mb-0"">
                            <input type=""text"" id=""subject"" name=""subject"" class=""form-control"">
                            <label for=""subject""");
                BeginWriteAttribute("class", " class=\"", 1415, "\"", 1423, 0);
                EndWriteAttribute();
                WriteLiteral(@">Assunto</label>
                        </div>
                    </div>
                </div>

                <div class=""row"">


                    <div class=""col-md-12"">

                        <div class=""md-form"">
                            <textarea type=""text"" id=""message"" name=""message"" rows=""2"" class=""form-control md-textarea""></textarea>
                            <label for=""message"">Sua mensagem</label>
                        </div>

                    </div>
                </div>


            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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

            <div class=""text-center text-md-left"">
                <a class=""btn btn-primary"">Enviar</a>
            </div>
            <div class=""status""></div>
        </div>

        <div class=""col-md-3 text-center"">
            <ul class=""list-unstyled mb-0"">
                <li>
                    <i class=""fa fa-map-marker fa-2x""></i>
                    <p>São Paulo - SP, Brasil</p>
                </li>

                <li>
                    <i class=""fa fa-phone mt-4 fa-2x""></i>
                    <p>+ 01 234 567 89</p>
                </li>

                <li>
                    <i class=""fa fa-envelope mt-4 fa-2x""></i>
                    <p>contato@mawaro.com.br</p>
                </li>
            </ul>
        </div>


    </div>

</section>");
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
