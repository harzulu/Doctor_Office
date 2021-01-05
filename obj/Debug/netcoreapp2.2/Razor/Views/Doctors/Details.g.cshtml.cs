#pragma checksum "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2b93934bdc8e2524a6b537333a2fa0fd0704f74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Details), @"mvc.1.0.view", @"/Views/Doctors/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Doctors/Details.cshtml", typeof(AspNetCore.Views_Doctors_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2b93934bdc8e2524a6b537333a2fa0fd0704f74", @"/Views/Doctors/Details.cshtml")]
    public class Views_Doctors_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Doctor_Office.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(30, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(69, 39, true);
            WriteLiteral("\r\n<h2>Doctor Details</h2>\r\n<hr />\r\n<h3>");
            EndContext();
            BeginContext(109, 40, false);
#line 9 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(149, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(152, 36, false);
#line 9 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
                                          Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(188, 15, true);
            WriteLiteral("</h3>\r\n\r\n<ul>\r\n");
            EndContext();
#line 12 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
 if (@Model.Patients.Count == 0)
{

#line default
#line hidden
            BeginContext(240, 28, true);
            WriteLiteral("  <p>No patients found</p>\r\n");
            EndContext();
#line 15 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(280, 39, true);
            WriteLiteral("  <h4>Patients with this doctor:</h4>\r\n");
            EndContext();
#line 19 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
   foreach (var join in @Model.Patients)
  {

#line default
#line hidden
            BeginContext(366, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(374, 17, false);
#line 21 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
  Write(join.Patient.Name);

#line default
#line hidden
            EndContext();
            BeginContext(391, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 22 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
  }

#line default
#line hidden
#line 22 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
   
}

#line default
#line hidden
            BeginContext(405, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
            EndContext();
#line 26 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
 if(@Model.Specialties.Count == 0)
{

#line default
#line hidden
            BeginContext(453, 52, true);
            WriteLiteral("  <p>This doctor does not have any specialties</p>\r\n");
            EndContext();
#line 29 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(517, 45, true);
            WriteLiteral("  <h4>The specialties this doctor has:</h4>\r\n");
            EndContext();
#line 33 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
   foreach(var join in Model.Specialties)
  {

#line default
#line hidden
            BeginContext(610, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(618, 19, false);
#line 35 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
  Write(join.Specialty.Name);

#line default
#line hidden
            EndContext();
            BeginContext(637, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 36 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
     using (Html.BeginForm("DeleteSpecialty", "Doctors"))
    {
      

#line default
#line hidden
            BeginContext(716, 46, false);
#line 38 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
 Write(Html.Hidden("joinId", @join.SpecialtyDoctorId));

#line default
#line hidden
            EndContext();
            BeginContext(764, 115, true);
            WriteLiteral("      <span class=\"glyphicon glyphicon-trash\" aria-hidden=\"true\"></span><br><input type=\"submit\" value=\"Delete\"/>\r\n");
            EndContext();
#line 40 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
    }

#line default
#line hidden
#line 40 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
     
  }

#line default
#line hidden
#line 41 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
   
}

#line default
#line hidden
            BeginContext(894, 230, true);
            WriteLiteral("\r\n\r\n<nav class=\"navbar navbar\">\r\n  <div class=\"container-fluid\">\r\n    <ul class=\"nav navbar-nav\"> \r\n      <button type=\"button\" class=\"btn btn-dark\">\r\n        <span class=\"glyphicon glyphicon-pencil\" aria-hidden=\"true\"></span><li>");
            EndContext();
            BeginContext(1125, 67, false);
#line 49 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
                                                                          Write(Html.ActionLink("Edit Doctor", "Edit", new { id = Model.DoctorId }));

#line default
#line hidden
            EndContext();
            BeginContext(1192, 165, true);
            WriteLiteral("</li>\r\n      </button>\r\n          \r\n      <button type=\"button\" class=\"btn btn-dark\">\r\n        <span class=\"glyphicon glyphicon-trash\" aria-hidden=\"true\"></span><li>");
            EndContext();
            BeginContext(1358, 71, false);
#line 53 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
                                                                         Write(Html.ActionLink("Delete Doctor", "Delete", new { id = Model.DoctorId }));

#line default
#line hidden
            EndContext();
            BeginContext(1429, 155, true);
            WriteLiteral("</li>\r\n      </button>\r\n\r\n      <button type=\"button\" class=\"btn btn-dark\">\r\n        <span class=\"glyphicon glyphicon-stats\" aria-hidden=\"true\"></span><li>");
            EndContext();
            BeginContext(1585, 79, false);
#line 57 "C:\Users\lamapost0001\desktop\Doctor_office.solution\doctor_office\Views\Doctors\Details.cshtml"
                                                                         Write(Html.ActionLink("Add a Specialty", "AddSpecialty", new { id = Model.DoctorId }));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 51, true);
            WriteLiteral("</li>\r\n      </button>\r\n    </ul>\r\n  </div>\r\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Doctor_Office.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591
