using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

//namespaces required to setup a custom control
using System.Web.UI;
using System.Web.UI.WebControls;
using SourceCode.Forms.Controls.Web.SDK;
using SourceCode.Forms.Controls.Web.SDK.Attributes;

//link to the resource files that are used by the contorl (the style.css and the image file)
[assembly: WebResource("K2Documentation.Samples.Extensions.SmartForms.CustomControl.IconControl.Style.css", "text/css", PerformSubstitution = true)]
[assembly: WebResource("K2Documentation.Samples.Extensions.SmartForms.CustomControl.IconControl.icon.png", "image/png")]

namespace K2Documentation.Samples.Extensions.SmartForms.CustomControl.IconControl
{
    //link the definition file for the control 
    [ControlTypeDefinition("K2Documentation.Samples.Extensions.SmartForms.CustomControl.IconControl.Definition.xml")]

    public class IconControl : BaseControl
    {
        public IconControl()
        {
            ((SourceCode.Forms.Controls.Web.Shared.IControl)this).DesignFormattingPaths.Add("stylecss", "Style.css");
        }
        protected override void RenderContents(System.Web.UI.HtmlTextWriter writer)
        {
            writer.Write("Control With Icon");
        }

    }
}
