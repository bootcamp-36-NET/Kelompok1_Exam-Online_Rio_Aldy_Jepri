$(document).ready(function () {
    loadData();
});
var id = null;
function loadData() {
    $.ajax({
        url: "/notifications/loadnotif",
        data: "",
        cache: false,
        type: "GET",
        dataType: "JSON"
    }).then((result) => {
        debugger;
        $('#Id').append(result.id);
        $('#Message').append(result.message);
        $('#Emp').append(result.employeeId);
        $('#Date').append(result.createdDate);  
    });
}

//function Delete(id) {
//    debugger;
//    $('#Id').append(result.id);
//    Swal.fire({
//        title: 'Are you sure?',
//        text: "You won't be able to revert this!",
//        showCancelButton: true,
//        confirmButtonColor: '#3085d6',
//        cancelButtonColor: '#d33',
//        confirmButtonText: 'Yes, delete it!',
//    }).then((resultSwal) => {
//        if (resultSwal.value) {
//            debugger;
//            $.ajax({
//                url: "/questions/Delete/",
//                data: { id: id }
//            }).then((result) => {
//                debugger;
//                if (result.statusCode == 200) {
//                    //debugger;
//                    Swal.fire({
//                        position: 'center',
//                        icon: 'success',
//                        title: 'Delete Successfully',
//                        showConfirmButton: false,
//                        timer: 1500,
//                    });
//                    table.ajax.reload(null, false);
//                } else {
//                    Swal.fire('Error', 'Failed to Delete', 'error');
//                    ClearScreen();
//                }
//            })
//        };
//    });
//}