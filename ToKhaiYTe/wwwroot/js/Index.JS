
var listGate = listGate || {};
var listNational = listNational || {};

var urlGetListGate = "/Address/GetListGate";
var urlGetListGender = "/Helper/GetListGender";
var urlGetListNational = "/address/getlistNational ";
var urlGetListProvince = "/address/getListProvince";
var urlGetListDistrict = "/address/getlistdistrict/";
var urlGetListWard = "/address/getListWard/"

$(function () {
    getListGate();
    getListGender();
    getListNational();
    drawOptProvinceDeparture();
    drawOptProvinceDestiny();
    getListProvinceVN();
})


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

            let s = "";
            $.each(response.listNational.result, function (i, v) {
                if (v.id == 237) {
                    s += '<option value="' + v.id + '" selected>' + v.commonName + '</option>';
                }
                s += '<option value="' + v.id + '" >' + v.commonName + '</option>';

            });
            $(".National").html(s);
        }
    });
}

function drawOptProvinceDeparture() {
    $.ajax({
        type: "GET",
        url: urlGetListProvince,
        dataType: "json",
        success: function (response) {
            let s = "";
            $.each(response.listProvince.result, function (i, v) {
                if (v.id == 237) {
                    s += '<option value="' + v.id + '" selected>' + v.name + '</option>';
                } else {
                    s += '<option value="' + v.id + '" >' + v.name + '</option>';
                }
            });
            $("#DepartureProvinceSelect").html(s);
        }
    });
}
function drawOptProvinceDestiny() {
    $.ajax({
        type: "GET",
        url: urlGetListProvince,
        dataType: "json",
        success: function (response) {
            let s = "";
            $.each(response.listProvince.result, function (i, v) {
                if (v.id == 237) {
                    s += '<option value="' + v.id + '" selected>' + v.name + '</option>';
                } else {
                    s += '<option value="' + v.id + '" >' + v.name + '</option>';
                }
            });
            $("#DestinyLocationProvinceSelect").html(s);
        }
    });
}


// change
$("#DepartureCountry").change(function (e) {
    IdDeparture = $("#DepartureCountry").val();
    if (IdDeparture == 237) {
        $("#DepartureProvinceSelect").show();
        $("#DepartureProvinceInput").hide();

    }
    else {
        $("#DepartureProvinceSelect").hide();
        $("#DepartureProvinceInput").show();
    }
});

$("#DestinyLocationCountry").change(function (e) {
    IdDeparture = $("#DestinyLocationCountry").val();
    if (IdDeparture == 237) {
        $("#DestinyLocationProvinceSelect").show();
        $("#DestinyLocationProvinceInput").hide();

    }
    else {
        $("#DestinyLocationProvinceSelect").hide();
        $("#DestinyLocationProvinceInput").show();
    }

});



var getListProvinceVN = function () {
    $.ajax({
        type: "GET",
        url: urlGetListProvince,
        
        dataType: "json",
        success: function (response) {
            let s = "<option disabled selected>-Chọn-<option>";
            $.each(response.listProvince.result, function (i, v) {
                    s += '<option value="' + v.id + '" >' + v.name + '</option>';
            });
            $("#vnProvince").html(s);
        }
    });
}
$("#vnProvince").change(function (e) {
    let idProvince = $("#vnProvince").val();
    $.ajax({
        type: "GET",
        url: `${urlGetListDistrict}${parseInt(idProvince)}`,
        dataType: "json",
        success: function (response) {
            let s = "<option disabled selected>-Chọn-<option>";
            $.each(response.listDistrict.result, function (i, v) {

                s += '<option value="' + v.id + '" >' + v.name + '</option>';

            });
            $("#CurrentAddressDistrict").html(s);
        }
    });
});
$("#CurrentAddressDistrict").change(function (e) {
    let idProvince = $("#CurrentAddressDistrict").val();
    $.ajax({
        type: "GET",
        url: `${urlGetListWard}${parseInt(idProvince)}`,
        dataType: "json",
        success: function (response) {
            let s = "<option disabled selected>-Chọn-<option>";
            $.each(response.listWard.result, function (i, v) {

                s += '<option value="' + v.id + '" >' + v.name + '</option>';

            });
            $("#CurrentAddressWard").html(s);
        }
    });
})

