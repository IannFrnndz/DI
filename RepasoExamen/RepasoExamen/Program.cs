// paso 1
//crear los constructores iniciarlo y arrancar la app

var constructor = WebApplication.CreateBuilder(args);

constructor.Services.AddCors(opciones =>
{
    opciones.AddDefaultPolicy(politica =>
    {
        politica.WithOrigins("http://localhost")
               .AllowAnyMethod()
               .AllowAnyHeader();
    });
});

var app = constructor.Build();

app.UseCors();



var listaPersona = new List<Persona> // lista de persona
{
    new(1, "Ramses", "Muñoz", 31, "8029559C", "Caracas"),
    new(2, "María", "González", 28, "9134567A", "Valencia"),
    new(3, "Carlos", "Pérez", 35, "7845123B", "Maracay"),
    new(4, "Ana", "Rodríguez", 22, "6547891D", "Barquisimeto"),
    new(5, "Luis", "Fernández", 40, "9988776E", "Maracaibo"),
    new(6, "Sofía", "López", 26, "5566778F", "Mérida"),
    new(7, "José", "Ramírez", 33, "4433221G", "Puerto La Cruz"),
    new(8, "Valentina", "Torres", 29, "1122334H", "San Cristóbal"),
    new(9, "Miguel", "Hernández", 45, "8899001J", "Ciudad Bolívar"),
    new(10, "Daniela", "Castillo", 24, "6677889K", "Cumaná")
};

// get todos 
app.MapGet("/personas", () => Results.Ok(listaPersona));
// get uno
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

// crea uno

app.MapPost("/personas", (Persona nuevaPersona) =>
{
    // validaciones
    if(string.IsNullOrWhiteSpace(nuevaPersona.Nombre))
    {
        return Results.BadRequest("El nombre no puede estar vacío");
    }
    if(string.IsNullOrWhiteSpace(nuevaPersona.Dni))
    {
        return Results.BadRequest("El DNI no puede estar vacío");
    }
    if(nuevaPersona.Edad == null || nuevaPersona.Edad <= 18)
    {
        return Results.BadRequest("no hay edad o es menor de edad");
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
        nuevaPersona.LugarNacimineto
    );

    // agg la persona a la lista
    listaPersona.Add(persona);
    return Results.Created($"/personas/{persona.Dni}", persona);
});

// actualiza uno


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
// elimina uno
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

// clase record persona
public record Persona(int Id, string Nombre, string Apellidos, int Edad, string Dni, string LugarNacimineto);