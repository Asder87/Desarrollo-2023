// Control Bancario
// Probar clase CuentaBancaria
CuentaBancaria cuenta = new CuentaBancaria(100);
cuenta.Deposita(200);
Console.WriteLine($"Saldo : {cuenta.Saldo}");
cuenta.Retirar(150);
if(cuenta.Retirar(1500)) Console.WriteLine("Retiro Exitoso");
else Console.WriteLine("No se puede retirar saldo insuficiente");
Console.WriteLine($"Saldo : {cuenta.Saldo}");

// Probar clase Cliente
Cliente cliente1 = new Cliente("Juan Carlos", "jcarlos@gmail.com");
cliente1.Cuenta = cuenta;
cliente1.Cuenta.Deposita(1500);
Console.WriteLine($"\nDatos del Cliente : {cliente1.ToString()}");
Console.WriteLine($"Saldo Cuenta : {cliente1.Cuenta.Saldo}");

Cliente cliente2 = new Cliente ("Paola Díaz", "paolad@gmail.com");
cliente2.Cuenta = new CuentaBancaria(450);
Console.WriteLine($"\nDatos del Cliente : {cliente2.ToString()}");
Console.WriteLine($"Saldo Cuenta : {cliente2.Cuenta.Saldo}");

// Probar clase banco
Banco mibanco = new Banco("Banco del Bienestar","En cas de la jodida");
mibanco.AgregarCliente(cliente1);
mibanco.AgregarCliente(cliente2);
Cliente cliente3 = new Cliente("Xochitl", "xochitl@gmail.com");
cliente3.Cuenta = new CuentaBancaria(200);
mibanco.AgregarCliente(cliente3);
Console.WriteLine(mibanco.ToString());
Console.WriteLine($"El banco tiene {mibanco.Clientes.Count} Clientes");
mibanco.Clientes[2].Cuenta.Deposita(10000);
foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"Cliente {cl.ToString()}");
    Console.WriteLine($"Saldo {cl.Cuenta.Saldo}");
}