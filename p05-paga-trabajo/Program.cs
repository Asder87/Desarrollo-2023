// Imprime una tabla de conversion de peso a otras monedas
int ini, fin, c;
float tcd=17.70f, tcl=21.21f, tce=18.19f, tca=0.048f;

Console.Clear();
Console.WriteLine("Imprime tabla de conversion de monedas\n");

do{
    Console.WriteLine("Inicio: "); ini = int.Parse(Console.ReadLine());
    Console.WriteLine("Fin  : "); fin = int.Parse(Console.ReadLine());
} while(fin<ini);

c=ini;
Console.WriteLine("Peso\tDolar\tLibra\tEuro\tMessi Peso");
Console.WriteLine(new string('-',43));
while(c<=fin){
    Console.WriteLine($"{c:f2}\t{c/tcd:f2}\t{c/tcl:f2}\t{c/tce:f2}\t{c/tca:f2}");
    c++;
}
Console.WriteLine(new string('-',43));