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


Console.WriteLine("=== MOTORISTA DE CARRETA ===");

motorista.MostrarDetalhes();


Console.WriteLine();


Console.WriteLine("=== ENTREGADOR DE MOTO ===");

entregador.MostrarDetalhes();