function searchAccount() {
    var search = $("#searchString").val();
    $.ajax({
        url: "",
        data: {
            searchstring: search
        }
    }).done(function (data) {
        $("#personId").val(date.PersonId);
        $("#FirstName").val(date.FirstName);
        $("#LastName").val(date.LastName);
        $("#Age").val(date.Age);
        $("#Gender").val(date.Gender);
        $("#Email").val(date.Email);
        $("#PlayerName").val(date.PlayerName);
        $("#Phone").val(date.Phone);
        $("#UserPassword").val(date.UserPassword);

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
            $("#succMessage").removeClass("invisible").addClass("visible");
        } else {
            $("#errMessage").removeClass("invisible").addClass("visible");        }
    });
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
