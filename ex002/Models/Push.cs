namespace ex002.Models;

public sealed class Push : Notificacao
{
    public Push(NotificacaoParametros parametros) : base(parametros) { }

    public override void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando Push Notification para {Parametros.Destinatario}: {mensagem}");
    }
}