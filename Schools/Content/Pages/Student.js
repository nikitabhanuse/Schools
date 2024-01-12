$(document).ready(function () {
    GetStudentlst();
});
var SaveStudent = function () {
    debugger;
    var Name = $("#txtname").val();
    var Mobile = $("#txtm").val();
    var Class = $("#txtc").val();
    var DeptId = $("#txtdId").val();

    var model = {
        Name: Name,
        Mobile: Mobile,
        Class: Class,
        DeptId: DeptId
    }

    $.ajax({
        url: "/Student/SaveStudent",
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
var GetStudentlst = function () {
    debugger;
    $.ajax({
        url: "/Student/GetStudentlst",
        method: "post",
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#tblStudent tbody").empty();
            $.each(response.Message, function (index, elementValue) {
                html += "<tr><td>" + elementValue.Name +
                    "</td><td>" + elementValue.Mobile +
                    "</td><td>" + elementValue.Class +
                    "</td><td>" + elementValue.DeptId + "</td><td><button type='button' class='btn btn-primary btn-sm' onclick='deleteStudent(" + elementValue.Id + ")'><i class ='bi bi-trash-fill' aria-hidden='true'></i></button></td></tr>"
            });
            $("#tblStudent tbody").append(html);
        }
    });
}

var deleteStudent = function (Id) {
    var model = { Id: Id };
    $.ajax({
        url: "/Student/deleteStudent",
        method: "post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        dataType: "json",
        async: false,

        success: function (response) {
            alert("Deleted");
            GetStudentlst()
        },
        error: function (response) {
            alert(response.model);
        }
    });
}
