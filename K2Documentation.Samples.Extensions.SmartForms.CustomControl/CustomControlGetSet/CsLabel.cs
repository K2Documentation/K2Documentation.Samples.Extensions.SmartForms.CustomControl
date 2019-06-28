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

[assembly: WebResource("K2Documentation.Samples.Extensions.SmartForms.CustomControl.CustomControlGetSet.Script.js", "text/javascript", PerformSubstitution = true)]

namespace K2Documentation.Samples.Extensions.SmartForms.CustomControl.CustomControlGetSet
{
    [ControlTypeDefinition("K2Documentation.Samples.Extensions.SmartForms.CustomControl.CustomControlGetSet.Definition.xml")]
    [ClientScript("K2Documentation.Samples.Extensions.SmartForms.CustomControl.CustomControlGetSet.Script.js")]
    public class CsLabel : BaseControl
    {
        public CsLabel()
            : base("input")
        {
            base.Attributes.Add("type", "text");
        }
    }
}
