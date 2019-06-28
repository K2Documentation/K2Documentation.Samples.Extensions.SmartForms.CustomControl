(function ($, undefined) {
    $(document).ready(function () {
        // Use event delegation
        $(document).delegate('.SFC.CustomControls-HelloWorld-Control', 'click.HelloWorldExample', function (e) {
            var target = this;
            $.ajax(
                {
                    url: 'HelloWorld.handler',
                    cache: false,
                    dataType: 'text'
                }).done(function (text) {
                    target.innerHTML = text;
                });

        });
    });
})(jQuery);