// Este programa muestra el promedio del alumno con un mensaje

double puntos;
string nombre="", letra;

Console.WriteLine("Dame tu nombre"); nombre = Console.ReadLine();
Console.WriteLine("Cual fue tu promedio final del semestre"); puntos = double.Parse(Console.ReadLine());

if(puntos < 0 || puntos >= 11){
    Console.WriteLine("Error vuelva a intentarlo");
    return 0;
}

if(puntos >= 0 && puntos <= 5.9){
    letra = "D Vas mal chavo";
    Console.WriteLine($"Tu nombre es {nombre}\nTu promedio es {puntos}\n" + letra);
    return 0;
}

if(puntos >= 6 && puntos <= 7.5){
    letra = "C Mucho mejor";
    Console.WriteLine($"Tu nombre es {nombre}\nTu promedio es {puntos}\n" + letra);
    return 0;
}

if(puntos >= 7.6 && puntos <= 8.5){
    letra = "B Muy bien";
    Console.WriteLine($"Tu nombre es {nombre}\nTu promedio es {puntos}\n" + letra);
    return 0;
}

if(puntos >= 8.6 && puntos <= 10){
    letra = "A Excelente";
    Console.WriteLine($"Tu nombre es {nombre}\nTu promedio es {puntos}\n" + letra);
    return 0;
}

return 0;