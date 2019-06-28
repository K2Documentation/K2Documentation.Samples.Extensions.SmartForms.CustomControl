using SourceCode.Forms.Controls.Web.SDK;
using SourceCode.Forms.Controls.Web.SDK.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

[assembly: WebResource("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.HelloWorld.Script.js", "text/javascript", PerformSubstitution = true)]
[assembly: WebResource("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.HelloWorld.Stylesheet.css", "text/css", PerformSubstitution = true)]

namespace K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.HelloWorld
{
    [ControlTypeDefinition("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.HelloWorld.Definition.xml")]
    [ClientScript("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.HelloWorld.Script.js")]
    [ClientCss("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.HelloWorld.Stylesheet.css")]
    [ClientResources("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.HelloWorld.Resources")]
    public class Control : BaseControl
    {
        protected override void CreateChildControls()
        {
            Label label = new Label();
            label.Text = "Hello";
            this.Controls.Add(label);

            Label label2 = new Label();
            label2.Text = Resources.Message1;
            this.Controls.Add(label2);
        }

        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            writer.Write(" <b>World</b>");
        }
    }
}
