//Código Sucio

public string DeterminarCategoria(int edad)
{
    if (edad < 12)
    {
        return "Niño";
    }
    else
    {
        if (edad >= 12 && edad <= 17)
        {
            return "Adolescente";
        }
        else
        {
            if (edad >= 18 && edad <= 64)
            {
                return "Adulto";
            }
            else
            {
                return "Senior";
            }
        }
    }
}


//Código Limpio

public string DeterminarCategoria(int edad) => edad switch
{
    < 12 => "Niño",
    <= 17 => "Adolescente",
    <= 64 => "Adulto",
    _ => "Senior"
};

