function AddContact(c) {
    var contactElement = document.createElement("div")
    contactElement.className = "contact"
    contactElement.innerHTML = c
    contactElement.addEventListener("click", function () {
        GetChatHistory()
    });
    document.getElementById("contacts").appendChild(contactElement)
}
function GetChatHistory() {
    ShowError("Will implement chat history soon enough")
    ClearChatHistory();
}