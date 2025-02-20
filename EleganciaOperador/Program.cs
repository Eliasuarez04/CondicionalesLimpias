//Código Sucio

public string GetStatus(int score)
{
    if (score >= 70)
    {
        return "Aprobado";
    }
    else
    {
        return "Reprobado";
    }
}


//Código Limpio
public string GetStatus(int score) => score >= 70 ? "Aprobado" : "Reprobado";
