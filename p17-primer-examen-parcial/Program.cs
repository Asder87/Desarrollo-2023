class Program
{
    static void Main()
    {
        // Crear la Academia
        Academia academia = new Academia
        {
            Nombre = "Academia Deportiva",
            Propietario = "Juan Pérez",
            Domicilio = "Calle Principal, 123"
        };

        // Crear Categorías
        Categoria categoria1 = new Categoria
        {
            Nombre = "Infantil",
            Rango = "Novato",
            Costo = 50.0
        };

        Categoria categoria2 = new Categoria
        {
            Nombre = "Juvenil",
            Rango = "Avanzado",
            Costo = 75.0
        };

        // Crear Jugadores
        Jugador jugador1 = new Jugador("Luis García", 2005, 'H', true);
        Jugador jugador2 = new Jugador("Ana Martínez", 2004, 'M', false);
        Jugador jugador3 = new Jugador("Carlos Rodríguez", 2003, 'H', false);
        Jugador jugador4 = new Jugador("Sofía López", 2006, 'M', true);

        // Agregar Jugadores a Categorías
        categoria1.AgregarJugador(jugador1);
        categoria1.AgregarJugador(jugador2);
        categoria2.AgregarJugador(jugador3);
        categoria2.AgregarJugador(jugador4);

        // Agregar Categorías a la Academia
        academia.AgregarCategoria(categoria1);
        academia.AgregarCategoria(categoria2);

        // Generar el reporte
        Console.WriteLine("Datos generales de la academia:");
        Console.WriteLine(academia);
        Console.WriteLine("Total de Categorías: " + academia.ObtenerTotalCategorias());
        Console.WriteLine("Total de Hombres: " + academia.ObtenerTotalHombres());
        Console.WriteLine("Total de Mujeres: " + academia.ObtenerTotalMujeres());

        Console.WriteLine("\nDatos generales de las Categorías:");
        foreach (var categoria in academia.Ncategoria)
        {
            Console.WriteLine(categoria);
            Console.WriteLine("Total de Jugadores: " + categoria.Njugador.Count);
            Console.WriteLine("Total de Hombres: " + categoria.ObtenerTotalHombres());
            Console.WriteLine("Total de Mujeres: " + categoria.ObtenerTotalMujeres());
            Console.WriteLine("Subtotal del costo (becados no pagan): " + categoria.ObtenerTotalIngresos());
            Console.WriteLine();
        }

        Console.WriteLine("Total de Ingresos: " + academia.ObtenerTotalIngresos());
    }
}