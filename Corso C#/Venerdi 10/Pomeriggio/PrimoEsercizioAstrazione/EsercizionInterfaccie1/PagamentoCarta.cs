using PrimoEsercizioAstrazione.EsercizioInterfaccie;

class PagamentoCarta : IPagamento
{
    public string? Circuito { get; set; }

    public void MostraMetodo()
    {
        Console.WriteLine($"Metodo: Carta");
        
    }

    void EseguiPagamento(float importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro con carta : {Circuito}");
        
    }

    void IPagamento.EseguiPagamento(float importo)
    {
        EseguiPagamento(importo);
    }
}