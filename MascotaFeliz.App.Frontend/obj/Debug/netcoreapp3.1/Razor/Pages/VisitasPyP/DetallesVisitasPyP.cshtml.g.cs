#pragma checksum "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\VisitasPyP\DetallesVisitasPyP.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2094aa979ce3369301bf0d2c428fcb3ef823b8e5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MascotaFeliz.App.Frontend.Pages.VisitasPyP.Pages_VisitasPyP_DetallesVisitasPyP), @"mvc.1.0.razor-page", @"/Pages/VisitasPyP/DetallesVisitasPyP.cshtml")]
namespace MascotaFeliz.App.Frontend.Pages.VisitasPyP
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
#line 1 "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\_ViewImports.cshtml"
using MascotaFeliz.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2094aa979ce3369301bf0d2c428fcb3ef823b8e5", @"/Pages/VisitasPyP/DetallesVisitasPyP.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cf052204a3bb4119b871dc96742e016457a0b55", @"/Pages/_ViewImports.cshtml")]
    public class Pages_VisitasPyP_DetallesVisitasPyP : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary table-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./ListaVisitasPyP", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("waterform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"     <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }

        body,
        html {
            height: 100%;
            padding: 0;
            margin: 0;
            font-family: 'Sniglet', cursive;
        }

        h1 {

            font-weight: normal;
            font-size: 3em;
            font-style: bold;
            font-family: 'Raleway', sans-serif;
            margin: 0 auto;
            margin-top: 10px;
            width: 500px;
            color: #F90;
            text-align: center;

        }

        header {
            height: 120px;
            background: url('http://www.geertjanhendriks.nl/codepen/form/golf.png') repeat-x bottom;
        }

        #form {
            max-width: 100%;
            background-color: #98d4f3;
            overflow: hidden;
            position: relative;

        }

        form {
            margin-top: -25px;
            margin: 0 auto;
        ");
            WriteLiteral(@"    padding-top: -10px;
            color: rgb(47, 107, 137);
            position: relative;
        }

        label,
        input,
        textarea {
            display: block;
        }

        .titulo {
            color: #642a73;
            font-size: 30px;
            text-align: center;
            margin-bottom: 60px;
        }

        input,
        textarea {
            width: 500px;
            border: none;
            border-radius: 20px;
            outline: none;
            padding: 8px;
            font-family: 'Sniglet', cursive;
            font-size: 1em;
            color: #676767;
            transition: border 0.5s;
            -webkit-transition: border 0.5s;
            -moz-transition: border 0.5s;
            -o-transition: border 0.5s;
            border: solid 3px #98d4f3;
            -webkit-box-sizing: border-box;
            -moz-box-sizing: border-box;
            box-sizing: border-box;

        }

        input:focus,
        te");
            WriteLiteral(@"xtarea:focus {
            border: solid 3px #77bde0;
        }

        textarea {
            height: 100px;
            resize: none;
            overflow: auto;
        }

        input[type=""submit""] {
            background-color: #F90;
            color: white;
            height: 50px;
            cursor: pointer;
            margin-top: 15px;
            font-size: 1.29em;
            font-family: 'Sniglet', cursive;
            -webkit-transition: background-color 0.5s;
            -moz-transition: background-color 0.5s;
            -o-transition: background-color 0.5s;
            transition: background-color 0.5s;
        }

        input[type=""submit""]:hover {
            background-color: #e58f0e;

        }

        label {
            font-size: 1.5em;
            margin-top: 20px;
            padding-left: 20px;
        }

        .formgroup,
        .formgroup-active,
        .formgroup-error {
            background-repeat: no-repeat;
            backg");
            WriteLiteral(@"round-position: right bottom;
            background-size: 10.5%;
            transition: background-image 0.7s;
            -webkit-transition: background-image 0.7s;
            -moz-transition: background-image 0.7s;
            -o-transition: background-image 0.7s;
            width: 566px;
            padding-top: 2px;
        }

        .formgroup {
            margin-top: -15px;
            background-image: url('http://www.geertjanhendriks.nl/codepen/form/pixel.gif');
        }

        .formgroup-active {
            background-image: url('http://www.geertjanhendriks.nl/codepen/form/octo.png');
        }

        .formgroup-error {
            background-image: url('http://www.geertjanhendriks.nl/codepen/form/octo-error.png');
            color: red;
        }

        a {
            text-decoration: none;
            list-style: none;
            font-weight: bold;
            background-color: rgb(237, 163, 52);
            border-radius: 5px;
            height: 40px");
            WriteLiteral(@";
            cursor: pointer;
            margin-top: 30px;
            margin-left: 40px;
            font-size: 1.5em;
            font-family: 'Sniglet', cursive;
            -webkit-transition: background-color 0.5s;
            -moz-transition: background-color 0.5s;
            -o-transition: background-color 0.5s;
            transition: background-color 0.5s;

        }

        a:hover {
            background-color: #e58f0e;
        }

        .link {
            margin-left: 640px;
        }

        img {
            max-width: 100%;
            height: 340px;
            width: 340px;
            margin-left: 35px;
            margin-top: 20px;
        }

        #perroImg {
            margin-top: -500px;
            margin-left: 1000px;
        }

        #waterform {
            margin-top: 5px;
            margin-left: 400px;
            margin-bottom: 20px;
        }

        btn{
           height: 340px; 
        }
    </style>
");
            WriteLiteral("    <header>\r\n        <h1>Detalles de la VisitaPyP</h1>\r\n    </header>\r\n");
            WriteLiteral("    <div id=\"form\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2094aa979ce3369301bf0d2c428fcb3ef823b8e510051", async() => {
                WriteLiteral("\r\n            <div>\r\n                <label for=\"id\">Id: ");
#nullable restore
#line 211 "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\VisitasPyP\DetallesVisitasPyP.cshtml"
                               Write(Model.visitaPyP.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> \r\n            </div>\r\n            <div class=\"formgroup\" id=\"name-form\">\r\n                <label for=\"cedula\">Fecha Visita: ");
#nullable restore
#line 214 "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\VisitasPyP\DetallesVisitasPyP.cshtml"
                                             Write(Model.visitaPyP.FechaVisita);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label> \r\n            </div>\r\n            <div class=\"formgroup\" id=\"name-form\">\r\n                <label for=\"name\">Temperatura: ");
#nullable restore
#line 217 "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\VisitasPyP\DetallesVisitasPyP.cshtml"
                                          Write(Model.visitaPyP.Temperatura);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label> \r\n            </div>\r\n            <div class=\"formgroup\" id=\"name-form\">\r\n                <label");
                BeginWriteAttribute("for", " for=\"", 5821, "\"", 5827, 0);
                EndWriteAttribute();
                WriteLiteral(">Peso: ");
#nullable restore
#line 220 "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\VisitasPyP\DetallesVisitasPyP.cshtml"
                               Write(Model.visitaPyP.Peso);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label> \r\n            </div>\r\n            <div class=\"formgroup\" id=\"name-form\">\r\n                <label for=\"direccion\">FrecuenciaRespiratoria : ");
#nullable restore
#line 223 "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\VisitasPyP\DetallesVisitasPyP.cshtml"
                                                           Write(Model.visitaPyP.FrecuenciaRespiratoria);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label> \r\n            </div>\r\n            <div class=\"formgroup\" id=\"name-form\">\r\n                <label for=\"telefono\"> FrecuenciaCardiaca: ");
#nullable restore
#line 226 "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\VisitasPyP\DetallesVisitasPyP.cshtml"
                                                      Write(Model.visitaPyP.FrecuenciaCardiaca);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label> \r\n            </div>\r\n            <div class=\"formgroup\" id=\"name-form\">\r\n                <label for=\"correo\">EstadoAnimo: ");
#nullable restore
#line 229 "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\VisitasPyP\DetallesVisitasPyP.cshtml"
                                            Write(Model.visitaPyP.EstadoAnimo);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label> \r\n            </div>\r\n            <div class=\"formgroup\" id=\"name-form\">\r\n                <label for=\"correo\">Recomendaciones: ");
#nullable restore
#line 232 "C:\Mascotas\MascotaFeliz.App\mascotafeliz.app.frontend\Pages\VisitasPyP\DetallesVisitasPyP.cshtml"
                                                Write(Model.visitaPyP.Recomendaciones);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </label> \r\n            </div>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2094aa979ce3369301bf0d2c428fcb3ef823b8e513962", async() => {
                    WriteLiteral(" Volver a lista ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MascotaFeliz.App.Frontend.Pages.DetallesVisitasPyPModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesVisitasPyPModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MascotaFeliz.App.Frontend.Pages.DetallesVisitasPyPModel>)PageContext?.ViewData;
        public MascotaFeliz.App.Frontend.Pages.DetallesVisitasPyPModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591