Console.Write("Nome do Cliente: ");
string nomeCliente = Console.ReadLine() ?? string.Empty;

Console.Write("Quantidade de Ingressos: ");
int quantidadeIngressos = Convert.ToInt32(Console.ReadLine());

Console.Write("Cupom de Desconto: ");
string cupomDesconto = Console.ReadLine() ?? string.Empty;

Console.Write("Idade do Cliente: ");
int idadeCliente = Convert.ToInt32(Console.ReadLine());

const decimal taxaConveniencia = 5.00m;
const decimal precoIngresso = 25.00m;

decimal custoBruto = taxaConveniencia + (precoIngresso * quantidadeIngressos);

decimal desconto = cupomDesconto.Trim().Equals("CINEMA10", StringComparison.OrdinalIgnoreCase)
    ? custoBruto * 0.10m
    : 0.00m;

decimal valorFinal = custoBruto - desconto;
