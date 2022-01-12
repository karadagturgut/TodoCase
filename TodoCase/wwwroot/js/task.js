var dataTable;
$(document).ready(function () {
    loadDataTable();
});

function loadDataTable() {
    dataTable = $('#tblData').dataTable({
        "ajax": {
            "url": "/Task/GetAll"
        },
        "columns": [
            { "data": "id", "width": "15%" },
            { "data": "personelId", "width": "15%" },
            { "data": "description", "width": "15%" },
            { "data": "deadlineDate", "width": "15%" },
            {
                "data": "id",
                "render": function (data) {
                    return `<div class="text-center">
    <a href="/Task/Update/${data}" class="btn btn-success text-white" style="cursor:pointer">
        <i class="fas fa-edit"></i>
    </a>
    <a onclick=Delete("/Task/Delete/${data}") class="btn btn-danger text-white" style="cursor:pointer">
        <i class="fas fa-trash-alt"></i>
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