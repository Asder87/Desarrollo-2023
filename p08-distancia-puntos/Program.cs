// Este programa calcula la distancia entre dos puntos A y B

double ax, ay, bx, by, restx=0, resty=0, cuadx=0, cuady, resultado=0;

Console.WriteLine("Dame las cordenadas de A en x: "); ax = double.Parse(Console.ReadLine());
if(ax <= 0 ){
    Console.WriteLine("Error Numero invalido");
    return 1;
}
Console.WriteLine("Ahora las cordenadas de A en y: "); ay = double.Parse(Console.ReadLine());
if(ay <= 0 ){
    Console.WriteLine("Error Numero invalido");
    return 0;
}
Console.WriteLine("Dame las cordenadas de B en x: "); bx = double.Parse(Console.ReadLine());
if(bx <= 0 ){
    Console.WriteLine("Error Numero invalido");
    return 0;
}
Console.WriteLine("Ahora las cordenadas de B en y: "); by = double.Parse(Console.ReadLine());
if(by <= 0 ){
    Console.WriteLine("Error Numero invalido");
    return 0;
}

//Operaciones
restx = ax-bx;
resty = ay-by;
cuadx = Math.Pow(restx,2);
cuady = Math.Pow(resty,2);
resultado = Math.Sqrt(cuadx+cuady);

Console.WriteLine($"La distancia entre A y B es de : {resultado:f2}");

return 0;