// This script is responsible to dynamically change the trips information. Based on user click
    function updateTripMenu(id) {

    var guestId = "PassingToJavaScriptGuest" + id;
    var priceId = "PassingToJavaScriptPrice" + id;
    var dateId = "PassingToJavaScriptDate" + id;
    var classId = "PassingToJavaScriptClass" + id;
    var cityNameId = "PassingToJavaScriptCityName" + id;

    //Taking trip information
    var guest = document.getElementById(guestId).value;
    var price = document.getElementById(priceId).value;
    var date = document.getElementById(dateId).value;
    var className = document.getElementById(classId).value;
    var cityName = document.getElementById(cityNameId).value;

    //changing the tripInformation div
       // document.getElementById("tripInformation").innerHTML = name;

       /* $('#tripInformation').replaceWith(' <div class="panel-body centralizado" id="tripInformation" > ' + 

           date +  
          
            '</div >');  */


        $('#tripInformation').replaceWith(' <div class="panel-body centralizado" id="tripInformation" >' 
            + '<table class="table table-hover table-responsive"> '
            + '<tr>'
            + '<td class="col-md-2"><i class="material-icons" style="font-size:24px;color:steelblue">location_on</i> ' + cityName + '</td>'
            + ' <td class= "col-md-2" > <i class="material-icons" style="font-size:24px;color:steelblue">date_range</i>' + date + '</td >'         
            + ' <td class= "col-md-2" > <i class="material-icons" style="font-size:24px;color:steelblue">person_outline</i>' + guest + '</td >'
            + '<td class="col-md-2"><i class="material-icons" style="font-size:24px;color:steelblue">flight_takeoff</i> ' + className +  ' class</td>'
            + '<td class="col-md-2"> <i class="material-icons" style="font-size:24px;color:steelblue">attach_money</i>' + price + ',00</td>'
            + '</tr>'
            + ' </table>'
            + '</div > ');

}

