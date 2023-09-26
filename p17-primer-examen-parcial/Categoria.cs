public class Categoria
{
    public string Nombre { get; set; }
    public string Rango { get; set; }
    public double Costo = 0;
    public List<Jugador> Njugador { get; set; }

    public Categoria() => Njugador = new List<Jugador>();

    public Categoria(string nombre, string rango, double costo) : this() => (Nombre,Rango,Costo) = (nombre,rango,costo);

    public void AgregarJugador(Jugador jugador) => Njugador.Add(jugador);

    public int ObtenerTotalHombres()
    {
        return Njugador.Count(jugador => jugador.Sexo == 'H');
    }

    public int ObtenerTotalMujeres()
    {
        return Njugador.Count(jugador => jugador.Sexo == 'M');
    }

    public double ObtenerTotalIngresos()
    {
        return Njugador.Sum(jugador => jugador.ObtenerPago(this));
    }

    public override string ToString() => $"\nNombre: {Nombre}\nRango: {Rango}\nCosto: {Costo:f2}";
}
