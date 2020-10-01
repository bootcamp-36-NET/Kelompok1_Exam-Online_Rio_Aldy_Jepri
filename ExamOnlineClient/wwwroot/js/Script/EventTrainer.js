var table = null;

$(document).ready(function () {
    //debugger;
    table = $('#TblEventT').DataTable({
        "processing": true,
        "responsive": true,
        "pagination": true,
        "stateSave": true,
        "ajax": {
            url: "/events/Load/",
            type: "GET",
            dataType: "json",
            dataSrc: "",
        },
        "columns": [
            {
                "data": "id",
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            { "data": "name" },
            {
                "data": "startDate",
                'render': function (jsonDate) {
                    var date = new Date(jsonDate);
                    return moment(date).format('DD MMMM YYYY');
                }
            },
            {
                "data": "endDate",
                'render': function (jsonDate) {
                    var date = new Date(jsonDate);
                    return moment(date).format('DD MMMM YYYY');
                }
            }
        ]
    });
});