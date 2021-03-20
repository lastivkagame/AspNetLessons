function onSearch(e) {
    if (e.key === "Enter") {
        location.href = `/Games/Index?search=${e.target.value}`;
    }
}

function ChoosenUrlImg(element) {
    var selector = $(element).data("input-to-show"); 
    var selector2 = $(element).data("input-to-hide"); 

    if ($(element).is(':checked')) {
        $(selector).hide();
        $(selector2).show();
    } else {
        $(selector).show();
        $(selector2).hide();
    }
}

