// Este programa calcula el volumen de una esfera

double radio, res, a=4, b=3, div;

Console.WriteLine("Dame el radio de la esfera"); radio = double.Parse(Console.ReadLine());
if (radio <= 0){Console.WriteLine("Error!!"); return 0;}

div = a/b;
res = ((div)*(3.1416)*(Math.Pow(radio, 3)));
//Por alguna razon 4/3 expresado sin variables me daba = 1, por lo que decidi declararlos como variables

Console.WriteLine($"El radio de la esfera es de : {res:f2}");

return 0;