// $(document).ready(function(){
// // Comment Section

// let url="https://jsonplaceholder.typicode.com/comments"
// $(".AddComment_btn").click(function(){
//     $.ajax({
//         url:"url",
//         type:"GET",
//         success: function(res){

//         }
//     })
// })
//     // Gallery Section
//     $(".placeImg").magnificPopup({
//         delegate: 'a',
//         type: 'image',
//         gallery: {
//             enabled: true
//         }
//     })
// })

$(document).ready(function () {
    
    // Comment Section

    
  

    // Gallery Section
    $(".placeImg").magnificPopup({
        delegate: 'a',
        type: 'image',
        gallery: {
            enabled: true
        }
    })

let check=true;
// Reply to Comment
$(".reply").click(function(){
    let mainObj=$(this).parent().children(".replyBox");
    if($(mainObj).is(":visible")){
        $(mainObj).hide();
       
        $(this).html("Cavabla")
    }
    else{
        $(mainObj).show();
        
        $(this).html("Geri")
    }
    
    
    
})

   
//    $(".replyBox").click(function(){
//        event.stopPropagation()
// })
})

