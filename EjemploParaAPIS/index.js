let contenedor = document.getElementById("contenedor");


fetch("http://localhost:5110/productos")

    .then(res => {
        if (!res.ok) {
            return;
        } else {
            return res.json();
        }
    })

    .then(todos => {
        if (todos) {

            todos.forEach(producto => {
                contenedor.innerHTML += `
                <div class="card">
            
                    <div class="titulo">
                        <h2>${producto.id} ${producto.nombre}</h2>
                    </div>
                    
                    
                    <div>
                        <img src="${producto.urlImagen}">
                    </div>
                    
                    <div class="precio">
                        <p>Precio: $${producto.precio}</p>
                        <p>Categoria: ${producto.categoria}</p>
                    </div>

                    <div class="botones">
                        <button onclick="eilminarProducto( ${producto.id})">Eliminar</button>
                    </div>
                    <div class="botones">
                        <button style="background-color: blue;" onclick="editarProducto( ${producto.id})">Editar</button>
                    </div>

                </div>`;
            });

        } else {
            return;
        }
    })

    function eilminarProducto(id) {
        if(confirm("¿Estás seguro de que deseas eliminar este producto?")){
            fetch(`http://localhost:5110/productos/`+id, {
            method: 'DELETE',
        }).then(()=> location.reload());
        }
        
    }

    if(document.getElementById("formulario")) {
        let formulario = document.getElementById("formulario");

        formulario.addEventListener("submit", (e) => {
            e.preventDefault();
            fetch("http://localhost:5110/productos", {
                method: 'POST',
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify({
                    nombre: formulario.nombre.value,
                    precio: Number(formulario.precio.value),
                    categoria: formulario.categoria.value,
                    urlImagen: formulario.urlImagen.value
                })
            })
            .then((res) => {
                if(res.status == 201){
                    alert("Producto agregado correctamente")
                    location.href = "index.html";
                }
            });
        });
    }

    function editarProducto(id) {
        fetch(`http://localhost:5110/productos`, {
            method: 'GET'
            
        }).then(res => {
        if (!res.ok) {
            return;
        } else {
            return res.json();
        }
    }).then(datos => {
        let section = document.getElementById("contenedor");
        location.href = `#formulario`;
        section.style.display = "none";

        let nombre = document.getElementById("nombre");
        let precio = document.getElementById("precio");
        let categoria = document.getElementById("categoria");
        let urlImagen = document.getElementById("urlImagen");

        id.value = datos.id;
        nombre.value = datos.nombre;
        precio.value = datos.precio;
        categoria.value = datos.categoria;
        urlImagen.value = datos.urlImagen;
        
    }) ;


    if(document.getElementById("formulario")) {
        let formulario = document.getElementById("formulario");

        formulario.addEventListener("submit", (e) => {
            e.preventDefault();
            fetch("http://localhost:5110/productos", {
                method: 'PUT',
                headers: {"Content-Type": "application/json"},
                body: JSON.stringify({
                    id: Number(formulario.id.value),
                    nombre: formulario.nombre.value,
                    precio: Number(formulario.precio.value),
                    categoria: formulario.categoria.value,
                    urlImagen: formulario.urlImagen.value
                })
            })
            .then((res) => {
                if(res.status == 201){
                    alert("Producto agregado correctamente")
                    location.href = "index.html";
                }
            });
        });
    }
}
    