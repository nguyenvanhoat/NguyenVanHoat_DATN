/*const { type } = require("jquery");*/

var CartController = function () {
    this.initialize = function () {
        loadData();

        registerEvents();
    }

    function registerEvents() {
        $('#frmPayment').validate({
            rules: {
                name: "required",
                address: "required",
                email: {
                    required: true,
                    email: true
                },
                phone: {
                    required: true,
                    number: true
                }
            },
            messages: {
                name: "Yêu cầu nhập tên",
                address: "Yêu cầu nhập địa chỉ",
                email: {
                    required: "Bạn cần nhập email",
                    email: "Định dạng email chưa đúng"
                },
                phone: {
                    required: "Số điện thoại được yêu cầu",
                    number: "Số điện thoại phải là số."
                }
            }
        });
        $('body').on('click', '.btn-plus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) + 1;
            updateCart(id, quantity);
        });

        $('body').on('click', '.btn-minus', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            const quantity = parseInt($('#txt_quantity_' + id).val()) - 1;
            updateCart(id, quantity);
        });
        $('body').on('click', '.btn-remove', function (e) {
            e.preventDefault();
            const id = $(this).data('id');
            updateCart(id, 0);
        });
        $('body').on('click', '#btnCheckout', function (e) {
            e.preventDefault();
            $('#divCheckout').show();
        });
        $('body').on('click', '#chkUserLoginInfo', function () {
            if ($(this).prop('checked')) {
                getUser();
            }
            else {
                $('#txtName').val('');
                $('#txtAddress').val('');
                $('#txtEmail').val('');
                $('#txtPhone').val('');
            }

        });
        $('body').on('click', '#btnCreateOrder', function (e) {
            e.preventDefault();
            var isValid = $('#frmPayment').valid();
            if (isValid) {
                createOrder();
            }

        });


    }

    function getUser() {
        $.ajax({
            url: '/Cart/GetUser',
            type: 'POST',
            dataType: 'json',
            success: function (res) {
                if (res.status) {
                    var user = res.data;
                    $('#txtName').val(user.userName);
                    /*$('#txtAddress').val(user.Address);*/
                    $('#txtEmail').val(user.email);
                    $('#txtPhone').val(user.phoneNumber);
                }
            }
        });
    }

    function createOrder() {
        //debugger
        var order = {
            OrderDate: $('#txtDate').val(),
            ShipName: $('#txtName').val(),
            ShipAddress: $('#txtAddress').val(),
            ShipEmail: $('#txtEmail').val(),
            ShipPhoneNumber: $('#txtPhone').val()
        };
        $.ajax({
            url: '/Cart/CreateOrder',
            type: 'POST',
            dataType: 'json',
            data: {
                model: JSON.stringify(order)
            },
            success: function (res) {
                if (res.status) {
                    $('#divCheckout').hide();
                    deleteAll();
                    setTimeout(function () {
                        $('#cartcontainer').html('Cảm ơn bạn đã đặt hàng thành công. Chúng tôi sẽ liên hệ sớm nhất.');
                    }, 1000);
                }
            }
        });
    }
    function deleteAll() {

        $.ajax({
            url: '/Cart/DeleteAll',
            type: 'POST',
            dataType: 'json',
            success: function (response) {
                if (response.status) {
                    loadData();
                    loadCart();
                }
            }

        });
    }
    function loadCart() {
        $.ajax({
            type: "GET",
            url: "/Cart/GetListItem",
            success: function (res) {
                $('#lbl_number_of_items_header').text(res.length)
            }
        });
    }
    function updateCart(id, quantity) {
        $.ajax({
            type: "POST",
            url: '/Cart/UpdateCart',
            data: {
                id: id,
                quantity: quantity
            },
            success: function (res) {
                $('#lbl_number_items_header').text(res.length);
                loadData();
            },
            error: function (err) {
                console.log(err);
            }
        });
    }


    function loadData() {
        $.ajax({
            type: "GET",
            url: '/Cart/GetListItem',
            success: function (res) {
                var html = '';
                var total = 0;

                $.each(res, function (i, item) {
                    var amount = item.price * item.quantity;
                    html += "<tr>"
                        + "<td> <img width=\"60\" src=\"" + "/img/" + item.image + "\" alt=\"\" /></td>"
                        + "<td>" + item.name + "</td>"
                        + "<td><div class=\"input-append\"><input class=\"span1\" style=\"max-width: 48px\" placeholder=\"1\" id=\"txt_quantity_" + item.productId + "\" value=\"" + item.quantity + "\" size=\"36\" type=\"text\">"
                        + "<button class=\"btn btn-minus\" data-id=\"" + item.productId + "\" type =\"button\"> <i class=\"fa fa-minus\"></i></button>"
                        + "<button class=\"btn btn-plus\" type=\"button\" data-id=\"" + item.productId + "\"><i class=\"fa fa-plus\"></i></button>"
                        + "<button class=\"btn btn-danger btn-remove\" type=\"button\" data-id=\"" + item.productId + "\"><i class=\"pe-7s-close\"></i></button>"
                        + "</div>"
                        + "</td>"

                        + "<td>" + numberWithCommas(item.price) + "</td>"
                        + "<td>" + numberWithCommas(amount) + "</td>"
                        + "</tr>";
                    total += amount;
                });
                $('#cart_body').html(html);
                if (html == '') {
                    $('#cartcontainer').html('Không có sản phẩm nào trong giỏ hàng');
                }
                $('#lbl_number_of_items').text(res.length);
                $('#lbl_total').text(numberWithCommas(total));
                //xóa không gặp bug lớn :)))
                // registerEvents();
            }
        });
    }
}
function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

