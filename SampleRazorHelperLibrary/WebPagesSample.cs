#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.214
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyCustomNamespace
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using System.Web.WebPages.Html;
    
    [System.Web.WebPages.PageVirtualPathAttribute("~/WebPagesSample.cshtml")]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorSingleFileGenerator", "1.0.0.0")]
    public class WebPagesSample_cshtml : System.Web.WebPages.WebPage
    {
#line hidden

                    // Resolve package relative syntax
                    // Also, if it comes from a static embedded resource, change the path accordingly
                    public override string Href(string virtualPath, params object[] pathParts) {
                        virtualPath = ApplicationPart.ProcessVirtualPath(GetType().Assembly, VirtualPath, virtualPath);
                        return base.Href(virtualPath, pathParts);
                    }
        public WebPagesSample_cshtml()
        {
        }
        protected System.Web.HttpApplication ApplicationInstance
        {
            get
            {
                return ((System.Web.HttpApplication)(Context.ApplicationInstance));
            }
        }
        public override void Execute()
        {


WriteLiteral("\r\n<p>\r\n    <ul>\r\n        <li>\r\n            This precompiled page was served to yo" +
"u at ");


                                                  Write(DateTime.Now);

WriteLiteral("\r\n        </li>\r\n        <li>\r\n            <a href=\"");


                Write(Href("@/WebPagesSample"));

WriteLiteral(@""">Hyperlinks</a> inside ApplicationParts can be rooted to the base virtual path that is registered.    
        </li>
        <li>
            Application parts can also serve embedded resources. For instance, this cake is not a lie: 
            <br />
            <img src=""");


                 Write(Href("@/Images/Cake.jpg"));

WriteLiteral("\" alt=\"Delicious chocolate cake - Courtesy Bakery Template, WebMatrix\" />\r\n      " +
"  </li>\r\n    </ul>\r\n    <br />\r\n</p>");


        }
    }
}
#pragma warning restore 1591
