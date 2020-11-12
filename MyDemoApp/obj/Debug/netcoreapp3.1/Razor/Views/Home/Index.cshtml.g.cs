#pragma checksum "C:\Users\Syed Muhammad Hassan\Desktop\VS Projects\MyDemoApp\MyDemoApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "669c89e8d0190e17e2f330894f2e21ffc9cfbc4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Syed Muhammad Hassan\Desktop\VS Projects\MyDemoApp\MyDemoApp\Views\_ViewImports.cshtml"
using MyDemoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Syed Muhammad Hassan\Desktop\VS Projects\MyDemoApp\MyDemoApp\Views\_ViewImports.cshtml"
using MyDemoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"669c89e8d0190e17e2f330894f2e21ffc9cfbc4c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eefb4757c871cc53944373ffbfd739d5b88d4612", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Syed Muhammad Hassan\Desktop\VS Projects\MyDemoApp\MyDemoApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<div class=""jumbotron"">

    <style>
        h1 {
            text-align: center;
        }
    </style>

    <h1>User Data Entry System</h1>

</div>

<br />



<style>
    h2, #steps {
        text-align: center;
    }
</style>

<h2> About the application </h2>
<br />
<p>
    ""My Demo Application"" is a simple application that uses Entity Framework in an ASP.NET Core MVC web application. On launching the application 100 dummy users are automatically created and seeded into the database. This application is intended to be run on localhost and was developed as a part of the interview project at KPMG.
</p>

<p id=""intro"">
    The application was developed as a part of interview project for KPMG International Limited for it's branch Düsseldorf in Germany. The application was developed in the following seven steps.

</p>

<p id=""steps"">

    <ol>
        <li> Creation of an MVC .NET Core Project using Visual Studio Community 2019</li>

        <li>Integration of Enti");
            WriteLiteral(@"tyFramework (6.4.4) as a NuGet Package. </li>

        <li>Creation of an EntityFramework Data context with the name ""TestContext""</li>

        <li>In the constructor of TestContext, a static string was used as a source for sarving data.</li>

        <li>
            Creation of the user table, with the following columns :
            <br />

            <ul>
                <li>ID  (int, Primary Key, Auti-Identity)</li>
                <li>Name  (string)</li>
                <li>Vorname  (string)</li>
                <li>Email  (string)</li>
            </ul>

        </li>

        <li>Migration of the database and development of a standard seeding method, to seed the database automatically with 100 dummy users.</li>

        <li>Implementaion of GUI</li>
    </ol>



</p>

<br />
<br />

<p>
    Furthermore the application makes it possible to create and add new users to the database and to delete existing users from the database
</p>






");
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