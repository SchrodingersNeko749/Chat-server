
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
    document.getElementById("messages").removeChild()
}
