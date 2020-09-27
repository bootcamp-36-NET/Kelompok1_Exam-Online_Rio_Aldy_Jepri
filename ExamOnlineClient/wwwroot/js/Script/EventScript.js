﻿var table = null;

$(document).ready(function () {
    debugger;
    table = $('#TblEvent').DataTable({
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
            },
            {
                "sortable": false,
                "render": function (data, type, row, meta) {
                    //console.log(row);
                    $('[data-toggle="tooltip"]').tooltip();
                    return '<button class="btn btn-outline-warning btn-circle" data-placement="left" data-toggle="tooltip" data-animation="false" title="Edit" onclick="return GetById(' + meta.row + ')" ><i class="fa fa-lg fa-edit"></i></button>'
                        + '&nbsp;'
                        + '<button class="btn btn-outline-danger btn-circle" data-placement="right" data-toggle="tooltip" data-animation="false" title="Delete" onclick="return Delete(' + meta.row + ')" ><i class="fa fa-lg fa-times"></i></button>'
                }
            }
        ]
    });
});

function ClearScreen() {
    $('#Id').val('');
    $('#Name').val('');
    $('#StartDate').val('');
    $('#EndDate').val('');
    $('#update').hide();
    $('#add').show();
}

function GetById(number) {
    debugger;
    var id = table.row(number).data().id;
    $.ajax({
        url: "/events/GetById/",
        data: {id : id}
    }).then((result) => {
        debugger;
        $('#Name').val(result.name);
        $('#StartDate').val(result.startDate);
        $('#EndDate').val(result.endDate);
        $('#add').hide();
        $('#update').show();
        $('#myModal').modal('show');
    })
}

function Save() {
    debugger;
    var item = new Object();
    item.Name = $('#Name').val();
    item.StartDate = $('#StartDate').val();
    item.EndDate = $('#EndDate').val();
    $.ajax({
        url: "/events/insert/",
        type: "POST",
        dataType: "JSON",
        data: item
    }).then((result) => {
        debugger;
        if (result.success == true) {
            swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Data Saved',
                showConfirmationButton: false,
                timer: 1500,
            })
            table.ajax.reload(null, false);
        } else {
            swal.fire('Error', 'Failed to input', 'error');
            ClearScreen();
        }
    })
}

function Update(id) {
    var id = table.row(number).data().id;
    var item = new Object();
    item.Name = $('#Name').val();
    item.StartDate = $('#StartDate').val();
    item.EndDate = $('#EndDate').val();
    $.ajax({
        type: "POST",
        url: "/events/insert/" + id,
        cache: false,
        dataType: "JSON",
        data: item
    }).then((result) => {
        if (result.success == true) {
            swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Data Updated',
                showConfirmationButton: false,
                timer: 1500,
            });
            table.ajax.reload(null, false);
        } else {
            Swal.fire('Error', 'Failed to input', 'error');
            ClearScreen();
        }
    })
}

function Delete(number) {
    var id = table.row(number).data().id;
    swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert to this!",
        showCancelButton: true,
        showConfirmationButton: '#3085d6',
        cancelButtonColor: '#d33',
        confirmationButtonText: "Yes, I'm understand",
    }).then((resultSwal) => {
        debugger;
        if (resultSwal.value == true) {
            $.ajax({
                url: "/Events/Delete/",
                data: { id: id }
            }).then((result) => {
                debugger;
                if (result.success.statusCode == 200) {
                    Swal.fire({
                        position: 'Center',
                        icon: 'success',
                        title: 'Delete Successfully',
                        showConfirmationButton: false,
                        timer: 1500,
                    })
                    table.ajax.reload(null, false);
                } else {
                    swal.fire('Error', 'Delete failed', 'error');
                    ClearScreen();
                }
            })
        };
    });
}