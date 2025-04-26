namespace ex002.Models;

public record struct NotificacaoParametros
{
    public NotificacaoParametros(string destinatario)
    {
        Destinatario = destinatario;
    }

    public string Destinatario { get; }
}