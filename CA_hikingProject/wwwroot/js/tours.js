$(document).ready(function(){
// Pagination


    // Datetime Filter
    $(function() {
        $('input[name="daterange"]').daterangepicker({
          opens: 'left'
        }, function(start, end, label) {
          console.log("A new date selection was made: " + start.format('YYYY-MM-DD') + ' to ' + end.format('YYYY-MM-DD'));
        });
      });

   
  
    $("#hell").click(function () {
        $.ajax({
            url: "/tours/PriceFilter",
            type: "POST",
            success: function (res) { }
        })
    })
    //$("#prcFilter").click(function () {
    //    $.ajax({
    //        url: "/tours/PriceFilter",
    //        type: "GET",
    //        success: function (res) { }
    //    })
    //})
      // Filter button click
    $(".fltBtn button").click(function () {
        
    })
  $(".overlay").toggleClass("aftOver")

      })