"use strict";

$(document).ready(function () {


    // Header 

    $(document).on("click", ".mobile-nav", function () {
        $(".mobile-menu").slideToggle();
    });
      $(document).on("click", ".sub-menu-mobile-li a", function(){
        $(this).next().slideToggle();
    });
    //   End Header


    //Slider  start

    let vw = $(window).outerWidth();
    let totalWidth = $("#slider .slider-lent li").length * 100;

    $("#slider .slider-lent").css("width", totalWidth + "%");

    let index = 0;
    setInterval(function () {
        index++;
        

        $("#slider .slider-lent").css(
            {
                left: -index * 100 + "%"
            })

        if (index === $("#slider .slider-lent li").length) {
            index = 0;
            $("#slider .slider-lent").css(
                {
                    left: -index * 100 + "%"
                })
        }
    }, 6000);
    $(document).on("click", "#slider .arrow-right", function () {
        index++;

        $("#slider .slider-lent").css(
            {
                left: -index * 100 + "%"
            })

        if (index === $("#slider .slider-lent li").length) {
            index = 0;
            $("#slider .slider-lent").css(
                {
                    left: -index * 100 + "%"
                })
        }
    });
    $(document).on("click", "#slider .arrow-left", function () {
        index--;

        $("#slider .slider-lent").css(
            {
                left: -index * 100 + "%"
            })

        if (index < 0) {
            index = $("#slider .slider-lent li").length - 1;
            $("#slider .slider-lent").css(
                {
                    left: -index * 100 + "%"
                })
        }
    });
    //Slider end

    // Start Footer

    $(document).on("click", ".goTop", function(e){

        e.preventDefault();
       
        $("html").animate({scrollTop:0}, '500');
    
    });

    //  End Footer

    // Start Squad Stadium

    $(document).on("click", ".squad-stadium button", function(){
        $('.stadium-3d').css("display", "block");
    });
    $(document).on("click", ".stad-img i", function(){
        $('.stadium-3d').css("display", "none");
    });

    // End Squad Stadium

    let innerSlidervW = $(".inner-photos li img").width();
    let totalWidthInnerSlider = $(".inner-photos li").length * innerSlidervW;

    $(".inner-photos").css("width", totalWidthInnerSlider + "px");

    let innerSliderIndex = 0;
    const innerSlides = $('.inner-photos li');


    $(document).on("click", ".image-slider-stadium", function () {

        var indexImg = $(".image-slider-stadium").index(this);
        $(".inner-slider ul").css("left", -indexImg * innerSlidervW);
        $(".inner-slider").css("display", "block");

    });
    $(document).on("click", ".one-photo", function(){
        var indexImg = $(".one-photo").index(this);
        $(".inner-slider ul").css("left", -indexImg * innerSlidervW);
        $(".inner-slider").css("display", "block");

    });

    $(document).on("click", ".inner-arrow-left", function()
    {
        innerSlideLeft();
    });

    $(document).on("click", ".inner-arrow-right", function()
    {
        innerSlideRight();
    });

    function innerSlide()
    {
        let innerSlidervW = $(".inner-photos li img").width();
        $('.inner-photos').css("left", -innerSliderIndex * innerSlidervW + "px");
    }

    function innerSlideRight(){
        innerSliderIndex++

        if(innerSliderIndex === innerSlides.length)
        {
            innerSliderIndex = 0;
   	    }
   	    innerSlide();
    }

    function innerSlideLeft()
    {
        innerSliderIndex--;
        if(innerSliderIndex < 0)
        {
            innerSliderIndex = innerSlides.length - 1; 
        }    
        innerSlide();
    }

    $(document).on("click", ".close", function(){

        $(".inner-slider").css("display", "none");

    });

    // Start News Details Slider


    let totalWidthOneNews = $(".news-details-img .slider-lent li").length * 100;


    $(".news-details-img .slider-lent").css("width", totalWidthOneNews + "%");

    let indexOneNews = 0;
    
    $(document).on("click", ".news-details-img .arrow-right", function () {


        indexOneNews++;

        $(".news-details-img .slider-lent").css(
            {
                left: -indexOneNews * 100 + "%"
            })

        if (indexOneNews === $(".news-details-img .slider-lent li").length) {
            indexOneNews = 0;
            $(".news-details-img .slider-lent").css(
                {
                    left: -indexOneNews * 100 + "%"
                })
        }
    });
    $(document).on("click", ".news-details-img .arrow-left", function () {



        indexOneNews--;

        $(".news-details-img .slider-lent").css(
            {
                left: -indexOneNews * 100 + "%"
            })

        if (indexOneNews < 0) {
            indexOneNews = $(".news-details-img .slider-lent li").length - 1;
            $(".news-details-img .slider-lent").css(
                {
                    left: -indexOneNews * 100 + "%"
                })
        }
    });

    // End News Details Slider

    //Upload Input with Icons
    $(document).on("click", ".uploadImage", function () {
        $("#uploadInput").click();
    });
    $(document).on("click", ".uploadImage", function () {
        $(".uploadInput").click();
    });
    $(document).on("click", ".uploadImageSecond", function () {
        $(".uploadInputSecond").click();
    });
    $(document).on("click", ".uploadImageThird", function () {
        $(".uploadInputThird").click();
    });
    $(document).on("click", ".uploadImageFour", function () {
        $(".uploadInputFour").click();
    });
    $(document).on("click", ".uploadImageFive", function () {
        $(".uploadInputFive").click();
    });

    //listen to the change event of file
    $('#uploadInput').change(function (e) {

        $(".file-view").addClass("show");


        ImagesUploader([...e.target.files]);

    });

    function ImagesUploader(files) {
        files.forEach(file => {
            if (file.type.match("image/*")) {

                const reader = new FileReader();
                reader.onloadend = function (event) {


                    $(".photo-convert img").attr("src", event.target.result);
                }
                reader.readAsDataURL(file);
            }
        })
    }

    //listen to the change event of file
    $('#uploadInputThird').change(function (e) {

        $(".file-view-third").addClass("show");

    });


    //listen to the change event of file
    $('.uploadInput').change(function (e) {

        $(".file-view").addClass("show");

    });
    //listen to the change event of file
    $('.uploadInputSecond').change(function (e) {

        $(".file-view-second").addClass("show");

    });
    //listen to the change event of file
    $('.uploadInputThird').change(function (e) {

        $(".file-view-third").addClass("show");

    });
    //listen to the change event of file
    $('.uploadInputFour').change(function (e) {

        $(".file-view-four").addClass("show");

    });
    //listen to the change event of file
    $('.uploadInputFive').change(function (e) {

        $(".file-view-five").addClass("show");

    });

    setInterval(function () {
        $(".temp-message").fadeOut(3000);
    }, 6000);

});