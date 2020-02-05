// $(document).ready(function(){
//     checkScreen()
//     $(".brg_com").click(function () {
//         $("#nav_menuRes").toggleClass("afterClick");

//     })
 
//     checkPosition()
//     $(window).scroll(function(){
     
//         checkPosition()
//       })
      
  
// })
// $(window).on('resize', function () {
//     checkScreen()
   
// })

// // For Nav Layout
// function checkScreen() {
//     if (window.innerWidth >= 768) {
        
//         $("#nav_menu").addClass("d-flex justify-content-around");
//         $("#nav_menu").removeClass("d-none");
//         $(".srchNorm").removeClass("d-none");
//         $("#nav_menuRes").removeClass("d-block");
//         $("#nav_menuRes").addClass("d-none");
//         $("#burger_menu").html(" ")
//     }
//     else {
//         $("#nav_menu").removeClass("d-flex justify-content-around");
//         $("#nav_menu").addClass("d-none");
//         $(".srchNorm").addClass("d-none");
//         $("#nav_menuRes").removeClass("d-none");
//         $("#burger_menu").html("<i class='fas fa-mountain'></i>")
//     }
// }

// function checkPosition(){
//     if($(window).scrollTop()>80){
//         $("#navigation").addClass("p_fix")
//     }
//     else{
//         $("#navigation").removeClass("p_fix")
//     }
// }

$(document).ready(function () {

    checkScreen()
    $(".brg_com").click(function () {
        $("#nav_menuRes").toggleClass("afterClick");
        // $("#navigation").toggleClass("ovfl-x");
    })
    $(".hasChild").click(function () {
        $(".childMenu").toggleClass("d-block")
    })
    $(window).scroll(function(){
     
      checkPosition()
    })

})

$(window).on('resize', function () {
    checkScreen()
   
})
var a="<div class='search_box'><input type='text' class='search' placeholder='Axtarış'>"+
"<a href='#'' class='search_btn' ><i class='fas fa-search'></i></a></div>"
function checkScreen() {
    if (window.innerWidth > 768) {
        
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
    // if($(window).scrollTop()>80){
    //     $("#navigation").addClass("p_fix")
    // }
    // else{
    //     $("#navigation").removeClass("p_fix")
    // }
}