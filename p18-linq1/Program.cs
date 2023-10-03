// CONSULTA LINQ
// Origen de datos
List<int> numeros = new(){5,4,1,3,9,8,6,7,2,0};

foreach(int n in numeros)
    Console.WriteLine(n);
Console.WriteLine("\nNumeros pares:");
var pares = from num in numeros where num%2==0 select num;
foreach(int n in pares)
    Console.WriteLine(n);
Console.WriteLine("\nNumeros impares:");
var impares = numeros.Where(num=>num%2!=0);
foreach(int n in impares)
    Console.WriteLine(n);
Console.WriteLine("\nNumeros entre 5 a 9");
var rango1 = (from n in numeros where n>=5 && n<=9 select n).ToList();
rango1.ForEach(n=>Console.WriteLine(n));

Console.WriteLine("\nNumeros 1 y 4");
var rango2 = numeros.Where(n=> n>=1 && n<=4).ToList();
rango2.ForEach(n=>Console.WriteLine(n));