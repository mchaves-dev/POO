namespace ex002.Models;

public sealed class Email : Notificacao
{
    public Email(NotificacaoParametros parametros) : base(parametros) { }

    public override void Enviar(string mensagem)
    {
        Console.WriteLine($"Enviando e-mail para {Parametros.Destinatario}: {mensagem}");
    }
}