using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//the namespaces used in the control
using SourceCode.Forms.Controls.Web.SDK;
using SourceCode.Forms.Controls.Web.SDK.Attributes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

//Link style resource file
[assembly: WebResource("K2Documentation.Samples.Extensions.SmartForms.CustomControl.StyleControl.Styles.css", "text/css", PerformSubstitution = true)]

namespace K2Documentation.Samples.Extensions.SmartForms.CustomControl.StyleControl
{
    //Link to the definition file
    [ControlTypeDefinition("K2Documentation.Samples.Extensions.SmartForms.CustomControl.StyleControl.Definition.xml")]
    [ClientCss("K2Documentation.Samples.Extensions.SmartForms.CustomControl.StyleControl.Styles.css")]
    class StyleControl : BaseControl
    {
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            writer.Write("Control Styled");
        }
    }
}
