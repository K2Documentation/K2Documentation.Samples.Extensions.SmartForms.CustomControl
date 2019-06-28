(function ($, undefined) {
    if (typeof CustomControlGetSet === "undefined" || CustomControlGetSet === null) CustomControlGetSet = {};


    CustomControlGetSet =
        {
            //	    getProperty: function (objInfo) {

            //	        var instance = $('#' + objInfo.CurrentControlID);
            //	        var value = instance('option', objInfo.property);
            //	        //if the property was not found jQuery UI will return the instance for chaining
            //	        //override this and instead return undefined
            //	        if (value == instance) {
            //	            return;
            //	        }
            //	        else {
            //	            return value;
            //	        }

            //	    },

            //	    setProperty: function (objInfo) {

            //	        var instance = $('#' + objInfo.CurrentControlID);
            //	        instance('option', objInfo.property, objInfo.Value);

            //	    },

            getValue: function (objInfo) {
                return $("#" + objInfo.CurrentControlID).val();
            },

            //For onChange Code Interaction
            setValue: function (objInfo) {
                var instance = $('#' + objInfo.CurrentControlID);
                var oldValue = instance.val();

                instance.val(objInfo.Value);


            },

            validate: function (objInfo) {
                var control = $("#" + objInfo.CurrentControlID);
                UtilitiesHelper.showValidationMessage(control, objInfo, false);

            }

        };
}
    (jQuery));