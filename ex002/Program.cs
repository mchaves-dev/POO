using ex002.Models;

public class Program
{
    public static void Main(string[] args)
    {
        new Email(new NotificacaoParametros("cliente@exemplo.com")).Enviar("Seu pedido foi enviado!");
        new Sms(new NotificacaoParametros("5599999999999")).Enviar("Código de verificação: 123456");
        new Push(new NotificacaoParametros("User123")).Enviar("Você tem uma nova mensagem!");
    }
}