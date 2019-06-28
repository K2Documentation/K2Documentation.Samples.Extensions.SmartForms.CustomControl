(function ($, window, document, undefinded) {
    if (typeof CustomControls === "undefined" || CustomControls == null) CustomControls = {};

    CustomControls.WithStyles =
        {
            getProperty: function (objInfo) {

            },

            setProperty: function (objInfo) {
                if (objInfo.property == "Style") {
                    CustomControls.WithStyles.setStyles(null, objInfo.Value, $('#' + objInfo.CurrentControlID));
                }

            },

            setStyles: function (wrapper, styles, target) {
                var isRuntime = (wrapper == null);
                var options = {};
                var element = isRuntime
                    ? jQuery(target)
                    : wrapper.find('.SFC.CustomControls-WithStyles-ControlWithStyles');

                jQuery.extend(options, {
                    "border": element,
                    "background": element,
                    "margin": element,
                    "padding": element,
                    "font": element,
                    "horizontalAlign": element
                });

                StyleHelper.setStyles(options, styles);

            }
        };


}(jQuery, window, document));