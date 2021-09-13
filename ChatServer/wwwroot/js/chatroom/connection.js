"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();

connection.on("ReceiveMessage", function (user, message) {
    new Message(user+" : "+message)
});

connection.start().then(function () {
    
}).catch(function (err) {
    return console.error(err.toString());
});
function loginRequest(request) {
    alert(request.name)
}