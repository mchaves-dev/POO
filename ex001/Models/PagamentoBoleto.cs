namespace ex001.Models;

public sealed class PagamentoBoleto : Pagamento
{
    public override void RealizarPagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} realizado via Boleto.");
    }
}