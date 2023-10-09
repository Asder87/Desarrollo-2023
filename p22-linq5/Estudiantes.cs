List<Estudiante> estudiantes = new List<Estudiante>();
estudiantes.Add(new Estudiante("1234","Adrian","Principal 123","Zacatecas",'H',21,true, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("256","Erick","Chula vista","Guadalupe",'M',21,false, new List<float>{97,92,81,57}));
estudiantes.Add(new Estudiante("6511","Kiki","Popular F","Loreto",'M',21,true, new List<float>{97,92,59,60}));
estudiantes.Add(new Estudiante("6452","Jose","Del Deposito","Valparaiso",'H',21,false, new List<float>{97,92,81,60}));
estudiantes.Add(new Estudiante("9526","Miguel","Las Palmas","Jalpa",'H',21,true, new List<float>{97,60,81,60}));
estudiantes.Add(new Estudiante("9874","Torres","Buena Vista","Jerez",'H',21,true, new List<float>{97,92,97,97}));
estudiantes.Add(new Estudiante("0230","Bernardo","Astros","Villanueva",'M',21,true, new List<float>{97,92,81,02}));
estudiantes.Add(new Estudiante("6018","Cumacho","Historico","Fresnillo",'H',21,true, new List<float>{97,92,03,60}));

Console.WriteLine("\nTodos los estudiantes en el Grupo:");
estudiantes.ForEach(e=>Console.WriteLine(e));

string mun = "Fresnillo";
var estmun = estudiantes.Where(e=>e.Municipio==mun).ToList();
Console.WriteLine($"\nEstudiantes que son de {mun} - {estmun.Count()}");
estmun.ForEach(e=>Console.WriteLine(e));

float prom=80f;
var estprom =(from e in estudiantes where e.Califs.Average() >= prom orderby e.Nombre select e).ToList();
Console.WriteLine($"\nEstudiantes con promedio >= {prom} - {estprom.Count()}");
estprom.ForEach(e=>Console.WriteLine(e));

var estprom1 =(from e in estudiantes select $"Nombre={e.Nombre,-18} - Prom = {e.Califs.Average(),5:n2}").ToList();
Console.WriteLine("\nLista de alumnos y promedio:");
estprom1.ForEach(e=>Console.WriteLine(e));

Console.WriteLine("\n\nSubtotales:");
var pedades = (from e in estudiantes select e.Edad).Average();
Console.WriteLine($"Promedio de edades = {pedades}");
var pcalifs = (from e in estudiantes select e.Califs.Average()).Average();
Console.WriteLine($"Promedio de calificaciones = {pcalifs}");
var totm = estudiantes.Where(e=>e.Sexo=='M').Count();
Console.WriteLine($"Total de mujeres = {totm}");
var toth = estudiantes.Where(e=>e.Sexo=='H').Count();
Console.WriteLine($"Total de hombres = {toth}");
var totb = estudiantes.Where(e=>e.Becado).Count();
Console.WriteLine($"Total de becados = {totb}");
var totnb = estudiantes.Where(e=>!e.Becado).Count();
Console.WriteLine($"Total de no becados = {totnb}");
var totmb = estudiantes.Where(e=>e.Becado && e.Sexo=='M').Count();
Console.WriteLine($"Total de mentirosas becadas = {totmb}");
var tothb = estudiantes.Where(e=>e.Becado && e.Sexo=='H').Count();
Console.WriteLine($"Total de hombres becados = {tothb}");

var gpoest = from e in estudiantes group e by e.Municipio;
Console.WriteLine("\nEstudiantes agrupados por municipios:");
foreach (var gpo in gpoest)
{
    Console.WriteLine($"\n {gpo.Key} : {gpo.Count()}");
    foreach (var est in gpo)
    {
        Console.WriteLine(est);
    }
}
