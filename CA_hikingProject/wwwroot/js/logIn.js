$(document).ready(function(){
    // $('.preloader').fadeOut('slow');
    checkScreen()
    $(".brg_com").click(function () {
        $("#nav_menuRes").toggleClass("afterClick");

    })
    checkPosition()
    $(window).scroll(function(){
     
        checkPosition()
      })
      $(".inputIcon input").focus(function(){
          $(this).parent().next().children().css({
              "width":"100%",
              "background":"linear-gradient(to right, #e55d87, #5fc3e4)",
              "transition":"all 0.5s linear" 
          })
          $(this).parent().children('i').css({
            "color":"#9733EE",
        })
        $(this).parent().children('i').removeClass("fas fa-lock")
            $(this).parent().children('i').addClass("fas fa-lock-open ")

      })
      $(".inputIcon input").blur(function(){
          if(!$(this).val()){
            $(this).parent().next().children().css({
                "width":"0%",
                "transition":"all 0.5s linear" 
            })
            $(this).parent().children('i').css({
                "color":"#adadad",
            })
            $(this).parent().children('i').removeClass("fas fa-lock-open")
            $(this).parent().children('i').addClass("fas fa-lock")
          }
        
    })
      
    // Password char check
  
})
$(window).on('resize', function () {
    checkScreen()
   
})

// For Nav Layout
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
    if($(window).scrollTop()>80){
        $("#navigation").addClass("p_fix")
    }
    else{
        $("#navigation").removeClass("p_fix")
    }
}


