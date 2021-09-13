function inputKey(input, ev)
{
    if(ev.keyCode == "13" && input.value!="")
    {
        postMessage(input.value)
        input.value = ""
    }
}

function postMessage(message) {
    new Message(message)
    connection.invoke("SendMessage", "neko", message).catch(function (err) {
        return console.error(err.toString());
    });
    chat = document.getElementById("messages")
    messages.scrollTo(0,messages.scrollHeight)
}
