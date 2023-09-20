Console.Clear();

Tienda tienda = new Tienda("Waldos","Hercules","Apozol");
Console.Write(tienda.ToString());

Cliente cliente01 = new Cliente("Juan","J16F5","Mazapil","juanA@hotmail.com",0);
tienda.AgregarCliente(cliente01);
Venta venta01 = new Venta("Detergente",3,57);
cliente01.sumaT(venta01.subT(venta01.NoA,venta01.Precio));
tienda.TotalD(venta01.subtotal);
Console.WriteLine(cliente01.ToString());


Cliente cliente02 = new Cliente("Axel","A15E9","Jerez","axl@gmail.com",0);
tienda.AgregarCliente(cliente02);
Venta venta02 = new Venta("Galletas",7,12.5);
cliente02.sumaT(venta02.subT(venta02.NoA,venta02.Precio));
tienda.TotalD(venta02.subtotal);
Console.WriteLine(cliente02.ToString());

Venta venta03 = new Venta("Pasta de dientes",12,36);
cliente02.sumaT(venta03.subT(venta03.NoA,venta03.Precio));
tienda.TotalD(venta03.subtotal);
Console.WriteLine(cliente02.ToString());

Console.Write(tienda.ToString());