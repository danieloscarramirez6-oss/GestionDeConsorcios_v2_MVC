public class Reserva
{
    public int Id { get; set; }
    public int AmenityId { get; set; }
    public int UnidadFuncionalId { get; set; }
    public DateTime FechaReserva { get; set; }
    public TimeSpan HoraInicio { get; set; }
    public TimeSpan HoraFin { get; set; }
    public EstadoReserva Estado { get; set; } = EstadoReserva.Pendiente;
    public string? Observaciones { get; set; }

    public Amenity Amenity { get; set; } = null!;
    public UnidadFuncional UnidadFuncional { get; set; } = null!;
}

public enum EstadoReserva
{
    Pendiente,
    Confirmada,
    Cancelada
}
