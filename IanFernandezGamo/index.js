const pass1 = document.getElementById('contrasena');
const pass2 = document.getElementById('exampleInputPassword2');
const form = document.getElementById('formulario');
const boton = document.getElementById('boton');
const email = document.getElementById("email");
const telefono = document.getElementById("telefono");
const nombreUsuario = document.getElementById("nombreUsuario");

const nombre = document.getElementById("nombre");
const apellidos = document.getElementById("apellidos");

const politica = document.getElementById("politica");


const listaInputs = []


pass2.addEventListener('change', () => {
    console.log(pass1.value, pass2.value)
    if (pass1.value != null) {
        if (pass1.value != pass2.value) {
            alert('No coincide la clave');
            boton.disabled = true;
        }else{
            
            boton.disabled = false;
        }
    }

    pass1.addEventListener('change', () => {
        console.log(pass1.value, pass2.value)
        if (pass2.value != null) {
            if (pass1.value != pass2.value) {
                alert('No coincide la clave');
                boton.disabled = true;
            }else{
            
            boton.disabled = false;
            }
        }
    });


});


form.addEventListener("submit", (e) => {
    e.preventDefault();

    listaInputs.push({id:"nombre", valor: nombre.value});
    listaInputs.push({id:"apellidos", valor: apellidos.value});
    listaInputs.push({id:"email", valor: email.value});
    listaInputs.push({id:"telefono", valor: telefono.value});
    listaInputs.push({id:"nombreUsuario", valor: nombreUsuario.value});
    listaInputs.push({id:"contrasena", valor: pass1.value});
    listaInputs.push({id:"exampleInputPassword2", valor: pass2.value});
    listaInputs.push({id:"politica", valor: politica.checked});
    
    localStorage.setItem("misDatos",JSON.stringify(listaInputs));
    console.log(localStorage.getItem("misDatos"));

    setInterval(() =>console.log("Guardando tus datos") , 1000);

    setTimeout(() =>alert("Tengo tus datos ") , 5000);

    
});

