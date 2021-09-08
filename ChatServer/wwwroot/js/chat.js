// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
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
function inputKey(input, ev)
{
    if(ev.keyCode == "13")
    {
        postMessage(input.value)
        input.value = ""
    }
}
function postMessage(message) {
    new Message(message)
}