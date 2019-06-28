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


namespace K2Documentation.Samples.Extensions.SmartForms.CustomControl.BasicControl
{
    //Link to the definition file
    [ControlTypeDefinition("K2Documentation.Samples.Extensions.SmartForms.CustomControl.BasicControl.Definition.xml")]

    class BasicControl : BaseControl
    {
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            writer.Write(" <b>Basic Control</b>");
        }
    }
}
