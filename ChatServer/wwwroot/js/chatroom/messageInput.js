function inputKey(input, ev)
{
    
    if(ev.keyCode == "13" && input.value!="")
    {
        console.log(input ,input.value)
        postMessage(id,"neko",input.value)
        //input.value = ""
    }
}

function postMessage(id, target, message) {
    new Message(message)
    connection.invoke("SendMessage", id, target, message).catch(function (err) {
        return console.error(err.toString());
    });
    chat = document.getElementById("messages")
    messages.scrollTo(0,messages.scrollHeight)
}
