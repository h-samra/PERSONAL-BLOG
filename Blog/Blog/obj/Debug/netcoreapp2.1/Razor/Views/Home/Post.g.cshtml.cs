#pragma checksum "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c76cf52093ab8d4474fd4fff8a8f40636b0b58"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Post.cshtml", typeof(AspNetCore.Views_Home_Post))]
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
#line 1 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\_ViewImports.cshtml"
using Blog;

#line default
#line hidden
#line 2 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\_ViewImports.cshtml"
using Blog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c76cf52093ab8d4474fd4fff8a8f40636b0b58", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60de8826b8954e9153bb5ddebbd8520bddd0a921", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Post.cshtml"
  
    ViewData["Title"] = "Post";

#line default
#line hidden
            BeginContext(53, 27, true);
            WriteLiteral("\r\n<h2 class=\"text-left\"><b>");
            EndContext();
            BeginContext(81, 11, false);
#line 6 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Post.cshtml"
                    Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(92, 37, true);
            WriteLiteral("</b></h2>\r\n<h4 class=\"text-right\"><i>");
            EndContext();
            BeginContext(130, 33, false);
#line 7 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Post.cshtml"
                     Write(Model.Created.ToShortDateString());

#line default
#line hidden
            EndContext();
            BeginContext(163, 13, true);
            WriteLiteral("</i></h4>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Post.cshtml"
 if (!String.IsNullOrEmpty(Model.Image))
{

#line default
#line hidden
            BeginContext(221, 12, true);
            WriteLiteral("    <br />\r\n");
            EndContext();
#line 12 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Post.cshtml"
    var image_path = $"/Image/{Model.Image}";

#line default
#line hidden
            BeginContext(280, 8, true);
            WriteLiteral("    <img");
            EndContext();
            BeginWriteAttribute("src", " src=", 288, "", 304, 1);
#line 13 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Post.cshtml"
WriteAttributeValue("", 293, image_path, 293, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(304, 78, true);
            WriteLiteral(" style=\"display:block; margin-left:auto; margin-right:auto; width:1000px\" />\r\n");
            EndContext();
#line 14 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Post.cshtml"
}

#line default
#line hidden
            BeginContext(385, 11, true);
            WriteLiteral("<br />\r\n<p>");
            EndContext();
            BeginContext(397, 10, false);
#line 16 "C:\Users\herma\Documents\Repos\Personal-Blog\Blog\Blog\Views\Home\Post.cshtml"
Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(407, 6, true);
            WriteLiteral("</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
