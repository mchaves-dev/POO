namespace ex002.Models;

public abstract class Notificacao
{
    private readonly NotificacaoParametros _parametros;

    public NotificacaoParametros Parametros => _parametros;

    public Notificacao(NotificacaoParametros parametros)
    {
        _parametros = parametros;
    }

    public abstract void Enviar(string mensagem);
}