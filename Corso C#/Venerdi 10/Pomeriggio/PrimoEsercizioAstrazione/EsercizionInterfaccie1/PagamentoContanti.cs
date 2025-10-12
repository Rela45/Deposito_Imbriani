using PrimoEsercizioAstrazione.EsercizioInterfaccie;

class PagamentoContanti : IPagamento
{
    public void EseguiPagamento(float importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro in contanti");
    }

    public void MostraMetodo()
    {
        Console.WriteLine($"Metodo: Contanti");
        
    }
}