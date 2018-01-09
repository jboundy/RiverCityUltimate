$(window).scroll(function(){
    $(".page-wrap").css("opacity", 1 - $(window).scrollTop() / 250);
});