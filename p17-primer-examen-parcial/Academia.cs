public class Academia
{
    public string Nombre { get; set; }
    public string Propietario { get; set; }
    public string Domicilio { get; set; }
    public List<Categoria> Ncategoria { get; set; }

    public Academia() => Ncategoria = new List<Categoria>();

    public Academia(string nombre, string propietario, string domicilio) : this()
    {
        Nombre = nombre;
        Propietario = propietario;
        Domicilio = domicilio;
    }

    public void AgregarCategoria(Categoria categoria) => Ncategoria.Add(categoria);

    public int ObtenerTotalCategorias()
    {
        return Ncategoria.Count;
    }

    public int ObtenerTotalHombres()
    {
        return Ncategoria.Sum(categoria => categoria.ObtenerTotalHombres());
    }

    public int ObtenerTotalMujeres()
    {
        return Ncategoria.Sum(categoria => categoria.ObtenerTotalMujeres());
    }

    public double ObtenerTotalIngresos()
    {
        return Ncategoria.Sum(categoria => categoria.ObtenerTotalIngresos());
    }

    public override string ToString() => $"\nNombre: {Nombre}\nPropietario: {Propietario}\nDomicilio: {Domicilio}\n";
}