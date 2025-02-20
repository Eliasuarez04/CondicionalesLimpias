//Código Sucio 

public double ObtenerPrecio(string producto)
{
    if (producto == "Laptop") return 800;
    if (producto == "Celular") return 500;
    if (producto == "Tablet") return 300;
    return 0;
}


//Código Limpio

private static readonly Dictionary<string, double> Precios = new()
{
    { "Laptop", 800 },
    { "Celular", 500 },
    { "Tablet", 300 }
};

public double ObtenerPrecio(string producto) => Precios.TryGetValue(producto, out var precio) ? precio : 0;
