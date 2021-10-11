var selectedContact = ""
function AddContact(c) {
    var contactElement = document.createElement("div")
    contactElement.className = "contact"
    contactElement.innerHTML = c
    contactElement.addEventListener("click", function () {
        selectedContact = contactElement.innerHTML
        GetChatHistory()
    });
    document.getElementById("contacts").appendChild(contactElement)
}
function RemoveContacts() {
    var contacts = document.getElementById("contacts").children
    for (let index = 0; index < contacts.length; index++) {
        contacts[index].remove()
    }
}
function GetChatHistory() {
    ShowError("Will implement chat history soon enough")
    ClearChatHistory();
}