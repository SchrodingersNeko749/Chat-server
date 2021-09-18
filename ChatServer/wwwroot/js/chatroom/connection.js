"use strict";

var connection = new signalR.HubConnectionBuilder().withUrl("/chatHub").build();
connection.on("ReceiveMessage", function (user, message) {
    new Message(user+" : "+message)
});
var id = -1
var username = ""
connection.start().then(function () {
    
}).catch(function (err) {
    return console.error(err.toString());
});
function loginRequest(request) {
    alert(request.username)
    connection.invoke("Login", request).catch(function (err) {
        return console.error(err.toString());
    });
}
connection.on("LoginResponse", function (_id, _username,welcome) {
    id = _id
    username = _username
    new Message(welcome)
    form.parentElement.parentElement.style.display = "none"
    connection.invoke("GetContacts", id).catch(function (err) {
        return console.error(err.toString());
    });
})
connection.on("RecieveContacts", function(contacts){
    contacts.forEach(c => {
        AddContact(c)
    });
})
