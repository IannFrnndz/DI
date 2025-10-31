let formulario = document.getElementById("formulario");
let email = document.getElementById("email");
let password = document.getElementById("password");
let enviar = document.getElementById("enviar");

console.log(email, password, enviar);

enviar.addEventListener("click", (e) =>{
    e.preventDefault();
    console.log(email.value);
    console.log(password.value);

    if(password.value == 123){
        alert("Mario calla");
        document.body.style.background= "red";
    }else{
        document.body.style.background = "green";
    }
})