int[] numeros = new int[10] { 3, 10, 5, 9, -1, -4, 12, -15, 23, 6 };

Console.Write("Desordenados: ");
for (int i = 0; i < numeros.Length; i++) {
    if (i != 9) {
        Console.Write(numeros[i] + ", ");
    }
        else
    {
        Console.Write(numeros[i]);
    }
}

Array.Sort(numeros);

Console.Write("\nOrdenados: ");
for (int i = 0; i < numeros.Length; i++) {
    if (i != 9) {
        Console.Write(numeros[i] + ", ");
    }
    else {
        Console.Write(numeros[i]);
    }
}