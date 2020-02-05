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


    // Price filter

    $( function() {
        $( ".slider-range" ).slider({
          range: true,
          min: 0,
          max: 500,
          values: [ 75, 300 ],
          slide: function( event, ui ) {
            $( ".amount" ).val(   ui.values[ 0 ] + " azn"+" - " + ui.values[ 1 ] +" azn");
          }
        });
        $( ".amount" ).val(   $( ".slider-range" ).slider( "values", 0 )  +" azn"+
          " - " + $( ".slider-range" ).slider( "values", 1 )+" azn" );
      });

      // Filter button click
      $(".fltBtn button").click(function(){

  $(".overlay").toggleClass("aftOver")

      })
})