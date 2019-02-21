function searchAccount() {
    var search = $("#searchString").val();
    $.ajax({
        url: "",
        data: {
            searchstring: search
        }
    }).done(function (data) {
        $("#personId").val(data.PersonId);
        $("#FirstName").val(data.FirstName);
        $("#LastName").val(data.LastName);
        $("#Age").val(data.Age);
        $("#Gender").val(data.Gender);
        $("#Email").val(data.Email);
        $("#PlayerName").val(data.PlayerName);
        $("#Phone").val(data.Phone);
        $("#UserPassword").val(data.UserPassword);

    });
}
function Register() {
    var personId = $("#PersonId").val();
    var firstName = $("#FirstName").val();
    var lastName = $("#LastName").val();
    var age = $("#Age").val();
    var gender  = $("#Gender").val();
    var email = $("#Email").val();
    var playerName = $("#PlayerName").val();
    var phone   = $("#Phone").val();
    var password = $("#UserPassword").val();

    $.ajax({
        url: "Register",
        dataType: "Json",
        data: {
            FirstName: firstName,
            LastName: lastName,
            Age: age,
            Gender: gender,
            Email: email,
            PlayerName: playerName,
            Phone: phone,
            UserPassword: password,
        }
    }).done(function (data) {
        if (data) {
            $("#succMessage").removeClass("hidden").addClass("alert alert-success");
        } else {
            $("#errMessage").removeClass("hidden").addClass("alert alert-warning");        }
        }
    );
    document.getElementById("#personId").value = "";
    document.getElementById("#FirstName").value = "";
    document.getElementById("#LastName").value = "";
    document.getElementById("#PlayerName").value = "";
    document.getElementById("#Gender").value = "";
    document.getElementById("#Age").value = "";
    document.getElementById("#Phone").value = "";
    document.getElementById("#Age").value = "";
    document.getElementById("#UserPassword").value = "";
}
function Validate() {
    $.ajax(
        {
            type: "POST",
            url: '@Url.Action("Validate", "Account")',
            data: {
                email: $('#email').val(),
                password: $('#password').val()
            },
            error: function (result) {
                alert("There is a Problem, Try Again!");
            },
            success: function (result) {
                console.log(result);
                if (result.status == true) {
                    window.location.href = '@Url.Action("Index", "Home")';
                }
                else {
                    alert(result.message);
                }
            }
        });
}
