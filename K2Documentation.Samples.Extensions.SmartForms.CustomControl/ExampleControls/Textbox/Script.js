(function ($, undefined) {
    if (typeof CustomControls === "undefined" || CustomControls === null) CustomControls = {};


    CustomControls.Textbox =
        {
            getValue: function (objInfo) {
                return $("#" + objInfo.CurrentControlID).val();
            },

            //For onChange Code Interaction
            setValue: function (objInfo) {
                var instance = $('#' + objInfo.CurrentControlID);
                var oldValue = instance.val();

                instance.val(objInfo.Value);

                if (oldValue != objInfo.Value) {
                    raiseEvent(objInfo.CurrentControlID, 'Control', 'OnChange');
                }
            }
        };


    $(document).ready(function () {
        $(document).delegate('.SFC.CustomControls-TextBox-Control', 'click.CustomControls-TextBox-Control', function (e) {
            console.log('here'); // For debug purposes if needed
            raiseEvent('Control', this.id, 'OnClick');
        });

        // For onChange User Intereation
        $(document).delegate('.SFC.CustomControls-TextBox-Control', 'change.CustomControls-TextBox-Control', function (e) {
            console.log('here'); // For debug purposes if needed
            raiseEvent('Control', this.id, 'OnChange');
        });
    });
}
    (jQuery));