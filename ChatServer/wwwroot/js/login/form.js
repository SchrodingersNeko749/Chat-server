
var form = null
window.onclick = function(event) {
    if (event.target.className == "modal") {
        event.target.style.display = "none";
    }
}
window.addEventListener("load",function(){
	form = document.getElementById("login")
	form.onsubmit = function (evt){
		evt.preventDefault();
		isFormValid(form.elements["name"].value, form.elements["password"].value)
	}
});



function isFormValid(name, password){
	if(name.length != 0 && password.length != 0)
	{
		var request = new Object()
		request.username = name
		request.password = password
   		var jsonString= JSON.stringify(request)
		loginRequest(request)
	}
	else
		alert("shit went wrong")
}