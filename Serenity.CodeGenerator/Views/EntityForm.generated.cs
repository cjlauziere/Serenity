﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Serenity.CodeGenerator.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class EntityForm : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden
 public dynamic Model { get; set; } 
        public override void Execute()
        {


WriteLiteral("\r\n");



                                                   
    var dotModule = Model.Module == null ? "" : ("." + Model.Module);
    var moduleDot = Model.Module == null ? "" : (Model.Module + ".");


WriteLiteral("namespace ");


      Write(Model.RootNamespace);


                            Write(dotModule);

WriteLiteral(".Forms\r\n{\r\n    using Serenity;\r\n    using Serenity.ComponentModel;\r\n    using Ser" +
"enity.Data;\r\n    using System;\r\n    using System.ComponentModel;\r\n    using Syst" +
"em.Collections.Generic;\r\n    using System.IO;\r\n\r\n    [FormScript(\"");


             Write(moduleDot);


                         Write(Model.ClassName);

WriteLiteral("\")]\r\n    [BasedOnRow(typeof(Entities.");


                            Write(Model.RowClassName);

WriteLiteral("))]\r\n    public class ");


             Write(Model.ClassName);


                                   WriteLiteral("Form\r\n    {");

      foreach (EntityField x in Model.Fields)
    {
        if (x.Ident != Model.IdField)
        {
WriteLiteral("\r\n        public ");


          Write(x.DataType);

WriteLiteral(" ");


                      Write(x.Ident);

WriteLiteral(" { get; set; }");


                                                        }
    }

WriteLiteral("\r\n    }\r\n}");


        }
    }
}
#pragma warning restore 1591
