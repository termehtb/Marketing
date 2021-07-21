 type="text/javascript"
    function myfunction() {
        alert(2);
        $.ajax({
        type: 'POST',
            cache: false,
            url: '/Home/createSalesperson',
            dataType: 'json',
            data: {
        name: $("#txtname").val(),
                lastname: $("#txtlastname").val(),
                code: parseInt($("#txtcode").val()),
                commission: parseInt($("#txtcommission").val()),
                phone: $("#txtphone").val(),
                mobile: $("#txtmobile").val(),
                address: $("#txtaddress").val()

            },
            error: function () {
        alert('error')
    },
            success: function (result) {
        alert(1);

            }
        });
}

