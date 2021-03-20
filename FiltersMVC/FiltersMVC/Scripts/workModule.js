//let workModule = (function () {

//    let selectors =
//    {
//        bage: "#bage"
//    };

//    function onGetStateClick(element)
//    {
//        let url = $(element).data("href");

//        $.ajax({
//            url: url,
//            type: "GET",
//            dataType: "json",
//            success: (data) =>
//            {
//                updateState(data);
//            },
//            error: (data) => {
//                console.log(data);
//            }
//        });
//    }

//    function updateState(state)
//    {
//        $(selectors.bage).text(state);
//    }

//    return {
//        onGetStateClick: onGetStateClick
//    }

//})(jQuery)

var workModule = (function () {
    var selectors = {
        bage: "#badge"
    };



    function onGetStateClick(element) {
        var url = $(element).data("href");



        $.ajax({
            url: url,
            type: "POST",
            dataType: "json",
            success: (data) => {
                updateState(data.result);
            },
            error: (data) => {
                console.log(data.result);
            }
        });
    }



    function updateState(state) {
        $(selectors.bage).text(state);
    }



    return {
        onGetStateClick: onGetStateClick
    }
})(jQuery)

function MyDoSignOut(element)
{
    var url = $(element).data("href");
    $.ajax({
        url: url,
        type: "POST",
        dataType: "*",
        success: () => {
            $("#mylogin_signin").removeClass("d-none");
            $("#mybtn_signout").addClass("d-none");
        },
        error: (data) => {
            console.log(data)
        }
    });

    
}

function MyDoSignIn()
{
    location.href = `/Home/Login`;
    $("#mylogin_signin").addClass("d-none");
   // alert("work");
}

function MyDoSignRegistre() {
    //alert("work");
    location.href = `/Home/Login`;
    $("#mylogin_signin").addClass("d-none");
}