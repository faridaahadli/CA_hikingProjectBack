$(document).ready(function () {
    $(".replyBox").hide();
    // Comment Section

    const url = "https://jsonplaceholder.typicode.com/todos"
    $("#commentSubmit").click(function () {
        $.ajax({
            url: url,
            type: "Post",
            data:$("#cmtBox").serialize(),
        success: function (res) {
            console.log(res)
                $("#commentHolder").append(`<div>${res.id}</div>`)
            }
        })
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