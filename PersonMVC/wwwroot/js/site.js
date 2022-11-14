//JavaScript Code

function getLastPerson(actionUrl) {
    $.get(actionUrl, function (response); {
        console.log("Response", response);
        document.getElementById("result").innerHTML = response;

    });
}

function getPersonList(actionUrl) {
    $.get(actionUrl, function (response) {
        console.log("Response:", response);
        document.getElementById("result").innerHTML = response;
    });
}
function getLastPersonJSON(actionUrl) {
    $.get(actionUrl, function (response) {
        console.log("JSON Response:", response);
        document.getElementById("result").innerHTML = response;
    });
}