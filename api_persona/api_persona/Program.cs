var constructor = WebApplication.CreateBuilder(args);

constructor.Services.AddCors(opciones =>
{
    opciones.AddDefaultPolicy(politica =>
    {
        politica.WithOrigins("http://127.0.0.1:5500", "http://localhost:5500", "https://www.google.com")// agrego las IPs que pueden hacer peticiones
               .AllowAnyHeader()
               .AllowAnyMethod();

    });

});

var app = constructor.Build();
app.UseCors();

var listaPersonas = new List<Persona> // lista de personas
{
    new Persona(1, "Ramses", "Muñoz", 31, "12345678A", "Caracas"),
    new Persona(2, "María", "Gómez", 25, "87654321B", "Barcelona"),
    new Persona(3, "Luis", "Martínez", 40, "11223344C", "Valencia"),
    new Persona(4, "Ana", "López", 28, "44332211D", "Sevilla"),
    new Persona(5, "Carlos", "Sánchez", 35, "55667788E", "Bilbao"),
    new Persona(6, "Lucía", "Fernández", 22, "99887766F", "Granada"),
    new Persona(7, "Javier", "Rodríguez", 45, "66778899G", "Málaga"),
    new Persona(8, "Sofía", "García", 30, "33445566H", "Zaragoza"),
    new Persona(9, "Miguel", "Hernández", 38, "22113344I", "Córdoba"),
    new Persona(10, "Elena", "Díaz", 27, "77889900J", "Valladolid")
};

app.Run();//arranca la aplicacion

// ruta de inicio
app.MapGet("/", () => Results.Ok("Api funcionando lista de personas"));

// endpoint para obtener la lista de personas
app.MapGet("/personas", () => Results.Ok(listaPersonas));

app.MapGet("/personas/{id:int}", (int id) =>
{
    // busca a la persona en la lista si la encuentra la devuelve
    var persona = listaPersonas.FirstOrDefault(instanciaDeLista => instanciaDeLista.Id == id);
    if (persona is null)
    {
        return Results.NotFound("Persona no encontrada");
    }
    else
    {
        return Results.Ok(persona);
    }
});

app.MapPost("/personas", (Persona nuevaPersona) =>
{

    if (string.IsNullOrWhiteSpace(nuevaPersona.Nombre))
    {
        return Results.BadRequest("El nombre es obligatorio");
    }
    if (string.IsNullOrWhiteSpace(nuevaPersona.Apellidos))
    {
        return Results.BadRequest("Los apellidos son obligatorios");
    }
    if (nuevaPersona.Edad <= 0)
    {
        return Results.BadRequest("La edad debe ser un número positivo");
    }
    if (string.IsNullOrWhiteSpace(nuevaPersona.Dni))
    {
        return Results.BadRequest("El DNI es obligatorio");
    }
    if (string.IsNullOrWhiteSpace(nuevaPersona.LugarNacimiento))
    {
        return Results.BadRequest("El lugar de nacimiento es obligatorio");
    }

    var nuevoId = listaPersonas.Max(p => p.Id) + 1; // el id correspondiente a la nueva persona

    var persona = new Persona(
        nuevoId, 
        nuevaPersona.Nombre, 
        nuevaPersona.Apellidos, 
        nuevaPersona.Edad, 
        nuevaPersona.Dni, 
        nuevaPersona.LugarNacimiento
    );

    listaPersonas.Add(persona);
    return Results.Created("Persona creada", persona);

});


public record Persona(int Id, string Nombre, string Apellidos, int Edad, string Dni, string LugarNacimiento);