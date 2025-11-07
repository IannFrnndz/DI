const nombre = document.getElementById("nombre");
const apellidos = document.getElementById("apellidos");
const dni = document.getElementById("dni");
const nie = document.getElementById("nie");

const contenedorInputs = document.getElementById("contenedorInputs");

const radioDni = document.getElementById("radioDni");
const radioNie = document.getElementById("radioNie");

const edad = document.getElementById("edad");
const politica = document.getElementById("politica");
const contenedorNie = document.getElementById("contenedorNie");
const contenedorDni = document.getElementById("contenedorDni");
const formulario = document.getElementById("miFormulario");

const listaInputs = []

// ocultar contenedores

//if (radioDni.checked) {
contenedorDni.style.display = "grid";
contenedorNie.style.display = "none";
//}

radioDni.addEventListener("click", () => {
    contenedorDni.style.display = "grid";
    contenedorNie.style.display = "none";
    //contenedorInputs.style.gridTemplateAreas = " 'nombre apellidos' 'opcion opcion' 'edad edad' 'dni dni' 'politica politica' ";
    nie.value = "";
})

radioNie.addEventListener("click", () => {
    contenedorDni.style.display = "none";
    contenedorNie.style.display = "grid";
    //contenedorInputs.style.gridTemplateAreas = " 'nombre apellidos' 'opcion opcion' 'edad edad' 'dni dni' 'politica politica' ";
    dni.value = "";
})

formulario.addEventListener("submit", (e) => {
    e.preventDefault();

    listaInputs.push({id:"nombre", valor: nombre.value});
    listaInputs.push({id:"apellidos", valor: apellidos.value});
    listaInputs.push({id:"edad", valor: edad.value});
    listaInputs.push({id:"politica", valor: politica.checked});
    if (radioDni.checked) {
        listaInputs.push({id:"dni", valor: dni.value});
    } 
    if (radioNie.checked) {
        listaInputs.push({id:"nie", valor: nie.value});
    }
    localStorage.setItem("misDatos",JSON.stringify(listaInputs));
    console.log(localStorage.getItem("misDatos"));

    setInterval(() =>console.log("guardando tus datos") , 1000);

    setTimeout(() =>alert("tengo tus datos ") , 5000);

    
});