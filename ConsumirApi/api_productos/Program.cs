// el constructor
var constructor =  WebApplication.CreateBuilder(args);

constructor.Services.AddCors(opciones =>
{
    opciones.AddDefaultPolicy(politicas =>
        politicas.WithOrigins("http://127.0.0.1:5500", "http://127.0.0.1:5500")
                .AllowAnyHeader()
                .AllowAnyMethod());
 
});

var app = constructor.Build();
app.UseCors();

var listaProductos = new List<Producto>
{
    new(1, "Camiseta básica", 12.99m, "Ropa", "https://picsum.photos/seed/prod1/400/300"),
    new(2, "Zapatillas deportivas", 59.90m, "Calzado", "https://picsum.photos/seed/prod2/400/300"),
    new(3, "Mochila urbana", 29.50m, "Accesorios", "https://picsum.photos/seed/prod3/400/300"),
    new(4, "Auriculares Bluetooth", 24.99m, "Tecnología", "https://picsum.photos/seed/prod4/400/300"),
    new(5, "Teclado mecánico", 79.00m, "Tecnología", "https://picsum.photos/seed/prod5/400/300"),
    new(6, "Botella térmica", 15.25m, "Hogar", "https://picsum.photos/seed/prod6/400/300"),
    new(7, "Libro de diseño", 18.80m, "Libros", "https://picsum.photos/seed/prod7/400/300"),
    new(8, "Lámpara LED", 22.40m, "Hogar", "https://picsum.photos/seed/prod8/400/300"),
    new(9, "Gorra clásica", 9.99m, "Accesorios", "https://picsum.photos/seed/prod9/400/300"),
    new(10, "Sudadera con capucha", 34.95m, "Ropa", "https://picsum.photos/seed/prod10/400/300"),
};

//Ruta que saluda
app.MapGet("/", () => Results.Ok("ESTA TODO CORRECTO"));

// ruta para obtener todos los productos
app.MapGet("/productos", () => Results.Ok(listaProductos));

// ruta para obtener un producto por id
app.MapGet("/productos/{id:int}", (int id) =>
{
    var producto = listaProductos.FirstOrDefault(elementoDeLista => elementoDeLista.Id == id);
    return producto is null ? Results.NotFound("404, Producto no encontrado") : Results.Ok(producto);

});

app.MapPost("/productos", (ProductoCrear nuevoProducto) =>
{
    if (string.IsNullOrWhiteSpace(nuevoProducto.Nombre)) 
    {
        return Results.BadRequest("dale un nombre que no tiene");
    }
    if (nuevoProducto.Precio <= 0) 
    {
        return Results.BadRequest("el precio debe ser mayor a 0");
        
        
    }
    //var idProducto = listaProductos.Any() ? listaProductos.Max(elementoLista => elementoLista.Id) + 1 : 1;
    
    var idProducto = 1;// si no tiene nada no entra a la condicion siguiente y se queda en 1
    if (listaProductos.Any())// evaluamos si tiene elementos true/false
    {
        idProducto = listaProductos.Max(elementoDeLista => elementoDeLista.Id) + 1;
    }
    
    // crear el producto
    var productoCreado = new Producto(
        idProducto,
        nuevoProducto.Nombre,
        nuevoProducto.Precio, 
        nuevoProducto.Categoria, 
        nuevoProducto.UrlImagen
    );
    
    //lo damos de alta en la listaProductos
    listaProductos.Add(productoCreado);
    return Results.Created("si se creo el producto ", productoCreado);
});

app.MapPut("/productos", (Producto productoActualizado) =>
{
    // verificamos si el producto existe
    if (listaProductos.FirstOrDefault(elementoLista => elementoLista.Id == productoActualizado.Id) == null)
    {
        return Results.NotFound("No se encontro el producto para actualizar");
    }
    //sacamos el id del producto a actualizar
    var index = listaProductos.FindIndex(elementoLista => elementoLista.Id == productoActualizado.Id);
    // cambiamos el producto en la lista por el que nos esta llegando
    listaProductos[index] = productoActualizado;
    return Results.Ok("Producto actualizado correctamente", productoActualizado);
});

app.MapDelete("/productos/{id:int}", (int id) =>
{
    var producto = listaProductos.FirstOrDefault(elementoDeLista => elementoDeLista.Id == id);
    if (producto == null)
    {
        return Results.NotFound("No se encontro el producto para eliminar");
    }
    listaProductos.Remove(producto);
    return Results.Ok("Producto eliminado correctamente", producto);
});

app.Run();

public record Producto(int Id, string Nombre, decimal Precio, string Categoria, string UrlImagen);

public record ProductoCrear(string Nombre, decimal Precio, string Categoria, string UrlImagen);