using PrimoEsercizioAstrazione.EsercizioInterfaccie;

class PagamentoPayPal : IPagamento
{
    public string EmailUtente { get; set; }

    public void MostraMetodo()
    {
        Console.WriteLine($"Metodo: Carta");
        
    }

    void EseguiPagamento(float importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro tramite PayPal da : {EmailUtente}");
        
    }

    void IPagamento.EseguiPagamento(float importo)
    {
        EseguiPagamento(importo);
    }
}