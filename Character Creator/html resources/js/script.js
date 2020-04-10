$('.dropdown').hover(function () {
    $('.dropdown-toggle', this).trigger('click');
});

$(function () {
    $('[data-toggle="popover"]').popover()
})