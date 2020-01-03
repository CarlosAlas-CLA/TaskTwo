//GetAmazonFood
function getAmazonFood() {
    $(document).ready(function () {
        var data = [];
        $.ajax({
            method: 'Get',
            url: '/api/Amazon/GetAll',
            dataType: 'json',
            data: JSON.stringify(data),
            success: function (data) {
                var row = '';
                $.each(data, function (index, obj) {
                    row += '<tr><td hidden=hidden> ' + obj.masterPageID + ' </td> <td > '
                        + obj.lastDayQtySold + ' </td> <td >'
                        + obj.lastDayProfit + '</td> <td >'
                        + obj.totalProducts + '</td><td >' + '</td></tr>';
                }); $("#AmazonFood").append(row);
            }
        });
    });
}
//GetAmazonTrans
function getAmazonTrans() {
    $(document).ready(function () {
        var data = [];
        $.ajax({
            method: 'Get',
            url: '/api/Amazon/GetAllTrans',
            dataType: 'json',
            data: JSON.stringify(data),
            success: function (data) {
                var row = '';
                $.each(data, function (index, obj) {
                    row += '<tr><td > '
                        + obj.productName + ' </td> <td> '
                        + obj.asin + ' </td> <td>'
                        + obj.price + '</td> <td >'
                        + obj.lastDayQtySold + '</td><td >'
                        + obj.lastDayProfit + '</td><td >'
                        + obj.lastUpdateDate +
                        '</td></tr>';
                }); $("#amazonTrans").append(row);
            }
        });
    });
}
//GetEbayFood
function getEbayFood() {
    $(document).ready(function () {
        var data = [];
        $.ajax({
            method: 'Get',
            url: '/api/Ebay/GetAll',
            dataType: 'json',
            data: JSON.stringify(data),
            success: function (data) {
                var row = '';
                $.each(data, function (index, obj) {
                    row += '<tr><td hidden=hidden> ' + obj.masterPageID + ' </td> <td > '
                        + obj.lastDayQtySold + ' </td> <td >'
                        + obj.lastDayProfit + '</td> <td >'
                        + obj.totalProducts + '</td><td >' + '</td></tr>';
                }); $("#ebayFood").append(row);
            }
        });
    });
}
//GetEbayTrans
function getEbayTrans() {
    $(document).ready(function () {
        var data = [];
        $.ajax({
            method: 'Get',
            url: '/api/Ebay/GetAllTrans',
            dataType: 'json',
            data: JSON.stringify(data),
            success: function (data) {
                var row = '';
                $.each(data, function (index, obj) {
                    row += '<tr><td > '
                        + obj.productName + ' </td> <td> '
                        + obj.asin + ' </td> <td>'
                        + obj.price + '</td> <td >'
                        + obj.lastDayQtySold + '</td><td >'
                        + obj.lastDayProfit + '</td><td >'
                        + obj.lastUpdateDate +
                        '</td></tr>';
                }); $("#ebayTrans").append(row);
            }
        });
    });
}