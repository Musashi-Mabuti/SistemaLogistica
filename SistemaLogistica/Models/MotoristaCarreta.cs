namespace SistemaLogistica.Models;

public class MotoristaCarreta : FuncionarioTransporte
{
    public string PlacaCarreta { get; private set; }

    public string CategoriaCnh { get; private set; }

    public MotoristaCarreta(
        string nome,
        string registro,
        string placaCarreta,
        string categoriaCnh
    ) : base(nome, registro)
    {
        PlacaCarreta = placaCarreta;
        CategoriaCnh = categoriaCnh;
    }

    public override void MostrarDetalhes()
    {
        base.MostrarDetalhes();

        Console.WriteLine($"Placa da carreta: {PlacaCarreta}");
        Console.WriteLine($"Categoria da CNH: {CategoriaCnh}");
    }
}