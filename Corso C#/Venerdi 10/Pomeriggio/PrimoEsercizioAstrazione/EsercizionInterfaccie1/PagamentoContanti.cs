using PrimoEsercizioAstrazione.EsercizioInterfaccie;

class PagamentoContanti : IPagamento
{
    

    public void MostraMetodo()
    {
        Console.WriteLine($"Metodo: Contanti");
        
    }

    void EseguiPagamento(float importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro in contanti");
        
    }

    void IPagamento.EseguiPagamento(float importo)
    {
        EseguiPagamento(importo);
    }
}