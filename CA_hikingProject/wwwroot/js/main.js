
$(document).ready(function () {
    // $('.preloader').fadeOut('slow');
   
    checkScreen()
    $(".brg_com").click(function () {
        $("#nav_menuRes").toggleClass("afterClick");

    })
    $(".hasChild").click(function () {
        $(".childMenu").toggleClass("d-block")
    })
   checkPosition()
    $(window).scroll(function(){
     
      checkPosition()
    })
    
    // $(".clickSrch").click(function(){
    //     $(this).removeClass("search_box")
    //     $(".search").css({
    //         "width":"100%"
    //     })
    // })

    // $(".cardImg").hover(function(){

    // })
    
// -------------------------------------------------------
    // Card Slider
    $(".myGall").magnificPopup({
        delegate: 'a',
        type: 'image',
        gallery: {
            enabled: true
        }
    })
    $('#ourTeam .owl-carousel').owlCarousel({
        loop: true,
        margin: 10,
        nav: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            1000: {
                items: 3
            }
        }
    })
    $('#comingSoon .owl-carousel').owlCarousel({
        loop: true,
        margin: 10,
        nav: true,
        autoplay: true,
        autoplayTimeout:2000,
        autoplayHoverPause: true,
        responsive: {
            0: {
                items: 1
            },
            600: {
                items: 2
            },
            1000: {
                items: 3
            }
        }
    })
})

$(window).on('resize', function () {
    checkScreen()
   
})
var a="<div class='search_box'><input type='text' class='search' placeholder='Axtarış'>"+
"<a href='#'' class='search_btn' ><i class='fas fa-search'></i></a></div>"
function checkScreen() {
    if (window.innerWidth >= 768) {
        
        $("#nav_menu").addClass("d-flex justify-content-around");
        $("#nav_menu").removeClass("d-none");
        $(".srchNorm").removeClass("d-none");
        $("#nav_menuRes").removeClass("d-block");
        $("#nav_menuRes").addClass("d-none");
        $("#burger_menu").html(" ")
    }
    else {
        $("#nav_menu").removeClass("d-flex justify-content-around");
        $("#nav_menu").addClass("d-none");
        $(".srchNorm").addClass("d-none");
        $("#nav_menuRes").removeClass("d-none");
        $("#burger_menu").html("<i class='fas fa-mountain'></i>")
    }
}

function checkPosition(){
    if($(window).scrollTop()>40){
        $("#navigation").css({
            "background":" linear-gradient(135deg, #48c6ef 10%, #6f86d6 100%)"
        })
    }
    else{
        $("#navigation").css({
            "background":"transparent"
        })
    }
}