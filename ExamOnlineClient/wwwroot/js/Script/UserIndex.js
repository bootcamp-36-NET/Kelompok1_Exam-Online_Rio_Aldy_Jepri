﻿$(document).ready(function () {
    loadData();
});
var id = null;
function loadData() {
    $.ajax({
        url: "/examinations/GetUser",
        data: "",
        cache: false,
        type: "GET",
        dataType: "JSON"
    }).then((result) => {
        debugger;
        $('#Id').html(result.Item1.Id);
        id = result.Item1.Id;
        $('#EmployeeId').html(result.Item1.EmployeeId);
        $('#Subject').html(result.Item1.SubjectId);
        $('#CreatedDate').html(result.Item1.CreatedDate);
    });
}

function Update() {
    debugger;
    var Examination = new Object();
    Examination.Id = id;
    Examination.RescheduleDate = $('#Schedule').val();
    $.ajax({
        type: 'POST',
        url: "/examinations/InsertOrUpdate/",
        cache: false,
        dataType: "JSON",
        data: Examination
    }).then((result) => {
        debugger;
        if (result.statusCode === 200) {
            Swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Request Reschedule Successfull',
                showConfirmButton: false,
                timer: 1500,
            });
            table.ajax.reload(null, false);
        } else {
            Swal.fire('Error', 'Failed to Input', 'error');
            ClearScreen();
        }
    })
}