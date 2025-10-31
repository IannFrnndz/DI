// Referencias a elementos del formulario (mantener los mismos IDs que en index.html)
let formulario = document.getElementById("formulario");
let email = document.getElementById("email");
let comunidad = document.getElementById("comunidad");
let provincia = document.getElementById("provincia");
let codigo = document.getElementById("codigo");
let ciudad = document.getElementById("inputCity");
let direccion = document.getElementById("inputAddress");
let password = document.getElementById("password");
let boton = document.getElementById("boton");
let feedback = document.getElementById("feedback");

console.log(email, password, boton, comunidad, provincia, codigo, ciudad, direccion, feedback);

boton.addEventListener("click", (e) => {
    e.preventDefault();

    

    // limpiar estado previo
    if (feedback) {
        feedback.classList.remove('alert-success', 'alert-danger');
        feedback.classList.add('d-none');
        feedback.textContent = '';
    }

    // logs para depuración
    console.log({
        email: email?.value,
        password: password?.value,
        comunidad: comunidad?.value,
        provincia: provincia?.value,
        codigo: codigo?.value,
        ciudad: ciudad?.value,
        direccion: direccion?.value
    });

    if (password && feedback) {
        if (password.value === "123") {
            feedback.textContent = "Contraseña no válida.";
            feedback.classList.remove('d-none');
            feedback.classList.add('alert', 'alert-danger');
        } else {
            feedback.textContent = "Contraseña correcta.";
            feedback.classList.remove('d-none');
            feedback.classList.add('alert', 'alert-success');
        }
    }
});