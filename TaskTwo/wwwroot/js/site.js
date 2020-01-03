//GetAmazonFood
function getAmazonFood() {
    $(document).ready(function () {
        var data = [];
        $.ajax({
            method: 'Get',
            url: '/api/MasterPage/GetAll',
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
            url: '/api/MasterPage/GetAllTrans',
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
