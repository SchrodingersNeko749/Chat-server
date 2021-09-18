
class Message {
    textElement
    userElement
    dateElement
    constructor(text)
    {
        this.textElement = document.createElement("div")
        this.textElement.className = "message-text"
        this.textElement.innerHTML = text
        
        this.className = "message"
        this.addToChat()
    }
    addToChat()
    {
        var messages = document.getElementById("messages")
        var container = document.createElement("div")
        container.className = "message"
        container.appendChild(this.textElement)
        messages.appendChild(container)
    }
}
function ClearChatHistory() {
    var messages =  document.getElementById("messages")
    messages.children[0].remove()
}
function ShowError(error) {
    var errElmn = document.createElement("div")
    errElmn.className = "Error"
    errElmn.innerHTML = error
    document.getElementById("messages").appendChild(errElmn)
}