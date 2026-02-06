// paso 1
//crear los constructores iniciarlo y arrancar la app

var constructor = WebApplication.CreateBuilder(args);

constructor.Services.AddCors(opciones =>
{
    opciones.AddDefaultPolicy(politica =>
    {
        politica.AllowAnyOrigin() 
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = constructor.Build();

app.UseCors();

var listaPersona = new List<Persona>
{
    new(1, "Andrés", "Salazar Gómez", 29, "V12345678", "Caracas", "Venezuela", "Av. Libertador, Edif. Sol", "Universitario"),
    new(2, "Mariana", "Pinto Rodríguez", 34, "E23456789", "Madrid", "España", "Calle Gran Vía 120", "Postgrado"),
    new(3, "José", "Márquez León", 41, "M34567890", "Ciudad de México", "México", "Col. Roma Norte", "Universitario"),
    new(4, "Valentina", "Ríos Herrera", 22, "C45678901", "Bogotá", "Colombia", "Chapinero Alto", "Bachiller"),
    new(5, "Carlos", "Medina Torres", 37, "A56789012", "Buenos Aires", "Argentina", "Av. Corrientes 540", "Universitario"),
    new(6, "Paula", "Navarro Díaz", 26, "V44556677", "Mérida", "Venezuela", "Av. Las Américas, Apt. 3B", "Universitario"),
    new(7, "Ricardo", "Figueroa Silva", 45, "P67890123", "Lima", "Perú", "Miraflores, Calle 9", "Técnico Superior"),
    new(8, "Camila", "Suárez Pacheco", 31, "C78901234", "Medellín", "Colombia", "El Poblado", "Universitario"),
    new(9, "Daniel", "Peña Castillo", 28, "U89012345", "Montevideo", "Uruguay", "Barrio Pocitos", "Universitario"),
    new(10, "Lucía", "Ortega Morales", 39, "E90123456", "Barcelona", "España", "Calle Aragón 88", "Postgrado"),
    new(11, "Miguel", "Ramos Contreras", 24, "V10111213", "Guatire", "Venezuela", "Sector El Ingenio", "Universitario"),
    new(12, "Natalia", "Vera Montoya", 33, "C14151617", "Cali", "Colombia", "Barrio Granada", "Universitario"),
    new(13, "Óscar", "Luna Cabrera", 48, "B18192021", "La Paz", "Bolivia", "Zona Sopocachi", "Técnico Superior"),
    new(14, "Gabriela", "Mendoza Ruiz", 27, "H22232425", "Tegucigalpa", "Honduras", "Col. Morazán", "Universitario"),
    new(15, "Héctor", "Bautista Flores", 52, "C26272829", "Santiago", "Chile", "Providencia", "Bachiller")
};

// Desarrollar un endpoint GET para obtener toda la lista.
app.MapGet("/personas", () => listaPersona);

//Desarrollar un endpoint GET para obtener un solo elemento de la lista.
app.MapGet("/personas/{dni}", (string dni) =>
{
    var persona = listaPersona.FirstOrDefault(p => p.Dni == dni);
    if(persona != null)
    {
        return Results.Ok(persona);
    }else
    {
        return Results.NotFound("Persona no encontrada");
    }
});


// Desarrollar un endpoint POST para crear un nuevo elemento en la lista.

app.MapPost("/personas", (Persona nuevaPersona) =>
{
    // validaciones
    
    if(string.IsNullOrWhiteSpace(nuevaPersona.Nombre))
    {
        return Results.BadRequest("El nombre no puede estar vacío");
    }
    if(string.IsNullOrWhiteSpace(nuevaPersona.Apellidos))
    {
        return Results.BadRequest("Los Apellidos no puede estar vacío");
    }
    if(nuevaPersona.Edad == null || nuevaPersona.Edad < 18)
    {
        return Results.BadRequest("no hay edad o es menor de edad");
    }
    if(string.IsNullOrWhiteSpace(nuevaPersona.Dni))
    {
        return Results.BadRequest("El DNI no puede estar vacío");
    }
    if(string.IsNullOrWhiteSpace(nuevaPersona.LugarNacimineto))
    {
        return Results.BadRequest("El lugar de nacimiento no puede estar vacío");
    }
    if(string.IsNullOrWhiteSpace(nuevaPersona.PaisNacimineto))
    {
        return Results.BadRequest("El país de nacimiento no puede estar vacío");
    }
    if(string.IsNullOrWhiteSpace(nuevaPersona.Direccion))
    {
        return Results.BadRequest("La dirección no puede estar vacía");
    }
    if(string.IsNullOrWhiteSpace(nuevaPersona.UltimoEstudio))
    {
        return Results.BadRequest("El último estudio no puede estar vacío");
    }
    

    // creamos el id que sigue en la lista
    var nuevoId = listaPersona.Max(elemento => elemento.Id) + 1;

    // creamos la instancia de la persona
    var persona = new Persona(
        nuevoId, 
        nuevaPersona.Nombre, 
        nuevaPersona.Apellidos, 
        nuevaPersona.Edad, 
        nuevaPersona.Dni, 
        nuevaPersona.LugarNacimineto,
        nuevaPersona.PaisNacimineto,
        nuevaPersona.Direccion,
        nuevaPersona.UltimoEstudio
    );

    // agg la persona a la lista
    listaPersona.Add(persona);
    return Results.Created($"/personas/{persona.Dni}", persona);
});

// Desarrollar un endpoint PUT para actualizar un elemento de la lista.
app.MapPut("/personas", (Persona personaActualizada) =>
{
    // verificamos si la persona existe
    var personaExistente = listaPersona.FirstOrDefault(p => p.Dni == personaActualizada.Dni);
    if(personaExistente == null)
    {
        // retornamos un 404 en el caso de que no lo encontremos
        return Results.NotFound("No se encontró la persona para actualizar");
    }else
    { 

        // obtenemos el índice de la persona a actualizar
        var index = listaPersona.FindIndex(p => p.Id == personaActualizada.Id);

        // actualizamos la persona en la lista
        listaPersona[index] = personaActualizada;

        // retornamos la persona actualizada que nos llego en el cuerpo
        return Results.Ok(personaActualizada);
    }
});


// Desarrollar un endpoint DELETE para eliminar un elemento de la lista.
app.MapDelete("/personas/{id}", (int id) =>
{
    var persona = listaPersona.FirstOrDefault(p => p.Id == id);

    if(persona == null)
    {
        return Results.NotFound("No se encontró la persona para eliminar");
    }else
    {
        listaPersona.Remove(persona);
        return Results.Ok(" Persona eliminada correctamente");
    }
});


// arranca el servicio
app.Run();

public record Persona(int Id, string Nombre, string Apellidos, int Edad, string Dni, string LugarNacimineto, string PaisNacimineto, string Direccion, string UltimoEstudio);