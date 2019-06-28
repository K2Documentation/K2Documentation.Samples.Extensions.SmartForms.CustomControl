using SourceCode.Forms.Controls.Web.SDK;
using SourceCode.Forms.Controls.Web.SDK.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

[assembly: WebResource("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.TextBox.Script.js", "text/javascript", PerformSubstitution = true)]

namespace K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.TextBox
{
    [ControlTypeDefinition("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.TextBox.Definition.xml")]
    [ClientScript("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.TextBox.Script.js")]

    public class Control : BaseControl
    {
        public Control()
            : base("input")
        {
            base.Attributes.Add("type", "text");
        }

    }
}