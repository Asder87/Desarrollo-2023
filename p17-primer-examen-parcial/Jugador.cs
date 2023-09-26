public class Jugador
{
    public string Nombre { get; set; }
    public int AñoNac { get; set; }
    public char Sexo { get; set; }
    public bool Becado { get; set; }

    public Jugador(string nombre, int añoNac, char sexo, bool becado)
    {
        Nombre = nombre;
        AñoNac = añoNac;
        Sexo = sexo;
        Becado = becado;
    }

    public double ObtenerPago(Categoria categoria)
    {
        return Becado ? 0.0 : categoria.Costo;
    }



    public override string ToString() => $"\nNombre: {Nombre}\nAño de Nacimiento: {AñoNac}\nGénero: {Sexo}\nBecado: {Becado}";
}