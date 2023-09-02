class OperacionesConArreglo
{
    int[] arreglo = { 100, 123, 456, 222, 999, 895, 325, 234, 322, 988 };

    public void MostrarElementos()
    {
        Console.WriteLine("Elementos del arreglo:");
        foreach (int elemento in arreglo)
        {
            Console.Write(elemento + " ");
        }
        Console.WriteLine();
    }

    public int CalcularSuma()
    {
        int suma = 0;
        foreach (int elemento in arreglo)
        {
            suma += elemento;
        }
        return suma;
    }

    public int CalcularSumaDivididosEntre2()
    {
        int suma = 0;
        for (int i = 0; i < arreglo.Length; i++)
        {
            arreglo[i] /= 2;
            suma += arreglo[i];
        }
        return suma;
    }
}