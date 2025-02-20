//Código Sucio

public double CalcularArea(double baseFigura, double altura, int tipoFigura)
{
    if (tipoFigura == 1) // Triángulo
    {
        return (baseFigura * altura) / 2;
    }
    else if (tipoFigura == 2) // Rectángulo
    {
        return baseFigura * altura;
    }
    return 0;
}


//Código Limpio 

public enum Figura { Triangulo, Rectangulo }

public double CalcularArea(double baseFigura, double altura, Figura tipoFigura)
{
    return tipoFigura switch
    {
        Figura.Triangulo => (baseFigura * altura) / 2,
        Figura.Rectangulo => baseFigura * altura,
        _ => throw new ArgumentException("Figura no soportada")
    };
}
