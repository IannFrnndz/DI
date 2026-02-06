//consumir productos

let contenedor = document.getElementById("contenedor");

fetch("http://localhost:5139/personas")

    .then(res => {

        if (!res.ok) {
            return;
        } else {

            return res.json();
        }
    })
    .then(todos => {
        if (todos) {

            console.log(todos)

            todos.forEach(persona => {

                contenedor.innerHTML += `
            <div class="card">
            
                <div class="titulo">
               
                    <h2> ${persona.id} ${persona.nombre}</h2>
                </div>

                <div class="imagen"> 
                  <p>${persona.apellidos}</p> 
                </div>

                <div class="precio"> 
                  <p >edad: ${persona.edad} </p> 
                  <p >dni: ${persona.dni} </p> 

                  <p >lugar Nacimineto: ${persona.lugarNacimineto} </p> 

                </div>

                <div class="botones">
                    <button style="background:green;" onClick="editarProducto(${persona.id})">EDITAR</button>
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
    })