using PrimoEsercizioAstrazione.EsercizioInterfaccie;

class PagamentoPayPal : IPagamento
{
    public string EmailUtente { get; set; }

    public PagamentoPayPal(string emailUtente)
    {
        EmailUtente = emailUtente;
    }
    

    public void EseguiPagamento(float importo)
    {
        Console.WriteLine($"Pagamento effettuato con Paypald di : {EmailUtente} di importo: {importo}");
        
    }

    public void MostraMetodo()
    {
        Console.WriteLine($"Metodo: Paypal");
        
    }

    

}