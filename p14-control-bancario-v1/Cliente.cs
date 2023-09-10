public class Cliente{
    public string Nombre { get; set; }
    public string Correo { get; set; }
    public CuentaBancaria Cuenta { get; set; }
    public Cliente(string nombre, string correo) => (Nombre, Correo) = (nombre,correo);
    public override string ToString() => $"Nombre : {Nombre}, Correo: {Correo}";
}