//JavaScript Code

function getLastPeople(actionUrl) {
    $.get(actionUrl, function (response); {
        console.log("Response", response);
        document.getElementById("result").innerHTML = response;

    });
}

function getPeopleList(actionUrl) {
    $.get(actionUrl, function (response) {
        console.log("Response:", response);
        document.getElementById("result").innerHTML = response;
    });
}
function getLastPeoplelJSON(actionUrl) {
    $.get(actionUrl, function (response) {
        console.log("JSON Response:", response);
        document.getElementById("result").innerHTML = response;
    });
}