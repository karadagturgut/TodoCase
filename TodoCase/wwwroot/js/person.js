var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').dataTable({
        "ajax": {
            "url": "/Person/GetAll"
        },
        "columns": [
            { "data": "name", "width": "15%" },
            { "data": "lastName", "width": "15%" },
            { "data": "birthDate", "width": "15%" },
            { "data": "gender", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
    <a href="/Person/Update/${data}" class="btn btn-success text-white" style="cursor:pointer">
        <i class="fas fa-edit"></i>
    </a>
    <a onclick=Delete("/Person/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">
        <i class="fas fa-trash-alt"></i>
    </a>
    <a href="/Person/PersonsTask/${data}" class="btn btn-success text-white" style="cursor:pointer">
        <i class="fas fa-list"></i>
    </a>
</div>
`;
                }, "width": "20%"
            }
        ]

    });
}

function Delete(url) {
    swal({
        title: "Bu kayıt silinecektir. Devam etmek istiyor musunuz?",
        text: "Bu işlem geri alınamaz!",
        icon: "warning",
        buttons: true,
        dangerMode: true
    }).then((willDelete) => {
        if (willDelete) {
            $.ajax({
                type: "DELETE",
                url: url,
                success: function (data) {
                    if (data.success) {
                        toastr.success(data.message);
                        dataTable.api().ajax.reload();
                    }
                    else {
                        toastr.error(data.message);
                    }
                }
            })
        }

    });

}