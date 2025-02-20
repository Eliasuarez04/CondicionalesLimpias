//Código Sucio 

public double CalcularDescuento(double precio, int tipoCliente)
{
    if (tipoCliente == 1) return precio * 0.10; // Cliente regular
    if (tipoCliente == 2) return precio * 0.20; // Cliente VIP
    return 0;
}


//Código Limpio

public enum TipoCliente { Regular, VIP }

public double CalcularDescuento(double precio, TipoCliente tipoCliente)
{
    const double DESCUENTO_REGULAR = 0.10;
    const double DESCUENTO_VIP = 0.20;

    return tipoCliente switch
    {
        TipoCliente.Regular => precio * DESCUENTO_REGULAR,
        TipoCliente.VIP => precio * DESCUENTO_VIP,
        _ => 0
    };
}
