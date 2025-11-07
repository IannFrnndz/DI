const nombre = document.getElementById('nombre');
const apellidos = document.getElementById('apellidos');
const edad = document.getElementById('edad');
const politica = document.getElementById('politica');
const dni = document.getElementById('dni');
const nie = document.getElementById('nie');
const radioDni = document.getElementById('radioDNI');
const radioNie = document.getElementById('radioNIE');

const contenedorNie = document.getElementById('contenedorNie');
const contenedorDni = document.getElementById('contenedorDni');

const contenedorInputs = document.getElementById('contenedorInputs');

// ocultar contenedores

contenedorDni.style.display = 'none';
contenedorNie.style.display = 'none';

radioDni.addEventListener('click', () => {
    // contenedorNie.style.display = 'none';
    // contenedorDni.style.display = 'grid';
    
    contenedorInputs.style.gridTemplateRows ="'nombre apellidos''opcion opcion''edad edad''dni dni''politica politica'";
    dni.value = '';
});

radioNie.addEventListener('click', () => {
    contenedorNie.style.display = 'grid';
    contenedorDni.style.display = 'none';
    contenedorInputs.style.gridTemplateRows ="'nombre apellidos''opcion opcion''edad edad''nie nie''politica politica'";
    nie.value = '';
    
});