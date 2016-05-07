// Write your Javascript code.

$('.myButton').width(
    Math.max.apply(
        Math,
        $('.myButton').map(function () {
            return $(this).outerWidth();
        }).get()
    )
);