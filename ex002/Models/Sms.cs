namespace ex002.Models;

public sealed class Sms : Notificacao
{
    public Sms(NotificacaoParametros parametros) : base(parametros) { }

    public override void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando SMS para {Parametros.Destinatario}: {mensagem}");
    }
}