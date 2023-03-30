#pragma checksum "C:\Users\Eagha\Desktop\CodeLessons\P232\Backend\3. 30-03-2023\30032023\StartBootstrap\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c0fd38f944a804dc9fc0d417169b0cdd5880b79"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c0fd38f944a804dc9fc0d417169b0cdd5880b79", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Eagha\Desktop\CodeLessons\P232\Backend\3. 30-03-2023\30032023\StartBootstrap\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Contact Section-->
<section class=""page-section"" id=""contact"">
    <div class=""container mb-5"">
        <!-- Contact Section Heading-->
        <h2 class=""page-section-heading text-center text-uppercase text-secondary mb-0"">Contact Me</h2>
        <!-- Icon Divider-->
        <div class=""divider-custom"">
            <div class=""divider-custom-line""></div>
            <div class=""divider-custom-icon""><i class=""fas fa-star""></i></div>
            <div class=""divider-custom-line""></div>
        </div>
        <!-- Contact Section Form-->
        <div class=""row"">
            <div class=""col-lg-8 mx-auto"">
                <!-- To configure the contact form email address, go to mail/contact_me.php and update the email address in the PHP file on line 19.-->
                <form id=""contactForm"" name=""sentMessage"" novalidate=""novalidate"">
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
            ");
            WriteLiteral(@"                <label>Name</label>
                            <input class=""form-control"" id=""name"" type=""text"" placeholder=""Name"" required=""required"" data-validation-required-message=""Please enter your name."" />
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Email Address</label>
                            <input class=""form-control"" id=""email"" type=""email"" placeholder=""Email Address"" required=""required"" data-validation-required-message=""Please enter your email address."" />
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
     ");
            WriteLiteral(@"                       <label>Phone Number</label>
                            <input class=""form-control"" id=""phone"" type=""tel"" placeholder=""Phone Number"" required=""required"" data-validation-required-message=""Please enter your phone number."" />
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <div class=""control-group"">
                        <div class=""form-group floating-label-form-group controls mb-0 pb-2"">
                            <label>Message</label>
                            <textarea class=""form-control"" id=""message"" rows=""5"" placeholder=""Message"" required=""required"" data-validation-required-message=""Please enter a message.""></textarea>
                            <p class=""help-block text-danger""></p>
                        </div>
                    </div>
                    <br />
                    <div id=""success""></div>
                    <div class=""form-group""><button cla");
            WriteLiteral("ss=\"btn btn-primary btn-xl\" id=\"sendMessageButton\" type=\"submit\">Send</button></div>\r\n                </form>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591