$(document).ready(function(){
    // Increase and Decrease
   
    $(".minus").click(function(){
        if($(".quantity").val()>1)
            $(".quantity").val($(".quantity").val()-1);

        
    })
    $(".plus").click(function(){
            $(".quantity").val(parseInt($(".quantity").val())+1);

        
    })

})