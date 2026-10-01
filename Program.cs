using Alq_Cancha_Fa.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

app.UseCors();


// =====================================================
// INICIO DE LA API
// =====================================================

app.MapGet("/", () =>
{
    return "API Cancha de Fútbol funcionando";
});


// =====================================================
// COLECCIONES DE DATOS EXPANDIDAS
// =====================================================

var listaCanchas = new List<Cancha>
{
    new Cancha { Id = 1, Codigo = "C001", Nombre = "Cancha Principal - La Central", TipoCancha = "Fútbol 7", Capacidad = 14, PrecioHora = 80.00, Estado = "Disponible", Descripcion = "Cancha de fútbol 7 con césped sintético de alta densidad e iluminación LED.", Imagen = "https://images.unsplash.com/photo-1553778263-73a83bab9b0c" },
    new Cancha { Id = 2, Codigo = "C002", Nombre = "Cancha Premium - El Maracaná", TipoCancha = "Fútbol 7", Capacidad = 14, PrecioHora = 100.00, Estado = "Disponible", Descripcion = "Cancha de fútbol 7 con césped sintético, iluminación profesional y acceso a vestuarios VIP.", Imagen = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55" },
    new Cancha { Id = 3, Codigo = "C003", Nombre = "Cancha Familiar - La Bombonera", TipoCancha = "Fútbol 5", Capacidad = 10, PrecioHora = 60.00, Estado = "Mantenimiento", Descripcion = "Cancha de fútbol 5 ideal para partidos rápidos entre amigos y familiares.", Imagen = "https://images.unsplash.com/photo-1526232761682-d26e03ac148e" },
    new Cancha { Id = 4, Codigo = "C004", Nombre = "Cancha Sintética Jr. - Camp Nou", TipoCancha = "Fútbol 5", Capacidad = 10, PrecioHora = 50.00, Estado = "Disponible", Descripcion = "Cancha pequeña de fútbol 5 techada con mallas de protección y marcador digital.", Imagen = "https://images.unsplash.com/photo-1553778263-73a83bab9b0c" },
    new Cancha { Id = 5, Codigo = "C005", Nombre = "Estadio Central - El Monumental", TipoCancha = "Fútbol 11", Capacidad = 22, PrecioHora = 160.00, Estado = "Disponible", Descripcion = "Cancha reglamentaria de fútbol 11 profesional con césped natural e iluminación nocturna.", Imagen = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55" },
    new Cancha { Id = 6, Codigo = "C006", Nombre = "Cancha Techada VIP - Wembley", TipoCancha = "Fútbol 7", Capacidad = 14, PrecioHora = 120.00, Estado = "Disponible", Descripcion = "Cancha totalmente techada anti-lluvia, sonido ambiente y tribunas de descanso.", Imagen = "https://images.unsplash.com/photo-1526232761682-d26e03ac148e" },
    new Cancha { Id = 7, Codigo = "C007", Nombre = "Cancha Fútsal Pro - San Siro", TipoCancha = "Fútsal", Capacidad = 10, PrecioHora = 55.00, Estado = "Disponible", Descripcion = "Losa multideportiva de piso pulido parquet especial para fútsal rápido.", Imagen = "https://images.unsplash.com/photo-1553778263-73a83bab9b0c" },
    new Cancha { Id = 8, Codigo = "C008", Nombre = "Cancha Nocturna - Anfield", TipoCancha = "Fútbol 11", Capacidad = 22, PrecioHora = 180.00, Estado = "Mantenimiento", Descripcion = "Cancha completa para campeonatos nocturnos con reflectores de alta potencia.", Imagen = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55" }
};

var listaHorarios = new List<Horario>
{
    // Bloque 02 de Octubre
    new Horario { Id = 1, Codigo = "H001", Fecha = "2026-10-02", Hora = "08:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 7", Precio = 80.00, Duracion = 60 },
    new Horario { Id = 2, Codigo = "H002", Fecha = "2026-10-02", Hora = "09:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 5", Precio = 60.00, Duracion = 60 },
    new Horario { Id = 3, Codigo = "H003", Fecha = "2026-10-02", Hora = "10:00", Estado = "Reservado", Disponibilidad = false, TipoCancha = "Fútbol 7", Precio = 80.00, Duracion = 60 },
    new Horario { Id = 4, Codigo = "H004", Fecha = "2026-10-02", Hora = "11:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 11", Precio = 160.00, Duracion = 60 },
    new Horario { Id = 5, Codigo = "H005", Fecha = "2026-10-02", Hora = "12:00", Estado = "Reservado", Disponibilidad = false, TipoCancha = "Fútbol 7", Precio = 80.00, Duracion = 60 },
    new Horario { Id = 6, Codigo = "H006", Fecha = "2026-10-02", Hora = "14:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 5", Precio = 50.00, Duracion = 60 },
    new Horario { Id = 7, Codigo = "H007", Fecha = "2026-10-02", Hora = "16:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútsal", Precio = 55.00, Duracion = 60 },
    new Horario { Id = 8, Codigo = "H008", Fecha = "2026-10-02", Hora = "18:00", Estado = "Reservado", Disponibilidad = false, TipoCancha = "Fútbol 7", Precio = 100.00, Duracion = 60 },
    new Horario { Id = 9, Codigo = "H009", Fecha = "2026-10-02", Hora = "20:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 7", Precio = 120.00, Duracion = 60 },
    new Horario { Id = 10, Codigo = "H010", Fecha = "2026-10-02", Hora = "21:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 11", Precio = 180.00, Duracion = 60 },

    // Bloque 03 de Octubre
    new Horario { Id = 11, Codigo = "H011", Fecha = "2026-10-03", Hora = "08:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 5", Precio = 50.00, Duracion = 60 },
    new Horario { Id = 12, Codigo = "H012", Fecha = "2026-10-03", Hora = "10:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 7", Precio = 80.00, Duracion = 60 },
    new Horario { Id = 13, Codigo = "H013", Fecha = "2026-10-03", Hora = "12:00", Estado = "Reservado", Disponibilidad = false, TipoCancha = "Fútsal", Precio = 55.00, Duracion = 60 },
    new Horario { Id = 14, Codigo = "H014", Fecha = "2026-10-03", Hora = "15:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 11", Precio = 160.00, Duracion = 60 },
    new Horario { Id = 15, Codigo = "H015", Fecha = "2026-10-03", Hora = "16:00", Estado = "Reservado", Disponibilidad = false, TipoCancha = "Fútbol 7", Precio = 80.00, Duracion = 60 },
    new Horario { Id = 16, Codigo = "H016", Fecha = "2026-10-03", Hora = "18:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 7", Precio = 100.00, Duracion = 60 },
    new Horario { Id = 17, Codigo = "H017", Fecha = "2026-10-03", Hora = "19:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 5", Precio = 60.00, Duracion = 60 },
    new Horario { Id = 18, Codigo = "H018", Fecha = "2026-10-03", Hora = "20:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 7", Precio = 120.00, Duracion = 60 },
    new Horario { Id = 19, Codigo = "H019", Fecha = "2026-10-03", Hora = "21:00", Estado = "Reservado", Disponibilidad = false, TipoCancha = "Fútbol 11", Precio = 180.00, Duracion = 60 },
    new Horario { Id = 20, Codigo = "H020", Fecha = "2026-10-03", Hora = "22:00", Estado = "Disponible", Disponibilidad = true, TipoCancha = "Fútbol 5", Precio = 50.00, Duracion = 60 }
};

// =====================================================
// ENDPOINTS CON FILTROS
// =====================================================

// GET /api/Cancha?tipoCancha=Fútbol 7&estado=Disponible
app.MapGet("/api/Cancha", (string? tipoCancha, string? estado) =>
{
    var resultado = listaCanchas.AsEnumerable();

    if (!string.IsNullOrEmpty(tipoCancha))
    {
        resultado = resultado.Where(c => c.TipoCancha.Equals(tipoCancha, StringComparison.OrdinalIgnoreCase));
    }

    if (!string.IsNullOrEmpty(estado))
    {
        resultado = resultado.Where(c => c.Estado.Equals(estado, StringComparison.OrdinalIgnoreCase));
    }

    return Results.Ok(resultado.ToList());
});

// GET /api/Horarios?fecha=2026-10-02&disponibilidad=true&tipoCancha=Fútbol 7
app.MapGet("/api/Horarios", (string? fecha, bool? disponibilidad, string? tipoCancha) =>
{
    var resultado = listaHorarios.AsEnumerable();

    if (!string.IsNullOrEmpty(fecha))
    {
        resultado = resultado.Where(h => h.Fecha == fecha);
    }

    if (disponibilidad.HasValue)
    {
        resultado = resultado.Where(h => h.Disponibilidad == disponibilidad.Value);
    }

    if (!string.IsNullOrEmpty(tipoCancha))
    {
        resultado = resultado.Where(h => h.TipoCancha.Equals(tipoCancha, StringComparison.OrdinalIgnoreCase));
    }

    return Results.Ok(resultado.ToList());
});


// =====================================================
// SERVICIOS Y RESERVAS
// =====================================================

app.MapGet("/api/Servicios", () =>
{
    return Results.Ok(new[]
    {
        new { id = 1, codigo = "S001", nombre = "Alquiler de cancha", categoria = "Principal", precio = 80.00, estado = "Disponible", descripcion = "Alquiler de cancha de fútbol por una hora.", imagen = "https://images.unsplash.com/photo-1553778263-73a83bab9b0c" },
        new { id = 2, codigo = "S002", nombre = "Iluminación", categoria = "Adicional", precio = 20.00, estado = "Disponible", descripcion = "Servicio de iluminación para partidos nocturnos.", imagen = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55" },
        new { id = 3, codigo = "S003", nombre = "Vestuarios", categoria = "Adicional", precio = 10.00, estado = "Disponible", descripcion = "Uso de vestuarios para los jugadores.", imagen = "https://images.unsplash.com/photo-1518609878373-06d740f60d8b" },
        new { id = 4, codigo = "S004", nombre = "Estacionamiento", categoria = "Adicional", precio = 5.00, estado = "Disponible", descripcion = "Espacio de estacionamiento para los clientes.", imagen = "https://images.unsplash.com/photo-1506521781263-d8422e82f27a" },
        new { id = 5, codigo = "S005", nombre = "Campeonatos", categoria = "Eventos", precio = 150.00, estado = "Disponible", descripcion = "Organización de campeonatos y torneos de fútbol.", imagen = "https://images.unsplash.com/photo-1579952363873-27f3bade9f55" },
        new { id = 6, codigo = "S006", nombre = "Entrenamientos", categoria = "Eventos", precio = 70.00, estado = "Disponible", descripcion = "Espacios para entrenamientos deportivos.", imagen = "https://images.unsplash.com/photo-1431324155629-1a6deb1dec8d" }
    });
});

app.MapGet("/api/Reservas", () =>
{
    return Results.Ok(new[]
    {
        new { id = 1, codigo = "R001", cliente = "Carlos Mendoza", fecha = "2026-10-02", hora = "12:00", cancha = "Cancha Principal", tipoCancha = "Fútbol 7", estado = "Confirmada", precio = 80.00, duracion = 60 },
        new { id = 2, codigo = "R002", cliente = "Luis Torres", fecha = "2026-10-02", hora = "18:00", cancha = "Cancha Premium", tipoCancha = "Fútbol 7", estado = "Confirmada", precio = 100.00, duracion = 60 },
        new { id = 3, codigo = "R003", cliente = "Miguel Flores", fecha = "2026-10-03", hora = "16:00", cancha = "Cancha Principal", tipoCancha = "Fútbol 7", estado = "Confirmada", precio = 80.00, duracion = 60 }
    });
});


// =====================================================
// PUERTO PARA RENDER
// =====================================================

var port = Environment.GetEnvironmentVariable("PORT") ?? "10000";

app.Run($"http://0.0.0.0:{port}");