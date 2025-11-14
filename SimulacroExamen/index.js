const pass1 = document.getElementById('contraseña');
const pass2 = document.getElementById('exampleInputPassword2');
const form = document.getElementById('formulario');
const boton = document.getElementById('boton');



pass2.addEventListener('change', () => {
    console.log(pass1.value, pass2.value)
    if (pass1.value != null) {
        if (pass1.value != pass2.value) {
            alert('Las contraseñas no coinciden');
            boton.disabled = true;
        }else{
            
            boton.disabled = false;
        }
    }

    pass1.addEventListener('change', () => {
        console.log(pass1.value, pass2.value)
        if (pass2.value != null) {
            if (pass1.value != pass2.value) {
                alert('Las contraseñas no coinciden');
                boton.disabled = true;
            }else{
            
            boton.disabled = false;
            }
        }
    });


});




// document.querySelector('form').addEventListener('submit', function(e) {
//     const pass = document.getElementById('contraseña').value;
//     const repass = document.getElementById('exampleInputPassword2').value;

//     if (pass !== repass) {
//         e.preventDefault();
//         alert('Las contraseñas no coinciden');
//     }
// });
