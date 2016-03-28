$(document).ready(function () {

    // Display code

    $(".scPhone").hide();
    $(".scName").hide();
    $(".date").datetimepicker({
        format: 'd/m/Y H:i',
        minDate: 0,
        allowTimes: [
            '12:00', '12:15', '12:30', '12:45',
            '13:00', '13:15', '13:30', '13:45',
            '14:00', '14:15', '14:30', '14:45',
            '15:00', '15:15', '15:30', '15:45',
            '16:00', '16:15', '16:30', '16:45',
            '17:00', '17:15', '17:30', '17:45',
            '18:00', '18:15', '18:30', '18:45',
            '19:00', '19:15', '19:30', '19:45',
            '20:00', '20:15', '20:30', '20:45',
            '21:00', '21:15', '21:30', '21:45',
            '22:00', '22:15', '22:30', '22:45',
            '23:00', '23:15', '23:30', '23:45',
            '00:00'
        ]
    
    });


    // Code for input form swap according to sale channel selection. -- irrelevant for now

    /*var saleChannelArray = [".scWebsite", ".scPhone", ".scName"];

    $(function () {
        var prevSelect = '';
        var thisSelect = $(".saleChannel").val();
        $(".saleChannel").change(function () {
            prevSelect = thisSelect;
            thisSelect = $(this).val();
            $(saleChannelArray[prevSelect-1]).fadeOut(function () {

                $(saleChannelArray[thisSelect - 1]).fadeIn();

            });
        });
    });*/

    // Validation Code

    var intputElements = document.getElementsByTagName("INPUT");
    for (var i = 0; i < intputElements.length; i++) {
        intputElements[i].oninvalid = function (e) {
            e.target.setCustomValidity("");
            if (!e.target.validity.valid) {
                if (e.target.name == "Date") {
                    e.target.setCustomValidity("Fecha y hora incorrectos");
                } else if(e.target.name == "GuestsAmount"){
                    e.target.setCustomValidity("Cantidad de comensales incorrecta");
                } else if (e.target.name == "EMail") {
                    e.target.setCustomValidity("Dirección de correo electrónico incorrecta");
                } else if(e.target.name == "PhoneNumber" || e.target.name=="scPhoneNumber") {
                    e.target.setCustomValidity("Número de teléfono inválido");
                } else if (e.target.name == "TableNumber") {
                    e.target.setCustomValidity("Número de mesa inválido");
                }
            }
        }
    }

    /*// This function right here makes it so JQuery.validation accepts dd/mm/yy format.

    $(function () {
        $.validator.addMethod('date',
        function (value, element) {
            if (this.optional(element)) {
                return true;
            }
            var ok = true;
            try {
                $.datepicker.parseDate('dd/mm/yy', value);
            }
            catch (err) {
                ok = false;
            }
            return ok;
        });
        $(".datefield").datepicker({ dateFormat: 'dd/mm/yy', changeYear: true });
    });

    // JQuery Validation Rules

    var form = $('#reservationForm');
    form.validate({

        debug: false,
        rules: {

            date: {
                required: true,
            }

        }

    });*/


});