// Este programa calcula la cantidad de articulos precio total e iva

int cant;
double totalVentas = 0.0, IVACobrado = 0.0, precio, subtotal, iva;
    do
    {
        Console.Write("Ingrese la cantidad de artículos: "); cant = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el precio del artículo: "); precio = double.Parse(Console.ReadLine());

        subtotal = cant * precio;
        iva = 0.16 * subtotal;

        if (subtotal > 1200)
        {
            totalVentas += subtotal;
        }
        else
        {
            totalVentas += subtotal + iva;
            IVACobrado += iva;
        }

        Console.Write("¿Desea ingresar otro artículo? (S/N): ");
    }
        while (Console.ReadLine().ToUpper() == "S");

        Console.WriteLine($"Total de Ventas: ${totalVentas}");
        Console.WriteLine($"Total de IVA Cobrado: ${IVACobrado}");