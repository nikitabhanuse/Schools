var SaveDept = function () {
    debugger;
    
    var DeptId = $("#txtdId").val();
    var DeptName = $("#txtDname").val();

    var model = {
       
        DeptId: DeptId,
        DeptName: DeptName

    }

    $.ajax({
        url: "/Dept/SaveDept",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        sucess: function (response) {
            alert(response.Message)
        },
        error: function (response) {
            alert(response.Message)
        },

    });

}
