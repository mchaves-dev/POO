using ex001.Models;

public  class Program
{
    public static void Main(string[] args)
    {
        new PagamentoBoleto().RealizarPagamento(150.00);
        new PagamentoCartao().RealizarPagamento(300.00);
        new PagamentoPix().RealizarPagamento(75.00);
    }
}