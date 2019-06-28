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

namespace K2Documentation.Samples.Extensions.SmartForms.CustomControl.ControlUsingResource
{

    //Link to the definition file
    [ControlTypeDefinition("K2Documentation.Samples.Extensions.SmartForms.CustomControl.ControlUsingResource.Definition.xml")]
    public class ControlUsingResource : BaseControl
    {
        protected override void CreateChildControls()
        {
            Label label1 = new Label();
            label1.Text = Resource.welcome;
            this.Controls.Add(label1);
        }
    }
}
