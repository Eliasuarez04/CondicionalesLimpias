//Código Sucio

public int SumarPares(List<int> numeros)
{
    int suma = 0;
    foreach (var num in numeros)
    {
        if (num % 2 == 0)
        {
            suma += num;
        }
    }
    return suma;
}


//Código Limpio

public int SumarPares(List<int> numeros) => numeros.Where(n => n % 2 == 0).Sum();

