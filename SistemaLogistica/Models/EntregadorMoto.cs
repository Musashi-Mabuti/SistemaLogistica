namespace SistemaLogistica.Models;

public class EntregadorMoto : FuncionarioTransporte
{
    public string PlacaMoto { get; private set; }

    public string RegiaoEntrega { get; private set; }


    public EntregadorMoto(
        string nome,
        string registro,
        string placaMoto,
        string regiaoEntrega
    ) : base(nome, registro)
    {
        PlacaMoto = placaMoto;
        RegiaoEntrega = regiaoEntrega;
    }


    public override void MostrarDetalhes()
    {
        base.MostrarDetalhes();

        Console.WriteLine($"Placa da moto: {PlacaMoto}");
        Console.WriteLine($"Região de entrega: {RegiaoEntrega}");
    }
}