using SistemaLogistica.Models;

MotoristaCarreta motorista = new MotoristaCarreta(
    "Carlos",
    "FUNC001",
    "ABC1D23",
    "E"
);

EntregadorMoto entregador = new EntregadorMoto(
    "Lucas",
    "FUNC002",
    "XYZ9A87",
    "Zona Sul"
);

List<FuncionarioTransporte> funcionarios = new List<FuncionarioTransporte>();

funcionarios.Add(motorista);
funcionarios.Add(entregador);

Console.WriteLine("=== SISTEMA DE LOGÍSTICA ===");
Console.WriteLine();

foreach (FuncionarioTransporte funcionario in funcionarios)
{
    funcionario.MostrarDetalhes();

    Console.WriteLine("---------------------------");
}