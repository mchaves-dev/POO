namespace ex001.Models;

public sealed class PagamentoPix : Pagamento
{
    public override void RealizarPagamento(double valor)
    {
        Console.WriteLine($"Pagamento de R${valor} realizado via Pix.");
    }
}