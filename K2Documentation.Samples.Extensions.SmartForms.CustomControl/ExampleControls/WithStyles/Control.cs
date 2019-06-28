using SourceCode.Forms.Controls.Web.SDK;
using SourceCode.Forms.Controls.Web.SDK.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.UI;

[assembly: WebResource("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.WithStyles.Script.js", "text/javascript", PerformSubstitution = true)]

namespace K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.WithStyles
{
    [ControlTypeDefinition("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.WithStyles.Definition.xml")]
    [ClientScript("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ExampleControls.WithStyles.Script.js")]

    public class ControlWithStyles : BaseControl
    {
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            writer.Write("ControlWithStyles");
        }
    }
}