// URL base de la API 
const API_URL = "http://localhost:5166/personas";

let contenedor = document.getElementById("contenedor");

//personas
if (contenedor) {
    fetch(API_URL)
        .then(res => {
            if (!res.ok) {
                return;
            } else {
                return res.json();
            }
        })
        .then(todos => {
            if (todos) {
                console.log(todos);

                todos.forEach(persona => {
                    contenedor.innerHTML += `
                    <div class="card">
                        <div class="titulo">
                            <h2>${persona.id} - ${persona.nombre}</h2>
                        </div>

                        <div class="imagen"> 
                            <p>${persona.apellidos}</p> 
                        </div>

                        <div class="precio"> 
                            <p>Edad: ${persona.edad} años</p> 
                            <p>DNI: ${persona.dni}</p> 
                            <p>Lugar Nacimiento: ${persona.lugarNacimineto}</p> 
                            <p>País: ${persona.paisNacimineto}</p> 
                            <p>Dirección: ${persona.direccion}</p> 
                            <p>Estudio: ${persona.ultimoEstudio}</p> 
                        </div>

                        <div class="botones">
                            <button style="background:green;" onClick="editarProducto('${persona.dni}')">EDITAR</button>
                        </div>

                        <div class="botones">
                            <button onClick="eliminarProducto(${persona.id})">ELIMINAR</button>
                        </div>
                    </div>
                    `;
                });
            } else {
                return;
            }
        });
}

// eliminar persona
function eliminarProducto(id) {
    if (confirm("¿Estás seguro de que deseas eliminar esta persona?")) {
        fetch(`${API_URL}/${id}`, {
            method: 'DELETE',
        })
        .then(res => {
            if (res.ok) {
                alert("Persona eliminada correctamente");
                location.reload();
            }
        });
    }
}

// crear personas
if (document.getElementById('formulario')) {
    let formulario = document.getElementById('formulario');

    formulario.addEventListener('submit', (e) => {
        e.preventDefault();

        fetch(API_URL, {
            method: "POST",
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({
                nombre: formulario.nombre.value,
                apellidos: formulario.apellidos.value,
                edad: Number(formulario.edad.value),
                dni: formulario.dni.value,
                lugarNacimineto: formulario.lugarNacimineto.value,
                paisNacimineto: formulario.paisNacimineto.value,
                direccion: formulario.direccion.value,
                ultimoEstudio: formulario.ultimoEstudio.value
            })
        })
        .then((res) => {
            if (res.status == 201) {
                alert("Persona creada correctamente");
                location.href = "index.html";
            } else {
                return res.text().then(text => {
                    alert("Error: " + text);
                });
            }
        });
    });
}

// editar persona
function editarProducto(dni) {
    localStorage.setItem("dniEditar", dni);
    location.href = "editar.html";
}

// Cargar datos
if (document.getElementById("formularioEditar")) {
    let formularioEditar = document.getElementById("formularioEditar");
    let dni = localStorage.getItem("dniEditar");

    if (dni) {
        fetch(`${API_URL}/${dni}`)
            .then(res => {
                if (!res.ok) {
                    throw new Error("No se encontró la persona");
                }
                return res.json();
            })
            .then(persona => {
                formularioEditar.id.value = persona.id;
                formularioEditar.nombre.value = persona.nombre;
                formularioEditar.apellidos.value = persona.apellidos;
                formularioEditar.edad.value = persona.edad;
                formularioEditar.dni.value = persona.dni;
                formularioEditar.lugarNacimineto.value = persona.lugarNacimineto;
                formularioEditar.paisNacimineto.value = persona.paisNacimineto;
                formularioEditar.direccion.value = persona.direccion;
                formularioEditar.ultimoEstudio.value = persona.ultimoEstudio;
            })
            .catch(error => {
                console.error("Error:", error);
                alert("Error al cargar los datos de la persona");
                location.href = "index.html";
            });
    }

    formularioEditar.addEventListener("submit", (e) => {
        e.preventDefault();

        fetch(API_URL, {
            method: 'PUT',
            headers: { "Content-Type": "application/json" },
            body: JSON.stringify({
                id: Number(formularioEditar.id.value),
                nombre: formularioEditar.nombre.value,
                apellidos: formularioEditar.apellidos.value,
                edad: Number(formularioEditar.edad.value),
                dni: formularioEditar.dni.value,
                lugarNacimineto: formularioEditar.lugarNacimineto.value,
                paisNacimineto: formularioEditar.paisNacimineto.value,
                direccion: formularioEditar.direccion.value,
                ultimoEstudio: formularioEditar.ultimoEstudio.value
            })
        })
        .then((res) => {
            if (res.ok) {
                alert("Persona actualizada correctamente");
                localStorage.removeItem("dniEditar");
                location.href = "index.html";
            } else {
                return res.text().then(text => {
                    alert("Error: " + text);
                });
            }
        });
    });
}