using PrimoEsercizioAstrazione.EsercizioInterfaccie;

class PagamentoCarta : IPagamento
{
    public string? Circuito { get; set; }

    public void EseguiPagamento(float importo)
    {
        Console.WriteLine($"Pagamento di {importo} euro con carta : {Circuito}");
    }

    public void MostraMetodo()
    {
        Console.WriteLine($"Metodo: Carta");
        
    }




}