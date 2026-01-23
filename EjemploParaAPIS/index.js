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

