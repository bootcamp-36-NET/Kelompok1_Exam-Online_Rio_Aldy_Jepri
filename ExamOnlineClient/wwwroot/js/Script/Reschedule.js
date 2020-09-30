var table = null;
var nb = 0;

$(document).ready(function () {
    debugger;
    table = $("#ManageQuestions").DataTable({
        "processing": true,
        "responsive": true,
        "pagination": true,
        "stateSave": true,
        "ajax": {
            url: "/examinations/readSchedule/",
            type: "GET",
            dataType: "json",
            dataSrc: "",
        },
        "columns": [
            {
                "data": "id",
                render: function (data, type, row, meta) {
                    //console.log(row);
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            { "data": "employeeId" },
            { "data": "subjectId" },
            {
                "data": "createdDate",
                "render": function (jsonDate) {
                    var date = moment(jsonDate).format("DD MMMM YYYY, h:mm:ss a");
                    return date;
                }
            },
            {
                "data": "rescheduleDate",
                "render": function (jsonDate) {
                    var date = moment(jsonDate).format("DD MMMM YYYY, h:mm:ss a");
                    return date;
                }
            },
            {
                "sortable": false,
                "render": function (data, type, row, meta) {
                    $('[data-toggle="tooltip"]').tooltip();
                    return '<button class="btn btn-outline-success btn-circle" data-placement="left" data-toggle="tooltip" data-animation="false" title="Edit" onclick="return Approve(' + meta.row + ')" ><i class="fa fa-lg fa-check"></i></button>'
                        + '&nbsp;'
                        + '<button class="btn btn-outline-danger btn-circle" data-placement="right" data-toggle="tooltip" data-animation="false" title="Delete" onclick="return Reject(' + meta.row + ')" ><i class="fa fa-lg fa-times"></i></button>'
                }
            }
        ],

    });
});



function ClearScreen() {
    LoadTrainee($('#TraineeOption'));
    $('#Id').val('');
    $('#TraineeOption').val('0');
    $('#Name').val('');
    $('#Update').hide();
    $('#Insert').show();
}

function GetById(number) {
    debugger;
    var id = table.row(number).data().id;
    $.ajax({
        url: "/examinations/GetById/",
        data: { id: id }
    }).then((result) => {
        debugger;
        $('#Id').val(result.id);
        $('#SubjectsOption').val(result.subjectId);
        $('#TraineeOption').val(result.employeeId);
        $('#Schedule').val(result.createdDate);
        $('#Insert').hide();
        $('#Update').show();
        $('#exampleModal').modal('show');
    })
}


function approve(nummber) {
    debugger;
    var id = table.row(nummber).data().id;
    $.ajax({
        type: 'post',
        url: "/examinations/approve/",
        cache: false,
        datatype: "json",
        data: acc
    }).then((result) => {
        //debugger;
        if (result.statuscode == 200) {
            swal.fire({
                position: 'center',
                icon: 'success',
                title: 'jobseeker has been approved',
                showconfirmbutton: false,
                timer: 1500,
            });
            table.ajax.reload(null, false);
        } else {
            swal.fire('error', 'failed to approved', 'error');
            clearscreen();
        }
    })
}

function reject() {
    debugger;
    var acc = new object();
    acc.id = $('#id').val();
    acc.employeeId = $('#name').val();
    $.ajax({
        type: 'post',
        url: "/examinations/reject/",
        cache: false,
        datatype: "json",
        data: acc
    }).then((result) => {
        //debugger;
        if (result.statuscode == 200) {
            swal.fire({
                position: 'center',
                icon: 'success',
                title: 'jobseeker has been rejecct',
                showconfirmbutton: false,
                timer: 1500,
            });
            table.ajax.reload(null, false);
        } else {
            swal.fire('error', 'failed to reject', 'error');
            clearscreen();
        }
    })
}