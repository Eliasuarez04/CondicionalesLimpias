//Código Sucio

public enum TipoNotificacion { Email, SMS }

public class Notificador
{
    public void EnviarNotificacion(TipoNotificacion tipo, string mensaje)
    {
        if (tipo == TipoNotificacion.Email)
        {
            Console.WriteLine($"Enviando correo: {mensaje}");
        }
        else if (tipo == TipoNotificacion.SMS)
        {
            Console.WriteLine($"Enviando SMS: {mensaje}");
        }
    }
}


//Código Limpio

public interface INotificador
{
    void Enviar(string mensaje);
}

public class NotificadorEmail : INotificador
{
    public void Enviar(string mensaje) => Console.WriteLine($"Enviando correo: {mensaje}");
}

public class NotificadorSMS : INotificador
{
    public void Enviar(string mensaje) => Console.WriteLine($"Enviando SMS: {mensaje}");
}

// Uso
INotificador notificador = new NotificadorEmail();
notificador.Enviar("Hola, Clean Code!");
