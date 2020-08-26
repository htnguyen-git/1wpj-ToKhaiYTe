
var listGate = listGate || {};
var urlGetListGate = "/Address/GetListGate";
var urlGetListGender = "/Helper/GetListGender";
var urlGetListNational = "/address/GetListNational";
var urlGetListProvince = "/address/getListProvince";


var getListGate = function () {
    $('#Gate').append('<option value="" disabled selected>-Chọn-</option>')
    $.ajax({
        type: "Get",
        url: urlGetListGate,
        dataType: "json",
        success: function (response) {       
            $.each(response.listGate.result, function (i, v) {
                $('#Gate').append('<option value="' + v.id + '">' + v.gateName + '</option>')
            });
        }
    });
}

var getListGender = function () {
    $("#Gender").append('<option value="" disabled selected>-Chọn-</option>')
    $.ajax({
        type: "GET",
        url: urlGetListGender,
        dataType: "json",
        success: function (response) {
            $.each(response.listGender, function (i, v) {
                $("#Gender").append('<option value="' + v + '">' + v + '</option>')
                
            });
        }
    });
}

var getListNational = function () {
    $(".National").append('<option value="" disabled selected>-Chọn-</option>')
    $.ajax({
        type: "GET",
        url: urlGetListNational,
        
        dataType: "json",
        success: function (response) {
            $.each(response.listNational.result, function (i, v) {

                $(".National").append('<option value="' + v.id + '">' + v.commonName + '</option>')
            });
        }
    });
}

$(function () {
    getListGate();
    getListGender();
    getListNational();
});

$("#DepartureCountry").change(function (e) {
    let departureCountry = $("#DepartureCountry").val();
    if (departureCountry == 237) {
        $.ajax({
           
            type: "GET",
            url: urlGetListProvince,
            dataType: "json",
            success: function (response) {
                $.each(response.listProvince.result, function (i, v) {

                    $("#DepartureProvince").append('<option value="' + v.id + '">' + v.name + '</option>')
                });
            }
        });
    }

});

$("#DestinyLocationCountry").change(function (e) {
    let departureCountry = $("#DestinyLocationCountry").val();
    if (departureCountry == 237) {
       
        $.ajax({
            type: "GET",
            url: urlGetListProvince,
            dataType: "json",
            success: function (response) {
                $.each(response.listProvince.result, function (i, v) {

                    $("#DestinyLocationProvince").append('<option value="' + v.id + '">' + v.name + '</option>')
                });
            }
        });
    }

});