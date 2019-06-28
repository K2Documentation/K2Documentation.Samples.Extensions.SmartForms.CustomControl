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

//Add the java script file to the control
[assembly: WebResource("K2Documentation.Samples.Extensions.SmartForms.CustomControl.JavaScriptControl.Script.js", "text/javascript", PerformSubstitution = true)]

namespace K2Documentation.Samples.Extensions.SmartForms.CustomControl.JavaScriptControl
{
    //Link to the definition file and the script file to the class
    [ControlTypeDefinition("K2Documentation.Samples.Extensions.SmartForms.CustomControl.JavaScriptControl.Definition.xml")]
    [ClientScript("K2Documentation.Samples.Extensions.SmartForms.CustomControl.JavaScriptControl.Script.js")]

    class JavaScriptControl : BaseControl
    {
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            writer.Write(" <b>JavaScript on Control</b>");
        }
    }
}
