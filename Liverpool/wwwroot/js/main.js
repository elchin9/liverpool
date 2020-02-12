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
    $(document).on("click", ".image-slider-stadium img", function () {
        var photoSrc = $(this).attr("src");
        $(".inner-slider .inner-photos-stadium img").attr("src", photoSrc);
        $(".inner-slider").css("display", "block");
    });
    $(document).on("click", ".one-photo img", function () {
        var photoSrc = $(this).attr("src");
        $(".inner-slider .inner-photos img").attr("src", photoSrc);
        $(".inner-slider").css("display", "block");

    });
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

    //Load More Gallery Ajax
    var galleryCount = 20;
    $(".btn-gallery").click(function (e) {
        var totalCount = +$("#gallery-hidden-input").val();

        e.preventDefault();
        $.ajax({
            url: "/Ajax/LoadGallery?skip=" + galleryCount,
            type: "GET",
            success: function (res) {
                $("#gallery .galleryRow").append(res);
                galleryCount += 8;

                if (galleryCount >= totalCount) {
                    $(".btn-gallery").css("display", "none");
                }
            }
        });
    });
    //Load More Event Ajax
    var eventCount = 2;
    $(".btn-event").click(function (e) {
        var totalCount = +$("#event-hidden-input").val();

        e.preventDefault();
        $.ajax({
            url: "/Ajax/LoadEvent?skip=" + eventCount,
            type: "GET",
            success: function (res) {
                $("#event .eventRow").append(res);
                eventCount += 2;

                if (eventCount >= totalCount) {
                    $(".btn-event").css("display", "none");
                }
            }
        });
    });
    //Load More News Ajax
    var newsCount = 16;
    $(".btn-news").click(function (e) {
        var totalCount = +$("#news-hidden-input").val();

        e.preventDefault();
        $.ajax({
            url: "/Ajax/LoadNews?skip=" + newsCount,
            type: "GET",
            success: function (res) {
                $("#latest-news .newsRow").append(res);
                newsCount += 8;

                if (newsCount >= totalCount) {
                    $(".btn-news").css("display", "none");
                }
            }
        });
    });
    //Load More Video Ajax
    var videoCount = 12;
    $(".btn-video").click(function (e) {
        var totalCount = +$("#video-hidden-input").val();

        e.preventDefault();
        $.ajax({
            url: "/Ajax/LoadVideos?skip=" + videoCount,
            type: "GET",
            success: function (res) {
                $("#last-match .videoRow").append(res);
                videoCount += 8;

                if (videoCount >= totalCount) {
                    $(".btn-video").css("display", "none");
                }
            }
        });
    });
    //Load More Video Ajax
    var stadiumCount = 12;
    $(".btn-stadium").click(function (e) {
        var totalCount = +$("#stadium-hidden-input").val();

        e.preventDefault();
        $.ajax({
            url: "/Ajax/LoadStadiumPhotos?skip=" + stadiumCount,
            type: "GET",
            success: function (res) {
                $("#stadium-section .stadiumRow").append(res);
                stadiumCount += 8;

                if (stadiumCount >= totalCount) {
                    $(".btn-stadium").css("display", "none");
                }
            }
        });
    });
});